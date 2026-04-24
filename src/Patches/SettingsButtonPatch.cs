using System;
using System.Collections;
using MelonLoader;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using Il2CppInterop.Runtime;
using Il2Cpp;
using Il2CppUI.Controls;
using Il2CppAssets.Scripts.UI.Panels;

namespace Euterpe.Patches
{
    /// <summary>
    /// Injects a custom "Euterpe" toggle button into the game's Settings panel (设置).
    /// When clicked, displays a profile popup styled after the native Account System (账号系统) dialog.
    /// </summary>
    [HarmonyPatch(typeof(PnlMenu), "OnEnable")]
    public class SettingsButtonPatch
    {
        private const string EuterpeButtonName = "ModEuterpeButton";
        private const string AvatarPath = @"D:\MuseDashModTool\Muse_Dash_Mod\TestPictures\b_3061db1bd1954328f6efaa0e85684761.jpg";

        // Cached avatar sprite to avoid reloading from disk every time
        private static Sprite _cachedAvatarSprite = null;

        // Hover state management
        internal static Transform _euterpeImgSelected = null;
        internal static Transform _euterpeParent = null; // Toggles container
        internal static bool _euterpeActive = false;

        public static void Postfix(PnlMenu __instance)
        {
            try
            {
                MelonLogger.Msg("[Euterpe] PnlMenu.OnEnable fired — attempting button injection...");

                // The settings grid buttons are located in Panels/PnlOption/Toggles
                var togglesParent = __instance.transform.Find("Panels/PnlOption/Toggles");
                if (togglesParent == null)
                {
                    MelonLogger.Warning("[Euterpe] Settings toggles parent not found!");
                    return;
                }

                // Use a standard button like "BtnFeedback" as the clone template to guarantee standard hover cursor logic.
                // The 'Account' button is a heavily customized prefab which breaks hover when modified.
                var templateBtn = togglesParent.Find("BtnFeedback");
                if (templateBtn == null)
                {
                    MelonLogger.Warning("[Euterpe] 'BtnFeedback' button template not found!");
                    return;
                }

                // Grab the icon sprite from the real Account button to use on our clone
                Sprite accountIconSprite = null;
                var accountBtn = togglesParent.Find("Account");
                if (accountBtn != null)
                {
                    // Account has no root Image, so any child Image is likely the icon or background.
                    var accountImages = accountBtn.GetComponentsInChildren<Image>(true);
                    foreach (var img in accountImages)
                    {
                        if (img != null && img.sprite != null)
                        {
                            accountIconSprite = img.sprite;
                            break; // Take the first valid sprite
                        }
                    }
                }

                // Prevent duplicate injection
                if (togglesParent.Find(EuterpeButtonName) != null)
                {
                    MelonLogger.Msg("[Euterpe] Settings button already exists, skipping.");
                    return;
                }

                // Clone the standard template button
                var newBtnObj = GameObject.Instantiate(templateBtn.gameObject, togglesParent);
                newBtnObj.name = EuterpeButtonName;
                newBtnObj.SetActive(true);
                newBtnObj.transform.SetAsLastSibling();

                // Destroy InputKeyBinding to prevent hotkey conflicts with the original BtnFeedback
                var keyBinding = newBtnObj.GetComponent("InputKeyBinding");
                if (keyBinding != null)
                {
                    GameObject.DestroyImmediate(keyBinding);
                }

                // ===== Critical: Destroy all Localization components on the clone =====
                // The Localization component will override our custom text with the original
                // localization key's value (e.g. "遇到问题"). Must destroy BEFORE setting text.
                var localizations = newBtnObj.GetComponentsInChildren<Component>(true);
                if (localizations != null)
                {
                    foreach (var loc in localizations)
                    {
                        if (loc != null && loc.GetIl2CppType().Name == "Localization")
                        {
                            MelonLogger.Msg($"[Euterpe] Destroying Localization on: {loc.gameObject.name}");
                            GameObject.DestroyImmediate(loc);
                        }
                    }
                }

                // Ensure root Image can receive raycasts
                var rootImg = newBtnObj.GetComponent<Image>();
                if (rootImg != null)
                {
                    rootImg.raycastTarget = true;
                }

                // Re-enable Animator so hover state transitions work on the clone
                var animator = newBtnObj.GetComponent<Animator>();
                if (animator != null)
                {
                    animator.enabled = true;
                    animator.Rebind();
                    MelonLogger.Msg($"[Euterpe] Animator controller: {(animator.runtimeAnimatorController != null ? animator.runtimeAnimatorController.name : "NULL")}");
                }

                // Replace the child icon with the Account icon
                if (accountIconSprite != null)
                {
                    // Find the icon Image child (ImgFeedback / first child Image)
                    var iconChild = newBtnObj.transform.Find("ImgFeedback");
                    if (iconChild != null)
                    {
                        var iconImg = iconChild.GetComponent<Image>();
                        if (iconImg != null)
                        {
                            iconImg.sprite = accountIconSprite;
                            MelonLogger.Msg("[Euterpe] Icon replaced with Account sprite.");
                        }
                    }
                }
                else
                {
                    MelonLogger.Warning("[Euterpe] Account icon sprite was null — icon not replaced.");
                }

                // Set the label text to "Euterpe"
                var txtChild = newBtnObj.transform.Find("TxtFeedback");
                if (txtChild != null)
                {
                    var txt = txtChild.GetComponent<Text>();
                    if (txt != null)
                    {
                        txt.text = "Euterpe";
                    }
                }

                // Re-wire the Button component (it's a Button, not a Toggle)
                var newButton = newBtnObj.GetComponent<Button>();
                if (newButton != null)
                {
                    newButton.onClick.RemoveAllListeners();
                    newButton.onClick.AddListener((UnityAction)new Action(() =>
                    {
                        MelonLogger.Msg("[Euterpe] Settings button clicked!");
                        ShowEuterpeProfilePopup();
                    }));
                }

                // ===== Hover effect (brute-force coroutine approach) =====
                // PointerEnter sets flag → coroutine kills all sibling brackets each frame
                // OptionSelect.OnSelect clears flag → coroutine stops → native takes over
                var imgSelected = newBtnObj.transform.Find("ImgSelected");
                if (imgSelected != null)
                {
                    _euterpeImgSelected = imgSelected;
                    _euterpeParent = togglesParent;

                    var selTransform = imgSelected;
                    var eventTrigger = newBtnObj.AddComponent<UnityEngine.EventSystems.EventTrigger>();

                    // PointerEnter: set flag + show bracket + start coroutine
                    var enterEntry = new UnityEngine.EventSystems.EventTrigger.Entry();
                    enterEntry.eventID = UnityEngine.EventSystems.EventTriggerType.PointerEnter;
                    enterEntry.callback.AddListener(
                        (UnityAction<UnityEngine.EventSystems.BaseEventData>)
                        new Action<UnityEngine.EventSystems.BaseEventData>((data) =>
                        {
                            if (!_euterpeActive)
                            {
                                _euterpeActive = true;
                                MelonCoroutines.Start(EuterpeHoverCoroutine());
                            }
                        }));
                    eventTrigger.triggers.Add(enterEntry);

                    MelonLogger.Msg("[Euterpe] Hover effect wired via coroutine.");
                }

                MelonLogger.Msg($"[Euterpe] Settings button injected successfully! Position: {newBtnObj.transform.position}");
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[Euterpe] Failed to inject settings button: {ex.Message}");
                MelonLogger.Error(ex.StackTrace);
            }
        }

