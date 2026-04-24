using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x200040A")]
public enum Result
{
	[Token(Token = "0x400168B")]
	Ok,
	[Token(Token = "0x400168C")]
	ServiceUnavailable,
	[Token(Token = "0x400168D")]
	InvalidVersion,
	[Token(Token = "0x400168E")]
	LockFailed,
	[Token(Token = "0x400168F")]
	InternalError,
	[Token(Token = "0x4001690")]
	InvalidPayload,
	[Token(Token = "0x4001691")]
	InvalidCommand,
	[Token(Token = "0x4001692")]
	InvalidPermissions,
	[Token(Token = "0x4001693")]
	NotFetched,
	[Token(Token = "0x4001694")]
	NotFound,
	[Token(Token = "0x4001695")]
	Conflict,
	[Token(Token = "0x4001696")]
	InvalidSecret,
	[Token(Token = "0x4001697")]
	InvalidJoinSecret,
	[Token(Token = "0x4001698")]
	NoEligibleActivity,
	[Token(Token = "0x4001699")]
	InvalidInvite,
	[Token(Token = "0x400169A")]
	NotAuthenticated,
	[Token(Token = "0x400169B")]
	InvalidAccessToken,
	[Token(Token = "0x400169C")]
	ApplicationMismatch,
	[Token(Token = "0x400169D")]
	InvalidDataUrl,
	[Token(Token = "0x400169E")]
	InvalidBase64,
	[Token(Token = "0x400169F")]
	NotFiltered,
	[Token(Token = "0x40016A0")]
	LobbyFull,
	[Token(Token = "0x40016A1")]
	InvalidLobbySecret,
	[Token(Token = "0x40016A2")]
	InvalidFilename,
	[Token(Token = "0x40016A3")]
	InvalidFileSize,
	[Token(Token = "0x40016A4")]
	InvalidEntitlement,
	[Token(Token = "0x40016A5")]
	NotInstalled,
	[Token(Token = "0x40016A6")]
	NotRunning,
	[Token(Token = "0x40016A7")]
	InsufficientBuffer,
	[Token(Token = "0x40016A8")]
	PurchaseCanceled,
	[Token(Token = "0x40016A9")]
	InvalidGuild,
	[Token(Token = "0x40016AA")]
	InvalidEvent,
	[Token(Token = "0x40016AB")]
	InvalidChannel,
	[Token(Token = "0x40016AC")]
	InvalidOrigin,
	[Token(Token = "0x40016AD")]
	RateLimited,
	[Token(Token = "0x40016AE")]
	OAuth2Error,
	[Token(Token = "0x40016AF")]
	SelectChannelTimeout,
	[Token(Token = "0x40016B0")]
	GetGuildTimeout,
	[Token(Token = "0x40016B1")]
	SelectVoiceForceRequired,
	[Token(Token = "0x40016B2")]
	CaptureShortcutAlreadyListening,
	[Token(Token = "0x40016B3")]
	UnauthorizedForAchievement,
	[Token(Token = "0x40016B4")]
	InvalidGiftCode,
	[Token(Token = "0x40016B5")]
	PurchaseError,
	[Token(Token = "0x40016B6")]
	TransactionAborted
}
