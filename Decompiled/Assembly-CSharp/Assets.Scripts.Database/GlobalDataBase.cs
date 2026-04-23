using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000816")]
public static class GlobalDataBase
{
	[Token(Token = "0x4002A22")]
	private static DBRandom s_DbRandom;

	[Token(Token = "0x4002A23")]
	private static DBOther s_DbOther;

	[Token(Token = "0x4002A24")]
	private static DBLevelConfig s_DbLevelConfig;

	[Token(Token = "0x4002A25")]
	private static DBTouch s_DbTouch;

	[Token(Token = "0x4002A26")]
	private static DBScene s_DbScene;

	[Token(Token = "0x4002A27")]
	private static DBStageInfo s_StageInfo;

	[Token(Token = "0x4002A28")]
	private static DBTouhou s_DbTouhou;

	[Token(Token = "0x4002A29")]
	private static DBUISpecial s_DbUISpecial;

	[Token(Token = "0x4002A2A")]
	private static DBUi s_DbUi;

	[Token(Token = "0x4002A2B")]
	private static DBMusicTag s_DbMusicTag;

	[Token(Token = "0x4002A2C")]
	private static DBConfig s_DbConfig;

	[Token(Token = "0x4002A2D")]
	private static DBBattleStage s_DbBattleStage;

	[Token(Token = "0x4002A2E")]
	private static DBGameScene s_DbGameScene;

	[Token(Token = "0x4002A2F")]
	private static DBSkill s_DbSkill;

	[Token(Token = "0x4002A30")]
	private static List<BaseDatabase> s_BaseDatabases;

	[Token(Token = "0x17000778")]
	internal static DBOther dbOther
	{
		[Address(RVA = "0x49E590", Offset = "0x49CD90", Length = "0x57")]
		[Token(Token = "0x6004957")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000779")]
	internal static DBLevelConfig dbLevelConfig
	{
		[Token(Token = "0x6004958")]
		[Address(RVA = "0x49E4D0", Offset = "0x49CCD0", Length = "0x57")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700077A")]
	internal static DBTouch dbTouch
	{
		[Token(Token = "0x6004959")]
		[Address(RVA = "0x49E770", Offset = "0x49CF70", Length = "0x57")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700077B")]
	internal static DBScene dbScene
	{
		[Token(Token = "0x600495A")]
		[Address(RVA = "0x49E650", Offset = "0x49CE50", Length = "0x57")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700077C")]
	internal static DBStageInfo dbStageInfo
	{
		[Token(Token = "0x600495B")]
		[Address(RVA = "0x49E710", Offset = "0x49CF10", Length = "0x57")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700077D")]
	internal static DBTouhou dbTouhou
	{
		[Token(Token = "0x600495C")]
		[Address(RVA = "0x49E7D0", Offset = "0x49CFD0", Length = "0x57")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700077E")]
	internal static DBRandom dbRandom
	{
		[Address(RVA = "0x49E5F0", Offset = "0x49CDF0", Length = "0x56")]
		[Token(Token = "0x600495D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700077F")]
	internal static DBSkill dbSkill
	{
		[Token(Token = "0x600495E")]
		[Address(RVA = "0x49E6B0", Offset = "0x49CEB0", Length = "0x57")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000780")]
	public static DBUISpecial dbUISpecial
	{
		[Token(Token = "0x600495F")]
		[Address(RVA = "0x49E830", Offset = "0x49D030", Length = "0x57")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000781")]
	public static DBUi dbUi
	{
		[Token(Token = "0x6004960")]
		[Address(RVA = "0x49E890", Offset = "0x49D090", Length = "0x57")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000782")]
	public static DBMusicTag dbMusicTag
	{
		[Token(Token = "0x6004961")]
		[Address(RVA = "0x49E530", Offset = "0x49CD30", Length = "0x57")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000783")]
	public static DBConfig dbConfig
	{
		[Token(Token = "0x6004962")]
		[Address(RVA = "0x49E410", Offset = "0x49CC10", Length = "0x57")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000784")]
	public static DBBattleStage dbBattleStage
	{
		[Token(Token = "0x6004963")]
		[Address(RVA = "0x49E3B0", Offset = "0x49CBB0", Length = "0x57")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000785")]
	public static DBGameScene dbGameScene
	{
		[Address(RVA = "0x49E470", Offset = "0x49CC70", Length = "0x57")]
		[Token(Token = "0x6004964")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600494F")]
	[Address(RVA = "0x49DE10", Offset = "0x49C610", Length = "0x597")]
	static GlobalDataBase()
	{
	}

	[Address(RVA = "0x49DAB0", Offset = "0x49C2B0", Length = "0x9A")]
	[Token(Token = "0x6004950")]
	private static void OnLeaveUiSystem()
	{
	}

	[Address(RVA = "0x49DA00", Offset = "0x49C200", Length = "0xA2")]
	[Token(Token = "0x6004951")]
	public static void InitDatabase()
	{
	}

	[Token(Token = "0x6004952")]
	[Address(RVA = "0x49DB50", Offset = "0x49C350", Length = "0xDE")]
	private static void OnSceneChange(Scene preScene, Scene curScene)
	{
	}

	[Token(Token = "0x6004953")]
	[Address(RVA = "0x49D820", Offset = "0x49C020", Length = "0xEB")]
	internal static void AwakeInit()
	{
	}

	[Token(Token = "0x6004954")]
	[Address(RVA = "0x49DD20", Offset = "0x49C520", Length = "0xEB")]
	internal static void StartInit()
	{
	}

	[Token(Token = "0x6004955")]
	[Address(RVA = "0x49DC30", Offset = "0x49C430", Length = "0xEB")]
	internal static void Release()
	{
	}

	[Address(RVA = "0x49D910", Offset = "0x49C110", Length = "0xEB")]
	[Token(Token = "0x6004956")]
	internal static void Flush()
	{
	}
}
