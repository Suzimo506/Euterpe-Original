namespace rail;

public class LeaveVoiceChannelResult : EventBase
{
	public RailVoiceChannelID voice_channel_id; //Field offset: 0x30
	public EnumRailVoiceLeaveChannelReason reason; //Field offset: 0x38

	public LeaveVoiceChannelResult() { }

}

