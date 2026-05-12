using System;
using MelonLoader;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using Il2CppUI.Controls;
using Il2CppAssets.Scripts.UI.Panels;
using Il2CppInterop.Runtime;
using Il2Cpp;
using Il2CppAssets.Scripts.Database;

namespace Euterpe.Patches
{
    [HarmonyPatch(typeof(PnlPreparation), "Awake")]
    public class CommentUIPatchAwake
    {
        private const float CommentInputLeftPadding = 10f;
        private const float CommentInputRightPadding = 42f;
        private const float CommentInputVerticalPadding = 2f;
        private static readonly Color CommentClearButtonBgColor = new Color(0.42f, 0.16f, 0.66f, 0.95f);
        private static readonly Color CommentClearButtonIconColor = new Color(0.88f, 0.46f, 1f, 1f);

        private static void ApplyInputTextPadding(InputField inputField, float rightPadding = CommentInputRightPadding)
        {
            if (inputField == null || inputField.textComponent == null) return;

            var textAreaTransform = inputField.textComponent.transform.parent;

            if (textAreaTransform != null && textAreaTransform != inputField.transform)
            {
                if (textAreaTransform.GetComponent<RectMask2D>() == null)
                    textAreaTransform.gameObject.AddComponent<RectMask2D>();

                var taRect = textAreaTransform.GetComponent<RectTransform>();
                if (taRect != null)
                {
                    taRect.offsetMin = new Vector2(CommentInputLeftPadding, CommentInputVerticalPadding);
                    taRect.offsetMax = new Vector2(-rightPadding, -CommentInputVerticalPadding);
                }
            }
            else
            {
                var txtRect = inputField.textComponent.GetComponent<RectTransform>();
                if (txtRect != null)
                {
                    txtRect.offsetMin = new Vector2(CommentInputLeftPadding, CommentInputVerticalPadding);
                    txtRect.offsetMax = new Vector2(-rightPadding, -CommentInputVerticalPadding);
                }
            }
        }

        private static bool HasTextRecursive(Transform root, string expected)
        {
            if (root == null || string.IsNullOrEmpty(expected)) return false;

            var texts = root.GetComponentsInChildren<Text>(true);
            if (texts == null) return false;

            for (int i = 0; i < texts.Length; i++)
            {
                var txt = texts[i];
                if (txt != null && !string.IsNullOrEmpty(txt.text) && txt.text.Contains(expected))
                    return true;
            }

            return false;
        }

        private static bool HasAncestorNamed(Transform root, params string[] patterns)
        {
            var current = root;
            while (current != null)
            {
                var name = current.name?.ToLowerInvariant() ?? string.Empty;
                for (int i = 0; i < patterns.Length; i++)
                {
                    if (name.Contains(patterns[i])) return true;
                }
                current = current.parent;
            }

            return false;
        }

