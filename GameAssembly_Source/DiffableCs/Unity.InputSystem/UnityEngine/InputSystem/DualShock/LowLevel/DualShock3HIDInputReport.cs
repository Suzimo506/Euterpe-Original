namespace UnityEngine.InputSystem.DualShock.LowLevel;

internal struct DualShock3HIDInputReport : IInputStateTypeInfo
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <padding3>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	private ushort padding1; //Field offset: 0x0
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	public byte buttons1; //Field offset: 0x2
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	public byte buttons2; //Field offset: 0x3
	[InputControl]
	[InputControl]
	public byte buttons3; //Field offset: 0x4
	private byte padding2; //Field offset: 0x5
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	public byte leftStickX; //Field offset: 0x6
	public byte leftStickY; //Field offset: 0x7
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	public byte rightStickX; //Field offset: 0x8
	public byte rightStickY; //Field offset: 0x9
	[FixedBuffer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private <padding3>e__FixedBuffer padding3; //Field offset: 0xA
	[InputControl]
	public byte leftTrigger; //Field offset: 0x12
	[InputControl]
	public byte rightTrigger; //Field offset: 0x13

	public override FourCC format
	{
		 get { } //Length: 53
	}

	public override FourCC get_format() { }

}

