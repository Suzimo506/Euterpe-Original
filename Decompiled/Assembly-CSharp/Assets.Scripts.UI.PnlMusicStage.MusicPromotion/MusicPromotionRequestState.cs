using Cpp2ILInjected;

namespace Assets.Scripts.UI.PnlMusicStage.MusicPromotion;

[Token(Token = "0x200085E")]
public enum MusicPromotionRequestState
{
	[Token(Token = "0x4002BAE")]
	Waiting,
	[Token(Token = "0x4002BAF")]
	Requesting,
	[Token(Token = "0x4002BB0")]
	RequestSuccess,
	[Token(Token = "0x4002BB1")]
	RequestFail
}
