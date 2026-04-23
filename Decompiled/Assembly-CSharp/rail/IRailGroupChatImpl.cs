using System;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200023D")]
public class IRailGroupChatImpl : RailObject, IRailGroupChat, IRailComponent
{
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	[Token(Token = "0x6002838")]
	internal IRailGroupChatImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6002839")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~IRailGroupChatImpl()
	{
	}

	[Address(RVA = "0xD2BB80", Offset = "0xD2A380", Length = "0x12E")]
	[Token(Token = "0x600283A")]
	public virtual RailResult GetGroupInfo(RailGroupInfo group_info)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD2BCB0", Offset = "0xD2A4B0", Length = "0x55")]
	[Token(Token = "0x600283B")]
	public virtual RailResult OpenGroupWindow()
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD2BB20", Offset = "0xD2A320", Length = "0x55")]
	[Token(Token = "0x600283C")]
	public virtual ulong GetComponentVersion()
	{
		return default(ulong);
	}

	[Token(Token = "0x600283D")]
	[Address(RVA = "0xD2BD10", Offset = "0xD2A510", Length = "0x55")]
	public virtual void Release()
	{
	}
}
