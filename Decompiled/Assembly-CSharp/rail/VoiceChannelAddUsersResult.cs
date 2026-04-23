using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003E6")]
public class VoiceChannelAddUsersResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40015EC")]
	public List<RailID> success_ids;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40015ED")]
	public RailVoiceChannelID voice_channel_id;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40015EE")]
	public List<RailID> failed_ids;

	[Token(Token = "0x6002FB8")]
	[Address(RVA = "0x27226B0", Offset = "0x2720EB0", Length = "0xF7")]
	public VoiceChannelAddUsersResult()
	{
	}
}
