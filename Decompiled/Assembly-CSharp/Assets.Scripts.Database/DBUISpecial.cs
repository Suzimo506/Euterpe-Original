using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000813")]
public class DBUISpecial : BaseDatabase
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002A12")]
	public bool isBarrageMode;

	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4002A13")]
	private bool m_IsReview;

	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x4002A14")]
	private bool m_MasterNekoEgg;

	[Token(Token = "0x4002A15")]
	[FieldOffset(Offset = "0x13")]
	private bool m_RoleNekoEggIsOn;

	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4002A16")]
	private int m_BattleSfxType;

	[Token(Token = "0x17000771")]
	internal bool masterNekoEgg
	{
		[Token(Token = "0x600492F")]
		[Address(RVA = "0x48C7D0", Offset = "0x48AFD0", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004930")]
		[Address(RVA = "0x48CCA0", Offset = "0x48B4A0", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x17000772")]
	internal bool roleNekoEggIsOn
	{
		[Token(Token = "0x6004931")]
		[Address(RVA = "0x102FD30", Offset = "0x102E530", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x48C7B0", Offset = "0x48AFB0", Length = "0x4")]
		[Token(Token = "0x6004932")]
		set
		{
		}
	}

	[Token(Token = "0x17000773")]
	internal int battleSfxType
	{
		[Token(Token = "0x6004933")]
		[Address(RVA = "0x50A7E0", Offset = "0x508FE0", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004934")]
		[Address(RVA = "0x494A20", Offset = "0x493220", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x17000774")]
	internal bool IsReview
	{
		[Token(Token = "0x6004935")]
		[Address(RVA = "0x45CA60", Offset = "0x45B260", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004936")]
		[Address(RVA = "0x45C990", Offset = "0x45B190", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x6004937")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public override void AwakeInit()
	{
	}

	[Token(Token = "0x6004938")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public override void Release()
	{
	}

	[Address(RVA = "0x102FBE0", Offset = "0x102E3E0", Length = "0xE1")]
	[Token(Token = "0x6004939")]
	public void InitDatabase()
	{
	}

	[Token(Token = "0x600493A")]
	[Address(RVA = "0x102FAD0", Offset = "0x102E2D0", Length = "0x101")]
	public override void Flush()
	{
	}

	[Token(Token = "0x600493B")]
	[Address(RVA = "0x102FCD0", Offset = "0x102E4D0", Length = "0x51")]
	public DBUISpecial()
	{
	}
}
