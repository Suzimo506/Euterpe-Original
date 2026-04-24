namespace rail;

public class VoiceChannelMemeberChangedEvent : EventBase
{
	public RailVoiceChannelID voice_channel_id; //Field offset: 0x30
	public List<RailID> member_ids; //Field offset: 0x38

	public VoiceChannelMemeberChangedEvent() { }

}

