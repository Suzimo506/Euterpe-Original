using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003DD")]
public enum EnumRailVoiceChannelJoinState
{
	[Token(Token = "0x40015CA")]
	kRailVoiceChannelJoinStateUnknown,
	[Token(Token = "0x40015CB")]
	kRailVoiceChannelJoinStateCreating,
	[Token(Token = "0x40015CC")]
	kRailVoiceChannelJoinStateCreated,
	[Token(Token = "0x40015CD")]
	kRailVoiceChannelJoinStateCreateFailed,
	[Token(Token = "0x40015CE")]
	kRailVoiceChannelJoinStateJoining,
	[Token(Token = "0x40015CF")]
	kRailVoiceChannelJoinStateJoined,
	[Token(Token = "0x40015D0")]
	kRailVoiceChannelJoinStateJoinFailed,
	[Token(Token = "0x40015D1")]
	kRailVoiceChannelJoinStateLeaving,
	[Token(Token = "0x40015D2")]
	kRailVoiceChannelJoinStateLeft,
	[Token(Token = "0x40015D3")]
	kRailVoiceChannelJoinStateLeaveFailed,
	[Token(Token = "0x40015D4")]
	kRailVoiceChannelJoinStateLostConnection
}
