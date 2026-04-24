namespace Rewired.Data.Mapping;

public class AxisCalibrationInfo : IDeepCloneable
{
	[SerializeField]
	private bool _applyRangeCalibration; //Field offset: 0x10
	[SerializeField]
	private bool _invert; //Field offset: 0x11
	[SerializeField]
	private float _deadZone; //Field offset: 0x14
	[SerializeField]
	private float _zero; //Field offset: 0x18
	[SerializeField]
	private float _min; //Field offset: 0x1C
	[SerializeField]
	private float _max; //Field offset: 0x20
	[SerializeField]
	private AxisSensitivityType _sensitivityType; //Field offset: 0x24
	[SerializeField]
	private float _sensitivity; //Field offset: 0x28
	[SerializeField]
	private AnimationCurve _sensitivityCurve; //Field offset: 0x30

	public bool applyRangeCalibration
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public float deadZone
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public bool invert
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public float max
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float min
	{
		 get { } //Length: 6
		 set { } //Length: 6
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

	public float zero
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	[CustomObfuscation]
	internal AxisCalibrationInfo(float unnamed_param_0, float unnamed_param_1, float unnamed_param_2, float unnamed_param_3, bool unnamed_param_4, bool unnamed_param_5, AxisSensitivityType unnamed_param_6, float unnamed_param_7, AnimationCurve unnamed_param_8) { }

	public AxisCalibrationInfo() { }

	internal static AxisCalibrationData bbZBourtyoaUJCfvjwvQAVyddLKHb(AxisCalibrationInfo unnamed_param_0) { }

	public override object DeepClone() { }

	public bool get_applyRangeCalibration() { }

	public float get_deadZone() { }

	public bool get_invert() { }

	public float get_max() { }

	public float get_min() { }

	public float get_sensitivity() { }

	public AnimationCurve get_sensitivityCurve() { }

	public AxisSensitivityType get_sensitivityType() { }

	public float get_zero() { }

	internal static AxisCalibrationInfo hekCpiZeqEWsYgFqHFglDCqZxwWy(AxisCalibrationData unnamed_param_0) { }

	public void set_applyRangeCalibration(bool value) { }

	public void set_deadZone(float value) { }

	public void set_invert(bool value) { }

	public void set_max(float value) { }

	public void set_min(float value) { }

	public void set_sensitivity(float value) { }

	public void set_sensitivityCurve(AnimationCurve value) { }

	public void set_sensitivityType(AxisSensitivityType value) { }

	public void set_zero(float value) { }

}

