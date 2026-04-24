namespace PeroPeroGames.GlobalDefines;

public struct NODE_TYPE
{
	public const uint NODE_TYPE_NONE = 0; //Field offset: 0x0
	public const uint NODE_TYPE_SCREENSCROLL_DOWN = 19; //Field offset: 0x0
	public const uint NODE_TYPE_SCREENSCROLL_OFF = 20; //Field offset: 0x0
	public const uint NODE_TYPE_TWIST_OFF = 22; //Field offset: 0x0
	public const uint NODE_TYPE_DISPERSION_ON = 23; //Field offset: 0x0
	public const uint NODE_TYPE_DISPERSION_OFF = 24; //Field offset: 0x0
	public const uint NODE_TYPE_OLDTV_ON = 25; //Field offset: 0x0
	public const uint NODE_TYPE_SCREENSCROLL_UP = 18; //Field offset: 0x0
	public const uint NODE_TYPE_OLDTV_OFF = 26; //Field offset: 0x0
	public const uint NODE_TYPE_SNOWFLAKE_OFF = 28; //Field offset: 0x0
	public const uint NODE_TYPE_FLASH_START = 29; //Field offset: 0x0
	public const uint NODE_TYPE_FLASH_HOLDON = 30; //Field offset: 0x0
	public const uint NODE_TYPE_FLASH_END = 31; //Field offset: 0x0
	public const uint NODE_TYPE_FREEZE = 32; //Field offset: 0x0
	private static UInt32[] IGNORE_NODE_TYPE; //Field offset: 0x0
	public const uint NODE_TYPE_SNOWFLAKE_ON = 27; //Field offset: 0x0
	public const uint NODE_TYPE_GAMESCENE_HIDE_OFF = 17; //Field offset: 0x0
	public const uint NODE_TYPE_TWIST_ON = 21; //Field offset: 0x0
	public const uint NODE_TYPE_DISAPPEAR_BOSS_OFF = 15; //Field offset: 0x0
	public const uint NODE_TYPE_MONSTER = 1; //Field offset: 0x0
	public const uint NODE_TYPE_BLOCK = 2; //Field offset: 0x0
	public const uint NODE_TYPE_PRESS = 3; //Field offset: 0x0
	public const uint NODE_TYPE_GAMESCENE_HIDE_ON = 16; //Field offset: 0x0
	public const uint NODE_TYPE_BOSS = 5; //Field offset: 0x0
	public const uint NODE_TYPE_HP = 6; //Field offset: 0x0
	public const uint NODE_TYPE_MUSIC = 7; //Field offset: 0x0
	public const uint NODE_TYPE_HIDE = 4; //Field offset: 0x0
	public const uint NODE_TYPE_SCENECHANGE = 9; //Field offset: 0x0
	public const uint NODE_TYPE_AUTO_ON = 10; //Field offset: 0x0
	public const uint NODE_TYPE_AUTO_OFF = 11; //Field offset: 0x0
	public const uint NODE_TYPE_DISAPPEAR_ON = 12; //Field offset: 0x0
	public const uint NODE_TYPE_MUL = 8; //Field offset: 0x0
	public const uint NODE_TYPE_DISAPPEAR_OFF = 13; //Field offset: 0x0
	public const uint NODE_TYPE_DISAPPEAR_BOSS_ON = 14; //Field offset: 0x0
	private static UInt32[] NODE_TYPE_IS_ADD_COMBO; //Field offset: 0x8
	private static UInt32[] NODE_TYPE_IS_MISS_COMBO; //Field offset: 0x10
	private static UInt32[] NODE_TYPE_IS_SHOW_PLAY_EFFECT; //Field offset: 0x18
	private static UInt32[] IS_SUPPORT_ANIMATOR; //Field offset: 0x20
	private static UInt32[] RUNTIME_SCROLL_NODE_TYPE; //Field offset: 0x28
	private static UInt32[] SCROLL_NODE_TYPE; //Field offset: 0x30
	private static UInt32[] SUPPORT_HIDE_TYPE; //Field offset: 0x38
	private static UInt32[] NODE_TYPE_TRIGGER_TYPE; //Field offset: 0x40
	private static UInt32[] NODE_TYPES_NO_MISS; //Field offset: 0x48
	private static UInt32[] SUPPORT_MIRROR_TYPE; //Field offset: 0x50

	private static NODE_TYPE() { }

	public static bool IsAddComboType(uint type) { }

	public static bool IsIgnoreNodeType(uint type, bool addSpecialNode) { }

	public static bool IsIgnoreType(uint type) { }

	public static bool IsMissComboType(uint type) { }

	public static bool IsScrollType(uint type, bool includePress = true, string boss_action = null) { }

	public static bool IsShowPlayEffect(uint type) { }

	public static bool IsSupportAnimator(uint type) { }

	public static bool IsSupportHideType(uint type) { }

	public static bool IsSupportMirror(uint type) { }

	public static bool IsTriggerType(uint type) { }

}

