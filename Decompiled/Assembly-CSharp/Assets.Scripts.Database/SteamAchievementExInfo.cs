using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007F1")]
internal struct SteamAchievementExInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4002989")]
	public bool initialized;

	[Token(Token = "0x400298A")]
	[FieldOffset(Offset = "0x1")]
	public bool isHidden;
}
