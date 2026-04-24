namespace Rewired;

[CustomClassObfuscation]
public sealed class AxisCalibration
{
	private AlternateAxisCalibrationType _calibrationMode; //Field offset: 0x10
	private Dictionary<Int32, AxisCalibrationInfo> _hardwareCalibrations; //Field offset: 0x18
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _enabled; //Field offset: 0x20
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _deadZone; //Field offset: 0x24
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _calibratedZero; //Field offset: 0x28
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _calibratedMin; //Field offset: 0x2C
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _calibratedMax; //Field offset: 0x30
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _invert; //Field offset: 0x34
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private AxisSensitivityType _sensitivityType; //Field offset: 0x38
	[CustomObfuscation]
	[FieldRange(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _sensitivity; //Field offset: 0x3C
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private AnimationCurve _sensitivityCurve; //Field offset: 0x40
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _applyRangeCalibration; //Field offset: 0x48

	public bool applyRangeCalibration
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public float calibratedMax
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float calibratedMin
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float calibratedZero
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	internal AlternateAxisCalibrationType calibrationMode
	{
		internal get { } //Length: 4
		internal set { } //Length: 16
	}

	public float deadZone
	{
		 get { } //Length: 6
		 set { } //Length: 30
	}

	public bool enabled
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool invert
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public float sensitivity
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public AnimationCurve sensitivityCurve
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public AxisSensitivityType sensitivityType
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	internal AxisCalibration(AxisCalibrationData unnamed_param_0) { }

	internal AxisCalibration(bool unnamed_param_0, Dictionary<Int32, AxisCalibrationInfo> unnamed_param_1, float unnamed_param_2, float unnamed_param_3, float unnamed_param_4, float unnamed_param_5, bool unnamed_param_6, bool unnamed_param_7, AxisSensitivityType unnamed_param_8, float unnamed_param_9, AnimationCurve unnamed_param_10) { }

	internal AxisCalibration() { }

	internal void CopyFrom(AxisCalibration data, bool copyHardwareData) { }

	private void CreateDefaultHardwareCalibration(AxisCalibrationData defaultData) { }

	internal static AxisCalibration CreateRelative() { }

	internal SerializedObject ExportData() { }

	public bool get_applyRangeCalibration() { }

	public float get_calibratedMax() { }

	public float get_calibratedMin() { }

	public float get_calibratedZero() { }

	internal AlternateAxisCalibrationType get_calibrationMode() { }

	public float get_deadZone() { }

	public bool get_enabled() { }

	public bool get_invert() { }

	public float get_sensitivity() { }

	public AnimationCurve get_sensitivityCurve() { }

	public AxisSensitivityType get_sensitivityType() { }

	internal float GetCalibratedValue(float value, AxisRange axisRange, float customDeadzone, bool applySensitivity, bool applyInversion) { }

	public float GetCalibratedValue(float value, AxisRange axisRange) { }

	internal float GetCalibratedValue(float value, float customDeadzone, bool applySensitivity, bool applyInversion) { }

	public float GetCalibratedValue(float value) { }

	public AxisCalibrationData GetData() { }

	private AxisCalibrationInfo GetHardwareDefault() { }

	internal void Import(SerializedObject serializedObject) { }

	private void InitHardwareCalibrations(Dictionary<Int32, AxisCalibrationInfo> hardwareCalibrations, AxisCalibrationData defaultData) { }

	public void Reset() { }

	public void set_applyRangeCalibration(bool value) { }

	public void set_calibratedMax(float value) { }

	public void set_calibratedMin(float value) { }

	public void set_calibratedZero(float value) { }

	internal void set_calibrationMode(AlternateAxisCalibrationType value) { }

	public void set_deadZone(float value) { }

	public void set_enabled(bool value) { }

	public void set_invert(bool value) { }

	public void set_sensitivity(float value) { }

	public void set_sensitivityCurve(AnimationCurve value) { }

	public void set_sensitivityType(AxisSensitivityType value) { }

	public void SetData(AxisCalibrationData data) { }

}

