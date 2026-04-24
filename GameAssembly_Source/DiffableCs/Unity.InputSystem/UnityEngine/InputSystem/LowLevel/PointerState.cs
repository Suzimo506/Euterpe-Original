namespace UnityEngine.InputSystem.LowLevel;

internal struct PointerState : IInputStateTypeInfo
{
	private uint pointerId; //Field offset: 0x0
	[InputControl]
	public Vector2 position; //Field offset: 0x4
	[InputControl]
	public Vector2 delta; //Field offset: 0xC
	[InputControl]
	public float pressure; //Field offset: 0x14
	[InputControl]
	public Vector2 radius; //Field offset: 0x18
	[InputControl]
	public ushort buttons; //Field offset: 0x20

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

