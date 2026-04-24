using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x200041E")]
public struct ImageHandle
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400170D")]
	public ImageType Type;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400170E")]
	public long Id;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400170F")]
	public uint Size;

	[Token(Token = "0x6003145")]
	[Address(RVA = "0x21477B0", Offset = "0x2145FB0", Length = "0x32")]
	public static ImageHandle User(long id)
	{
		return default(ImageHandle);
	}

	[Token(Token = "0x6003146")]
	[Address(RVA = "0x21477F0", Offset = "0x2145FF0", Length = "0x14")]
	public static ImageHandle User(long id, uint size)
	{
		return default(ImageHandle);
	}
}
