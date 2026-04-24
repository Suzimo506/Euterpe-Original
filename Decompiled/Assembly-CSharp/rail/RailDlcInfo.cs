using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002AF")]
public class RailDlcInfo
{
	[Token(Token = "0x4001087")]
	[FieldOffset(Offset = "0x10")]
	public double original_price;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001088")]
	public RailDlcID dlc_id;

	[Token(Token = "0x4001089")]
	[FieldOffset(Offset = "0x20")]
	public string description;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400108A")]
	public double discount_price;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400108B")]
	public string version;

	[Token(Token = "0x400108C")]
	[FieldOffset(Offset = "0x38")]
	public RailGameID game_id;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400108D")]
	public string name;

	[Address(RVA = "0x271FA60", Offset = "0x271E260", Length = "0xFE")]
	[Token(Token = "0x6002D15")]
	public RailDlcInfo()
	{
	}
}
