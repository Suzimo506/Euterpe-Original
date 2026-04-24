namespace rail;

public class RailCoinInfo
{
	public string name; //Field offset: 0x10
	public string icon_url; //Field offset: 0x18
	public string description; //Field offset: 0x20
	public RailCurrencyExchangeCoinRate exchange_rate; //Field offset: 0x28
	public uint coin_class_id; //Field offset: 0x30
	public string metadata; //Field offset: 0x38

	public RailCoinInfo() { }

}

