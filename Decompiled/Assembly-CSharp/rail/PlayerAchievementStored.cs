using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000269")]
public class PlayerAchievementStored : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000FCF")]
	public bool group_achievement;

	[Token(Token = "0x4000FD0")]
	[FieldOffset(Offset = "0x38")]
	public string achievement_name;

	[Token(Token = "0x4000FD1")]
	[FieldOffset(Offset = "0x40")]
	public uint current_progress;

	[Token(Token = "0x4000FD2")]
	[FieldOffset(Offset = "0x44")]
	public uint max_progress;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002C8B")]
	public PlayerAchievementStored()
	{
	}
}
