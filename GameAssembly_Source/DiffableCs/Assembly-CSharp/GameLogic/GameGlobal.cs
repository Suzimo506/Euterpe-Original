namespace GameLogic;

public class GameGlobal
{
	public const int SCENE_TOTLE_COUNT = 10; //Field offset: 0x0
	public static bool IS_DEBUG; //Field offset: 0x0
	public static bool IS_NODE_DEBUG; //Field offset: 0x1
	[DecimalConstant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static readonly decimal END_TIME_PLUS; //Field offset: 0x4
	[DecimalConstant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static readonly decimal DEFAULT_END_CD; //Field offset: 0x14
	[DecimalConstant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static readonly decimal LONG_PRESS_FREQUENCY; //Field offset: 0x24
	public static int onClickNotReachableNumber; //Field offset: 0x34
	public static bool isCytusHideBMS; //Field offset: 0x38
	[DecimalConstant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static readonly decimal MISS_NO_CHECK_TICK; //Field offset: 0x3C
	public static GameOptimization gGameOptimization; //Field offset: 0x50
	public static TouchScript gTouch; //Field offset: 0x58
	public static GameMissPlay gGameMissPlay; //Field offset: 0x60
	public static GameTouchPlay gGameTouchPlay; //Field offset: 0x68
	public static GameMusic gGameMusic; //Field offset: 0x70
	public static GameMusicScene gGameMusicScene; //Field offset: 0x78
	public static Stopwatch stopwatch; //Field offset: 0x80
	public static BaseConfigReader configReader; //Field offset: 0x88

	private static GameGlobal() { }

	public GameGlobal() { }

}

