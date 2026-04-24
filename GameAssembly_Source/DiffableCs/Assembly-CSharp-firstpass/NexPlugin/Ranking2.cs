namespace NexPlugin;

public static class Ranking2
{
	internal enum Ranking2GetOptionFlags
	{
		NOTHING = 0,
		MII_REQUIRED = 1,
	}

	internal enum Ranking2Mode
	{
		USER_RANKING = 0,
		NEAR_RANKING = 1,
		RANGE_RANKING = 2,
		FRIEND_RANKING = 3,
		MIN = 0,
		MAX = 3,
	}

	internal enum Ranking2ResetMode
	{
		NOTHING = 0,
		EVERYDAY = 1,
		EVERYWEEK = 2,
		MULTI_MONTH = 3,
		MULTI_MONTH_WEEKDAY = 4,
		MIN = 0,
		MAX = 4,
	}

	internal enum Ranking2SortFlags
	{
		NOTHING = 0,
		MOVE_TO_TOP_IN_TIE = 4,
	}

	public const int MAX_BINARY_DATA_LENGTH = 100; //Field offset: 0x0
	public const uint MAX_CHART_GET_LENGTH = 20; //Field offset: 0x0
	public const uint MAX_PUT_MULTI_SCORES = 20; //Field offset: 0x0
	public const uint MAX_RANKING_LENGTH = 100; //Field offset: 0x0
	public const int MAX_USERNAME_LENGTH = 20; //Field offset: 0x0
	public const bool SCORE_ORDER_ASC = False; //Field offset: 0x0
	public const bool SCORE_ORDER_DESC = True; //Field offset: 0x0

}

