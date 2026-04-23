using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x200080F")]
internal class DBSkill : BaseDatabase
{
	[Token(Token = "0x40029FC")]
	[FieldOffset(Offset = "0x10")]
	private bool m_NekoSkillInvalid;

	[Token(Token = "0x40029FD")]
	[FieldOffset(Offset = "0x11")]
	private bool m_NekoSkillInvoke;

	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x40029FE")]
	private bool m_IsAutoPlay;

	[FieldOffset(Offset = "0x13")]
	[Token(Token = "0x40029FF")]
	private bool m_IsGMAutoPlay;

	[Token(Token = "0x4002A02")]
	[FieldOffset(Offset = "0x16")]
	private bool m_BetaDogSkillInvoke;

	[Token(Token = "0x4002A03")]
	[FieldOffset(Offset = "0x17")]
	private bool m_DiverBuroSkillDisable;

	[Token(Token = "0x1700075B")]
	internal bool nekoSkillInvalid
	{
		[Token(Token = "0x60048F3")]
		[Address(RVA = "0x45CA50", Offset = "0x45B250", Length = "0x5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700075C")]
	internal bool nekoSkillInvoke
	{
		[Token(Token = "0x60048F4")]
		[Address(RVA = "0x45CA60", Offset = "0x45B260", Length = "0x5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700075D")]
	internal bool isAutoPlay
	{
		[Address(RVA = "0x48C7D0", Offset = "0x48AFD0", Length = "0x5")]
		[Token(Token = "0x60048F7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700075E")]
	internal bool isTouhouRole
	{
		[Address(RVA = "0x44C9C0", Offset = "0x44B1C0", Length = "0x5")]
		[Token(Token = "0x60048FA")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x44CA30", Offset = "0x44B230", Length = "0x4")]
		[Token(Token = "0x60048FB")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700075F")]
	internal bool isTouhouSkillValid
	{
		[Address(RVA = "0xDC2660", Offset = "0xDC0E60", Length = "0x5")]
		[Token(Token = "0x60048FC")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x102EA10", Offset = "0x102D210", Length = "0x4")]
		[Token(Token = "0x60048FD")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000760")]
	internal bool betaDogSkillInvoke
	{
		[Token(Token = "0x60048FE")]
		[Address(RVA = "0x102E9F0", Offset = "0x102D1F0", Length = "0x5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000761")]
	internal bool diverBuroSkillDisable
	{
		[Address(RVA = "0x102EA00", Offset = "0x102D200", Length = "0x5")]
		[Token(Token = "0x6004900")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60048F5")]
	[Address(RVA = "0x45C980", Offset = "0x45B180", Length = "0x4")]
	internal void SetNekoSkillInvalid(bool invalid)
	{
	}

	[Token(Token = "0x60048F6")]
	[Address(RVA = "0x45C990", Offset = "0x45B190", Length = "0x4")]
	internal void SetNekoSkillInvoke(bool invoke)
	{
	}

	[Address(RVA = "0x102E8C0", Offset = "0x102D0C0", Length = "0xAE")]
	[Token(Token = "0x60048F8")]
	internal void SetAutoPlay(bool enable)
	{
	}

	[Token(Token = "0x60048F9")]
	[Address(RVA = "0x102E810", Offset = "0x102D010", Length = "0x7E")]
	internal void GMSetAutoPlay(bool enable)
	{
	}

	[Token(Token = "0x60048FF")]
	[Address(RVA = "0x102E970", Offset = "0x102D170", Length = "0x4")]
	internal void SetBetaDogSkillInvoke(bool invoke)
	{
	}

	[Address(RVA = "0x102E980", Offset = "0x102D180", Length = "0x4")]
	[Token(Token = "0x6004901")]
	internal void SetDiverBuroSkillDisable(bool disable)
	{
	}

	[Token(Token = "0x6004902")]
	[Address(RVA = "0x102E7F0", Offset = "0x102CFF0", Length = "0x11")]
	public override void AwakeInit()
	{
	}

	[Token(Token = "0x6004903")]
	[Address(RVA = "0x102E890", Offset = "0x102D090", Length = "0x2D")]
	public override void Release()
	{
	}

	[Token(Token = "0x6004904")]
	[Address(RVA = "0x102E990", Offset = "0x102D190", Length = "0x51")]
	public DBSkill()
	{
	}
}
