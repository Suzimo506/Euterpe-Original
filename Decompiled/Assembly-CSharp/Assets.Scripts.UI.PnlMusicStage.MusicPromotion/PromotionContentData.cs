using Cpp2ILInjected;

namespace Assets.Scripts.UI.PnlMusicStage.MusicPromotion;

[Token(Token = "0x2000860")]
public struct PromotionContentData
{
	[Token(Token = "0x4002BB9")]
	[FieldOffset(Offset = "0x0")]
	public string promotionSignImgUrl;

	[Token(Token = "0x4002BBA")]
	[FieldOffset(Offset = "0x8")]
	public string promotionBgColorHex;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002BBB")]
	public string promotionTextColorHex;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002BBC")]
	public string promotionContent;

	[Token(Token = "0x4002BBD")]
	[FieldOffset(Offset = "0x20")]
	public string promotionActRedirectUrl;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002BBE")]
	public string popupContent;
}
