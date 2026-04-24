namespace UnityEngine.InputSystem.XInput.LowLevel;

internal struct XInputControllerWindowsState : IInputStateTypeInfo
{
	internal enum Button
	{
		DPadUp = 0,
		DPadDown = 1,
		DPadLeft = 2,
		DPadRight = 3,
		Start = 4,
		Select = 5,
		LeftThumbstickPress = 6,
		RightThumbstickPress = 7,
		LeftShoulder = 8,
		RightShoulder = 9,
		A = 12,
		B = 13,
		X = 14,
		Y = 15,
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
	public ushort buttons; //Field offset: 0x0
	[InputControl]
	public byte leftTrigger; //Field offset: 0x2
	[InputControl]
	public byte rightTrigger; //Field offset: 0x3
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	public short leftStickX; //Field offset: 0x4
	public short leftStickY; //Field offset: 0x6
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	public short rightStickX; //Field offset: 0x8
	public short rightStickY; //Field offset: 0xA

	public override FourCC format
	{
		 get { } //Length: 6
	}

	public override FourCC get_format() { }

	public XInputControllerWindowsState WithButton(Button button) { }

}

