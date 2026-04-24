using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007EA")]
public struct StageAchievementExInfo
{
	[Token(Token = "0x4002970")]
	[FieldOffset(Offset = "0x0")]
	public int albumUidIndex;

	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4002971")]
	public int musicIndex;
}
