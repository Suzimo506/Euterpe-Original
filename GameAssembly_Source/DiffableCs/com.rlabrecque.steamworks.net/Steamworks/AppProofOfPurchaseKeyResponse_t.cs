namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct AppProofOfPurchaseKeyResponse_t
{
	public const int k_iCallback = 1021; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public uint m_nAppID; //Field offset: 0x4
	public uint m_cchKeyLength; //Field offset: 0x8
	private Byte[] m_rgchKey_; //Field offset: 0x10

	public string m_rgchKey
	{
		 get { } //Length: 134
		 set { } //Length: 24
	}

	public string get_m_rgchKey() { }

	public void set_m_rgchKey(string value) { }

}