        /// <summary>
        /// Coroutine that runs every frame while Euterpe is hovered.
        /// Ensures Euterpe's bracket stays visible and all sibling brackets are killed.
        /// Stops when _euterpeActive is set to false (by OptionSelectHoverPatch).
        /// </summary>
        private static IEnumerator EuterpeHoverCoroutine()
        {
            while (_euterpeActive)
            {
                // Ensure our bracket is visible
                if (_euterpeImgSelected != null)
                {
                    if (!_euterpeImgSelected.gameObject.activeSelf)
                        _euterpeImgSelected.gameObject.SetActive(true);
                    if (_euterpeImgSelected.childCount > 0 && !_euterpeImgSelected.GetChild(0).gameObject.activeSelf)
                        _euterpeImgSelected.GetChild(0).gameObject.SetActive(true);
                }

                // Kill all sibling brackets
                if (_euterpeParent != null)
                {
                    for (int i = 0; i < _euterpeParent.childCount; i++)
                    {
                        var sibling = _euterpeParent.GetChild(i);
                        if (_euterpeImgSelected != null && sibling == _euterpeImgSelected.parent)
                            continue; // skip Euterpe itself

                        var sibSel = sibling.Find("ImgSelected");
                        if (sibSel != null && sibSel.gameObject.activeSelf)
                        {
                            if (sibSel.childCount > 0)
                                sibSel.GetChild(0).gameObject.SetActive(false);
                            sibSel.gameObject.SetActive(false);
                        }
                    }
                }

                yield return null; // wait one frame
            }
        }

