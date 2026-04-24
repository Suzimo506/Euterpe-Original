namespace rail;

public class JoinVoiceChannelResult : EventBase
{
	public RailVoiceChannelID already_joined_channel_id; //Field offset: 0x30
	public RailVoiceChannelID voice_channel_id; //Field offset: 0x38

	public JoinVoiceChannelResult() { }

}

