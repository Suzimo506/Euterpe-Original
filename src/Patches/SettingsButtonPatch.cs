using System;
using System.Collections;
using System.Collections.Generic;
using MelonLoader;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using Il2Cpp;
using Il2CppInterop.Runtime;
using Il2CppUI.Controls;
using Il2CppAssets.Scripts.UI.Panels;
using Il2CppAccount;

namespace Euterpe.Patches
{
    /// <summary>
    /// Ultimate UI Integration for Euterpe settings button.
    /// Combines "Shadow Sync" animations with a rich, custom profile popup.
    /// </summary>
    [HarmonyPatch(typeof(PnlMenu), "OnEnable")]
    public class SettingsButtonPatch
    {
        private const string EuterpeButtonName = "ModEuterpeButton";
        private const string AvatarPath = @"D:\MuseDashModTool\Muse_Dash_Mod\TestPictures\b_3061db1bd1954328f6efaa0e85684761.jpg";
        
        internal static GameObject _euterpeBtn = null;
        private static Sprite _cachedAvatarSprite = null;

        public static void Postfix(PnlMenu __instance)
        {
            try
            {
                var pnlOption = __instance.transform.Find("Panels/PnlOption");
                var togglesParent = pnlOption?.Find("Toggles");
                
                if (togglesParent == null) return;

                var templateBtn = togglesParent.Find("BtnFeedback");
                if (templateBtn == null) return;

                if (togglesParent.Find(EuterpeButtonName) != null) return;

                // 1. Create button
                _euterpeBtn = GameObject.Instantiate(templateBtn.gameObject, togglesParent);
                _euterpeBtn.name = EuterpeButtonName;
                _euterpeBtn.SetActive(true);
                _euterpeBtn.transform.SetAsLastSibling();

                // 2. Cleanup components
                var keyBinding = _euterpeBtn.GetComponent("InputKeyBinding");
                if (keyBinding != null) GameObject.DestroyImmediate(keyBinding);

                var localizations = _euterpeBtn.GetComponentsInChildren<Component>(true);
                if (localizations != null)
                {
                    foreach (var loc in localizations)
                    {
                        if (loc != null && loc.GetIl2CppType().Name == "Localization")
                            GameObject.DestroyImmediate(loc);
                    }
                }

                // 3. Visuals
                var txtChild = _euterpeBtn.transform.Find("TxtFeedback");
                if (txtChild != null)
                {
                    var txt = txtChild.GetComponent<Text>();
                    if (txt != null) txt.text = "Euterpe";
                }

                // 4. Click Event
                var button = _euterpeBtn.GetComponent<Button>();
                if (button != null)
                {
                    button.onClick.RemoveAllListeners();
                    button.onClick.AddListener((UnityAction)new Action(() =>
                    {
                        ShowEuterpeProfilePopup();
                    }));
                }

                // 5. CanvasGroup
                if (_euterpeBtn.GetComponent<CanvasGroup>() == null)
                    _euterpeBtn.AddComponent<CanvasGroup>();
                
                var cg = _euterpeBtn.GetComponent<CanvasGroup>();
                if (cg != null) cg.alpha = 0f;

                // 6. Back Listener
                if (__instance.backBtn != null)
                {
                    __instance.backBtn.onClick.AddListener((UnityAction)new Action(() =>
                    {
                        StartFadeOut();
                    }));
                }

                // Refresh navigation
                var optionSelect = pnlOption.GetComponent<OptionSelect>();
                if (optionSelect != null) optionSelect.SetSelectableObj();

                MelonLogger.Msg("[Euterpe] Settings button setup complete with custom popup logic.");
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[Euterpe] Injection failed: {ex.Message}");
            }
        }

        internal static void StartFadeOut()
        {
            if (_euterpeBtn != null && _euterpeBtn.activeSelf)
            {
                MelonCoroutines.Start(FadeOutRoutine());
            }
        }

        private static IEnumerator FadeOutRoutine()
        {
            var cg = _euterpeBtn.GetComponent<CanvasGroup>();
            if (cg == null) yield break;

            var animator = _euterpeBtn.GetComponent<Animator>();
            if (animator != null) animator.Play("Hide", 0, 0f);

            float elapsed = 0f;
            while (elapsed < 0.2f)
            {
                elapsed += Time.deltaTime;
                cg.alpha = 1f - (elapsed / 0.2f);
                yield return null;
            }
            cg.alpha = 0f;
            _euterpeBtn.SetActive(false);
        }

