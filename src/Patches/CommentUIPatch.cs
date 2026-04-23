using System;
using MelonLoader;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using Il2CppAssets.Scripts.UI.Panels;
using Il2CppUI.Controls; 
using Il2CppInterop.Runtime;
using Il2Cpp;
using Il2CppAssets.Scripts.Database;

namespace Euterpe.Patches
{
    [HarmonyPatch(typeof(PnlPreparation), "Awake")]
    public class CommentUIPatchAwake
    {
        public static void Postfix(PnlPreparation __instance)
        {
            try
            {
                /* 
                 * The hotkey-based input scheme is deprecated.
                 * Now injecting the comment input field directly into the Stage Achievement panel.
                 */
                
                var layAchv = __instance.pnlPreparationLayAchv;
                if (layAchv == null) return;

                // Prevent duplicate initialization
                if (layAchv.transform.Find("ModCommentInputBox") != null) return;

                // Clone a native input field to preserve UI styling
                var templateInput = UnityEngine.Resources.FindObjectsOfTypeAll<Il2CppAssets.Scripts.UI.PeroInputField>();
                if (templateInput == null || templateInput.Count == 0) return;

                var inputObj = GameObject.Instantiate(templateInput[0].gameObject, layAchv.transform);
                inputObj.name = "ModCommentInputBox";
                inputObj.SetActive(true);

                // Add a dark semi-transparent background
                var bgImg = inputObj.GetComponent<Image>();
                if (bgImg == null) bgImg = inputObj.AddComponent<Image>();
                
                // Clear any native sprite so our pure color and alpha work perfectly
                bgImg.sprite = null;
                // Red, Green, Blue, Alpha (0.0 to 1.0)
                bgImg.color = new Color(0f, 0f, 0f, 0.4f); 

                // Adjust input field position and size
                var rect = inputObj.GetComponent<RectTransform>();
                rect.anchorMax = new Vector2(0.5f, 1);
                rect.anchorMin = new Vector2(0.5f, 1);
                rect.sizeDelta = new Vector2(750, 100); 
                rect.anchoredPosition3D = new Vector3(0, -440, 0);
                
                // Ignore native layout to prevent layout displacement
                var layoutElement = inputObj.GetComponent<LayoutElement>() ?? inputObj.AddComponent<LayoutElement>();
                layoutElement.ignoreLayout = true;

                var inputField = inputObj.GetComponent<InputField>();
                if (inputField != null) 
                {
                    inputField.text = ""; 
                    // Remove native input restrictions
                    inputField.contentType = InputField.ContentType.Standard;
                    inputField.characterValidation = InputField.CharacterValidation.None;
                    inputField.characterLimit = 0;
                    inputField.lineType = InputField.LineType.MultiLineSubmit;

                    var placeholderTxt = inputField.placeholder?.GetComponent<Text>();
                    if (placeholderTxt != null) 
                    {
                        placeholderTxt.text = "";
                    }

                    // Intercept input actions to prevent game hotkey conflicts
                    var trigger = inputObj.GetComponent<UnityEngine.EventSystems.EventTrigger>() ?? inputObj.AddComponent<UnityEngine.EventSystems.EventTrigger>();
                    trigger.triggers.Clear();

                    var selectEntry = new UnityEngine.EventSystems.EventTrigger.Entry { eventID = UnityEngine.EventSystems.EventTriggerType.Select };
                    selectEntry.callback.AddListener((UnityAction<UnityEngine.EventSystems.BaseEventData>)new Action<UnityEngine.EventSystems.BaseEventData>((data) => {
                        Il2CppAssets.Scripts.PeroTools.Managers.InputManager.instance.isStopKeyAction = true;
                    }));
                    trigger.triggers.Add(selectEntry);

                    var deselectEntry = new UnityEngine.EventSystems.EventTrigger.Entry { eventID = UnityEngine.EventSystems.EventTriggerType.Deselect };
                    deselectEntry.callback.AddListener((UnityAction<UnityEngine.EventSystems.BaseEventData>)new Action<UnityEngine.EventSystems.BaseEventData>((data) => {
                        Il2CppAssets.Scripts.PeroTools.Managers.InputManager.instance.isStopKeyAction = false;
                    }));
                    trigger.triggers.Add(deselectEntry);

                    // Bind Enter key submission event
                    inputField.onEndEdit.AddListener((UnityAction<string>)new Action<string>((text) => 
                    {
                        if (!string.IsNullOrEmpty(text)) 
                        {
                            var info = GlobalDataBase.s_DbMusicTag.CurMusicInfo();
                            string currentTargetUid = info?.uid ?? "Unknown";
                            MelonLogger.Msg($"[Euterpe] Comment For {currentTargetUid} Submitted: {text}");
                            
                            // Clear input field after submission
                            inputField.text = "";
                            
                            // TODO: Add network request logic here
                        }
                    }));
                }

                // Find the title group
                var pnlAchv = GameObject.Find("PnlAchv");
                if (pnlAchv != null)
                {
                    var imgTittleBase = pnlAchv.transform.Find("ImgTittleBaseP");
                    if (imgTittleBase != null && imgTittleBase.childCount > 0)
                    {
                        var titleTxtObj = imgTittleBase.GetChild(0);
                        if (titleTxtObj != null)
                        {
                            titleTxtObj.name = "TxtStageAchievementTitle"; 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[Euterpe] CommentUIPatch Awake Error: {ex.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(PnlPreparation), "OnEnable")]
    public class CommentUIPatchOnEnable
    {
        private static Color[] _originalCupColors = null;
        private static Sprite[] _originalCupSprites = null;

        private static Transform FindChildRecursively(Transform parent, string name)
        {
            if (parent.name == name) return parent;
            for (int i = 0; i < parent.childCount; i++)
            {
                var result = FindChildRecursively(parent.GetChild(i), name);
                if (result != null) return result;
            }
            return null;
        }

        public static void Postfix(PnlPreparation __instance)
        {
            try
            {
                var info = GlobalDataBase.s_DbMusicTag.CurMusicInfo();
                if (info == null || info.uid == null) return;

                bool isCustomChart = info.uid.StartsWith("999");

                var layAchv = __instance.pnlPreparationLayAchv;
                if (layAchv != null)
                {
                    // 1. Control comment input box and scroll view visibility
                    var inputBox = layAchv.transform.Find("ModCommentInputBox");
                    if (inputBox != null) inputBox.gameObject.SetActive(isCustomChart);

                    var scrollViewObj = layAchv.transform.Find("ModCommentScrollView");
                    if (scrollViewObj != null) scrollViewObj.gameObject.SetActive(isCustomChart);

                    // 2. Hide/Show ImgStageAchievement (the top-right native trophy and watermark) safely via parent
                    // It might not be under PnlAchv, so let's find it from __instance.transform recursively
                    var imgStageAchievement = FindChildRecursively(__instance.transform, "ImgStageAchievement");
                    if (imgStageAchievement != null)
                    {
                        imgStageAchievement.gameObject.SetActive(!isCustomChart);
                    }
                    
                    // The user mentioned it might be called ImgTrophy and directly under the parent panel
                    var imgTrophy = FindChildRecursively(__instance.transform, "ImgTrophy");
                    if (imgTrophy != null)
                    {
                        imgTrophy.gameObject.SetActive(!isCustomChart);
                    }

                    // 3. Keep cup backgrounds but unify their color/sprite for custom charts
                    if (layAchv.achvGamobjects != null && layAchv.achvGamobjects.Length > 0)
                    {
                        // Cache original colors if not done yet
                        if (_originalCupColors == null || _originalCupColors.Length != layAchv.achvGamobjects.Length)
                        {
                            _originalCupColors = new Color[layAchv.achvGamobjects.Length];
                            _originalCupSprites = new Sprite[layAchv.achvGamobjects.Length];
                            for (int i = 0; i < layAchv.achvGamobjects.Length; i++)
                            {
                                var img = layAchv.achvGamobjects[i].GetComponent<Image>();
                                if (img != null)
                                {
                                    _originalCupColors[i] = img.color;
                                    _originalCupSprites[i] = img.sprite;
                                }
                            }
                        }

                        var baseColor = _originalCupColors[0];
                        var baseSprite = _originalCupSprites[0];

                        for (int i = 0; i < layAchv.achvGamobjects.Length; i++)
                        {
                            var cup = layAchv.achvGamobjects[i];
                            if (cup != null)
                            {
                                if (isCustomChart)
                                {
                                    cup.SetActive(true); // Force active to serve as the background panel

                                    var cupImg = cup.GetComponent<Image>();
                                    if (cupImg != null)
                                    {
                                        cupImg.color = baseColor;
                                        cupImg.sprite = baseSprite;
                                    }

                                    if (cup.transform.childCount > 1)
                                    {
                                        cup.transform.GetChild(0).gameObject.SetActive(false);
                                        cup.transform.GetChild(1).gameObject.SetActive(false);
                                    }
                                }
                                else
                                {
                                    // For official charts, native OnEnable sets active state. Just restore appearance.
                                    var cupImg = cup.GetComponent<Image>();
                                    if (cupImg != null)
                                    {
                                        cupImg.color = _originalCupColors[i];
                                        cupImg.sprite = _originalCupSprites[i];
                                    }

                                    if (cup.transform.childCount > 1)
                                    {
                                        cup.transform.GetChild(0).gameObject.SetActive(true);
                                        cup.transform.GetChild(1).gameObject.SetActive(true);
                                    }
                                }
                            }
                        }
                    }

                    // 4. Hide/Show 0/4 completion text
                    if (__instance.stageAchievementValue != null)
                    {
                        __instance.stageAchievementValue.gameObject.SetActive(!isCustomChart);
                    }

                    // 5. Dynamically replace title text and hide/show adjacent trophy
                    var pnlAchv = GameObject.Find("PnlAchv");
                    if (pnlAchv != null)
                    {
                        var imgTittleBase = pnlAchv.transform.Find("ImgTittleBaseP");
                        if (imgTittleBase != null)
                        {
                            // Hide/Show the right-side trophy inside ImgTittleBaseP
                            for (int i = 0; i < imgTittleBase.childCount; i++)
                            {
                                var child = imgTittleBase.GetChild(i);
                                if (!child.name.Contains("TxtStageAchievementTitle") && !child.name.Contains("ImgTittleBase"))
                                {
                                    child.gameObject.SetActive(!isCustomChart);
                                }
                            }

                            // Replace title text
                            var titleTextObj = imgTittleBase.Find("TxtStageAchievementTitle");
                            if (titleTextObj != null)
                            {
                                var t = titleTextObj.GetComponent<Text>();
                                if (t != null)
                                {
                                    t.text = isCustomChart ? "你好，<color=#00A2FF>Euterpe</color>，欢迎留下你的神评论~" : "关卡成就";
                                }

                                // Clean up the old ModCommentGreeting if it exists
                                var oldGreeting = layAchv.transform.Find("ModCommentGreeting");
                                if (oldGreeting != null)
                                {
                                    GameObject.Destroy(oldGreeting.gameObject);
                                }

                                // Create ScrollView for comments
                                scrollViewObj = layAchv.transform.Find("ModCommentScrollView");
                                if (scrollViewObj == null)
                                {
                                    var svObj = new GameObject("ModCommentScrollView");
                                    svObj.transform.SetParent(layAchv.transform, false);
                                    
                                    var svRect = svObj.AddComponent<RectTransform>();
                                    svRect.anchorMax = new Vector2(0.5f, 1);
                                    svRect.anchorMin = new Vector2(0.5f, 1);
                                    svRect.pivot = new Vector2(0.5f, 1);
                                    svRect.anchoredPosition3D = new Vector3(0, -60, 0); // Start below the title
                                    svRect.sizeDelta = new Vector2(750, 310); // Fit space above input box, adjusted to 310 to not overlap input box
                                    
                                    // Add an invisible Image to act as a solid raycast target for the mouse wheel
                                    var svImage = svObj.AddComponent<Image>();
                                    svImage.color = Color.clear;
                                    
                                    var layoutEle = svObj.AddComponent<LayoutElement>();
                                    layoutEle.ignoreLayout = true;
                                    
                                    var scrollRect = svObj.AddComponent<ScrollRect>();
                                    scrollRect.horizontal = false;
                                    scrollRect.vertical = true;
                                    scrollRect.scrollSensitivity = 35f; // Increase mouse wheel sensitivity
                                    
                                    var viewportObj = new GameObject("Viewport");
                                    viewportObj.transform.SetParent(svObj.transform, false);
                                    var vpRect = viewportObj.AddComponent<RectTransform>();
                                    vpRect.anchorMax = Vector2.one;
                                    vpRect.anchorMin = Vector2.zero;
                                    vpRect.sizeDelta = Vector2.zero;
                                    vpRect.anchoredPosition3D = Vector3.zero;
                                    viewportObj.AddComponent<RectMask2D>();
                                    
                                    scrollRect.viewport = vpRect;
                                    
                                    var contentObj = new GameObject("Content");
                                    contentObj.transform.SetParent(viewportObj.transform, false);
                                    var contentRect = contentObj.AddComponent<RectTransform>();
                                    contentRect.anchorMax = new Vector2(1, 1);
                                    contentRect.anchorMin = new Vector2(0, 1);
                                    contentRect.pivot = new Vector2(0.5f, 1);
                                    contentRect.sizeDelta = new Vector2(0, 0);
                                    contentRect.anchoredPosition3D = Vector3.zero;
                                    
                                    var vlg = contentObj.AddComponent<VerticalLayoutGroup>();
                                    vlg.childControlWidth = true;
                                    vlg.childControlHeight = true; // Crucial for dynamic row height
                                    vlg.childForceExpandWidth = true;
                                    vlg.childForceExpandHeight = false;
                                    vlg.spacing = 10;
                                    
                                    var csf = contentObj.AddComponent<ContentSizeFitter>();
                                    csf.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
                                    
                                    scrollRect.content = contentRect;
                                    
                                    string[] testAvatars = new string[]
                                    {
                                        "b_3061db1bd1954328f6efaa0e85684761.jpg",
                                        "b_3a2b4c55825fe3b94dbc54a8bc728a1b.jpg",
                                        "b_3b631464df8856511976c30d4e84e6f0.jpg",
                                        "b_b8c1147a915280d6d6a53cbb6be40855.jpg"
                                    };
                                    
                                    for (int j = 1; j <= 10; j++)
                                    {
                                        var itemObj = new GameObject($"CommentItem_{j}");
                                        itemObj.transform.SetParent(contentObj.transform, false);
                                        itemObj.AddComponent<RectTransform>();
                                        
                                        var itemEle = itemObj.AddComponent<LayoutElement>();
                                        itemEle.minHeight = 80;
                                        
                                        var hlg = itemObj.AddComponent<HorizontalLayoutGroup>();
                                        hlg.childControlWidth = false;
                                        hlg.childControlHeight = false;
                                        var alignPropHlg = typeof(HorizontalLayoutGroup).GetProperty("childAlignment");
                                        if (alignPropHlg != null) alignPropHlg.SetValue(hlg, 3, null); // 3 is MiddleLeft
                                        hlg.spacing = 10; // Tighten spacing between avatar and text
                                        hlg.padding = new RectOffset(10, 10, 10, 10);
                                        
                                        var avatarObj = new GameObject("Avatar");
                                        avatarObj.transform.SetParent(itemObj.transform, false);
                                        var avatarRect = avatarObj.AddComponent<RectTransform>();
                                        avatarRect.sizeDelta = new Vector2(60, 60);
                                        var img = avatarObj.AddComponent<Image>();
                                        
                                        if (j >= 1 && j <= 4)
                                        {
                                            try
                                            {
                                                string avatarPath = @"D:\MuseDashModTool\Muse_Dash_Mod\TestPictures\" + testAvatars[j - 1];
                                                if (System.IO.File.Exists(avatarPath))
                                                {
                                                    byte[] data = System.IO.File.ReadAllBytes(avatarPath);
                                                    Texture2D tex = new Texture2D(2, 2);
                                                    tex.LoadImage(data);
                                                    img.sprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
                                                }
                                                else 
                                                {
                                                    img.color = new Color(0.3f, 0.7f, 1f, 1f);
                                                }
                                            }
                                            catch (Exception e)
                                            {
                                                MelonLogger.Warning($"[Euterpe] Failed to load avatar {testAvatars[j - 1]}: {e.Message}");
                                                img.color = new Color(0.3f, 0.7f, 1f, 1f);
                                            }
                                        }
                                        else 
                                        {
                                            img.color = new Color(0.3f, 0.7f, 1f, 1f); 
                                        } 
                                        
                                        var textObj = GameObject.Instantiate(titleTextObj.gameObject, itemObj.transform);
                                        textObj.name = "CommentText";
                                        var textRect = textObj.GetComponent<RectTransform>();
                                        textRect.sizeDelta = new Vector2(640, 60); // Give text more width
                                        
                                        // Destroy layout elements on cloned text to prevent nested layout issues
                                        var clonedLayout = textObj.GetComponent<LayoutElement>();
                                        if (clonedLayout != null) GameObject.DestroyImmediate(clonedLayout);
                                        
                                        var txt = textObj.GetComponent<Text>();
                                        if (j == 3) {
                                            txt.text = $"这是预览{j}：这是一个非常非常非常非常非常非常非常非常非常非常长长长长长长长长长长的测试评论，用来看看多行文本换行以及自适应高度的效果是不是完美的！";
                                        } else {
                                        txt.text = $"这是预览{j}：原神nb！原神は最高だ！Genshin Impact is awesome!";
                                        }
                                        txt.fontSize = 26;
                                        var resizeProp = typeof(Text).GetProperty("resizeTextForBestFit");
                                        if (resizeProp != null) resizeProp.SetValue(txt, false, null);
                                        var alignProp = typeof(Text).GetProperty("alignment");
                                        if (alignProp != null) alignProp.SetValue(txt, 3, null); // MiddleLeft
                                        
                                        var hWrapProp = typeof(Text).GetProperty("horizontalOverflow");
                                        if (hWrapProp != null) hWrapProp.SetValue(txt, 0, null); // Wrap
                                        
                                        var vWrapProp = typeof(Text).GetProperty("verticalOverflow");
                                        if (vWrapProp != null) vWrapProp.SetValue(txt, 1, null); // Overflow
                                        
                                        var txtCsf = textObj.AddComponent<ContentSizeFitter>();
                                        txtCsf.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
                                    }
                                    
                                    scrollViewObj = svObj.transform;
                                }
                                if (scrollViewObj != null) scrollViewObj.gameObject.SetActive(isCustomChart);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MelonLogger.Error($"[Euterpe] CommentUIPatch OnEnable Error: {e.Message}");
            }
        }
    }
}
