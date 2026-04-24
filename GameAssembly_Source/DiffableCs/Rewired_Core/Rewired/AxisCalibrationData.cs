namespace Rewired;

public struct AxisCalibrationData
{
	public bool enabled; //Field offset: 0x0
	public float deadZone; //Field offset: 0x4
	public float zero; //Field offset: 0x8
	public float min; //Field offset: 0xC
	public float max; //Field offset: 0x10
	public bool invert; //Field offset: 0x14
	public AxisSensitivityType sensitivityType; //Field offset: 0x18
	public float sensitivity; //Field offset: 0x1C
	public AnimationCurve sensitivityCurve; //Field offset: 0x20
	public bool applyRangeCalibration; //Field offset: 0x28
	[CustomObfuscation]
	internal Dictionary<Int32, AxisCalibrationInfo> calibrations; //Field offset: 0x30

	public static AxisCalibrationData Default
	{
		 get { } //Length: 433
	}

	[CustomObfuscation]
	internal static AxisCalibrationData Raw
	{
		internal get { } //Length: 429
	}

	public AxisCalibrationData(bool unnamed_param_0, float unnamed_param_1, float unnamed_param_2, float unnamed_param_3, float unnamed_param_4, bool unnamed_param_5, bool unnamed_param_6) { }

	public AxisCalibrationData(bool unnamed_param_0, float unnamed_param_1, float unnamed_param_2, float unnamed_param_3, float unnamed_param_4, bool unnamed_param_5, bool unnamed_param_6, float unnamed_param_7) { }

	public AxisCalibrationData(bool unnamed_param_0, float unnamed_param_1, float unnamed_param_2, float unnamed_param_3, float unnamed_param_4, bool unnamed_param_5, bool unnamed_param_6, AxisSensitivityType unnamed_param_7, float unnamed_param_8, AnimationCurve unnamed_param_9) { }

	public static AxisCalibrationData get_Default() { }

	internal static AxisCalibrationData get_Raw() { }

}

