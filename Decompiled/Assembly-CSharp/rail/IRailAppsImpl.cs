using System;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200022D")]
public class IRailAppsImpl : RailObject, IRailApps
{
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	[Token(Token = "0x6002736")]
	internal IRailAppsImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6002737")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~IRailAppsImpl()
	{
	}

	[Token(Token = "0x6002738")]
	[Address(RVA = "0xD20B30", Offset = "0xD1F330", Length = "0x17C")]
	public virtual bool IsGameInstalled(RailGameID game_id)
	{
		return default(bool);
	}

	[Address(RVA = "0xD209B0", Offset = "0xD1F1B0", Length = "0x17B")]
	[Token(Token = "0x6002739")]
	public virtual RailResult AsyncQuerySubscribeWishPlayState(RailGameID game_id, string user_data)
	{
		return default(RailResult);
	}
}
