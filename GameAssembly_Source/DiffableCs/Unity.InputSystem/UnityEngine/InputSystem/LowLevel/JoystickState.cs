namespace UnityEngine.InputSystem.LowLevel;

internal struct JoystickState : IInputStateTypeInfo
{
	internal enum Button
	{
		HatSwitchUp = 0,
		HatSwitchDown = 1,
		HatSwitchLeft = 2,
		HatSwitchRight = 3,
		Trigger = 4,
	}

	[InputControl]
	public int buttons; //Field offset: 0x0
	[InputControl]
	public Vector2 stick; //Field offset: 0x4

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

