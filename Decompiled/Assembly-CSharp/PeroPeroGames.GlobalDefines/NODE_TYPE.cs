using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x200052E")]
public struct NODE_TYPE
{
	[Token(Token = "0x4001EC6")]
	public const uint NODE_TYPE_NONE = 0u;

	[Token(Token = "0x4001EC7")]
	public const uint NODE_TYPE_MONSTER = 1u;

	[Token(Token = "0x4001EC8")]
	public const uint NODE_TYPE_BLOCK = 2u;

	[Token(Token = "0x4001EC9")]
	public const uint NODE_TYPE_PRESS = 3u;

	[Token(Token = "0x4001ECA")]
	public const uint NODE_TYPE_HIDE = 4u;

	[Token(Token = "0x4001ECB")]
	public const uint NODE_TYPE_BOSS = 5u;

	[Token(Token = "0x4001ECC")]
	public const uint NODE_TYPE_HP = 6u;

	[Token(Token = "0x4001ECD")]
	public const uint NODE_TYPE_MUSIC = 7u;

	[Token(Token = "0x4001ECE")]
	public const uint NODE_TYPE_MUL = 8u;

	[Token(Token = "0x4001ECF")]
	public const uint NODE_TYPE_SCENECHANGE = 9u;

	[Token(Token = "0x4001ED0")]
	public const uint NODE_TYPE_AUTO_ON = 10u;

	[Token(Token = "0x4001ED1")]
	public const uint NODE_TYPE_AUTO_OFF = 11u;

	[Token(Token = "0x4001ED2")]
	public const uint NODE_TYPE_DISAPPEAR_ON = 12u;

	[Token(Token = "0x4001ED3")]
	public const uint NODE_TYPE_DISAPPEAR_OFF = 13u;

	[Token(Token = "0x4001ED4")]
	public const uint NODE_TYPE_DISAPPEAR_BOSS_ON = 14u;

	[Token(Token = "0x4001ED5")]
	public const uint NODE_TYPE_DISAPPEAR_BOSS_OFF = 15u;

	[Token(Token = "0x4001ED6")]
	public const uint NODE_TYPE_GAMESCENE_HIDE_ON = 16u;

	[Token(Token = "0x4001ED7")]
	public const uint NODE_TYPE_GAMESCENE_HIDE_OFF = 17u;

	[Token(Token = "0x4001ED8")]
	public const uint NODE_TYPE_SCREENSCROLL_UP = 18u;

	[Token(Token = "0x4001ED9")]
	public const uint NODE_TYPE_SCREENSCROLL_DOWN = 19u;

	[Token(Token = "0x4001EDA")]
	public const uint NODE_TYPE_SCREENSCROLL_OFF = 20u;

	[Token(Token = "0x4001EDB")]
	public const uint NODE_TYPE_TWIST_ON = 21u;

	[Token(Token = "0x4001EDC")]
	public const uint NODE_TYPE_TWIST_OFF = 22u;

	[Token(Token = "0x4001EDD")]
	public const uint NODE_TYPE_DISPERSION_ON = 23u;

	[Token(Token = "0x4001EDE")]
	public const uint NODE_TYPE_DISPERSION_OFF = 24u;

	[Token(Token = "0x4001EDF")]
	public const uint NODE_TYPE_OLDTV_ON = 25u;

	[Token(Token = "0x4001EE0")]
	public const uint NODE_TYPE_OLDTV_OFF = 26u;

	[Token(Token = "0x4001EE1")]
	public const uint NODE_TYPE_SNOWFLAKE_ON = 27u;

	[Token(Token = "0x4001EE2")]
	public const uint NODE_TYPE_SNOWFLAKE_OFF = 28u;

	[Token(Token = "0x4001EE3")]
	public const uint NODE_TYPE_FLASH_START = 29u;

	[Token(Token = "0x4001EE4")]
	public const uint NODE_TYPE_FLASH_HOLDON = 30u;

	[Token(Token = "0x4001EE5")]
	public const uint NODE_TYPE_FLASH_END = 31u;

	[Token(Token = "0x4001EE6")]
	public const uint NODE_TYPE_FREEZE = 32u;

	[Token(Token = "0x4001EE7")]
	public const uint NODE_TYPE_PIXELATION_START = 33u;

	[Token(Token = "0x4001EE8")]
	public const uint NODE_TYPE_PIXELATION_END = 34u;

	[Token(Token = "0x4001EE9")]
	public const uint NODE_TYPE_GRAY_SCALE_START = 35u;

	[Token(Token = "0x4001EEA")]
	public const uint NODE_TYPE_GRAY_SCALE_END = 36u;

	[Token(Token = "0x4001EEB")]
	public const uint NODE_TYPE_COMICS_BLACK = 37u;

	[Token(Token = "0x4001EEC")]
	public const uint NODE_TYPE_COMICS_WHITE = 38u;

	[Token(Token = "0x4001EED")]
	public const uint NODE_TYPE_COMICS_END = 39u;

