using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000306")]
public class RailCurrencyExchangeCoinRate
{
	[Token(Token = "0x4001238")]
	[FieldOffset(Offset = "0x10")]
	public string currency;

	[Token(Token = "0x4001239")]
	[FieldOffset(Offset = "0x18")]
	public uint to_exchange_coins;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400123A")]
	public float pay_price;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002DEE")]
	public RailCurrencyExchangeCoinRate()
	{
	}
}
