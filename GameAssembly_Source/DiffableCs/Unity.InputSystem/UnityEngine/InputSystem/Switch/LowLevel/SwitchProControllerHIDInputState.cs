namespace UnityEngine.InputSystem.Switch.LowLevel;

internal struct SwitchProControllerHIDInputState : IInputStateTypeInfo
{
	internal enum Button
	{
		North = 11,
		South = 8,
		West = 10,
		East = 9,
		StickL = 18,
		StickR = 19,
		L = 12,
		R = 13,
		ZL = 14,
		ZR = 15,
		Plus = 17,
		Minus = 16,
		X = 11,
		B = 8,
		Y = 10,
		A = 9,
	}

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
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	public uint buttons; //Field offset: 0x0
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	public ushort leftStickX; //Field offset: 0x4
	public ushort leftStickY; //Field offset: 0x6
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	public ushort rightStickX; //Field offset: 0x8
	public ushort rightStickY; //Field offset: 0xA

	public override FourCC format
	{
		 get { } //Length: 53
	}

	public float leftTrigger
	{
		 get { } //Length: 21
	}

	public float rightTrigger
	{
		 get { } //Length: 21
	}

	public override FourCC get_format() { }

	public float get_leftTrigger() { }

	public float get_rightTrigger() { }

	public SwitchProControllerHIDInputState WithButton(Button button, bool value = true) { }

}