        private static Button FindSearchTrashCanTemplate()
        {
            try
            {
                var buttons = UnityEngine.Resources.FindObjectsOfTypeAll<Button>();
                if (buttons != null)
                {
                    Button bestButton = null;
                    int bestScore = int.MinValue;

                    for (int i = 0; i < buttons.Length; i++)
                    {
                        var button = buttons[i];
                        if (button == null || string.IsNullOrEmpty(button.name)) continue;

                        var name = button.name.ToLowerInvariant();
                        int score = 0;

                        if (name.Contains("trash")) score += 120;
                        if (name.Contains("clear")) score += 100;
                        if (name.Contains("btn")) score += 10;
                        if (name.Contains("icon")) score += 10;
                        if (HasTextRecursive(button.transform, "清除")) score += 300;
                        if (HasTextRecursive(button.transform, "R")) score += 80;
                        if (HasAncestorNamed(button.transform, "search", "musictag", "tag")) score += 60;

                        if (score > bestScore)
                        {
                            bestScore = score;
                            bestButton = button;
                        }
                    }

                    if (bestButton != null && bestScore > 0)
                        return bestButton;
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[Euterpe] Failed to find search trash button template: {ex.Message}");
            }

            return null;
        }

        private static float GetClearButtonReservedWidth(Button clearButton)
        {
            return CommentInputRightPadding;
        }

        private static void AddClearButtonLine(Transform parent, float zRotation)
        {
            var lineObj = new GameObject(zRotation > 0 ? "LineA" : "LineB");
            lineObj.transform.SetParent(parent, false);

            var lineRect = lineObj.AddComponent<RectTransform>();
            lineRect.anchorMin = new Vector2(0.5f, 0.5f);
            lineRect.anchorMax = new Vector2(0.5f, 0.5f);
            lineRect.pivot = new Vector2(0.5f, 0.5f);
            lineRect.sizeDelta = new Vector2(14f, 2.8f);
            lineRect.anchoredPosition = Vector2.zero;
            lineRect.localRotation = Quaternion.Euler(0f, 0f, zRotation);

            var lineImage = lineObj.AddComponent<Image>();
            lineImage.color = CommentClearButtonIconColor;
        }

        private static Button CreateCommentClearButton(GameObject inputObj)
        {
            if (inputObj == null) return null;

            var clearObj = new GameObject("ModCommentClearButton");
            clearObj.transform.SetParent(inputObj.transform, false);

            var image = clearObj.AddComponent<Image>();
            image.color = CommentClearButtonBgColor;
            image.type = Image.Type.Sliced;

            var inputBg = inputObj.GetComponent<Image>();
            if (inputBg != null && inputBg.sprite != null)
            {
                image.sprite = inputBg.sprite;
            }

            AddClearButtonLine(clearObj.transform, 45f);
            AddClearButtonLine(clearObj.transform, -45f);

            var clearButton = clearObj.AddComponent<Button>();

            clearButton.onClick.RemoveAllListeners();

            var clearRect = clearButton.GetComponent<RectTransform>() ?? clearButton.gameObject.AddComponent<RectTransform>();
            clearRect.SetParent(inputObj.transform, false);
            clearRect.anchorMin = new Vector2(1f, 0.5f);
            clearRect.anchorMax = new Vector2(1f, 0.5f);
            clearRect.pivot = new Vector2(1f, 0.5f);
            clearRect.sizeDelta = new Vector2(28f, 28f);
            clearRect.anchoredPosition = new Vector2(-6f, 0f);

            var layoutElement = clearButton.GetComponent<LayoutElement>() ?? clearButton.gameObject.AddComponent<LayoutElement>();
            layoutElement.ignoreLayout = true;
            layoutElement.minWidth = clearRect.sizeDelta.x;
            layoutElement.minHeight = clearRect.sizeDelta.y;
            layoutElement.preferredWidth = clearRect.sizeDelta.x;
            layoutElement.preferredHeight = clearRect.sizeDelta.y;

            clearButton.gameObject.SetActive(false);
            clearButton.transform.SetAsLastSibling();
            return clearButton;
        }

        private static void UpdateCommentInputVisualState(InputField inputField, Button clearButton, bool hidePlaceholder)
        {
            if (inputField == null) return;

            bool hasText = !string.IsNullOrEmpty(inputField.text);

            if (inputField.placeholder != null)
                inputField.placeholder.gameObject.SetActive(!hidePlaceholder && !hasText);

            if (clearButton != null)
                clearButton.gameObject.SetActive(hasText);
        }

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
                if (templateInput == null || templateInput.Length == 0) return;

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

                // Fix caret/text overflow and reserve right-side space for the clear button.
                var inputFieldComp = inputObj.GetComponent<InputField>();
                ApplyInputTextPadding(inputFieldComp);

                var inputField = inputObj.GetComponent<InputField>();
                if (inputField != null) 
                {
                    var clearButton = CreateCommentClearButton(inputObj);
                    ApplyInputTextPadding(inputField, GetClearButtonReservedWidth(clearButton));
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
                        UpdateCommentInputVisualState(inputField, clearButton, true);
                    }));
                    trigger.triggers.Add(selectEntry);

                    var deselectEntry = new UnityEngine.EventSystems.EventTrigger.Entry { eventID = UnityEngine.EventSystems.EventTriggerType.Deselect };
                    deselectEntry.callback.AddListener((UnityAction<UnityEngine.EventSystems.BaseEventData>)new Action<UnityEngine.EventSystems.BaseEventData>((data) => {
                        Il2CppAssets.Scripts.PeroTools.Managers.InputManager.instance.isStopKeyAction = false;
                        UpdateCommentInputVisualState(inputField, clearButton, false);
                    }));
                    trigger.triggers.Add(deselectEntry);

                    inputField.onValueChanged.AddListener((UnityAction<string>)new Action<string>((text) =>
                    {
                        UpdateCommentInputVisualState(inputField, clearButton, inputField.isFocused);
                    }));

                    if (clearButton != null)
                    {
                        clearButton.onClick.AddListener((UnityAction)new Action(() =>
                        {
                            inputField.text = "";
                            UpdateCommentInputVisualState(inputField, clearButton, inputField.isFocused);
                            inputField.ActivateInputField();
                        }));
                    }