        /// <summary>
        /// Restored Custom Popup Implementation from historical version.
        /// Builds a rich UI inside the game's CommonMessageBox.
        /// </summary>
        internal static void ShowEuterpeProfilePopup()
        {
            // Use a no-op confirm action; we build our own buttons
            System.Action onConfirm = () => { };
            var il2CppConfirm = DelegateSupport.ConvertDelegate<Il2CppSystem.Action>(onConfirm);

            CommonMessageBox.ShowConfirm(" ", il2CppConfirm, false);

            var messageBox = CommonMessageBox.s_Instance;
            if (messageBox == null) return;

            try
            {
                var textComponents = messageBox.textComponents;
                Text fontTemplate = (textComponents != null && textComponents.Length > 0) ? textComponents[0] : null;

                // 1. Aggressively hide ALL native UI elements that might interfere
                var allTexts = messageBox.GetComponentsInChildren<Text>(true);
                foreach (var t in allTexts)
                    if (t != null && (t.text == "提示" || t.text == "Hint")) t.text = string.Empty;

                messageBox.btnDefaultClose?.gameObject.SetActive(false);
                
                // Hide ALL existing button layouts and their parents
                if (messageBox.m_BtnLayoutRects != null)
                {
                    foreach (var rect in messageBox.m_BtnLayoutRects)
                    {
                        if (rect != null)
                        {
                            rect.gameObject.SetActive(false);
                            // Also hide parent if it's just a layout container
                            if (rect.parent != null && rect.parent.name.Contains("Layout"))
                                rect.parent.gameObject.SetActive(false);
                        }
                    }
                }

                // Specifically find and hide ALL native buttons in the hierarchy
                var allButtons = messageBox.GetComponentsInChildren<Button>(true);
                foreach (var b in allButtons)
                {
                    var p = b.transform.parent;
                    bool isMine = false;
                    while (p != null)
                    {
                        if (p.name == "ModEuterpePopupContent" || p.name == "BottomBar") { isMine = true; break; }
                        p = p.parent;
                    }
                    if (!isMine) b.gameObject.SetActive(false);
                }

                messageBox.ResetImgBgSize(new Vector2(820f, 380f));

                var contentParent = messageBox.imgBgRect != null ? messageBox.imgBgRect : messageBox.transform as RectTransform;

                // Clean up old content
                var oldContent = contentParent?.Find("ModEuterpePopupContent");
                if (oldContent != null) GameObject.Destroy(oldContent.gameObject);
                var oldBottom = contentParent?.Find("BottomBar");
                if (oldBottom != null) GameObject.Destroy(oldBottom.gameObject);

                // Build Content
                var contentObj = new GameObject("ModEuterpePopupContent");
                contentObj.transform.SetParent(contentParent, false);
                var contentRect = contentObj.AddComponent<RectTransform>();
                contentRect.anchorMin = Vector2.zero;
                contentRect.anchorMax = Vector2.one;
                contentRect.offsetMin = new Vector2(30f, 70f);
                contentRect.offsetMax = new Vector2(-30f, -20f);

                // Avatar
                var avatarHolder = new GameObject("Avatar");
                avatarHolder.transform.SetParent(contentObj.transform, false);
                var avatarRect = avatarHolder.AddComponent<RectTransform>();
                avatarRect.anchorMin = new Vector2(0f, 0.5f);
                avatarRect.anchorMax = new Vector2(0f, 0.5f);
                avatarRect.pivot = new Vector2(0f, 0.5f);
                avatarRect.sizeDelta = new Vector2(110f, 110f); // Slightly larger
                avatarRect.anchoredPosition = new Vector2(10f, 0f);

                var maskImg = avatarHolder.AddComponent<Image>();
                maskImg.sprite = GetCircleMaskSprite();
                var mask = avatarHolder.AddComponent<Mask>();
                mask.showMaskGraphic = false;

                var avatarImgObj = new GameObject("AvatarImage");
                avatarImgObj.transform.SetParent(avatarHolder.transform, false);
                var avatarImgRect = avatarImgObj.AddComponent<RectTransform>();
                avatarImgRect.anchorMin = Vector2.zero; avatarImgRect.anchorMax = Vector2.one;
                avatarImgRect.offsetMin = Vector2.zero; avatarImgRect.offsetMax = Vector2.zero;
                var avatarImg = avatarImgObj.AddComponent<Image>();
                avatarImg.color = new Color(1f, 0.6f, 0.7f, 1f);

                var avatarSprite = LoadAvatarSprite();
                if (avatarSprite != null) { avatarImg.sprite = avatarSprite; avatarImg.color = Color.white; }

                // Info
                CreateInfoText(fontTemplate, contentObj.transform, "UserName", "用户名：<b>Euterpe</b>", 28, new Color(1f, 1f, 1f, 1f), new Vector2(140f, 10f), new Vector2(360f, 40f), 0);
                CreateInfoText(fontTemplate, contentObj.transform, "Level", "<color=#00A2FF>LV.1</color>", 22, new Color(0.8f, 0.8f, 1f, 1f), new Vector2(140f, -30f), new Vector2(360f, 30f), 0);
                CreateInfoText(fontTemplate, contentObj.transform, "Description", "Euterpe Mod is managing your session.", 18, new Color(0.75f, 0.75f, 0.95f, 1f), new Vector2(140f, -65f), new Vector2(360f, 28f), 0);

                // Buttons
                CreateSmallActionButton(fontTemplate, contentObj.transform, "BtnChangeName", "修改昵称", "Q", new Vector2(-10f, 10f), new Vector2(140f, 40f), new Color(0.3f, 0.5f, 1f, 0.9f), () => { });
                CreateSmallActionButton(fontTemplate, contentObj.transform, "BtnBindAccount", "绑定账号", "E", new Vector2(-10f, -40f), new Vector2(140f, 40f), new Color(0.3f, 0.5f, 1f, 0.9f), () => { });

                // Bottom Bar
                var bottomBar = new GameObject("BottomBar");
                bottomBar.transform.SetParent(contentParent, false);
                var bottomRect = bottomBar.AddComponent<RectTransform>();
                bottomRect.anchorMin = new Vector2(0f, 0f); bottomRect.anchorMax = new Vector2(1f, 0f);
                bottomRect.sizeDelta = new Vector2(0f, 60f); bottomRect.anchoredPosition = new Vector2(0f, 15f);
                var hlg = bottomBar.AddComponent<HorizontalLayoutGroup>();
                hlg.spacing = 15f; hlg.padding = new RectOffset(20, 20, 0, 0);
                hlg.childControlWidth = true; hlg.childForceExpandWidth = true;
                hlg.childAlignment = TextAnchor.MiddleCenter;

                CreatePopupActionButton(bottomBar.transform, "BtnCancel", "取消", new Color(0.95f, 0.3f, 0.5f, 1f), "ESC", fontTemplate, () => {
                    CommonMessageBox.s_Instance?.btnDefaultClose?.onClick.Invoke();
                });
                CreatePopupActionButton(bottomBar.transform, "BtnCopyUID", "复制 UID", new Color(0f, 0.8f, 0.9f, 1f), "Space", fontTemplate, () => {
                    Il2CppAssets.Scripts.UI.Controls.ShowText.ShowInfo("UID 已复制！");
                });

                contentObj.transform.SetAsLastSibling();
                bottomBar.transform.SetAsLastSibling();
            }
            catch (Exception ex) { MelonLogger.Error($"[Euterpe] Popup build failed: {ex.Message}"); }
        }

