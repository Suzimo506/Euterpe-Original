using System;
using System.Collections;
using MelonLoader;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using Il2Cpp;
using Il2CppInterop.Runtime;
using Il2CppUI.Controls;
using Il2CppAssets.Scripts.UI.Panels;

namespace Euterpe.Patches
{
    /// <summary>
    /// REPAIRED: Injects the Euterpe button with a safe synchronization method.
    /// No longer hooks base UI classes to prevent global game crashes.
    /// </summary>
    [HarmonyPatch(typeof(PnlMenu), "OnEnable")]
    public class SettingsButtonPatch
    {
        private const string EuterpeButtonName = "ModEuterpeButton";
        internal static GameObject _euterpeBtn = null;

        public static void Postfix(PnlMenu __instance)
        {
            try
            {
                var togglesParent = __instance.transform.Find("Panels/PnlOption/Toggles");
                if (togglesParent == null) return;

                var templateBtn = togglesParent.Find("BtnFeedback");
                if (templateBtn == null) return;

                if (togglesParent.Find(EuterpeButtonName) != null) return;

                // 1. Create the button
                _euterpeBtn = GameObject.Instantiate(templateBtn.gameObject, togglesParent);
                _euterpeBtn.name = EuterpeButtonName;
                _euterpeBtn.SetActive(true);
                _euterpeBtn.transform.SetAsLastSibling();

                // 2. Clean up components
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

                // 3. Setup Visuals (Icon & Text)
                var iconChild = _euterpeBtn.transform.Find("ImgFeedback");
                if (iconChild != null)
                {
                    var iconImg = iconChild.GetComponent<Image>();
                    var accountBtn = togglesParent.Find("Account");
                    if (accountBtn != null)
                    {
                        var accIcon = accountBtn.Find("ImgAccount")?.GetComponent<Image>();
                        if (accIcon != null && iconImg != null) iconImg.sprite = accIcon.sprite;
                    }
                }

                var txtChild = _euterpeBtn.transform.Find("TxtFeedback");
                if (txtChild != null)
                {
                    var txt = txtChild.GetComponent<Text>();
                    if (txt != null) txt.text = "Euterpe";
                }

                // 4. Setup Click Event
                var button = _euterpeBtn.GetComponent<Button>();
                if (button != null)
                {
                    button.onClick.RemoveAllListeners();
                    button.onClick.AddListener((UnityAction)new Action(() =>
                    {
                        MelonLogger.Msg("[Euterpe] Euterpe settings button clicked!");
                        ShowEuterpeProfilePopup();
                    }));
                }

                // 5. Add CanvasGroup
                if (_euterpeBtn.GetComponent<CanvasGroup>() == null)
                    _euterpeBtn.AddComponent<CanvasGroup>();

                // 6. Initial state: Hide
                var cg = _euterpeBtn.GetComponent<CanvasGroup>();
                if (cg != null) cg.alpha = 0f;

                // 7. Ensure bracket is ready
                var bracket = _euterpeBtn.transform.Find("ImgSelected");
                if (bracket != null) bracket.gameObject.SetActive(false);

                // Refresh navigation list
                var optionSelect = togglesParent.GetComponentInParent<OptionSelect>();
                if (optionSelect != null) optionSelect.SetSelectableObj();

                MelonLogger.Msg("[Euterpe] Settings button injected safely.");
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[Euterpe] Injection failed: {ex.Message}");
            }
        }

        internal static void ShowEuterpeProfilePopup()
        {
            MelonLogger.Msg("[Euterpe] Opening profile popup...");
        }
    }

    /// <summary>
    /// Bracket fix.
    /// </summary>
    [HarmonyPatch(typeof(OptionSelect), "OnSelect")]
    public class OptionSelectOnSelectPatch
    {
        public static void Postfix(GameObject currentObj)
        {
            if (SettingsButtonPatch._euterpeBtn != null && currentObj == SettingsButtonPatch._euterpeBtn)
            {
                var imgSelected = currentObj.transform.Find("ImgSelected");
                if (imgSelected != null)
                {
                    imgSelected.gameObject.SetActive(true);
                    if (imgSelected.childCount > 0)
                        imgSelected.GetChild(0).gameObject.SetActive(true);
                }
            }
        }
    }

    /// <summary>
    /// Safe entrance animation.
    /// </summary>
    [HarmonyPatch(typeof(OptionSelect), "OnEnablePnl")]
    public class OptionSelectOnEnablePatch
    {
        public static void Postfix()
        {
            if (SettingsButtonPatch._euterpeBtn != null)
            {
                MelonCoroutines.Start(DelayedEntrance());
            }
        }

        private static IEnumerator DelayedEntrance()
        {
            var cg = SettingsButtonPatch._euterpeBtn.GetComponent<CanvasGroup>();
            if (cg != null) cg.alpha = 0f;

            yield return new WaitForSeconds(0.3f);

            var animator = SettingsButtonPatch._euterpeBtn.GetComponent<Animator>();
            if (animator != null) animator.Play("Show", 0, 0f);

            float elapsed = 0f;
            float duration = 0.2f;
            while (elapsed < duration)
            {
                elapsed += Time.deltaTime;
                if (cg != null) cg.alpha = Mathf.Lerp(0f, 1f, elapsed / duration);
                yield return null;
            }
            if (cg != null) cg.alpha = 1f;
        }
    }

    /// <summary>
    /// Selectable list fix.
    /// </summary>
    [HarmonyPatch(typeof(OptionSelect), "SetSelectableObj")]
    public class OptionSelectSetSelectablePatch
    {
        public static void Postfix(ref Il2CppSystem.Collections.Generic.List<GameObject> __result)
        {
            if (SettingsButtonPatch._euterpeBtn != null && !__result.Contains(SettingsButtonPatch._euterpeBtn))
            {
                __result.Add(SettingsButtonPatch._euterpeBtn);
            }
        }
    }
}