        private static string GetFullPath(Transform t)
        {
            var path = t.name;
            var current = t.parent;
            while (current != null)
            {
                path = current.name + "/" + path;
                current = current.parent;
            }
            return path;
        }

        private static Sprite LoadAvatarSprite()
        {
            if (_cachedAvatarSprite != null) return _cachedAvatarSprite;

            try
            {
                if (System.IO.File.Exists(AvatarPath))
                {
                    byte[] data = System.IO.File.ReadAllBytes(AvatarPath);
                    var tex = new Texture2D(2, 2);
                    tex.LoadImage(data);
                    tex.wrapMode = TextureWrapMode.Clamp;
                    tex.filterMode = FilterMode.Bilinear;

                    var side = Mathf.Min(tex.width, tex.height);
                    var x = (tex.width - side) / 2f;
                    var y = (tex.height - side) / 2f;
                    _cachedAvatarSprite = Sprite.Create(tex, new Rect(x, y, side, side), new Vector2(0.5f, 0.5f));
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[Euterpe] Failed to load avatar: {ex.Message}");
            }

            return _cachedAvatarSprite;
        }

        private static Sprite GetCircleMaskSprite()
        {
            const int size = 256;
            var texture = new Texture2D(size, size, TextureFormat.ARGB32, false);
            texture.wrapMode = TextureWrapMode.Clamp;
            texture.filterMode = FilterMode.Bilinear;

            var pixels = new Color[size * size];
            var center = (size - 1) * 0.5f;
            var radius = size * 0.5f - 1f;

            for (int py = 0; py < size; py++)
            {
                for (int px = 0; px < size; px++)
                {
                    var dx = px - center;
                    var dy = py - center;
                    var dist = Mathf.Sqrt(dx * dx + dy * dy);
                    var alpha = Mathf.Clamp01((radius - dist) / 2f + 0.5f);
                    pixels[py * size + px] = new Color(1f, 1f, 1f, alpha);
                }
            }

            texture.SetPixels(pixels);
            texture.Apply();
            return Sprite.Create(texture, new Rect(0, 0, size, size), new Vector2(0.5f, 0.5f));
        }

        /// <summary>
        /// Creates a styled action button (matching the account popup style) and parents it to the given container.
        /// </summary>
        private static GameObject CreatePopupActionButton(
            Transform parent, string name, string label, Color bgColor,
            string hotkeyText, Text fontTemplate, Action onClick)
        {
            var btnObj = new GameObject(name);
            btnObj.transform.SetParent(parent, false);

            var btnRect = btnObj.AddComponent<RectTransform>();
            btnRect.sizeDelta = new Vector2(200f, 52f);

            // Background image
            var bgImg = btnObj.AddComponent<Image>();
            bgImg.color = bgColor;
            bgImg.type = Image.Type.Sliced;

            // Try to copy rounded-corner sprite from the CommonMessageBox background
            var msgBox = CommonMessageBox.s_Instance;
            if (msgBox != null && msgBox.imgBgRect != null)
            {
                var parentBg = msgBox.imgBgRect.GetComponent<Image>();
                if (parentBg != null && parentBg.sprite != null)
                    bgImg.sprite = parentBg.sprite;
            }

            // Hotkey label (small text on the left, e.g. "ESC", "Space")
            if (!string.IsNullOrEmpty(hotkeyText))
            {
                var hotkeyObj = new GameObject("Hotkey");
                hotkeyObj.transform.SetParent(btnObj.transform, false);
                var hotkeyRect = hotkeyObj.AddComponent<RectTransform>();
                hotkeyRect.anchorMin = new Vector2(0f, 0.5f);
                hotkeyRect.anchorMax = new Vector2(0f, 0.5f);
                hotkeyRect.pivot = new Vector2(0f, 0.5f);
                hotkeyRect.sizeDelta = new Vector2(60f, 28f);
                hotkeyRect.anchoredPosition = new Vector2(12f, 0f);

                // Small hotkey badge background
                var hotkeyBg = hotkeyObj.AddComponent<Image>();
                hotkeyBg.color = new Color(0f, 0f, 0f, 0.3f);
                if (bgImg.sprite != null) hotkeyBg.sprite = bgImg.sprite;
                hotkeyBg.type = Image.Type.Sliced;

                Text hotkeyTxt;
                if (fontTemplate != null)
                {
                    hotkeyTxt = GameObject.Instantiate(fontTemplate, hotkeyObj.transform);
                    hotkeyTxt.name = "HotkeyText";
                }
                else
                {
                    var htObj = new GameObject("HotkeyText");
                    htObj.transform.SetParent(hotkeyObj.transform, false);
                    hotkeyTxt = htObj.AddComponent<Text>();
                }

                hotkeyTxt.transform.SetParent(hotkeyObj.transform, false);
                hotkeyTxt.text = hotkeyText;
                hotkeyTxt.fontSize = 14;
                hotkeyTxt.color = Color.white;
                hotkeyTxt.raycastTarget = false;
                var htRect = hotkeyTxt.rectTransform;
                htRect.anchorMin = Vector2.zero;
                htRect.anchorMax = Vector2.one;
                htRect.offsetMin = Vector2.zero;
                htRect.offsetMax = Vector2.zero;
                var htAlignProp = typeof(Text).GetProperty("alignment");
                if (htAlignProp != null) htAlignProp.SetValue(hotkeyTxt, 4, null); // MiddleCenter

                // Remove shadow from cloned text
                var shadow = hotkeyTxt.GetComponent<Shadow>();
                if (shadow != null) GameObject.DestroyImmediate(shadow);
            }

            // Main label text
            Text labelTxt;
            if (fontTemplate != null)
            {
                labelTxt = GameObject.Instantiate(fontTemplate, btnObj.transform);
                labelTxt.name = "Label";
            }
            else
            {
                var lObj = new GameObject("Label");
                lObj.transform.SetParent(btnObj.transform, false);
                labelTxt = lObj.AddComponent<Text>();
            }

            labelTxt.transform.SetParent(btnObj.transform, false);
            labelTxt.text = label;
            labelTxt.fontSize = 22;
            labelTxt.color = Color.white;
            labelTxt.raycastTarget = false;
            var lRect = labelTxt.rectTransform;
            lRect.anchorMin = Vector2.zero;
            lRect.anchorMax = Vector2.one;
            lRect.offsetMin = Vector2.zero;
            lRect.offsetMax = Vector2.zero;
            var lAlignProp = typeof(Text).GetProperty("alignment");
            if (lAlignProp != null) lAlignProp.SetValue(labelTxt, 4, null); // MiddleCenter

            // Remove shadow from cloned text
            var labelShadow = labelTxt.GetComponent<Shadow>();
            if (labelShadow != null) GameObject.DestroyImmediate(labelShadow);

            // Button component
            var button = btnObj.AddComponent<Button>();
            button.targetGraphic = bgImg;
            if (onClick != null)
            {
                button.onClick.AddListener((UnityAction)onClick);
            }

            return btnObj;
        }

        /// <summary>
        /// Shows the Euterpe profile popup, styled after the native Account System (账号系统) dialog.
        /// Layout:
        ///   Title: (hidden)
        ///   Body:  [Avatar]  用户名: Euterpe    [修改昵称]
        ///                    LV.xxx              [绑定账号]
        ///                    绑定账号可以解锁...
        ///   Bottom: [取消]  [复制 UID]  [退出登录]
        /// </summary>
        private static void ShowEuterpeProfilePopup()
        {
            // Use a no-op confirm action; we build our own buttons
            System.Action onConfirm = () => { };
            var il2CppConfirm = DelegateSupport.ConvertDelegate<Il2CppSystem.Action>(onConfirm);

            CommonMessageBox.ShowConfirm(" ", il2CppConfirm, false);

            var messageBox = CommonMessageBox.s_Instance;
            if (messageBox == null) return;

            try
            {
                // Grab font template from textComponents
                var textComponents = messageBox.textComponents;
                Text fontTemplate = (textComponents != null && textComponents.Length > 0) ? textComponents[0] : null;

                // Hide the native "提示" title
                var allTexts = messageBox.GetComponentsInChildren<Text>(true);
                if (allTexts != null)
                {
                    for (int i = 0; i < allTexts.Length; i++)
                    {
                        if (allTexts[i] != null && allTexts[i].text == "提示")
                            allTexts[i].text = string.Empty;
                    }
                }

                // Hide close button and resize
                messageBox.btnDefaultClose?.gameObject.SetActive(false);
                messageBox.ResetImgBgSize(new Vector2(820f, 380f));

                var bgRect = messageBox.imgBgRect;
                var contentParent = bgRect != null ? bgRect : messageBox.transform as RectTransform;

                // Hide the native confirm button — we build our own bottom bar
                var buttonLayouts = messageBox.m_BtnLayoutRects;
                if (buttonLayouts != null)
                {
                    for (int i = 0; i < buttonLayouts.Length; i++)
                    {
                        if (buttonLayouts[i] != null)
                            buttonLayouts[i].gameObject.SetActive(false);
                    }
                }

                // Clean up old content if reopened
                var oldContent = contentParent?.Find("ModEuterpePopupContent");
                if (oldContent != null) GameObject.Destroy(oldContent.gameObject);

                // ===== Build popup content =====
                var contentObj = new GameObject("ModEuterpePopupContent");
                contentObj.transform.SetParent(contentParent, false);

                var contentRect = contentObj.AddComponent<RectTransform>();
                contentRect.anchorMin = Vector2.zero;
                contentRect.anchorMax = Vector2.one;
                contentRect.offsetMin = new Vector2(30f, 70f);  // Left, Bottom (above our custom button bar)
                contentRect.offsetMax = new Vector2(-30f, -20f); // Right, Top

                // ----- Avatar (circular, left side) -----
                var avatarHolder = new GameObject("Avatar");
                avatarHolder.transform.SetParent(contentObj.transform, false);
                var avatarRect = avatarHolder.AddComponent<RectTransform>();
                avatarRect.anchorMin = new Vector2(0f, 0.5f);
                avatarRect.anchorMax = new Vector2(0f, 0.5f);
                avatarRect.pivot = new Vector2(0f, 0.5f);
                avatarRect.sizeDelta = new Vector2(90f, 90f);
                avatarRect.anchoredPosition = new Vector2(0f, 0f);

                // Circle mask
                var maskImg = avatarHolder.AddComponent<Image>();
                maskImg.sprite = GetCircleMaskSprite();
                maskImg.color = Color.white;
                maskImg.raycastTarget = false;
                var mask = avatarHolder.AddComponent<Mask>();
                mask.showMaskGraphic = false;

                // Avatar image inside mask
                var avatarImgObj = new GameObject("AvatarImage");
                avatarImgObj.transform.SetParent(avatarHolder.transform, false);
                var avatarImgRect = avatarImgObj.AddComponent<RectTransform>();
                avatarImgRect.anchorMin = Vector2.zero;
                avatarImgRect.anchorMax = Vector2.one;
                avatarImgRect.offsetMin = Vector2.zero;
                avatarImgRect.offsetMax = Vector2.zero;
                var avatarImg = avatarImgObj.AddComponent<Image>();
                avatarImg.color = new Color(1f, 0.6f, 0.7f, 1f); // Fallback pink
                avatarImg.raycastTarget = false;

                var avatarSprite = LoadAvatarSprite();
                if (avatarSprite != null)
                {
                    avatarImg.sprite = avatarSprite;
                    avatarImg.color = Color.white;
                }

                // ----- Info text area (right of avatar) -----
                float infoX = 110f;
                float infoWidth = 360f;

                // Line 1: 用户名：Euterpe
                CreateInfoText(fontTemplate, contentObj.transform, "UserName",
                    "用户名：<b>Euterpe</b>",
                    26, new Color(0.95f, 0.92f, 1f, 1f),
                    new Vector2(infoX, 0f), new Vector2(infoWidth, 36f), 0);

                // Line 2: LV.1
                CreateInfoText(fontTemplate, contentObj.transform, "Level",
                    "<color=#00A2FF>LV.1</color>",
                    22, new Color(0.8f, 0.75f, 1f, 1f),
                    new Vector2(infoX, -36f), new Vector2(infoWidth, 30f), 0);

                // Line 3: Description
                CreateInfoText(fontTemplate, contentObj.transform, "Description",
                    "绑定账号可以解锁一张插图哦 >w0",
                    18, new Color(0.7f, 0.65f, 0.9f, 1f),
                    new Vector2(infoX, -68f), new Vector2(infoWidth, 28f), 0);

                // ----- Right-side action buttons -----
                float rightBtnX = -10f;
                float rightBtnWidth = 130f;
                float rightBtnHeight = 36f;

                // "修改昵称" button
                var changeNameBtn = CreateSmallActionButton(fontTemplate, contentObj.transform, "BtnChangeName",
                    "修改昵称", "Q",
                    new Vector2(rightBtnX, 0f), new Vector2(rightBtnWidth, rightBtnHeight),
                    new Color(0.28f, 0.44f, 0.88f, 0.95f),
                    () => { MelonLogger.Msg("[Euterpe] Change name clicked (placeholder)"); });

                // "绑定账号" button
                var bindBtn = CreateSmallActionButton(fontTemplate, contentObj.transform, "BtnBindAccount",
                    "绑定账号", "E",
                    new Vector2(rightBtnX, -46f), new Vector2(rightBtnWidth, rightBtnHeight),
                    new Color(0.28f, 0.44f, 0.88f, 0.95f),
                    () => { MelonLogger.Msg("[Euterpe] Bind account clicked (placeholder)"); });

                // ===== Custom bottom button bar =====
                var bottomBar = new GameObject("BottomBar");
                bottomBar.transform.SetParent(contentParent, false);
                var bottomRect = bottomBar.AddComponent<RectTransform>();
                bottomRect.anchorMin = new Vector2(0f, 0f);
                bottomRect.anchorMax = new Vector2(1f, 0f);
                bottomRect.pivot = new Vector2(0.5f, 0f);
                bottomRect.sizeDelta = new Vector2(0f, 58f);
                bottomRect.anchoredPosition = new Vector2(0f, 12f);

                var hlg = bottomBar.AddComponent<HorizontalLayoutGroup>();
                hlg.spacing = 20f;
                hlg.padding = new RectOffset(40, 40, 0, 0);
                hlg.childControlWidth = true;
                hlg.childControlHeight = true;
                hlg.childForceExpandWidth = true;
                hlg.childForceExpandHeight = true;
                var alignProp = typeof(HorizontalLayoutGroup).GetProperty("childAlignment");
                if (alignProp != null) alignProp.SetValue(hlg, 4, null); // MiddleCenter

                // "取消" button (pink, closes popup)
                CreatePopupActionButton(bottomBar.transform, "BtnCancel", "取消",
                    new Color(0.92f, 0.28f, 0.48f, 1f), "ESC", fontTemplate,
                    () =>
                    {
                        MelonLogger.Msg("[Euterpe] Cancel clicked");
                        if (CommonMessageBox.s_Instance != null && CommonMessageBox.s_Instance.btnDefaultClose != null)
                        {
                            // Invoke the native close button's logic to properly tear down the modal overlay
                            CommonMessageBox.s_Instance.btnDefaultClose.onClick.Invoke();
                        }
                    });

                // "复制 UID" button (cyan)
                CreatePopupActionButton(bottomBar.transform, "BtnCopyUID", "复制 UID",
                    new Color(0f, 0.78f, 0.85f, 1f), "Space", fontTemplate,
                    () =>
                    {
                        MelonLogger.Msg("[Euterpe] Copy UID clicked (placeholder)");
                        Il2CppAssets.Scripts.UI.Controls.ShowText.ShowInfo("UID 已复制到剪贴板！");
                    });

                // "退出登录" button (cyan)
                CreatePopupActionButton(bottomBar.transform, "BtnLogout", "退出登录",
                    new Color(0f, 0.78f, 0.85f, 1f), null, fontTemplate,
                    () =>
                    {
                        MelonLogger.Msg("[Euterpe] Logout clicked (placeholder)");
                    });

                contentObj.transform.SetAsLastSibling();
                bottomBar.transform.SetAsLastSibling();
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[Euterpe] Failed to build profile popup: {ex.Message}");
            }
        }

        /// <summary>
        /// Creates an info text line inside the popup.
        /// </summary>
        private static Text CreateInfoText(Text template, Transform parent, string name,
            string value, int fontSize, Color color, Vector2 anchoredPos, Vector2 size, int anchor)
        {
            Text txt;
            if (template != null)
            {
                txt = GameObject.Instantiate(template, parent);
                txt.name = name;
            }
            else
            {
                var obj = new GameObject(name);
                obj.transform.SetParent(parent, false);
                txt = obj.AddComponent<Text>();
            }

            txt.transform.SetParent(parent, false);
            txt.text = value;
            txt.fontSize = fontSize;
            txt.color = color;
            txt.raycastTarget = false;
            txt.supportRichText = true;

            // Remove inherited shadow
            var shadow = txt.GetComponent<Shadow>();
            if (shadow != null) GameObject.DestroyImmediate(shadow);
            var outline = txt.GetComponent<Outline>();
            if (outline != null) GameObject.DestroyImmediate(outline);

            var rect = txt.rectTransform;
            rect.anchorMin = new Vector2(0f, 1f);
            rect.anchorMax = new Vector2(0f, 1f);
            rect.pivot = new Vector2(0f, 1f);
            rect.sizeDelta = size;
            rect.anchoredPosition = anchoredPos;

            var alignProp = typeof(Text).GetProperty("alignment");
            if (alignProp != null) alignProp.SetValue(txt, (int)anchor, null);

            return txt;
        }

        /// <summary>
        /// Creates a small action button positioned on the right side of the content area
        /// (e.g. "修改昵称", "绑定账号").
        /// </summary>
        private static GameObject CreateSmallActionButton(Text fontTemplate, Transform parent, string name,
            string label, string hotkeyText, Vector2 anchoredPos, Vector2 size, Color bgColor, Action onClick)
        {
            var btnObj = new GameObject(name);
            btnObj.transform.SetParent(parent, false);

            var btnRect = btnObj.AddComponent<RectTransform>();
            btnRect.anchorMin = new Vector2(1f, 1f);
            btnRect.anchorMax = new Vector2(1f, 1f);
            btnRect.pivot = new Vector2(1f, 1f);
            btnRect.sizeDelta = size;
            btnRect.anchoredPosition = anchoredPos;

            var bgImg = btnObj.AddComponent<Image>();
            bgImg.color = bgColor;
            bgImg.type = Image.Type.Sliced;

            // Hotkey badge on the left
            if (!string.IsNullOrEmpty(hotkeyText))
            {
                var hotkeyObj = new GameObject("Hotkey");
                hotkeyObj.transform.SetParent(btnObj.transform, false);
                var hotkeyRect = hotkeyObj.AddComponent<RectTransform>();
                hotkeyRect.anchorMin = new Vector2(0f, 0.5f);
                hotkeyRect.anchorMax = new Vector2(0f, 0.5f);
                hotkeyRect.pivot = new Vector2(0f, 0.5f);
                hotkeyRect.sizeDelta = new Vector2(28f, 24f);
                hotkeyRect.anchoredPosition = new Vector2(6f, 0f);

                var hotkeyBg = hotkeyObj.AddComponent<Image>();
                hotkeyBg.color = new Color(0f, 0f, 0f, 0.35f);
                hotkeyBg.type = Image.Type.Sliced;

                Text hotkeyTxt;
                if (fontTemplate != null)
                {
                    hotkeyTxt = GameObject.Instantiate(fontTemplate, hotkeyObj.transform);
                    hotkeyTxt.name = "HotkeyLabel";
                }
                else
                {
                    var htObj = new GameObject("HotkeyLabel");
                    htObj.transform.SetParent(hotkeyObj.transform, false);
                    hotkeyTxt = htObj.AddComponent<Text>();
                }

                hotkeyTxt.transform.SetParent(hotkeyObj.transform, false);
                hotkeyTxt.text = hotkeyText;
                hotkeyTxt.fontSize = 14;
                hotkeyTxt.color = Color.white;
                hotkeyTxt.raycastTarget = false;
                var htRect = hotkeyTxt.rectTransform;
                htRect.anchorMin = Vector2.zero;
                htRect.anchorMax = Vector2.one;
                htRect.offsetMin = Vector2.zero;
                htRect.offsetMax = Vector2.zero;
                var htAlignProp = typeof(Text).GetProperty("alignment");
                if (htAlignProp != null) htAlignProp.SetValue(hotkeyTxt, 4, null);

                var htShadow = hotkeyTxt.GetComponent<Shadow>();
                if (htShadow != null) GameObject.DestroyImmediate(htShadow);
            }

            // Label text
            Text labelTxt;
            if (fontTemplate != null)
            {
                labelTxt = GameObject.Instantiate(fontTemplate, btnObj.transform);
                labelTxt.name = "Label";
            }
            else
            {
                var lObj = new GameObject("Label");
                lObj.transform.SetParent(btnObj.transform, false);
                labelTxt = lObj.AddComponent<Text>();
            }

            labelTxt.transform.SetParent(btnObj.transform, false);
            labelTxt.text = label;
            labelTxt.fontSize = 18;
            labelTxt.color = Color.white;
            labelTxt.raycastTarget = false;
            var lRect = labelTxt.rectTransform;
            lRect.anchorMin = Vector2.zero;
            lRect.anchorMax = Vector2.one;
            lRect.offsetMin = Vector2.zero;
            lRect.offsetMax = Vector2.zero;
            var lAlignProp = typeof(Text).GetProperty("alignment");
            if (lAlignProp != null) lAlignProp.SetValue(labelTxt, 4, null);

            var labelShadow = labelTxt.GetComponent<Shadow>();
            if (labelShadow != null) GameObject.DestroyImmediate(labelShadow);

            var button = btnObj.AddComponent<Button>();
            button.targetGraphic = bgImg;
            if (onClick != null)
            {
                button.onClick.AddListener((UnityAction)new Action(onClick));
            }

            return btnObj;
        }
    }