	[Token(Token = "0x4001EEE")]
	public const uint NODE_TYPE_COLOR_WHITE = 40u;

	[Token(Token = "0x4001EEF")]
	public const uint NODE_TYPE_COLOR_BLACK = 41u;

	[Token(Token = "0x4001EF0")]
	public const uint NODE_TYPE_COLOR_RED = 42u;

	[Token(Token = "0x4001EF1")]
	public const uint NODE_TYPE_COLOR_GREEN = 43u;

	[Token(Token = "0x4001EF2")]
	public const uint NODE_TYPE_COLOR_BLUE = 44u;

	[Token(Token = "0x4001EF3")]
	public const uint NODE_TYPE_COLOR_CYAN = 45u;

	[Token(Token = "0x4001EF4")]
	public const uint NODE_TYPE_COLOR_MAGENTA = 46u;

	[Token(Token = "0x4001EF5")]
	public const uint NODE_TYPE_COLOR_YELLOW = 47u;

	[Token(Token = "0x4001EF6")]
	public const uint NODE_TYPE_NOSTALGIA_START = 48u;

	[Token(Token = "0x4001EF7")]
	public const uint NODE_TYPE_NOSTALGIA_END = 49u;

	[Token(Token = "0x4001EF8")]
	public const uint NODE_TYPE_QUESTION_START = 50u;

	[Token(Token = "0x4001EF9")]
	public const uint NODE_TYPE_QUESTION_END = 51u;

	[Token(Token = "0x4001EFA")]
	private static uint[] IGNORE_NODE_TYPE;

	[Token(Token = "0x4001EFB")]
	private static uint[] NODE_TYPE_IS_ADD_COMBO;

	[Token(Token = "0x4001EFC")]
	private static uint[] NODE_TYPE_IS_MISS_COMBO;

	[Token(Token = "0x4001EFD")]
	private static uint[] NODE_TYPE_IS_SHOW_PLAY_EFFECT;

	[Token(Token = "0x4001EFE")]
	private static uint[] IS_SUPPORT_ANIMATOR;

	[Token(Token = "0x4001EFF")]
	private static uint[] RUNTIME_SCROLL_NODE_TYPE;

	[Token(Token = "0x4001F00")]
	private static uint[] SCROLL_NODE_TYPE;

	[Token(Token = "0x4001F01")]
	private static uint[] SUPPORT_HIDE_TYPE;

	[Token(Token = "0x4001F02")]
	private static uint[] NODE_TYPE_TRIGGER_TYPE;

	[Token(Token = "0x4001F03")]
	private static uint[] NODE_TYPES_NO_MISS;

	[Token(Token = "0x4001F04")]
	private static uint[] SUPPORT_MIRROR_TYPE;

	[Address(RVA = "0x4F6500", Offset = "0x4F4D00", Length = "0xA0")]
	[Token(Token = "0x600373C")]
	public static bool IsSupportAnimator(uint type)
	{
		return default(bool);
	}

	[Token(Token = "0x600373D")]
	[Address(RVA = "0x4F6660", Offset = "0x4F4E60", Length = "0xEB")]
	public static bool IsSupportMirror(uint type)
	{
		return default(bool);
	}

	[Token(Token = "0x600373E")]
	[Address(RVA = "0x4F61A0", Offset = "0x4F49A0", Length = "0xD0")]
	public static bool IsIgnoreType(uint type)
	{
		return default(bool);
	}

	[Token(Token = "0x600373F")]
	[Address(RVA = "0x4F6060", Offset = "0x4F4860", Length = "0x130")]
	public static bool IsIgnoreNodeType(uint type, bool addSpecialNode)
	{
		return default(bool);
	}

	[Token(Token = "0x6003740")]
	[Address(RVA = "0x4F6330", Offset = "0x4F4B30", Length = "0x111")]
	public static bool IsScrollType(uint type, bool includePress = true, string boss_action = null)
	{
		return default(bool);
	}

	[Token(Token = "0x6003741")]
	[Address(RVA = "0x4F65B0", Offset = "0x4F4DB0", Length = "0xA0")]
	public static bool IsSupportHideType(uint type)
	{
		return default(bool);
	}

	[Token(Token = "0x6003742")]
	[Address(RVA = "0x4F5FB0", Offset = "0x4F47B0", Length = "0xA0")]
	public static bool IsAddComboType(uint type)
	{
		return default(bool);
	}

	[Address(RVA = "0x4F6280", Offset = "0x4F4A80", Length = "0xA0")]
	[Token(Token = "0x6003743")]
	public static bool IsMissComboType(uint type)
	{
		return default(bool);
	}

	[Address(RVA = "0x4F6450", Offset = "0x4F4C50", Length = "0xA0")]
	[Token(Token = "0x6003744")]
	public static bool IsShowPlayEffect(uint type)
	{
		return default(bool);
	}

	[Token(Token = "0x6003745")]
	[Address(RVA = "0x4F6750", Offset = "0x4F4F50", Length = "0xD2")]
	public static bool IsTriggerType(uint type)
	{
		return default(bool);
	}
}
