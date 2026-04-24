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

                // Apply dark semi-transparent tint while preserving the native rounded-corner sprite
                var bgImg = inputObj.GetComponent<Image>();
                if (bgImg == null) bgImg = inputObj.AddComponent<Image>();
                
                // Keep the original sprite for rounded corners, use Sliced mode for proper 9-slice stretching
                bgImg.type = Image.Type.Sliced;
                bgImg.color = new Color(0f, 0f, 0f, 0.4f); 

                // Adjust input field position and size
                var rect = inputObj.GetComponent<RectTransform>();
                rect.anchorMax = new Vector2(0.5f, 1);
                rect.anchorMin = new Vector2(0.5f, 1);
                rect.sizeDelta = new Vector2(750, 60); 
                rect.anchoredPosition3D = new Vector3(0, -460, 0);
                
                // Ignore native layout to prevent layout displacement
                var layoutElement = inputObj.GetComponent<LayoutElement>() ?? inputObj.AddComponent<LayoutElement>();
                layoutElement.ignoreLayout = true;

                // Fix caret/text overflow: the native search input prefab clips via a RectMask2D
                // on the text area container. We replicate that here.
                var inputFieldComp = inputObj.GetComponent<InputField>();
                if (inputFieldComp != null && inputFieldComp.textComponent != null)
                {
                    var textAreaTransform = inputFieldComp.textComponent.transform.parent;

                    // Only modify if the text area is a real sub-container (not the root inputObj itself)
                    if (textAreaTransform != null && textAreaTransform != inputObj.transform)
                    {
                        if (textAreaTransform.GetComponent<RectMask2D>() == null)
                            textAreaTransform.gameObject.AddComponent<RectMask2D>();

                        var taRect = textAreaTransform.GetComponent<RectTransform>();
                        if (taRect != null)
                        {
                            taRect.offsetMin = new Vector2(10, 2);
                            taRect.offsetMax = new Vector2(-10, -2);
                        }
                    }
                    else
                    {
                        // Text is directly under root: just shrink the textComponent itself
                        var txtRect = inputFieldComp.textComponent.GetComponent<RectTransform>();
                        if (txtRect != null)
                        {
                            txtRect.offsetMin = new Vector2(10, 2);
                            txtRect.offsetMax = new Vector2(-10, -2);
                        }
                    }
                }

                var inputField = inputObj.GetComponent<InputField>();
                if (inputField != null) 
                {
                    inputField.text = ""; 
                    // Remove native input restrictions
                    inputField.contentType = InputField.ContentType.Standard;
                    inputField.characterValidation = InputField.CharacterValidation.None;
                    inputField.characterLimit = 0;
                    inputField.lineType = InputField.LineType.SingleLine;

                    // Scale down font size to match the 60px input box height (caret height = line height)
                    if (inputField.textComponent != null)
                    {
                        inputField.textComponent.fontSize = 24;
                        // 3 = TextAnchor.MiddleLeft (use reflection for Il2Cpp compatibility)
                        var alignProp = typeof(Text).GetProperty("alignment");
                        if (alignProp != null) alignProp.SetValue(inputField.textComponent, 3, null);
                    }
                    inputField.caretWidth = 2;

                    var placeholderTxt = inputField.placeholder?.GetComponent<Text>();
                    if (placeholderTxt != null) 
                    {
                        placeholderTxt.text = "";
                        placeholderTxt.fontSize = inputField.textComponent != null ? inputField.textComponent.fontSize : 24;
                        placeholderTxt.color = new Color(1f, 1f, 1f, 0.45f);

                        var placeholderAlignProp = typeof(Text).GetProperty("alignment");
                        if (placeholderAlignProp != null) placeholderAlignProp.SetValue(placeholderTxt, 3, null);

                        if (inputField.textComponent != null)
                        {
                            var sourceRect = inputField.textComponent.GetComponent<RectTransform>();
                            var placeholderRect = placeholderTxt.GetComponent<RectTransform>();
                            if (sourceRect != null && placeholderRect != null)
                            {
                                placeholderRect.anchorMin = sourceRect.anchorMin;
                                placeholderRect.anchorMax = sourceRect.anchorMax;
                                placeholderRect.pivot = sourceRect.pivot;
                                placeholderRect.anchoredPosition = sourceRect.anchoredPosition;
                                placeholderRect.sizeDelta = sourceRect.sizeDelta;
                                placeholderRect.offsetMin = sourceRect.offsetMin;
                                placeholderRect.offsetMax = sourceRect.offsetMax;
                            }
                        }
                    }

                    // Intercept input actions to prevent game hotkey conflicts
                    var trigger = inputObj.GetComponent<UnityEngine.EventSystems.EventTrigger>() ?? inputObj.AddComponent<UnityEngine.EventSystems.EventTrigger>();
                    trigger.triggers.Clear();

                    var selectEntry = new UnityEngine.EventSystems.EventTrigger.Entry { eventID = UnityEngine.EventSystems.EventTriggerType.Select };
                    selectEntry.callback.AddListener((UnityAction<UnityEngine.EventSystems.BaseEventData>)new Action<UnityEngine.EventSystems.BaseEventData>((data) => {
                        Il2CppAssets.Scripts.PeroTools.Managers.InputManager.instance.isStopKeyAction = true;
                        if (inputField.placeholder != null)
                        {
                            inputField.placeholder.gameObject.SetActive(false);
                        }
                    }));
                    trigger.triggers.Add(selectEntry);

                    var deselectEntry = new UnityEngine.EventSystems.EventTrigger.Entry { eventID = UnityEngine.EventSystems.EventTriggerType.Deselect };
                    deselectEntry.callback.AddListener((UnityAction<UnityEngine.EventSystems.BaseEventData>)new Action<UnityEngine.EventSystems.BaseEventData>((data) => {
                        Il2CppAssets.Scripts.PeroTools.Managers.InputManager.instance.isStopKeyAction = false;
                        if (inputField.placeholder != null)
                        {
                            inputField.placeholder.gameObject.SetActive(string.IsNullOrEmpty(inputField.text));
                        }
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
                            if (inputField.placeholder != null)
                            {
                                inputField.placeholder.gameObject.SetActive(true);
                            }
                            
                            // Show native success toast message
                            try
                            {
                                Il2CppAssets.Scripts.UI.Controls.ShowText.ShowInfo("评论上传成功！");
                            }
                            catch (Exception ex)
                            {
                                MelonLogger.Warning($"[Euterpe] Failed to show success toast: {ex.Message}");
                            }

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
        private const string CommentTitleText = "你好，<color=#00A2FF>Euterpe</color>";
        private const string CommentPlaceholderText = "欢迎留下你的神评论~";
        private static Color[] _originalCupColors = null;
        private static Sprite[] _originalCupSprites = null;
        private static Sprite _avatarMaskSprite = null;

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

        private static Sprite GetAvatarMaskSprite()
        {
            if (_avatarMaskSprite != null) return _avatarMaskSprite;

            const int size = 1024;
            var texture = new Texture2D(size, size, TextureFormat.ARGB32, false);
            texture.wrapMode = TextureWrapMode.Clamp;
            texture.filterMode = FilterMode.Bilinear;

            var pixels = new Color[size * size];
            var center = (size - 1) * 0.5f;
            var radius = size * 0.5f - 2f;
            const float feather = 3f;

            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    var dx = x - center;
                    var dy = y - center;
                    var distance = Mathf.Sqrt(dx * dx + dy * dy);
                    var alpha = Mathf.Clamp01((radius - distance) / feather + 0.5f);
                    pixels[y * size + x] = new Color(1f, 1f, 1f, alpha);
                }
            }

            texture.SetPixels(pixels);
            texture.Apply();

            _avatarMaskSprite = Sprite.Create(
                texture,
                new Rect(0, 0, size, size),
                new Vector2(0.5f, 0.5f));
            return _avatarMaskSprite;
        }

        private static Sprite CreateCenteredSquareSprite(Texture2D texture)
        {
            if (texture == null) return null;

            texture.wrapMode = TextureWrapMode.Clamp;
            texture.filterMode = FilterMode.Bilinear;

            var side = Mathf.Min(texture.width, texture.height);
            var x = (texture.width - side) / 2f;
            var y = (texture.height - side) / 2f;

            return Sprite.Create(
                texture,
                new Rect(x, y, side, side),
                new Vector2(0.5f, 0.5f));
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

                    var inputField = inputBox?.GetComponent<InputField>();
                    var placeholderTxt = inputField?.placeholder?.GetComponent<Text>();
                    if (placeholderTxt != null)
                    {
                        placeholderTxt.text = isCustomChart ? CommentPlaceholderText : "";
                        placeholderTxt.fontSize = inputField?.textComponent != null ? inputField.textComponent.fontSize : 24;
                        placeholderTxt.color = new Color(1f, 1f, 1f, 0.45f);

                        var placeholderAlignProp = typeof(Text).GetProperty("alignment");
                        if (placeholderAlignProp != null) placeholderAlignProp.SetValue(placeholderTxt, 3, null);
                    }

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
                                    t.text = isCustomChart ? CommentTitleText : "关卡成就";
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
                                    svRect.sizeDelta = new Vector2(750, 360); // Fit space above input box
                                    
                                    // Add an invisible Image to act as a solid raycast target for the mouse wheel
                                    var svImage = svObj.AddComponent<Image>();
                                    svImage.color = Color.clear;
                                    
                                    var layoutEle = svObj.AddComponent<LayoutElement>();
                                    layoutEle.ignoreLayout = true;
                                    
                                    var scrollRect = svObj.AddComponent<ScrollRect>();
                                    scrollRect.horizontal = false;
                                    scrollRect.vertical = true;
                                    scrollRect.scrollSensitivity = 20f; // Increase mouse wheel sensitivity
                                    
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

                                        var avatarLayout = avatarObj.AddComponent<LayoutElement>();
                                        avatarLayout.minWidth = 60;
                                        avatarLayout.minHeight = 60;
                                        avatarLayout.preferredWidth = 60;
                                        avatarLayout.preferredHeight = 60;

                                        var avatarMaskImage = avatarObj.AddComponent<Image>();
                                        avatarMaskImage.sprite = GetAvatarMaskSprite();
                                        avatarMaskImage.color = Color.white;
                                        var avatarMask = avatarObj.AddComponent<Mask>();
                                        avatarMask.showMaskGraphic = false;

                                        var avatarContentObj = new GameObject("AvatarContent");
                                        avatarContentObj.transform.SetParent(avatarObj.transform, false);
                                        var avatarContentRect = avatarContentObj.AddComponent<RectTransform>();
                                        avatarContentRect.anchorMin = Vector2.zero;
                                        avatarContentRect.anchorMax = Vector2.one;
                                        avatarContentRect.offsetMin = Vector2.zero;
                                        avatarContentRect.offsetMax = Vector2.zero;

                                        var img = avatarContentObj.AddComponent<Image>();

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
                                                    img.sprite = CreateCenteredSquareSprite(tex);
                                                    img.color = Color.white;
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
                                        txt.fontSize = 22;
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

                // TODO: Character lock icon state does not refresh on custom charts.
                // The native RefreshLevelConfigUI() fails to update lock icons for custom chart UIDs (999-*).
                // The lock functionality works correctly (state is persisted), but the golden lock icon does not appear.
                // Root cause is in the game's native PnlRank code, not in Euterpe or CustomAlbums.
                /*
                if (isCustomChart && __instance.pnlRanks != null)
                {
                    try
                    {
                        var dbLevelConfig = GlobalDataBase.s_DbLevelConfig;
                        if (dbLevelConfig != null)
                        {
                            bool isLocked = (int)dbLevelConfig.curLevelConfigState == 1;

                            foreach (var pnlRank in __instance.pnlRanks)
                            {
                                if (pnlRank == null) continue;

                                var refreshMethod = typeof(Il2CppAssets.Scripts.UI.Panels.PnlRank)
                                    .GetMethod("RefreshLevelConfigUI", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                                if (refreshMethod != null)
                                {
                                    refreshMethod.Invoke(pnlRank, null);
                                }

                                if (pnlRank.imgLevelLockBg != null && pnlRank.imgLevelLock != null)
                                {
                                    var globalDataProp = typeof(Il2CppAssets.Scripts.UI.Panels.PnlRank)
                                        .GetProperty("globalData", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                                    if (globalDataProp != null)
                                    {
                                        var gd = globalDataProp.GetValue(pnlRank) as GlobalScriptableObjectData;
                                        if (gd != null)
                                        {
                                            string spriteName = isLocked ? gd.imgLockOnName : gd.imgLockOffName;
                                            Color bgColor = isLocked ? gd.colorLevelBgPink : gd.colorLevelBgGrey;

                                            var sprite = Il2CppAssets.Scripts.UI.Panels.PnlRank.GetSprite(spriteName);
                                            if (sprite != null)
                                            {
                                                pnlRank.imgLevelLock.sprite = sprite;
                                            }
                                            pnlRank.imgLevelLockBg.color = bgColor;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception lockEx)
                    {
                        MelonLogger.Warning($"[Euterpe] Lock icon refresh failed: {lockEx.Message}");
                    }
                }
                */
            }
            catch (Exception e)
            {
                MelonLogger.Error($"[Euterpe] CommentUIPatch OnEnable Error: {e.Message}");
            }
        }
    }
}
