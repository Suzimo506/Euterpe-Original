using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.PnlMusicStage.MusicPromotion;

[Token(Token = "0x200085F")]
public class PromotionIndexData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002BB2")]
	public string promotionId;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002BB3")]
	public List<string> bindMusicUids;

	[Token(Token = "0x4002BB4")]
	[FieldOffset(Offset = "0x20")]
	public long startTime;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002BB5")]
	public long endTime;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002BB6")]
	public bool isTimeLimit;

	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4002BB7")]
	public bool isRelease;

	[Token(Token = "0x4002BB8")]
	[FieldOffset(Offset = "0x38")]
	public Dictionary<string, PromotionContentData> contentDatas;

	[Address(RVA = "0x4D0520", Offset = "0x4CED20", Length = "0x96")]
	[Token(Token = "0x6004CA9")]
	public PromotionIndexData()
	{
	}
}
