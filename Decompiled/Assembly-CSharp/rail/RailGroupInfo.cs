using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002F5")]
public class RailGroupInfo
{
	[Token(Token = "0x400121B")]
	[FieldOffset(Offset = "0x10")]
	public string group_id;

	[Token(Token = "0x400121C")]
	[FieldOffset(Offset = "0x18")]
	public string group_icon_url;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400121D")]
	public string group_name;

	[Token(Token = "0x6002DCE")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public RailGroupInfo()
	{
	}
}
