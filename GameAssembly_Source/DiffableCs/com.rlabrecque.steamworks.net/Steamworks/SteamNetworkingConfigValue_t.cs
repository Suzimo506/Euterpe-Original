namespace Steamworks;

public struct SteamNetworkingConfigValue_t
{
	internal struct OptionValue
	{
		public int m_int32; //Field offset: 0x0
		public long m_int64; //Field offset: 0x0
		public float m_float; //Field offset: 0x0
		public IntPtr m_string; //Field offset: 0x0
		public IntPtr m_functionPtr; //Field offset: 0x0

	}

	public ESteamNetworkingConfigValue m_eValue; //Field offset: 0x0
	public ESteamNetworkingConfigDataType m_eDataType; //Field offset: 0x4
	public OptionValue m_val; //Field offset: 0x8

}

