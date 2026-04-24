namespace UnityEngine.InputSystem.LowLevel;

public struct PenState : IInputStateTypeInfo
{
	[InputControl]
	public Vector2 position; //Field offset: 0x0
	[InputControl]
	public Vector2 delta; //Field offset: 0x8
	[InputControl]
	public Vector2 tilt; //Field offset: 0x10
	[InputControl]
	public float pressure; //Field offset: 0x18
	[InputControl]
	public float twist; //Field offset: 0x1C
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
	public ushort buttons; //Field offset: 0x20
	private ushort displayIndex; //Field offset: 0x22

	public override FourCC format
	{
		 get { } //Length: 53
	}

	public static FourCC Format
	{
		 get { } //Length: 53
	}

	public override FourCC get_format() { }

	public static FourCC get_Format() { }

	public PenState WithButton(PenButton button, bool state = true) { }

}

