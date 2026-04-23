using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000807")]
public class DBGameScene : BaseDatabase
{
	[Token(Token = "0x17000748")]
	public bool noteFreeze
	{
		[Token(Token = "0x60048AC")]
		[Address(RVA = "0x45CA50", Offset = "0x45B250", Length = "0x5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60048AB")]
		[Address(RVA = "0x45C980", Offset = "0x45B180", Length = "0x4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000749")]
	public bool bgFreeze
	{
		[CompilerGenerated]
		[Token(Token = "0x60048AE")]
		[Address(RVA = "0x45CA60", Offset = "0x45B260", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Token(Token = "0x60048AD")]
		[Address(RVA = "0x45C990", Offset = "0x45B190", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x60048AF")]
	[Address(RVA = "0xDBB5B0", Offset = "0xDB9DB0", Length = "0x7")]
	public override void AwakeInit()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60048B0")]
	public override void Release()
	{
	}

	[Token(Token = "0x60048B1")]
	[Address(RVA = "0x1025FE0", Offset = "0x10247E0", Length = "0x51")]
	public DBGameScene()
	{
	}
}
