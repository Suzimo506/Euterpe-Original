namespace UnityEngine.InputSystem.DualShock.LowLevel;

internal struct DualShock4HIDInputReport : IInputStateTypeInfo
{
	public byte reportId; //Field offset: 0x0
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	public byte leftStickX; //Field offset: 0x1
	public byte leftStickY; //Field offset: 0x2
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	public byte rightStickX; //Field offset: 0x3
	public byte rightStickY; //Field offset: 0x4
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	public byte buttons1; //Field offset: 0x5
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	public byte buttons2; //Field offset: 0x6
	[InputControl]
	[InputControl]
	public byte buttons3; //Field offset: 0x7
	[InputControl]
	public byte leftTrigger; //Field offset: 0x8
	[InputControl]
	public byte rightTrigger; //Field offset: 0x9
	public byte batteryLevel; //Field offset: 0x1E

	public override FourCC format
	{
		 get { } //Length: 53
	}

	public override FourCC get_format() { }

}

