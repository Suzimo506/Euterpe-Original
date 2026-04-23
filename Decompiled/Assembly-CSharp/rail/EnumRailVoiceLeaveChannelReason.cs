using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003E0")]
public enum EnumRailVoiceLeaveChannelReason
{
	[Token(Token = "0x40015DD")]
	kRailVoiceLeaveChannelReasonUnknown,
	[Token(Token = "0x40015DE")]
	kRailVoiceLeaveChannelReasonChannelClosed,
	[Token(Token = "0x40015DF")]
	kRailVoiceLeaveChannelReasonKickedByPlayer,
	[Token(Token = "0x40015E0")]
	kRailVoiceLeaveChannelReasonExitedBySelf
}
