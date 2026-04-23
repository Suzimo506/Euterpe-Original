using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000756")]
public enum RedeemCode
{
	[Token(Token = "0x40026C8")]
	Success = 0,
	[Token(Token = "0x40026C9")]
	UnknownError = 400,
	[Token(Token = "0x40026CA")]
	ExtractFailed = 100021,
	[Token(Token = "0x40026CB")]
	ServerError = -1,
	[Token(Token = "0x40026CC")]
	RedeemCodeNotExist = 600201,
	[Token(Token = "0x40026CD")]
	RedeemCodeIsUsed = 600202,
	[Token(Token = "0x40026CE")]
	RedeemCodeNotInValidTime = 600203,
	[Token(Token = "0x40026CF")]
	UnsupportedPlatform = 600204,
	[Token(Token = "0x40026D0")]
	UnsupportedGameVersion = 600205,
	[Token(Token = "0x40026D1")]
	ContentsAreAlreadyExchanged = 600206
}
