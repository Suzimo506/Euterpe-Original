using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000812")]
public class DBTouhou : BaseDatabase
{
	[Token(Token = "0x4002A10")]
	[FieldOffset(Offset = "0x14")]
	private int m_TouhouAvailableFeverCount;

	[Token(Token = "0x1700076D")]
	public bool isTouhouEasterEgg
	{
		[CompilerGenerated]
		[Address(RVA = "0x45CA50", Offset = "0x45B250", Length = "0x5")]
		[Token(Token = "0x6004924")]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Token(Token = "0x6004925")]
		[Address(RVA = "0x45C980", Offset = "0x45B180", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700076E")]
	public bool isBadApple
	{
		[Address(RVA = "0x45CA60", Offset = "0x45B260", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6004926")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004927")]
		[Address(RVA = "0x45C990", Offset = "0x45B190", Length = "0x4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700076F")]
	public List<int> touhouBoomList
	{
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		[Token(Token = "0x6004928")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6004929")]
		[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000770")]
	public int touhouAvailableFeverCount
	{
		[Address(RVA = "0x50A7E0", Offset = "0x508FE0", Length = "0x4")]
		[Token(Token = "0x600492B")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600492A")]
		[Address(RVA = "0x102FA60", Offset = "0x102E260", Length = "0x63")]
		set
		{
		}
	}

	[Token(Token = "0x600492C")]
	[Address(RVA = "0x102F6C0", Offset = "0x102DEC0", Length = "0x31F")]
	public override void AwakeInit()
	{
	}

	[Token(Token = "0x600492D")]
	[Address(RVA = "0x102F9E0", Offset = "0x102E1E0", Length = "0x1F")]
	public override void Release()
	{
	}

	[Token(Token = "0x600492E")]
	[Address(RVA = "0x102FA00", Offset = "0x102E200", Length = "0x51")]
	public DBTouhou()
	{
	}
}
