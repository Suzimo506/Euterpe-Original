using Cpp2ILInjected;

namespace PeroPeroGames.DataStatistics;

[Token(Token = "0x20004EA")]
public abstract class DataStatisticsManager
{
	[Token(Token = "0x4001A98")]
	protected static DataStatisticsManager s_Instance;

	[Token(Token = "0x4001A99")]
	[FieldOffset(Offset = "0x10")]
	protected bool m_Init;

	[Token(Token = "0x170004FF")]
	public static DataStatisticsManager instance
	{
		[Token(Token = "0x600366F")]
		[Address(RVA = "0x86A220", Offset = "0x868A20", Length = "0x35")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000500")]
	public bool isInit
	{
		[Address(RVA = "0x45CA50", Offset = "0x45B250", Length = "0x5")]
		[Token(Token = "0x6003671")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000501")]
	protected string channel
	{
		[Address(RVA = "0x86A1F0", Offset = "0x8689F0", Length = "0x2B")]
		[Token(Token = "0x6003679")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x912FD0", Offset = "0x9117D0", Length = "0xAC")]
	[Token(Token = "0x6003670")]
	public static T Instance<T>() where T : DataStatisticsManager
	{
		return null;
	}

	[Address(RVA = "0x869F40", Offset = "0x868740", Length = "0x23A")]
	[Token(Token = "0x6003672")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x6003673")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void UserCreateEvent()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6003674")]
	public virtual void UserCancelEvent()
	{
	}

	[Address(RVA = "0x86A180", Offset = "0x868980", Length = "0x65")]
	[Token(Token = "0x6003675")]
	private void OnLogin()
	{
	}

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6003676")]
	protected abstract void OnLogin(string peroUid);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6003677")]
	protected abstract void OnLoginFinished();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6003678")]
	protected abstract void OnLogout();

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x600367A")]
	protected DataStatisticsManager()
	{
	}
}
