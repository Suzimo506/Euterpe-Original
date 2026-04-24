namespace PeroPeroGames.GlobalDefines;

public static class GLOBAL_DEFINES
{
	internal enum DYUL_EVENT_TYPE
	{
		MUSIC_SINGLE_PRESS = 0,
		MUSIC_END_PRESS = 1,
		MUSIC_TOUCH_EVENT = 2,
		SCENE_ADD_OBJ = 3,
		MUSIC_STEP_EVENT = 4,
		SCENE_EVENT = 5,
		DYUL_EVENT_TOUCH_BEGAN = 6,
		DYUL_EVENT_TOUCH_MOVED = 7,
		DYUL_EVENT_TOUCH_ENDED = 8,
		DYUL_DIALOG_EVENT = 9,
		DYUL_TYPE_COUNT = 10,
	}

	public const int RESIZE_ADD = 500; //Field offset: 0x0
	public const int CHAR_TYPE_GRIL = -1; //Field offset: 0x0
	public const bool BZAAAAAAA = True; //Field offset: 0x0
	public const float JUMP_WHOLE_TIME = 0.2; //Field offset: 0x0
	public const float PunchPoint = -3.87; //Field offset: 0x0
	public const uint TOUCH_ACTION_SLIDE_DOWN = 5; //Field offset: 0x0
	public const uint TOUCH_ACTION_SLIDE_UP = 4; //Field offset: 0x0
	public const int CHAR_TYPE_BOSS = -2; //Field offset: 0x0
	public const uint TOUCH_ACTION_LONG_PRESS = 2; //Field offset: 0x0
	public const uint TOUCH_ACTION_NONE = 0; //Field offset: 0x0
	[DecimalConstant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static readonly decimal DEFAULT_MUSIC_LEN; //Field offset: 0x0
	public const int SCENE_MAX = 10; //Field offset: 0x0
	public const int SCENE_COUNT = 9; //Field offset: 0x0
	public const string POINT_CENTER = "pc"; //Field offset: 0x0
	public const uint TOUCH_ACTION_SIGNLE_PRESS = 1; //Field offset: 0x0
	public const int ALPHA_FX_INDEX = 1; //Field offset: 0x0
	[DecimalConstant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static readonly decimal DEFAULT_END_CD; //Field offset: 0x10

	private static GLOBAL_DEFINES() { }

}

