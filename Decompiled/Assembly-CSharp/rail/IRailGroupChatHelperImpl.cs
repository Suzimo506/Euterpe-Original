using System;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200023E")]
public class IRailGroupChatHelperImpl : RailObject, IRailGroupChatHelper
{
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	[Token(Token = "0x600283E")]
	internal IRailGroupChatHelperImpl(IntPtr cPtr)
	{
	}

	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	[Token(Token = "0x600283F")]
	~IRailGroupChatHelperImpl()
	{
	}

	[Token(Token = "0x6002840")]
	[Address(RVA = "0xD2BAB0", Offset = "0xD2A2B0", Length = "0x65")]
	public virtual RailResult AsyncQueryGroupsInfo(string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD2B9F0", Offset = "0xD2A1F0", Length = "0xBC")]
	[Token(Token = "0x6002841")]
	public virtual IRailGroupChat AsyncOpenGroupChat(string group_id, string user_data)
	{
		return null;
	}
}
