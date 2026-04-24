namespace rail;

public class VoiceChannelAddUsersResult : EventBase
{
	public List<RailID> success_ids; //Field offset: 0x30
	public RailVoiceChannelID voice_channel_id; //Field offset: 0x38
	public List<RailID> failed_ids; //Field offset: 0x40

	public VoiceChannelAddUsersResult() { }

}

