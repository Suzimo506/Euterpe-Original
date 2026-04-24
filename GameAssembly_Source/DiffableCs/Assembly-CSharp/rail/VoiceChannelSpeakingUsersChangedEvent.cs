namespace rail;

public class VoiceChannelSpeakingUsersChangedEvent : EventBase
{
	public List<RailID> speaking_users; //Field offset: 0x30
	public RailVoiceChannelID voice_channel_id; //Field offset: 0x38
	public List<RailID> not_speaking_users; //Field offset: 0x40

	public VoiceChannelSpeakingUsersChangedEvent() { }

}

