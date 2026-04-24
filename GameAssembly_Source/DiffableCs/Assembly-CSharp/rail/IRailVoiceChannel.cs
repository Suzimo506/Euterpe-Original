namespace rail;

public interface IRailVoiceChannel : IRailComponent
{

	public RailResult AsyncAddUsers(List<RailID> user_list, string user_data) { }

	public RailResult AsyncJoinVoiceChannel(string user_data) { }

	public RailResult AsyncLeaveVoiceChannel(string user_data) { }

	public RailResult AsyncRemoveUsers(List<RailID> user_list, string user_data) { }

	public RailResult AsyncSetUsersSpeakingState(List<RailVoiceChannelUserSpeakingState> users_speaking_state, string user_data) { }

	public RailResult CloseChannel() { }

	public EnumRailVoiceChannelJoinState GetJoinState() { }

	public RailResult GetSpeakingUsers(List<RailID> speaking_users, List<RailID> not_speaking_users) { }

	public RailResult GetUsers(List<RailID> user_list) { }

	public RailResult GetUsersSpeakingState(List<RailVoiceChannelUserSpeakingState> users_speaking_state) { }

	public RailVoiceChannelID GetVoiceChannelID() { }

	public string GetVoiceChannelName() { }

	public bool IsOwner() { }

	public bool IsSelfSpeaking() { }

	public RailResult SetSelfSpeaking(bool speaking) { }

}

