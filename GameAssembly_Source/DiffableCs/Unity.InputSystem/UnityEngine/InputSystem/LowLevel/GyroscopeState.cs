namespace UnityEngine.InputSystem.LowLevel;

internal struct GyroscopeState : IInputStateTypeInfo
{
	[InputControl]
	public Vector3 angularVelocity; //Field offset: 0x0

	public override FourCC format
	{
		 get { } //Length: 53
	}

	public static FourCC kFormat
	{
		 get { } //Length: 53
	}

	public override FourCC get_format() { }

	public static FourCC get_kFormat() { }

}

