using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200025B")]
public class IRailVoiceChannelImpl : RailObject, IRailVoiceChannel, IRailComponent
{
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	[Token(Token = "0x60029AA")]
	internal IRailVoiceChannelImpl(IntPtr cPtr)
	{
	}

	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	[Token(Token = "0x60029AB")]
	~IRailVoiceChannelImpl()
	{
	}

	[Token(Token = "0x60029AC")]
	[Address(RVA = "0x37AD60", Offset = "0x379560", Length = "0xEB")]
	public virtual RailVoiceChannelID GetVoiceChannelID()
	{
		return null;
	}

	[Token(Token = "0x60029AD")]
	[Address(RVA = "0x37AE50", Offset = "0x379650", Length = "0xBE")]
	public virtual string GetVoiceChannelName()
	{
		return null;
	}

	[Address(RVA = "0x37A750", Offset = "0x378F50", Length = "0xB5")]
	[Token(Token = "0x60029AE")]
	public virtual EnumRailVoiceChannelJoinState GetJoinState()
	{
		return default(EnumRailVoiceChannelJoinState);
	}

	[Token(Token = "0x60029AF")]
	[Address(RVA = "0x37A110", Offset = "0x378910", Length = "0xDD")]
	public virtual RailResult AsyncJoinVoiceChannel(string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60029B0")]
	[Address(RVA = "0x37A1F0", Offset = "0x3789F0", Length = "0xDD")]
	public virtual RailResult AsyncLeaveVoiceChannel(string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x37ABD0", Offset = "0x3793D0", Length = "0x18B")]
	[Token(Token = "0x60029B1")]
	public virtual RailResult GetUsers(List<RailID> user_list)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x379F60", Offset = "0x378760", Length = "0x1A0")]
	[Token(Token = "0x60029B2")]
	public virtual RailResult AsyncAddUsers(List<RailID> user_list, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60029B3")]
	[Address(RVA = "0x37A2D0", Offset = "0x378AD0", Length = "0x1A0")]
	public virtual RailResult AsyncRemoveUsers(List<RailID> user_list, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x37A630", Offset = "0x378E30", Length = "0xB5")]
	[Token(Token = "0x60029B4")]
	public virtual RailResult CloseChannel()
	{
		return default(RailResult);
	}

	[Address(RVA = "0x37B0F0", Offset = "0x3798F0", Length = "0xC3")]
	[Token(Token = "0x60029B5")]
	public virtual RailResult SetSelfSpeaking(bool speaking)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x37AFD0", Offset = "0x3797D0", Length = "0xBA")]
	[Token(Token = "0x60029B6")]
	public virtual bool IsSelfSpeaking()
	{
		return default(bool);
	}

	[Address(RVA = "0x37A480", Offset = "0x378C80", Length = "0x1A0")]
	[Token(Token = "0x60029B7")]
	public virtual RailResult AsyncSetUsersSpeakingState(List<RailVoiceChannelUserSpeakingState> users_speaking_state, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x37AA40", Offset = "0x379240", Length = "0x18B")]
	[Token(Token = "0x60029B8")]
	public virtual RailResult GetUsersSpeakingState(List<RailVoiceChannelUserSpeakingState> users_speaking_state)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x37A810", Offset = "0x379010", Length = "0x222")]
	[Token(Token = "0x60029B9")]
	public virtual RailResult GetSpeakingUsers(List<RailID> speaking_users, List<RailID> not_speaking_users)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x37AF10", Offset = "0x379710", Length = "0xBA")]
	[Token(Token = "0x60029BA")]
	public virtual bool IsOwner()
	{
		return default(bool);
	}

	[Token(Token = "0x60029BB")]
	[Address(RVA = "0x37A6F0", Offset = "0x378EF0", Length = "0x55")]
	public virtual ulong GetComponentVersion()
	{
		return default(ulong);
	}

	[Address(RVA = "0x37B090", Offset = "0x379890", Length = "0x55")]
	[Token(Token = "0x60029BC")]
	public virtual void Release()
	{
	}
}
