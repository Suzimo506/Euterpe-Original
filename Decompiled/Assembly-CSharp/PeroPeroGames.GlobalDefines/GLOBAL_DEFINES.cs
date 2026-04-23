using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[Token(Token = "0x20004FE")]
public static class GLOBAL_DEFINES
{
	[Token(Token = "0x2000B74")]
	public enum DYUL_EVENT_TYPE
	{
		[Token(Token = "0x4003A4B")]
		MUSIC_SINGLE_PRESS,
		[Token(Token = "0x4003A4C")]
		MUSIC_END_PRESS,
		[Token(Token = "0x4003A4D")]
		MUSIC_TOUCH_EVENT,
		[Token(Token = "0x4003A4E")]
		SCENE_ADD_OBJ,
		[Token(Token = "0x4003A4F")]
		MUSIC_STEP_EVENT,
		[Token(Token = "0x4003A50")]
		SCENE_EVENT,
		[Token(Token = "0x4003A51")]
		DYUL_EVENT_TOUCH_BEGAN,
		[Token(Token = "0x4003A52")]
		DYUL_EVENT_TOUCH_MOVED,
		[Token(Token = "0x4003A53")]
		DYUL_EVENT_TOUCH_ENDED,
		[Token(Token = "0x4003A54")]
		DYUL_DIALOG_EVENT,
		[Token(Token = "0x4003A55")]
		DYUL_TYPE_COUNT
	}

	[Token(Token = "0x4001B32")]
	public const int RESIZE_ADD = 500;

	[Token(Token = "0x4001B33")]
	public const string POINT_CENTER = "pc";

	[Token(Token = "0x4001B34")]
	public const int SCENE_COUNT = 9;

	[Token(Token = "0x4001B35")]
	public const int SCENE_MAX = 10;

	[Token(Token = "0x4001B36")]
	[Attribute(Name = "DecimalConstantAttribute", RVA = "0x755E0", Offset = "0x749E0")]
	public static readonly decimal DEFAULT_MUSIC_LEN;

	[Token(Token = "0x4001B37")]
	[Attribute(Name = "DecimalConstantAttribute", RVA = "0x75700", Offset = "0x74B00")]
	public static readonly decimal DEFAULT_END_CD;

	[Token(Token = "0x4001B38")]
	public const uint TOUCH_ACTION_NONE = 0u;

	[Token(Token = "0x4001B39")]
	public const uint TOUCH_ACTION_SIGNLE_PRESS = 1u;

	[Token(Token = "0x4001B3A")]
	public const uint TOUCH_ACTION_LONG_PRESS = 2u;

	[Token(Token = "0x4001B3B")]
	public const uint TOUCH_ACTION_SLIDE_UP = 4u;

	[Token(Token = "0x4001B3C")]
	public const uint TOUCH_ACTION_SLIDE_DOWN = 5u;

	[Token(Token = "0x4001B3D")]
	public const float PunchPoint = -3.87f;

	[Token(Token = "0x4001B3E")]
	public const float JUMP_WHOLE_TIME = 0.2f;

	[Token(Token = "0x4001B3F")]
	public const bool BZAAAAAAA = true;

	[Token(Token = "0x4001B40")]
	public const int CHAR_TYPE_GRIL = -1;

	[Token(Token = "0x4001B41")]
	public const int CHAR_TYPE_BOSS = -2;

	[Token(Token = "0x4001B42")]
	public const int ALPHA_FX_INDEX = 1;
}
