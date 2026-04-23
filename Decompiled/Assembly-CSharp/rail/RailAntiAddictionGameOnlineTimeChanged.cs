using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200033A")]
public class RailAntiAddictionGameOnlineTimeChanged : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40012C0")]
	public uint game_online_time_count_minutes;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002E4C")]
	public RailAntiAddictionGameOnlineTimeChanged()
	{
	}
}
