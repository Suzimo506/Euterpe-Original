namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct SteamInventoryRequestPricesResult_t
{
	public const int k_iCallback = 4705; //Field offset: 0x0
	public EResult m_result; //Field offset: 0x0
	private Byte[] m_rgchCurrency_; //Field offset: 0x8

	public string m_rgchCurrency
	{
		 get { } //Length: 11
		 set { } //Length: 22
	}

	public string get_m_rgchCurrency() { }

	public void set_m_rgchCurrency(string value) { }

}

