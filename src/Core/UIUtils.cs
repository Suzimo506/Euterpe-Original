using UnityEngine;
using UnityEngine.UI;
using Il2CppUI.Controls;

namespace Euterpe.Core
{
    public static class UIUtils
    {
        /// <summary>
        /// Creates an Isolated clone of the CommonMessageBox.
        /// The key to preventing native popup pollution is saving and restoring s_Instance
        /// during the Instantiate call, ensuring the game's global reference remains unchanged.
        /// </summary>
        public static CommonMessageBox CreateIsolatedBox(string name)
        {
            // The root cause of pollution: Awake() on any CommonMessageBox overwrites s_Instance.
            // We MUST protect it.
            var originalSingleton = CommonMessageBox.s_Instance;
            var template = originalSingleton;
            
            // If the singleton isn't active, try to find it in the scene
            if (template == null) template = GameObject.FindObjectOfType<CommonMessageBox>();
            if (template == null) return null;

            // 1. Clone the entire hierarchy
            var cloneObj = GameObject.Instantiate(template.gameObject, template.transform.parent);
            cloneObj.name = name;
            
            // 2. RESTORE the global singleton immediately.
            // This is the CRITICAL STEP to solve native popup pollution.
            CommonMessageBox.s_Instance = originalSingleton;
            
            var script = cloneObj.GetComponent<CommonMessageBox>();
            if (script != null)
            {
                // 1. Call native reset logic
                script.ResetMsgBox();

                // 2. DEEP CLEAN: Manually clear all text and hide existing buttons.
                // ResetMsgBox often leaves stale content if the popup was previously active.
                var allTexts = cloneObj.GetComponentsInChildren<Text>(true);
                foreach (var t in allTexts) if (t != null) t.text = string.Empty;

                var allButtons = cloneObj.GetComponentsInChildren<Button>(true);
                foreach (var b in allButtons) if (b != null) b.gameObject.SetActive(false);
            }
            
            // 3. Reset transform for proper placement
            var rect = cloneObj.GetComponent<RectTransform>();
            if (rect != null)
            {
                rect.anchoredPosition = Vector2.zero;
                rect.localScale = Vector3.one;
            }

            return script;
        }
    }
}