        private static Text CreateInfoText(Text template, Transform parent, string name, string value, int fontSize, Color color, Vector2 anchoredPos, Vector2 size, int anchor)
        {
            var obj = new GameObject(name); obj.transform.SetParent(parent, false);
            var txt = obj.AddComponent<Text>();
            if (template != null) { txt.font = template.font; txt.material = template.material; }
            txt.text = value; txt.fontSize = fontSize; txt.color = color; txt.supportRichText = true;
            var rect = txt.rectTransform;
            rect.anchorMin = rect.anchorMax = rect.pivot = new Vector2(0f, 1f);
            rect.sizeDelta = size; rect.anchoredPosition = anchoredPos;
            txt.alignment = (TextAnchor)anchor;
            return txt;
        }

        private static GameObject CreateSmallActionButton(Text fontTemplate, Transform parent, string name, string label, string hotkeyText, Vector2 anchoredPos, Vector2 size, Color bgColor, Action onClick)
        {
            var obj = new GameObject(name); obj.transform.SetParent(parent, false);
            var rect = obj.AddComponent<RectTransform>();
            rect.anchorMin = rect.anchorMax = rect.pivot = new Vector2(1f, 1f);
            rect.sizeDelta = size; rect.anchoredPosition = anchoredPos;
            var img = obj.AddComponent<Image>(); img.color = bgColor; img.type = Image.Type.Sliced;
            var txtObj = new GameObject("Label"); txtObj.transform.SetParent(obj.transform, false);
            var txt = txtObj.AddComponent<Text>();
            if (fontTemplate != null) { txt.font = fontTemplate.font; txt.material = fontTemplate.material; }
            txt.text = label; txt.fontSize = 18; txt.color = Color.white; txt.alignment = TextAnchor.MiddleCenter;
            var txtRect = txt.rectTransform; txtRect.anchorMin = Vector2.zero; txtRect.anchorMax = Vector2.one; txtRect.offsetMin = txtRect.offsetMax = Vector2.zero;
            var btn = obj.AddComponent<Button>(); btn.onClick.AddListener((UnityAction)onClick);
            return obj;
        }

