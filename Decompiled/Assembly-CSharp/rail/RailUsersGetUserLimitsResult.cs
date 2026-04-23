using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003C4")]
public class RailUsersGetUserLimitsResult : EventBase
{
	[Token(Token = "0x4001597")]
	[FieldOffset(Offset = "0x30")]
	public RailID user_id;

	[Token(Token = "0x4001598")]
	[FieldOffset(Offset = "0x38")]
	public List<EnumRailUsersLimits> user_limits;

	[Address(RVA = "0x27217F0", Offset = "0x271FFF0", Length = "0xCA")]
	[Token(Token = "0x6002F71")]
	public RailUsersGetUserLimitsResult()
	{
	}
}