    /// <summary>
    /// When the native OptionSelect system selects any button, stop Euterpe's hover coroutine.
    /// This ensures only one hover bracket is visible at a time.
    /// </summary>
    [HarmonyPatch(typeof(Il2Cpp.OptionSelect), "OnSelect")]
    public class OptionSelectHoverPatch
    {
        public static void Postfix(GameObject currentObj)
        {
            // Native system selected a button → stop our coroutine and hide our bracket
            SettingsButtonPatch._euterpeActive = false;
            var euterpeImg = SettingsButtonPatch._euterpeImgSelected;
            if (euterpeImg != null && euterpeImg.gameObject.activeSelf)
            {
                if (euterpeImg.childCount > 0)
                    euterpeImg.GetChild(0).gameObject.SetActive(false);
                euterpeImg.gameObject.SetActive(false);
            }

            // Force-activate the newly selected button's bracket (immediate)
            ActivateBracket(currentObj);

            // Also schedule a delayed re-activation to survive the coroutine's last frame.
            // The coroutine might run AFTER this Postfix in the same frame and kill the bracket.
            if (currentObj != null)
                MelonCoroutines.Start(DelayedBracketActivation(currentObj));
        }

        private static void ActivateBracket(GameObject obj)
        {
            if (obj == null) return;
            var sel = obj.transform.Find("ImgSelected");
            if (sel != null)
            {
                sel.gameObject.SetActive(true);
                if (sel.childCount > 0)
                    sel.GetChild(0).gameObject.SetActive(true);
            }
        }

        private static IEnumerator DelayedBracketActivation(GameObject obj)
        {
            yield return null; // wait 1 frame for coroutine to fully exit
            yield return null; // extra safety frame
            if (!SettingsButtonPatch._euterpeActive) // only if Euterpe isn't hovered again
                ActivateBracket(obj);
        }
    }
}