        private static GameObject CreatePopupActionButton(Transform parent, string name, string label, Color bgColor, string hotkeyText, Text fontTemplate, Action onClick)
        {
            var obj = new GameObject(name); obj.transform.SetParent(parent, false);
            var rect = obj.AddComponent<RectTransform>(); rect.sizeDelta = new Vector2(200f, 52f);
            var img = obj.AddComponent<Image>(); img.color = bgColor; img.type = Image.Type.Sliced;
            var txtObj = new GameObject("Label"); txtObj.transform.SetParent(obj.transform, false);
            var txt = txtObj.AddComponent<Text>();
            if (fontTemplate != null) { txt.font = fontTemplate.font; txt.material = fontTemplate.material; }
            txt.text = label; txt.fontSize = 22; txt.color = Color.white; txt.alignment = TextAnchor.MiddleCenter;
            var txtRect = txt.rectTransform; txtRect.anchorMin = Vector2.zero; txtRect.anchorMax = Vector2.one; txtRect.offsetMin = txtRect.offsetMax = Vector2.zero;
            var btn = obj.AddComponent<Button>(); btn.onClick.AddListener((UnityAction)onClick);
            return obj;
        }

        private static Sprite LoadAvatarSprite()
        {
            if (_cachedAvatarSprite != null) return _cachedAvatarSprite;
            try {
                if (System.IO.File.Exists(AvatarPath)) {
                    byte[] data = System.IO.File.ReadAllBytes(AvatarPath);
                    var tex = new Texture2D(2, 2); tex.LoadImage(data);
                    var side = Mathf.Min(tex.width, tex.height);
                    _cachedAvatarSprite = Sprite.Create(tex, new Rect((tex.width - side) / 2f, (tex.height - side) / 2f, side, side), new Vector2(0.5f, 0.5f));
                }
            } catch { }
            return _cachedAvatarSprite;
        }

        /// <summary>
        /// Generates an anti-aliased circular mask sprite.
        /// </summary>
        private static Sprite GetCircleMaskSprite()
        {
            const int size = 256;
            var tex = new Texture2D(size, size, TextureFormat.ARGB32, false);
            var pixels = new Color[size * size];
            float center = (size - 1) * 0.5f;
            float radius = size * 0.5f - 2f; // Slight inset for better aliasing
            
            for (int y = 0; y < size; y++) {
                for (int x = 0; x < size; x++) {
                    float d = Vector2.Distance(new Vector2(x, y), new Vector2(center, center));
                    // Smoothstep-like anti-aliasing
                    float alpha = Mathf.Clamp01((radius - d) / 1.2f + 0.5f);
                    pixels[y * size + x] = new Color(1, 1, 1, alpha);
                }
            }
            tex.SetPixels(pixels); tex.Apply();
            return Sprite.Create(tex, new Rect(0, 0, size, size), new Vector2(0.5f, 0.5f));
        }
    }

    [HarmonyPatch(typeof(PnlMenu), "OnBackClicked")]
    public class PnlMenuOnBackClickedPatch
    {
        public static void Prefix() { SettingsButtonPatch.StartFadeOut(); }
    }

    [HarmonyPatch(typeof(OptionSelect), "OnSelect")]
    public class OptionSelectOnSelectPatch
    {
        public static void Postfix(GameObject currentObj)
        {
            if (SettingsButtonPatch._euterpeBtn != null && currentObj == SettingsButtonPatch._euterpeBtn)
            {
                var sel = currentObj.transform.Find("ImgSelected");
                if (sel != null) { sel.gameObject.SetActive(true); if (sel.childCount > 0) sel.GetChild(0).gameObject.SetActive(true); }
            }
        }
    }

    [HarmonyPatch(typeof(OptionSelect), "OnEnablePnl")]
    public class OptionSelectOnEnablePatch
    {
        public static void Postfix() { if (SettingsButtonPatch._euterpeBtn != null) { SettingsButtonPatch._euterpeBtn.SetActive(true); MelonCoroutines.Start(DelayedEntrance()); } }
        private static IEnumerator DelayedEntrance() {
            var cg = SettingsButtonPatch._euterpeBtn.GetComponent<CanvasGroup>();
            if (cg != null) cg.alpha = 0f; yield return new WaitForSeconds(0.3f);
            var animator = SettingsButtonPatch._euterpeBtn.GetComponent<Animator>();
            if (animator != null) animator.Play("Show", 0, 0f);
            float elapsed = 0f; while (elapsed < 0.2f) { elapsed += Time.deltaTime; if (cg != null) cg.alpha = elapsed / 0.2f; yield return null; }
            if (cg != null) cg.alpha = 1f;
        }
    }

    [HarmonyPatch(typeof(OptionSelect), "SetSelectableObj")]
    public class OptionSelectSetSelectablePatch
    {
        public static void Postfix(ref Il2CppSystem.Collections.Generic.List<GameObject> __result) {
            if (SettingsButtonPatch._euterpeBtn != null && !__result.Contains(SettingsButtonPatch._euterpeBtn)) __result.Add(SettingsButtonPatch._euterpeBtn);
        }
    }
}
