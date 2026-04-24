using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x2000530")]
public struct BMS_NODE_DEFINES
{
	[Token(Token = "0x4001F18")]
	public const string BOSS_NEAR_ATTACK_1 = "11";

	[Token(Token = "0x4001F19")]
	public const string BOSS_NEAR_ATTACK_2 = "12";

	[Token(Token = "0x4001F1A")]
	public const string BOSS_MUL_HIT_1 = "16";

	[Token(Token = "0x4001F1B")]
	public const string BOSS_MUL_HIT_2 = "17";

	[Token(Token = "0x4001F1C")]
	public const string TIP_BLOCK = "34";

	[Token(Token = "0x4001F1D")]
	public const string DOUBLE = "0H";

	[Token(Token = "0x4001F1E")]
	public const string BOSS_BLOCK = "18";

	[Token(Token = "0x4001F1F")]
	public const string BOSS_SCALY = "3C";

	[Token(Token = "0x4001F20")]
	public const string BOSS_SCALY_CROSS = "3D";

	[Token(Token = "0x4001F21")]
	public const string BOSS_KNIFE = "3E";

	[Token(Token = "0x4001F22")]
	public const string BOSS_KNIFE_CROSS = "3F";
}
