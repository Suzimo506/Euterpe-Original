using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using Il2CppUI.Controls;


namespace Euterpe.Core
{
    public static class UIUtils
    {
        public static bool IsAnyModUIOpen { get; set; } = false;

        /// <summary>
        /// Reference to the currently active mod popup.
        /// Used by the main update loop to handle ESC key dismissals.
        /// </summary>
        public static GameObject ActivePopup { get; set; }


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

            // 1. Create a Root Container to hold both the Modal and the Box
            var rootObj = new GameObject(name + "_Root");
            UnityEngine.Object.DontDestroyOnLoad(rootObj); 
            
            var rootRect = rootObj.AddComponent<RectTransform>();
            rootRect.anchorMin = Vector2.zero;
            rootRect.anchorMax = Vector2.one;
            rootRect.offsetMin = rootRect.offsetMax = Vector2.zero;

            var canvas = rootObj.AddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            canvas.overrideSorting = true;
            canvas.sortingOrder = 9999; 
            rootObj.AddComponent<GraphicRaycaster>();

            // 2. Add the Modal Background (Dimming Effect)
            var modalObj = new GameObject("ModalBackground");
            modalObj.transform.SetParent(rootObj.transform, false);
            
            var modalRect = modalObj.AddComponent<RectTransform>();
            modalRect.anchorMin = Vector2.zero;
            modalRect.anchorMax = Vector2.one;
            modalRect.offsetMin = new Vector2(-5000f, -5000f);
            modalRect.offsetMax = new Vector2(5000f, 5000f);
            
            var modalImg = modalObj.AddComponent<Image>();
            modalImg.color = new Color(0f, 0f, 0f, 0.6f); 
            modalImg.raycastTarget = true; 
            
            var modalBtn = modalObj.AddComponent<Button>();
            modalBtn.onClick.AddListener((UnityAction)new System.Action(() => {
                Euterpe.Core.UIUtils.IsAnyModUIOpen = false;
                Euterpe.Core.UIUtils.ActivePopup = null;
                UnityEngine.Object.Destroy(rootObj);
            }));

            // 3. Clone the Box into the root
            GameObject cloneObj = null;
            try
            {
                cloneObj = GameObject.Instantiate(template.gameObject, rootObj.transform);
            }
            finally
            {
                CommonMessageBox.s_Instance = originalSingleton;
            }

            if (cloneObj == null) return null;
            cloneObj.SetActive(true);

            var script = cloneObj.GetComponent<CommonMessageBox>();
            if (script != null)
            {
                script.ResetMsgBox();
                var allTexts = cloneObj.GetComponentsInChildren<Text>(true);
                foreach (var t in allTexts) if (t != null) t.text = string.Empty;
            }
            
            var rect = cloneObj.GetComponent<RectTransform>();
            if (rect != null)
            {
                rect.anchoredPosition = Vector2.zero;
                rect.localScale = Vector3.one;
            }

            ActivePopup = rootObj;
            return script;
        }
    }
}
