using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x2000527")]
public struct INPUT_DEFINES
{
	[Token(Token = "0x4001E0E")]
	public const string BATTLE_GROUND = "BattleGround";

	[Token(Token = "0x4001E0F")]
	public const string BATTLE_AIR = "BattleAir";

	[Token(Token = "0x4001E10")]
	public const string FEVER = "Fever";

	[Token(Token = "0x4001E11")]
	public const string CUSTOM = "Custom";

	[Token(Token = "0x4001E12")]
	public const string DEFAULT = "Default";

	[Token(Token = "0x4001E13")]
	public const string DEFAULT_REVERSE = "DefaultReverse";

	[Token(Token = "0x4001E14")]
	public const string MODE_A = "ModeA";

	[Token(Token = "0x4001E15")]
	public const string MODE_B = "ModeB";

	[Token(Token = "0x4001E16")]
	public const string MODE_B_REVERSE = "ModeBReverse";

	[Token(Token = "0x4001E17")]
	public const string MODE_C = "ModeC";

	[Token(Token = "0x4001E18")]
	public const string MODE_C_REVERSE = "ModeCReverse";

	[Token(Token = "0x4001E19")]
	public const string MODE_D = "ModeD";

	[Token(Token = "0x4001E1A")]
	public const string MODE_D_REVERSE = "ModeDReverse";

	[Token(Token = "0x4001E1B")]
	public const string YUAN_CON = "YuanCon";

	[Token(Token = "0x4001E1C")]
	public const string KEYBOARD = "Keyboard";

	[Token(Token = "0x4001E1D")]
	public const string MOUSE = "Mouse";

	[Token(Token = "0x4001E1E")]
	public static readonly string[] KEY_TYPE_NAME;
}
