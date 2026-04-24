namespace UnityEngine.InputSystem.LowLevel;

public struct GamepadState : IInputStateTypeInfo
{
	internal const string ButtonSouthShortDisplayName = "A"; //Field offset: 0x0
	internal const string ButtonNorthShortDisplayName = "Y"; //Field offset: 0x0
	internal const string ButtonWestShortDisplayName = "X"; //Field offset: 0x0
	internal const string ButtonEastShortDisplayName = "B"; //Field offset: 0x0
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	public uint buttons; //Field offset: 0x0
	[InputControl]
	public Vector2 leftStick; //Field offset: 0x4
	[InputControl]
	public Vector2 rightStick; //Field offset: 0xC
	[InputControl]
	public float leftTrigger; //Field offset: 0x14
	[InputControl]
	public float rightTrigger; //Field offset: 0x18

	public override FourCC format
	{
		 get { } //Length: 53
	}

	public static FourCC Format
	{
		 get { } //Length: 53
	}

	public GamepadState(GamepadButton[] buttons) { }

	public override FourCC get_format() { }

	public static FourCC get_Format() { }

	public GamepadState WithButton(GamepadButton button, bool value = true) { }

}

