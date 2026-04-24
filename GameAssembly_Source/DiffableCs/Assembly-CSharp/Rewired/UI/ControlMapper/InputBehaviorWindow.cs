namespace Rewired.UI.ControlMapper;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class InputBehaviorWindow : Window
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public Action<Int32, Int32, Single> valueChangedCallback; //Field offset: 0x10
		public int inputBehaviorId; //Field offset: 0x18
		public Action<Int32, Int32> cancelCallback; //Field offset: 0x20

		public <>c__DisplayClass26_0() { }

		internal void <CreateSlider>b__0(int cId, float value) { }

		internal void <CreateSlider>b__1(int cId) { }

	}

	internal enum ButtonIdentifier
	{
		Done = 0,
		Cancel = 1,
		Default = 2,
	}

	private class InputBehaviorInfo
	{
		private InputBehavior _inputBehavior; //Field offset: 0x10
		private UIControlSet _controlSet; //Field offset: 0x18
		private Dictionary<Int32, PropertyType> idToProperty; //Field offset: 0x20
		private InputBehavior copyOfOriginal; //Field offset: 0x28

		public UIControlSet controlSet
		{
			 get { } //Length: 5
		}

		public InputBehavior inputBehavior
		{
			 get { } //Length: 5
		}

		public InputBehaviorInfo(InputBehavior inputBehavior, UIControlSet controlSet, Dictionary<Int32, PropertyType> idToProperty) { }

		public UIControlSet get_controlSet() { }

		public InputBehavior get_inputBehavior() { }

		public void RefreshControls() { }

		public void RestoreData(PropertyType propertyType, int controlId) { }

		public void RestoreDefaultData() { }

		public void RestorePreviousData() { }

	}

	private enum PropertyType
	{
		JoystickAxisSensitivity = 0,
		MouseXYAxisSensitivity = 1,
	}

	private const float minSensitivity = 0.1; //Field offset: 0x0
	[SerializeField]
	private RectTransform spawnTransform; //Field offset: 0x80
	[SerializeField]
	private Button doneButton; //Field offset: 0x88
	[SerializeField]
	private Button cancelButton; //Field offset: 0x90
	[SerializeField]
	private Button defaultButton; //Field offset: 0x98
	[SerializeField]
	private Text doneButtonLabel; //Field offset: 0xA0
	[SerializeField]
	private Text cancelButtonLabel; //Field offset: 0xA8
	[SerializeField]
	private Text defaultButtonLabel; //Field offset: 0xB0
	[SerializeField]
	private GameObject uiControlSetPrefab; //Field offset: 0xB8
	[SerializeField]
	private GameObject uiSliderControlPrefab; //Field offset: 0xC0
	private List<InputBehaviorInfo> inputBehaviorInfo; //Field offset: 0xC8
	private Dictionary<Int32, Action`1<Int32>> buttonCallbacks; //Field offset: 0xD0
	private int playerId; //Field offset: 0xD8

	public InputBehaviorWindow() { }

	public virtual void Cancel() { }

	private UIControlSet CreateControlSet() { }

	private UISliderControl CreateSlider(UIControlSet set, int inputBehaviorId, string defaultTitle, string overrideTitle, Sprite icon, float minValue, float maxValue, Action<Int32, Int32, Single> valueChangedCallback, Action<Int32, Int32> cancelCallback) { }

	private InputBehavior GetInputBehavior(int id) { }

	private InputBehaviorInfo GetInputBehaviorInfo(int inputBehaviorId) { }

	public virtual void Initialize(int id, Func<Int32, Boolean> isFocusedCallback) { }

	private void JoystickAxisSensitivityCanceled(int inputBehaviorId, int controlId) { }

	private void JoystickAxisSensitivityValueChanged(int inputBehaviorId, int controlId, float value) { }

	private void MouseXYAxisSensitivityCanceled(int inputBehaviorId, int controlId) { }

	private void MouseXYAxisSensitivityValueChanged(int inputBehaviorId, int controlId, float value) { }

	public void OnCancel() { }

	public void OnDone() { }

	public void OnRestoreDefault() { }

	public void SetButtonCallback(ButtonIdentifier buttonIdentifier, Action<Int32> callback) { }

	public void SetData(int playerId, InputBehaviorSettings[] data) { }

	public virtual void TakeInputFocus() { }

}

