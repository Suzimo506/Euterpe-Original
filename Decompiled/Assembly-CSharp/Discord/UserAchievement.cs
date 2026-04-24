using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x200042E")]
public struct UserAchievement
{
	[Token(Token = "0x4001742")]
	[FieldOffset(Offset = "0x0")]
	public long UserId;

	[Token(Token = "0x4001743")]
	[FieldOffset(Offset = "0x8")]
	public long AchievementId;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001744")]
	public byte PercentComplete;

	[Token(Token = "0x4001745")]
	[FieldOffset(Offset = "0x18")]
	public string UnlockedAt;
}
