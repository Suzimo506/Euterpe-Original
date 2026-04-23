using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003EA")]
public class VoiceChannelRemoveUsersResult : EventBase
{
	[Token(Token = "0x40015F5")]
	[FieldOffset(Offset = "0x30")]
	public List<RailID> success_ids;

	[Token(Token = "0x40015F6")]
	[FieldOffset(Offset = "0x38")]
	public RailVoiceChannelID voice_channel_id;

	[Token(Token = "0x40015F7")]
	[FieldOffset(Offset = "0x40")]
	public List<RailID> failed_ids;

	[Token(Token = "0x6002FBC")]
	[Address(RVA = "0x2722920", Offset = "0x2721120", Length = "0xF7")]
	public VoiceChannelRemoveUsersResult()
	{
	}
}
