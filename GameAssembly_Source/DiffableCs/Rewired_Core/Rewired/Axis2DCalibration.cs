namespace Rewired;

[CustomClassObfuscation]
public sealed class Axis2DCalibration
{
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private DeadZone2DType _deadZoneType; //Field offset: 0x10
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private AxisSensitivity2DType _sensitivityType; //Field offset: 0x14

	public DeadZone2DType deadZoneType
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public AxisSensitivity2DType sensitivityType
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	internal Axis2DCalibration() { }

	public DeadZone2DType get_deadZoneType() { }

	public AxisSensitivity2DType get_sensitivityType() { }

	internal Vector2 GetCalibrated2DValue(float valueRawX, float valueRawY, AxisCalibration xAxis, AxisCalibration yAxis) { }

	internal static Vector2 GetCalibrated2DValue(float valueRawX, float valueRawY, AxisCalibration xAxis, AxisCalibration yAxis, DeadZone2DType deadZoneType, AxisSensitivity2DType sensitivityType) { }

	public void set_deadZoneType(DeadZone2DType value) { }

	public void set_sensitivityType(AxisSensitivity2DType value) { }

}

