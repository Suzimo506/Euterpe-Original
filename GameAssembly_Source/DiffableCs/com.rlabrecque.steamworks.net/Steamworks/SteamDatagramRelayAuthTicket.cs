namespace Steamworks;

public struct SteamDatagramRelayAuthTicket
{
	private struct ExtraField
	{
		private enum EType
		{
			k_EType_String = 0,
			k_EType_Int = 1,
			k_EType_Fixed64 = 2,
		}

		private struct OptionValue
		{
			private Byte[] m_szStringValue; //Field offset: 0x0
			private long m_nIntValue; //Field offset: 0x0
			private ulong m_nFixed64Value; //Field offset: 0x0

		}

		private EType m_eType; //Field offset: 0x0
		private Byte[] m_szName; //Field offset: 0x8
		private OptionValue m_val; //Field offset: 0x10

	}

	private const int k_nMaxExtraFields = 16; //Field offset: 0x0
	private SteamNetworkingIdentity m_identityGameserver; //Field offset: 0x0
	private SteamNetworkingIdentity m_identityAuthorizedClient; //Field offset: 0x10
	private uint m_unPublicIP; //Field offset: 0x20
	private RTime32 m_rtimeTicketExpiry; //Field offset: 0x24
	private SteamDatagramHostedAddress m_routing; //Field offset: 0x28
	private uint m_nAppID; //Field offset: 0x38
	private int m_nRestrictToVirtualPort; //Field offset: 0x3C
	private int m_nExtraFields; //Field offset: 0x40
	private ExtraField[] m_vecExtraFields; //Field offset: 0x48

	public void Clear() { }

}