                    // Bind Enter key submission event
                    inputField.onEndEdit.AddListener((UnityAction<string>)new Action<string>((text) => 
                    {
                        var submittedByEnter =
                            UnityEngine.Input.GetKey(KeyCode.Return) ||
                            UnityEngine.Input.GetKey(KeyCode.KeypadEnter);

                        if (submittedByEnter && !string.IsNullOrEmpty(text)) 
                        {
                            var info = GlobalDataBase.s_DbMusicTag.CurMusicInfo();
                            string currentTargetUid = info?.uid ?? "Unknown";
                            MelonLogger.Msg($"[Euterpe] Comment For {currentTargetUid} Submitted: {text}");
                            
                            // Clear input field after submission
                            inputField.text = "";
                            UpdateCommentInputVisualState(inputField, clearButton, inputField.isFocused);
                            
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

                    UpdateCommentInputVisualState(inputField, clearButton, false);
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
        private const string CommentTitleActionGroupName = "ModCommentTitleActions";
        private const string CommentAvatarPopupContentName = "ModCommentAvatarPopupContent";
        private static Color[] _originalCupColors = null;
        private static Sprite[] _originalCupSprites = null;
        private static Sprite _avatarMaskSprite = null;

        private static Button CreateTitleActionButton(Transform parent, Text templateText, string name, string label, Vector2 anchoredPosition, Color bgColor)
        {
            var buttonObj = new GameObject(name);
            buttonObj.transform.SetParent(parent, false);

            var rect = buttonObj.AddComponent<RectTransform>();
            rect.anchorMin = new Vector2(0.5f, 0.5f);
            rect.anchorMax = new Vector2(0.5f, 0.5f);
            rect.pivot = new Vector2(0.5f, 0.5f);
            rect.sizeDelta = new Vector2(68f, 30f);
            rect.anchoredPosition = anchoredPosition;

            var image = buttonObj.AddComponent<Image>();
            image.color = bgColor;
            image.type = Image.Type.Sliced;

            var labelObj = new GameObject("Label");
            labelObj.transform.SetParent(buttonObj.transform, false);
            var labelRect = labelObj.AddComponent<RectTransform>();
            labelRect.anchorMin = Vector2.zero;
            labelRect.anchorMax = Vector2.one;
            labelRect.offsetMin = Vector2.zero;
            labelRect.offsetMax = Vector2.zero;

            var txt = labelObj.AddComponent<Text>();
            if (templateText != null)
            {
                txt.font = templateText.font;
                txt.material = templateText.material;
            }
            txt.transform.SetParent(labelObj.transform, false);
            txt.rectTransform.anchorMin = Vector2.zero;
            txt.rectTransform.anchorMax = Vector2.one;
            txt.rectTransform.offsetMin = Vector2.zero;
            txt.rectTransform.offsetMax = Vector2.zero;
            txt.text = label;
            txt.fontSize = 17;
            txt.color = new Color(0.93f, 0.83f, 1f, 1f);
            var alignProp = typeof(Text).GetProperty("alignment");
            if (alignProp != null) alignProp.SetValue(txt, 4, null);

            var button = buttonObj.AddComponent<Button>();
            button.onClick.AddListener((UnityAction)new Action(() =>
            {
                MelonLogger.Msg($"[Euterpe] Title action clicked: {name}");
            }));

            return button;
        }

        private static Text ClonePopupText(Text template, Transform parent, string objectName, string value, int fontSize, Vector2 anchoredPosition, Vector2 sizeDelta)
        {
            Text text;
            if (template != null)
            {
                text = GameObject.Instantiate(template, parent);
                text.name = objectName;
            }
            else
            {
                var textObj = new GameObject(objectName);
                textObj.transform.SetParent(parent, false);
                text = textObj.AddComponent<Text>();
            }

            text.transform.SetParent(parent, false);
            text.text = value;
            text.fontSize = fontSize;
            text.raycastTarget = false;

            // Remove inherited Shadow/Outline effects from cloned template
            var shadow = text.GetComponent<Shadow>();
            if (shadow != null) GameObject.DestroyImmediate(shadow);
            var outline = text.GetComponent<Outline>();
            if (outline != null) GameObject.DestroyImmediate(outline);

            var textRect = text.rectTransform;
            textRect.anchorMin = new Vector2(0f, 1f);
            textRect.anchorMax = new Vector2(0f, 1f);
            textRect.pivot = new Vector2(0f, 1f);
            textRect.sizeDelta = sizeDelta;
            textRect.anchoredPosition = anchoredPosition;

            var alignProp = typeof(Text).GetProperty("alignment");
            if (alignProp != null) alignProp.SetValue(text, 3, null);

            return text;
        }

        private static GameObject _currentAvatarPopup;

        private static void ShowAvatarPopup(Sprite avatarSprite, string userName)
        {
            if (_currentAvatarPopup != null) UnityEngine.Object.Destroy(_currentAvatarPopup);

            Euterpe.Core.UIUtils.IsAnyModUIOpen = true; // Signal UI lock
            var boxScript = Euterpe.Core.UIUtils.CreateIsolatedBox("ModCommentAvatarBox");
            if (boxScript == null)
            {
                Euterpe.Core.UIUtils.IsAnyModUIOpen = false;
                return;
            }
            var messageBox = boxScript;
            var deadBox = messageBox.gameObject;
            _currentAvatarPopup = deadBox;
            Euterpe.Core.UIUtils.ActivePopup = deadBox;
            deadBox.SetActive(true);

            try
            {
                // Access Il2Cpp properties directly (AccessTools.Field returns null for Il2Cpp interop properties)
                // Grab a text template for font cloning; don't clear any text — ShowConfirm(" ") already sets body to empty
                var textComponents = messageBox.textComponents;
                Text popupTextTemplate = (textComponents != null && textComponents.Length > 0) ? textComponents[0] : null;

                // Hide the "提示" title by clearing all Text children that contain it
                var allTexts = messageBox.GetComponentsInChildren<Text>(true);
                if (allTexts != null)
                {
                    for (int i = 0; i < allTexts.Length; i++)
                    {
                        if (allTexts[i] != null && allTexts[i].text == "提示")
                            allTexts[i].text = string.Empty;
                    }
                }

                messageBox.btnDefaultClose?.gameObject.SetActive(false);
                messageBox.ResetImgBgSize(new Vector2(760f, 420f));

                var bgRect = messageBox.imgBgRect;
                var contentParent = bgRect != null ? bgRect : messageBox.transform as RectTransform;

                var oldContent = contentParent != null ? contentParent.Find(CommentAvatarPopupContentName) : null;
                if (oldContent != null)
                {
                    GameObject.Destroy(oldContent.gameObject);
                }

                var contentObj = new GameObject(CommentAvatarPopupContentName);
                contentObj.transform.SetParent(contentParent, false);

                var contentRect = contentObj.AddComponent<RectTransform>();
                contentRect.anchorMin = new Vector2(0.5f, 0.5f);
                contentRect.anchorMax = new Vector2(0.5f, 0.5f);
                contentRect.pivot = new Vector2(0.5f, 0.5f);
                contentRect.sizeDelta = new Vector2(660f, 270f);
                contentRect.anchoredPosition3D = new Vector3(0f, 24f, 0f);

                var avatarHolder = new GameObject("Avatar");
                avatarHolder.transform.SetParent(contentObj.transform, false);
                var avatarRect = avatarHolder.AddComponent<RectTransform>();
                avatarRect.anchorMin = new Vector2(0f, 1f);
                avatarRect.anchorMax = new Vector2(0f, 1f);
                avatarRect.pivot = new Vector2(0f, 1f);
                avatarRect.sizeDelta = new Vector2(96f, 96f);
                avatarRect.anchoredPosition = new Vector2(0f, 0f);

                var avatarMaskImage = avatarHolder.AddComponent<Image>();
                avatarMaskImage.sprite = GetAvatarMaskSprite();
                avatarMaskImage.color = Color.white;
                avatarMaskImage.raycastTarget = false;
                var avatarMask = avatarHolder.AddComponent<Mask>();
                avatarMask.showMaskGraphic = false;

                var avatarContentObj = new GameObject("AvatarContent");
                avatarContentObj.transform.SetParent(avatarHolder.transform, false);
                var avatarContentRect = avatarContentObj.AddComponent<RectTransform>();
                avatarContentRect.anchorMin = Vector2.zero;
                avatarContentRect.anchorMax = Vector2.one;
                avatarContentRect.offsetMin = Vector2.zero;
                avatarContentRect.offsetMax = Vector2.zero;

                var avatarImage = avatarContentObj.AddComponent<Image>();
                avatarImage.sprite = avatarSprite;
                avatarImage.color = Color.white;
                avatarImage.raycastTarget = false;

                var nameText = ClonePopupText(
                    popupTextTemplate,
                    contentObj.transform,
                    "UserName",
                    userName,
                    30,
                    new Vector2(120f, -8f),
                    new Vector2(500f, 42f));
                nameText.color = new Color(0.95f, 0.92f, 1f, 1f);

                var placeholderAreaObj = new GameObject("ReservedArea");
                placeholderAreaObj.transform.SetParent(contentObj.transform, false);
                var placeholderRect = placeholderAreaObj.AddComponent<RectTransform>();
                placeholderRect.anchorMin = new Vector2(0f, 0f);
                placeholderRect.anchorMax = new Vector2(1f, 0f);
                placeholderRect.pivot = new Vector2(0.5f, 0f);
                placeholderRect.sizeDelta = new Vector2(0f, 132f);
                placeholderRect.anchoredPosition = new Vector2(0f, 42f);

                contentObj.transform.SetAsLastSibling();

                contentObj.transform.SetAsLastSibling();

                contentObj.transform.SetAsLastSibling();
                messageBox.ForceRebuildBtnLayouts();

                messageBox.ForceRebuildBtnLayouts();
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[Euterpe] Failed to configure avatar popup: {ex.Message}");
                Euterpe.Core.UIUtils.IsAnyModUIOpen = false;
                if (_currentAvatarPopup != null) UnityEngine.Object.Destroy(_currentAvatarPopup);
                _currentAvatarPopup = null;
            }
        }

        private static void EnsureTitleActionButtons(Transform imgTittleBase, Text templateText, bool isCustomChart)
        {
            if (imgTittleBase == null) return;

            var actionGroup = imgTittleBase.Find(CommentTitleActionGroupName);
            if (actionGroup == null)
            {
                var groupObj = new GameObject(CommentTitleActionGroupName);
                groupObj.transform.SetParent(imgTittleBase, false);

                var groupRect = groupObj.AddComponent<RectTransform>();
                groupRect.anchorMin = new Vector2(1f, 0.5f);
                groupRect.anchorMax = new Vector2(1f, 0.5f);
                groupRect.pivot = new Vector2(1f, 0.5f);
                groupRect.sizeDelta = new Vector2(244f, 36f);
                groupRect.anchoredPosition = new Vector2(-10f, 0f);

                CreateTitleActionButton(groupObj.transform, templateText, "BtnLike", "点赞", new Vector2(-74f, 0f), new Color(0.28f, 0.44f, 0.88f, 0.9f));
                CreateTitleActionButton(groupObj.transform, templateText, "BtnDislike", "点踩", new Vector2(0f, 0f), new Color(0.54f, 0.24f, 0.78f, 0.9f));
                CreateTitleActionButton(groupObj.transform, templateText, "BtnReport", "举报", new Vector2(74f, 0f), new Color(0.78f, 0.24f, 0.42f, 0.9f));

                actionGroup = groupObj.transform;
            }

            actionGroup.gameObject.SetActive(isCustomChart);
        }

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

                                EnsureTitleActionButtons(imgTittleBase, t, isCustomChart);

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
                                    string[] testNames = new string[]
                                    {
                                        "Alice",
                                        "Momo",
                                        "Nora",
                                        "Rin",
                                        "Player 5",
                                        "Player 6",
                                        "Player 7",
                                        "Player 8",
                                        "Player 9",
                                        "Player 10"
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
                                        avatarMaskImage.raycastTarget = false;
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
                                        img.raycastTarget = true;

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

                                        var avatarButton = avatarObj.AddComponent<Button>();
                                        avatarButton.targetGraphic = img;
                                        avatarButton.onClick.RemoveAllListeners();
                                        int avatarIndex = j;
                                        var avatarSprite = img.sprite;
                                        string avatarName = j <= testNames.Length ? testNames[j - 1] : $"Player {j}";
                                        avatarButton.onClick.AddListener((UnityAction)new Action(() =>
                                        {
                                            MelonLogger.Msg($"[Euterpe] Comment avatar clicked: #{avatarIndex}");
                                            ShowAvatarPopup(avatarSprite, avatarName);
                                        }));
                                        
                                        var textObj = new GameObject("CommentText");
                                        textObj.transform.SetParent(itemObj.transform, false);
                                        var txt = textObj.AddComponent<Text>();
                                        var templateTextComp = titleTextObj.GetComponent<Text>();
                                        if (templateTextComp != null)
                                        {
                                            txt.font = templateTextComp.font;
                                            txt.material = templateTextComp.material;
                                        }
                                        var textRect = textObj.GetComponent<RectTransform>();
                                        textRect.sizeDelta = new Vector2(640, 60); // Give text more width
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
