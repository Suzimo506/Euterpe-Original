using Cpp2ILInjected;

namespace Assets.Scripts.Managers;

[Token(Token = "0x2000974")]
public struct SteamAchievementState
{
	[Token(Token = "0x40033D3")]
	[FieldOffset(Offset = "0x0")]
	public int id;

	[Token(Token = "0x40033D4")]
	[FieldOffset(Offset = "0x4")]
	public bool isHidden;
}
