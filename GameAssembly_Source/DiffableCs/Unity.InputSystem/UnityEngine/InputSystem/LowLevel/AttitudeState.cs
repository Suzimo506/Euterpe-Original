namespace UnityEngine.InputSystem.LowLevel;

internal struct AttitudeState : IInputStateTypeInfo
{
	[InputControl]
	public Quaternion attitude; //Field offset: 0x0

	public override FourCC format
	{
		 get { } //Length: 54
	}

	public static FourCC kFormat
	{
		 get { } //Length: 54
	}

	public override FourCC get_format() { }

	public static FourCC get_kFormat() { }

}

