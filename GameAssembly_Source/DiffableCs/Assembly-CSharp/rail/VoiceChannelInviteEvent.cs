namespace rail;

public class VoiceChannelInviteEvent : EventBase
{
	public string channel_name; //Field offset: 0x30
	public RailVoiceChannelID voice_channel_id; //Field offset: 0x38
	public string inviter_name; //Field offset: 0x40

	public VoiceChannelInviteEvent() { }

}

