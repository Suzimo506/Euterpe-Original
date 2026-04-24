namespace UnityEngine.InputSystem.DualShock.LowLevel;

internal struct DualSenseHIDInputReport : IInputStateTypeInfo
{
	public static FourCC Format; //Field offset: 0x0
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	public byte leftStickX; //Field offset: 0x0
	public byte leftStickY; //Field offset: 0x1
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	public byte rightStickX; //Field offset: 0x2
	public byte rightStickY; //Field offset: 0x3
	[InputControl]
	public byte leftTrigger; //Field offset: 0x4
	[InputControl]
	public byte rightTrigger; //Field offset: 0x5
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	public byte buttons0; //Field offset: 0x6
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	public byte buttons1; //Field offset: 0x7
	[InputControl]
	[InputControl]
	[InputControl]
	public byte buttons2; //Field offset: 0x8

	public override FourCC format
	{
		 get { } //Length: 85
	}

	private static DualSenseHIDInputReport() { }

	public override FourCC get_format() { }

}

