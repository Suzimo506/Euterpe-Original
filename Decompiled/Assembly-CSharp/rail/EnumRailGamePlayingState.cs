using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002DB")]
public enum EnumRailGamePlayingState
{
	[Token(Token = "0x40011D1")]
	kRailGamePlayingStateUnknow = 0,
	[Token(Token = "0x40011D2")]
	kRailGamePlayingStateLaunched = 1,
	[Token(Token = "0x40011D3")]
	kRailGamePlayingStatePlaying = 2,
	[Token(Token = "0x40011D4")]
	kRailGamePlayingStateStopped = 3,
	[Token(Token = "0x40011D5")]
	kRailGamePlayingStateGameDefinePlayingState = 100
}
