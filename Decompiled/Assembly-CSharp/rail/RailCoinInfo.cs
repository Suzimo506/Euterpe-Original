using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000304")]
public class RailCoinInfo
{
	[Token(Token = "0x400122F")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001230")]
	public string icon_url;

	[Token(Token = "0x4001231")]
	[FieldOffset(Offset = "0x20")]
	public string description;

	[Token(Token = "0x4001232")]
	[FieldOffset(Offset = "0x28")]
	public RailCurrencyExchangeCoinRate exchange_rate;

	[Token(Token = "0x4001233")]
	[FieldOffset(Offset = "0x30")]
	public uint coin_class_id;

	[Token(Token = "0x4001234")]
	[FieldOffset(Offset = "0x38")]
	public string metadata;

	[Address(RVA = "0x699660", Offset = "0x697E60", Length = "0x64")]
	[Token(Token = "0x6002DEC")]
	public RailCoinInfo()
	{
	}
}
