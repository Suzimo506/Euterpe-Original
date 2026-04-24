using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002D8")]
public class RailUserPlayedWith
{
	[Token(Token = "0x40011CB")]
	[FieldOffset(Offset = "0x10")]
	public string user_rich_content;

	[Token(Token = "0x40011CC")]
	[FieldOffset(Offset = "0x18")]
	public RailID rail_id;

	[Token(Token = "0x6002D65")]
	[Address(RVA = "0x2721570", Offset = "0x271FD70", Length = "0x9D")]
	public RailUserPlayedWith()
	{
	}
}
