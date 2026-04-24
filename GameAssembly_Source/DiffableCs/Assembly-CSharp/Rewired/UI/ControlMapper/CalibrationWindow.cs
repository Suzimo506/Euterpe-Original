namespace Rewired.UI.ControlMapper;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class CalibrationWindow : Window
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass41_0
	{
		public int index; //Field offset: 0x10
		public Button button; //Field offset: 0x18
		public CalibrationWindow <>4__this; //Field offset: 0x20

		public <>c__DisplayClass41_0() { }

		internal void <SetJoystick>b__0() { }

	}

	internal enum ButtonIdentifier
	{
		Done = 0,
		Cancel = 1,
		Default = 2,
		Calibrate = 3,
	}

	private const float minSensitivityOtherAxes = 0.1; //Field offset: 0x0
	private const float maxDeadzone = 0.8; //Field offset: 0x0
	[SerializeField]
	private RectTransform rightContentContainer; //Field offset: 0x80
	[SerializeField]
	private RectTransform valueDisplayGroup; //Field offset: 0x88
	[SerializeField]
	private RectTransform calibratedValueMarker; //Field offset: 0x90
	[SerializeField]
	private RectTransform rawValueMarker; //Field offset: 0x98
	[SerializeField]
	private RectTransform calibratedZeroMarker; //Field offset: 0xA0
	[SerializeField]
	private RectTransform deadzoneArea; //Field offset: 0xA8
	[SerializeField]
	private Slider deadzoneSlider; //Field offset: 0xB0
	[SerializeField]
	private Slider zeroSlider; //Field offset: 0xB8
	[SerializeField]
	private Slider sensitivitySlider; //Field offset: 0xC0
	[SerializeField]
	private Toggle invertToggle; //Field offset: 0xC8
	[SerializeField]
	private RectTransform axisScrollAreaContent; //Field offset: 0xD0
	[SerializeField]
	private Button doneButton; //Field offset: 0xD8
	[SerializeField]
	private Button calibrateButton; //Field offset: 0xE0
	[SerializeField]
	private Text doneButtonLabel; //Field offset: 0xE8
	[SerializeField]
	private Text cancelButtonLabel; //Field offset: 0xF0
	[SerializeField]
	private Text defaultButtonLabel; //Field offset: 0xF8
	[SerializeField]
	private Text deadzoneSliderLabel; //Field offset: 0x100
	[SerializeField]
	private Text zeroSliderLabel; //Field offset: 0x108
	[SerializeField]
	private Text sensitivitySliderLabel; //Field offset: 0x110
	[SerializeField]
	private Text invertToggleLabel; //Field offset: 0x118
	[SerializeField]
	private Text calibrateButtonLabel; //Field offset: 0x120
	[SerializeField]
	private GameObject axisButtonPrefab; //Field offset: 0x128
	private Joystick joystick; //Field offset: 0x130
	private string origCalibrationData; //Field offset: 0x138
	private int selectedAxis; //Field offset: 0x140
	private AxisCalibrationData origSelectedAxisCalibrationData; //Field offset: 0x148
	private float displayAreaWidth; //Field offset: 0x180
	private List<Button> axisButtons; //Field offset: 0x188
	private Dictionary<Int32, Action`1<Int32>> buttonCallbacks; //Field offset: 0x190
	private int playerId; //Field offset: 0x198
	private RewiredStandaloneInputModule rewiredStandaloneInputModule; //Field offset: 0x1A0
	private int menuHorizActionId; //Field offset: 0x1A8
	private int menuVertActionId; //Field offset: 0x1AC
	private float minSensitivity; //Field offset: 0x1B0

	private AxisCalibration axisCalibration
	{
		private get { } //Length: 130
	}

	private bool axisSelected
	{
		private get { } //Length: 78
	}

	public CalibrationWindow() { }

	public virtual void Cancel() { }

	private AxisCalibration get_axisCalibration() { }

	private bool get_axisSelected() { }

	private void GetAxisButtonDeadZone(int playerId, int actionId, ref float value) { }

	private float GetSliderSensitivity(AxisCalibration axisCalibration) { }

	public virtual void Initialize(int id, Func<Int32, Boolean> isFocusedCallback) { }

	private bool IsMenuAxis(int actionId, int axisIndex) { }

	public void OnAxisScrollRectScroll(Vector2 pos) { }

	private void OnAxisSelected(int axisIndex, Button button) { }

	public void OnCalibrate() { }

	public void OnCancel() { }

	public void OnDeadzoneCancel() { }

	public void OnDeadzoneValueChange(float value) { }

	public void OnDone() { }

	public void OnInvert(bool state) { }

	public void OnRestoreDefault() { }

	public void OnSensitivityCancel(float value) { }

	public void OnSensitivityValueChange(float value) { }

	public void OnZeroCancel() { }

	public void OnZeroValueChange(float value) { }

	private static float ProcessPowerValue(float value, float minValue, float maxValue) { }

	private void Redraw() { }

	private void RedrawCalibratedZero() { }

	private void RedrawDeadzone() { }

	private void RedrawValueMarkers() { }

	private void RefreshControls() { }

	private void SelectAxis(int index) { }

	public void SetButtonCallback(ButtonIdentifier buttonIdentifier, Action<Int32> callback) { }

	public void SetJoystick(int playerId, Joystick joystick) { }

	private void SetMinSensitivity() { }

	public void SetSensitivity(AxisCalibration axisCalibration, float sliderValue) { }

	public virtual void TakeInputFocus() { }

	protected virtual void Update() { }

	private void UpdateDisplay() { }

}

