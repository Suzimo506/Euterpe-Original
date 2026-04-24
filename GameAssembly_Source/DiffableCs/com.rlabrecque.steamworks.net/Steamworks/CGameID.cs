namespace Steamworks;

public struct CGameID : IEquatable<CGameID>, IComparable<CGameID>
{
	internal enum EGameIDType
	{
		k_EGameIDTypeApp = 0,
		k_EGameIDTypeGameMod = 1,
		k_EGameIDTypeShortcut = 2,
		k_EGameIDTypeP2P = 3,
	}

	public ulong m_GameID; //Field offset: 0x0

	public CGameID(ulong GameID) { }

	public CGameID(AppId_t nAppID) { }

	public CGameID(AppId_t nAppID, uint nModID) { }

	public AppId_t AppID() { }

	public override int CompareTo(CGameID other) { }

	public override bool Equals(CGameID other) { }

	public virtual bool Equals(object other) { }

	public virtual int GetHashCode() { }

	public bool IsMod() { }

	public bool IsP2PFile() { }

	public bool IsShortcut() { }

	public bool IsSteamApp() { }

	public bool IsValid() { }

	public uint ModID() { }

	public static bool op_Equality(CGameID x, CGameID y) { }

	public static ulong op_Explicit(CGameID that) { }

	public static CGameID op_Explicit(ulong value) { }

	public static bool op_Inequality(CGameID x, CGameID y) { }

	public void Reset() { }

	public void Set(ulong GameID) { }

	private void SetAppID(AppId_t other) { }

	private void SetModID(uint other) { }

	private void SetType(EGameIDType other) { }

	public virtual string ToString() { }

	public EGameIDType Type() { }

}

