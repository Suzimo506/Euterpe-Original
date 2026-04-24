using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007C2")]
public class ElfinSkin
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40028E9")]
	public int index;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40028EA")]
	public string skinName;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6004793")]
	public ElfinSkin()
	{
	}
}
