namespace Assets.Scripts.Database;

public static class GlobalDataBase
{
	private static DBRandom s_DbRandom; //Field offset: 0x0
	private static DBOther s_DbOther; //Field offset: 0x8
	private static DBTouch s_DbTouch; //Field offset: 0x10
	private static DBScene s_DbScene; //Field offset: 0x18
	private static DBStageInfo s_StageInfo; //Field offset: 0x20
	private static DBTouhou s_DbTouhou; //Field offset: 0x28
	private static DBUISpecial s_DbUISpecial; //Field offset: 0x30
	private static DBUi s_DbUi; //Field offset: 0x38
	private static DBMusicTag s_DbMusicTag; //Field offset: 0x40
	private static DBConfig s_DbConfig; //Field offset: 0x48
	private static DBBattleStage s_DbBattleStage; //Field offset: 0x50
	private static DBGameScene s_DbGameScene; //Field offset: 0x58
	private static DBSkill s_DbSkill; //Field offset: 0x60
	private static List<BaseDatabase> s_BaseDatabases; //Field offset: 0x68

	public static DBBattleStage dbBattleStage
	{
		 get { } //Length: 87
	}

	public static DBConfig dbConfig
	{
		 get { } //Length: 87
	}

	public static DBGameScene dbGameScene
	{
		 get { } //Length: 87
	}

	public static DBMusicTag dbMusicTag
	{
		 get { } //Length: 87
	}

	internal static DBOther dbOther
	{
		internal get { } //Length: 87
	}

	internal static DBRandom dbRandom
	{
		internal get { } //Length: 86
	}

	internal static DBScene dbScene
	{
		internal get { } //Length: 87
	}

	internal static DBSkill dbSkill
	{
		internal get { } //Length: 87
	}

	internal static DBStageInfo dbStageInfo
	{
		internal get { } //Length: 87
	}

	internal static DBTouch dbTouch
	{
		internal get { } //Length: 87
	}

	internal static DBTouhou dbTouhou
	{
		internal get { } //Length: 87
	}

	public static DBUi dbUi
	{
		 get { } //Length: 87
	}

	public static DBUISpecial dbUISpecial
	{
		 get { } //Length: 87
	}

	private static GlobalDataBase() { }

	internal static void AwakeInit() { }

	internal static void Flush() { }

	public static DBBattleStage get_dbBattleStage() { }

	public static DBConfig get_dbConfig() { }

	public static DBGameScene get_dbGameScene() { }

	public static DBMusicTag get_dbMusicTag() { }

	internal static DBOther get_dbOther() { }

	internal static DBRandom get_dbRandom() { }

	internal static DBScene get_dbScene() { }

	internal static DBSkill get_dbSkill() { }

	internal static DBStageInfo get_dbStageInfo() { }

	internal static DBTouch get_dbTouch() { }

	internal static DBTouhou get_dbTouhou() { }

	public static DBUi get_dbUi() { }

	public static DBUISpecial get_dbUISpecial() { }

	public static void InitDatabase() { }

	private static void OnSceneChange(Scene preScene, Scene curScene) { }

	internal static void Release() { }

	internal static void StartInit() { }

}

