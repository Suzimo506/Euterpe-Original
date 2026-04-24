namespace Steamworks;

public struct CSteamID : IEquatable<CSteamID>, IComparable<CSteamID>
{
	public static readonly CSteamID Nil; //Field offset: 0x0
	public static readonly CSteamID OutofDateGS; //Field offset: 0x8
	public static readonly CSteamID LanModeGS; //Field offset: 0x10
	public static readonly CSteamID NotInitYetGS; //Field offset: 0x18
	public static readonly CSteamID NonSteamGS; //Field offset: 0x20
	public ulong m_SteamID; //Field offset: 0x0

	private static CSteamID() { }

	public CSteamID(ulong ulSteamID) { }

	public CSteamID(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType) { }

	public CSteamID(AccountID_t unAccountID, uint unAccountInstance, EUniverse eUniverse, EAccountType eAccountType) { }

	public bool BAnonAccount() { }

	public bool BAnonGameServerAccount() { }

	public bool BAnonUserAccount() { }

	public bool BBlankAnonAccount() { }

	public bool BChatAccount() { }

	public bool BClanAccount() { }

	public bool BConsoleUserAccount() { }

	public bool BContentServerAccount() { }

	public bool BGameServerAccount() { }

	public bool BIndividualAccount() { }

	public bool BPersistentGameServerAccount() { }

	public void Clear() { }

	public override int CompareTo(CSteamID other) { }

	public void CreateBlankAnonLogon(EUniverse eUniverse) { }

	public void CreateBlankAnonUserLogon(EUniverse eUniverse) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(CSteamID other) { }

	public AccountID_t GetAccountID() { }

	public EAccountType GetEAccountType() { }

	public EUniverse GetEUniverse() { }

	public virtual int GetHashCode() { }

	public uint GetUnAccountInstance() { }

	public void InstancedSet(AccountID_t unAccountID, uint unInstance, EUniverse eUniverse, EAccountType eAccountType) { }

	public bool IsLobby() { }

	public bool IsValid() { }

	public static bool op_Equality(CSteamID x, CSteamID y) { }

	public static ulong op_Explicit(CSteamID that) { }

	public static CSteamID op_Explicit(ulong value) { }

	public static bool op_Inequality(CSteamID x, CSteamID y) { }

	public void Set(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType) { }

	public void SetAccountID(AccountID_t other) { }

	public void SetAccountInstance(uint other) { }

	public void SetEAccountType(EAccountType other) { }

	public void SetEUniverse(EUniverse other) { }

	public virtual string ToString() { }

}

