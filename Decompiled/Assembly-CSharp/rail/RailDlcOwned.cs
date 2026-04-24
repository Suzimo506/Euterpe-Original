using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002B1")]
public class RailDlcOwned
{
	[Token(Token = "0x4001092")]
	[FieldOffset(Offset = "0x10")]
	public bool is_owned;

	[Token(Token = "0x4001093")]
	[FieldOffset(Offset = "0x18")]
	public RailDlcID dlc_id;

	[Address(RVA = "0x271FB60", Offset = "0x271E360", Length = "0x9D")]
	[Token(Token = "0x6002D17")]
	public RailDlcOwned()
	{
	}
}
