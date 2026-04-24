namespace rail;

public class IRailVoiceChannelImpl : RailObject, IRailVoiceChannel, IRailComponent
{

	internal IRailVoiceChannelImpl(IntPtr cPtr) { }

	public override RailResult AsyncAddUsers(List<RailID> user_list, string user_data) { }

	public override RailResult AsyncJoinVoiceChannel(string user_data) { }

	public override RailResult AsyncLeaveVoiceChannel(string user_data) { }

	public override RailResult AsyncRemoveUsers(List<RailID> user_list, string user_data) { }

	public override RailResult AsyncSetUsersSpeakingState(List<RailVoiceChannelUserSpeakingState> users_speaking_state, string user_data) { }

	public override RailResult CloseChannel() { }

	protected virtual void Finalize() { }

	public override ulong GetComponentVersion() { }

	public override EnumRailVoiceChannelJoinState GetJoinState() { }

	public override RailResult GetSpeakingUsers(List<RailID> speaking_users, List<RailID> not_speaking_users) { }

	public override RailResult GetUsers(List<RailID> user_list) { }

	public override RailResult GetUsersSpeakingState(List<RailVoiceChannelUserSpeakingState> users_speaking_state) { }

	public override RailVoiceChannelID GetVoiceChannelID() { }

	public override string GetVoiceChannelName() { }

	public override bool IsOwner() { }

	public override bool IsSelfSpeaking() { }

	public override void Release() { }

	public override RailResult SetSelfSpeaking(bool speaking) { }

}

