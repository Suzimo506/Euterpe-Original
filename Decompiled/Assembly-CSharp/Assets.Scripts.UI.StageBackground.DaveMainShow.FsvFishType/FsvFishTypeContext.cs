using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.StageBackground.DaveMainShow.FsvFishType;

[Token(Token = "0x2000843")]
public class FsvFishTypeContext
{
	[Token(Token = "0x17000851")]
	public int CurFsvIndex
	{
		[Token(Token = "0x6004BF6")]
		[CompilerGenerated]
		[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004BF7")]
		[CompilerGenerated]
		[Address(RVA = "0x42CB50", Offset = "0x42B350", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x17000852")]
	public PnlDaveFishView DaveFishView
	{
		[CompilerGenerated]
		[Token(Token = "0x6004BF8")]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6004BF9")]
		[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
		set
		{
		}
	}

	[Token(Token = "0x17000853")]
	public DaveFishDataModel DataModel
	{
		[CompilerGenerated]
		[Token(Token = "0x6004BFA")]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		get
		{
			return null;
		}
		[Address(RVA = "0x483E40", Offset = "0x482640", Length = "0xC")]
		[CompilerGenerated]
		[Token(Token = "0x6004BFB")]
		set
		{
		}
	}

	[Token(Token = "0x6004BFC")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public FsvFishTypeContext()
	{
	}
}
