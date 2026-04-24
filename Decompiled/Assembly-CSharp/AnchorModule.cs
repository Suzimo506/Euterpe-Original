using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;

[Token(Token = "0x2000051")]
public class AnchorModule : Singleton<AnchorModule>
{
	[Token(Token = "0x40001DD")]
	[FieldOffset(Offset = "0x10")]
	private bool m_IsInited;

	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x40001DE")]
	private bool m_AllowAnchorMode;

	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x40001DF")]
	private bool m_IsAnchorMode;

	[Token(Token = "0x40001E0")]
	[FieldOffset(Offset = "0x13")]
	private bool m_IsAnchorModeShowUnuse;

	[Token(Token = "0x40001E1")]
	[FieldOffset(Offset = "0x18")]
	private DBConfigAnchor m_DbAnchor;

	[Token(Token = "0x40001E2")]
	[FieldOffset(Offset = "0x20")]
	private bool m_IsNetwork;

	[Token(Token = "0x17000049")]
	public bool allowAnchorMode
	{
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x45CA60", Offset = "0x45B260", Length = "0x5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700004A")]
	public bool isAnchorMode
	{
		[Address(RVA = "0x48C7D0", Offset = "0x48AFD0", Length = "0x5")]
		[Token(Token = "0x6000255")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x596710", Offset = "0x594F10", Length = "0xBB")]
		set
		{
		}
	}

	[Token(Token = "0x1700004B")]
	public bool isAnchorModeShowUnuse
	{
		[Address(RVA = "0x596670", Offset = "0x594E70", Length = "0xE")]
		[Token(Token = "0x6000257")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x596680", Offset = "0x594E80", Length = "0x80")]
		[Token(Token = "0x6000258")]
		set
		{
		}
	}

	[Address(RVA = "0x595F80", Offset = "0x594780", Length = "0x2FC")]
	[Token(Token = "0x6000251")]
	public void InitModule()
	{
	}

	[Address(RVA = "0x595E80", Offset = "0x594680", Length = "0x31")]
	[Token(Token = "0x6000252")]
	private void AnchorModeParse(string txt)
	{
	}

	[Address(RVA = "0x595EC0", Offset = "0x5946C0", Length = "0x66")]
	[Token(Token = "0x6000253")]
	public bool CheckLockByMusicUid(string musicUid)
	{
		return default(bool);
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x595F30", Offset = "0x594730", Length = "0x48")]
	public bool CheckUiBgmIsLock(string musicName)
	{
		return default(bool);
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x596630", Offset = "0x594E30", Length = "0x3C")]
	public AnchorModule()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
