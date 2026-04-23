using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002DD")]
public class RailBranchInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40011D7")]
	public string branch_name;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40011D8")]
	public string build_number;

	[Token(Token = "0x40011D9")]
	[FieldOffset(Offset = "0x20")]
	public string branch_type;

	[Token(Token = "0x40011DA")]
	[FieldOffset(Offset = "0x28")]
	public string branch_id;

	[Token(Token = "0x6002D7A")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public RailBranchInfo()
	{
	}
}
