namespace rail;

public class VoiceChannelUsersSpeakingStateChangedEvent : EventBase
{
	public RailVoiceChannelID voice_channel_id; //Field offset: 0x30
	public List<RailVoiceChannelUserSpeakingState> users_speaking_state; //Field offset: 0x38

	public VoiceChannelUsersSpeakingStateChangedEvent() { }

}

