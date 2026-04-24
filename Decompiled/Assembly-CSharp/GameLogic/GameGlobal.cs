using System.Diagnostics;
using Assets.Scripts.GameCore.GamePlay;
using Cpp2ILInjected;
using DYUnityLib;

namespace GameLogic;

[Token(Token = "0x2000496")]
public class GameGlobal
{
	[Token(Token = "0x40018D1")]
	public const int SCENE_TOTLE_COUNT = 13;

	[Token(Token = "0x40018D2")]
	public static bool IS_DEBUG;

	[Token(Token = "0x40018D3")]
	public static bool IS_NODE_DEBUG;

	[Token(Token = "0x40018D4")]
	[Attribute(Name = "DecimalConstantAttribute", RVA = "0x4E7D0", Offset = "0x4DBD0")]
	public static readonly decimal END_TIME_PLUS;

	[Token(Token = "0x40018D5")]
	[Attribute(Name = "DecimalConstantAttribute", RVA = "0x4E7D0", Offset = "0x4DBD0")]
	public static readonly decimal DEFAULT_END_CD;

	[Token(Token = "0x40018D6")]
	[Attribute(Name = "DecimalConstantAttribute", RVA = "0x37C90", Offset = "0x37090")]
	public static readonly decimal LONG_PRESS_FREQUENCY;

	[Token(Token = "0x40018D7")]
	public static int onClickNotReachableNumber;

	[Token(Token = "0x40018D8")]
	public static bool isCytusHideBMS;

	[Token(Token = "0x40018D9")]
	[Attribute(Name = "DecimalConstantAttribute", RVA = "0x4E970", Offset = "0x4DD70")]
	public static readonly decimal MISS_NO_CHECK_TICK;

	[Token(Token = "0x40018DA")]
	public static GameOptimization gGameOptimization;

	[Token(Token = "0x40018DB")]
	public static TouchScript gTouch;

	[Token(Token = "0x40018DC")]
	public static GameMissPlay gGameMissPlay;

	[Token(Token = "0x40018DD")]
	public static GameTouchPlay gGameTouchPlay;

	[Token(Token = "0x40018DE")]
	public static GameMusic gGameMusic;

	[Token(Token = "0x40018DF")]
	public static GameMusicScene gGameMusicScene;

	[Token(Token = "0x40018E0")]
	public static Stopwatch stopwatch;

	[Token(Token = "0x40018E1")]
	public static BaseConfigReader configReader;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x600347E")]
	public GameGlobal()
	{
	}
}
