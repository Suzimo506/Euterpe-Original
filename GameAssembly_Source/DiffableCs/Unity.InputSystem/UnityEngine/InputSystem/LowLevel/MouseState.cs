namespace UnityEngine.InputSystem.LowLevel;

public struct MouseState : IInputStateTypeInfo
{
	[InputControl]
	public Vector2 position; //Field offset: 0x0
	[InputControl]
	public Vector2 delta; //Field offset: 0x8
	[InputControl]
	[InputControl]
	[InputControl]
	public Vector2 scroll; //Field offset: 0x10
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	public ushort buttons; //Field offset: 0x18
	private ushort displayIndex; //Field offset: 0x1A
	[InputControl]
	public ushort clickCount; //Field offset: 0x1C

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

	public MouseState WithButton(MouseButton button, bool state = true) { }

}

