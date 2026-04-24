namespace rail;

public class RailCurrencyExchangeCoinRate
{
	public string currency; //Field offset: 0x10
	public uint to_exchange_coins; //Field offset: 0x18
	public float pay_price; //Field offset: 0x1C

	public RailCurrencyExchangeCoinRate() { }

}

