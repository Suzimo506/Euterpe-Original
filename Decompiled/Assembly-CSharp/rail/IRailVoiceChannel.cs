using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003D7")]
public interface IRailVoiceChannel : IRailComponent
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F8D")]
	RailVoiceChannelID GetVoiceChannelID();

	[Token(Token = "0x6002F8E")]
	[Address(RVA = "0x0", Length = "0x0")]
	string GetVoiceChannelName();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F8F")]
	EnumRailVoiceChannelJoinState GetJoinState();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F90")]
	RailResult AsyncJoinVoiceChannel(string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F91")]
	RailResult AsyncLeaveVoiceChannel(string user_data);

	[Token(Token = "0x6002F92")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetUsers(List<RailID> user_list);

	[Token(Token = "0x6002F93")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncAddUsers(List<RailID> user_list, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F94")]
	RailResult AsyncRemoveUsers(List<RailID> user_list, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F95")]
	RailResult CloseChannel();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F96")]
	RailResult SetSelfSpeaking(bool speaking);

	[Token(Token = "0x6002F97")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool IsSelfSpeaking();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F98")]
	RailResult AsyncSetUsersSpeakingState(List<RailVoiceChannelUserSpeakingState> users_speaking_state, string user_data);

	[Token(Token = "0x6002F99")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetUsersSpeakingState(List<RailVoiceChannelUserSpeakingState> users_speaking_state);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F9A")]
	RailResult GetSpeakingUsers(List<RailID> speaking_users, List<RailID> not_speaking_users);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F9B")]
	bool IsOwner();
}
