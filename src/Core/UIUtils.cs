using UnityEngine;
using UnityEngine.UI;
using Il2CppUI.Controls;

namespace Euterpe.Core
{
    public static class UIUtils
    {
        public static bool IsAnyModUIOpen { get; set; } = false;

        /// <summary>
        /// Creates an Isolated clone of the CommonMessageBox.
        /// Simplified hierarchy to ensure visibility and compatibility with native logic.
        /// </summary>
        public static CommonMessageBox CreateIsolatedBox(string name)
        {
            var originalSingleton = CommonMessageBox.s_Instance;
            var template = originalSingleton;
            if (template == null) template = GameObject.FindObjectOfType<CommonMessageBox>();
            if (template == null) return null;

            // 1. Clone directly into the native parent
            GameObject cloneObj = null;
            try
            {
                cloneObj = GameObject.Instantiate(template.gameObject, template.transform.parent);
            }
            finally
            {
                // ALWAYS restore the singleton, even if Instantiate/Awake crashes
                CommonMessageBox.s_Instance = originalSingleton;
            }

            if (cloneObj == null) return null;
            cloneObj.name = name;
            cloneObj.SetActive(true);

            // 2. Ensure interaction works by adding a Canvas and Raycaster if missing
            // This is crucial because some native parents might have raycasting disabled
            if (cloneObj.GetComponent<Canvas>() == null)
            {
                var canvas = cloneObj.AddComponent<Canvas>();
                canvas.overrideSorting = true;
                canvas.sortingOrder = 999; // Ensure it's on top
            }
            if (cloneObj.GetComponent<GraphicRaycaster>() == null)
            {
                cloneObj.AddComponent<GraphicRaycaster>();
            }

            // 3. Add the Modal Background (Dimming Effect)
            var modalObj = new GameObject("ModalBackground");
            modalObj.transform.SetParent(cloneObj.transform, false);
            modalObj.transform.SetAsFirstSibling(); 
            
            var modalRect = modalObj.AddComponent<RectTransform>();
            modalRect.anchorMin = Vector2.zero;
            modalRect.anchorMax = Vector2.one;
            modalRect.offsetMin = new Vector2(-5000f, -5000f);
            modalRect.offsetMax = new Vector2(5000f, 5000f);
            
            var modalImg = modalObj.AddComponent<Image>();
            modalImg.color = new Color(0f, 0f, 0f, 0.6f); 
            modalImg.raycastTarget = true; // This should block clicks to things BEHIND the popup

            var script = cloneObj.GetComponent<CommonMessageBox>();
            if (script != null)
            {
                script.ResetMsgBox();

                // 4. DEEP CLEAN
                var allTexts = cloneObj.GetComponentsInChildren<Text>(true);
                foreach (var t in allTexts) if (t != null) t.text = string.Empty;

                var allButtons = cloneObj.GetComponentsInChildren<Button>(true);
                foreach (var b in allButtons) if (b != null) b.gameObject.SetActive(false);
                
                // Stop any native animations that might hide the box
                var anims = cloneObj.GetComponentsInChildren<Animator>(true);
                foreach (var a in anims) if (a != null) a.enabled = false;
            }
            
            var rect = cloneObj.GetComponent<RectTransform>();
            if (rect != null)
            {
                rect.anchoredPosition = Vector2.zero;
                rect.localScale = Vector3.one;
            }

            Debug.Log($"[Euterpe] Created isolated message box: {name}");
            return script;
        }
    }
}
