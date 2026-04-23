using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.StageBackground.DaveMainShow.FsvFishType;

[Token(Token = "0x2000845")]
public class FishTypeItemData
{
	[Token(Token = "0x17000856")]
	public DaveFishQuality FishQuality
	{
		[CompilerGenerated]
		[Token(Token = "0x6004C07")]
		[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
		get
		{
			return default(DaveFishQuality);
		}
		[Address(RVA = "0x42CB50", Offset = "0x42B350", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6004C08")]
		set
		{
		}
	}

	[Token(Token = "0x17000857")]
	public string FishTypeName
	{
		[Token(Token = "0x6004C09")]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6004C0A")]
		[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
		set
		{
		}
	}

	[Token(Token = "0x6004C0B")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public FishTypeItemData()
	{
	}
}
