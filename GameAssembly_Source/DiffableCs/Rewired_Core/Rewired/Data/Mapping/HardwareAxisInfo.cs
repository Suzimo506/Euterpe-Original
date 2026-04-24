namespace Rewired.Data.Mapping;

public class HardwareAxisInfo : IDeepCloneable
{
	[SerializeField]
	internal AxisCoordinateMode _dataFormat; //Field offset: 0x10
	[SerializeField]
	internal bool _excludeFromPolling; //Field offset: 0x14
	[SerializeField]
	internal SpecialAxisType _specialAxisType; //Field offset: 0x18
	[SerializeField]
	internal float _pollingDeadZone; //Field offset: 0x1C

	public AxisCoordinateMode dataFormat
	{
		 get { } //Length: 4
	}

	[CustomObfuscation]
	internal static HardwareAxisInfo Default
	{
		internal get { } //Length: 92
	}

	public bool excludeFromPolling
	{
		 get { } //Length: 5
	}

	public float pollingDeadZone
	{
		 get { } //Length: 6
	}

	public SpecialAxisType specialAxisType
	{
		 get { } //Length: 4
	}

	public HardwareAxisInfo() { }

	[CustomObfuscation]
	internal HardwareAxisInfo(AxisCoordinateMode unnamed_param_0, bool unnamed_param_1, float unnamed_param_2, SpecialAxisType unnamed_param_3) { }

	public override object DeepClone() { }

	public AxisCoordinateMode get_dataFormat() { }

	internal static HardwareAxisInfo get_Default() { }

	public bool get_excludeFromPolling() { }

	public float get_pollingDeadZone() { }

	public SpecialAxisType get_specialAxisType() { }

}

