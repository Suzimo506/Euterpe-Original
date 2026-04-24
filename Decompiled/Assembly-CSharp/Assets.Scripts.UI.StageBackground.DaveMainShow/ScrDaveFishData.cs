using Assets.Scripts.Database;
using Cpp2ILInjected;
using UI.Components.UguiScrollViewExtend;

namespace Assets.Scripts.UI.StageBackground.DaveMainShow;

[Token(Token = "0x200083E")]
public class ScrDaveFishData : IScrollItemData
{
	[Token(Token = "0x4002B16")]
	[FieldOffset(Offset = "0x10")]
	public int fishUid;

	[Token(Token = "0x4002B17")]
	[FieldOffset(Offset = "0x14")]
	public bool isFishUnlocked;

	[Token(Token = "0x4002B18")]
	[FieldOffset(Offset = "0x18")]
	public DaveFishData configData;

	[Token(Token = "0x4002B19")]
	[FieldOffset(Offset = "0x20")]
	public DaveFishCachedData cachedData;

	[Token(Token = "0x6004BE2")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public ScrDaveFishData()
	{
	}
}
