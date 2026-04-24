namespace Assets.Scripts.GameCore.Managers;

public class StatisticsManager : Singleton<StatisticsManager>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<IData> <>9__8_0; //Field offset: 0x8
		public static Action<Int32> <>9__8_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <OnBattleEnd>b__8_0(IData m) { }

		internal void <OnBattleEnd>b__8_1(int rank) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public List<Dictionary`2<String, Object>> achievements; //Field offset: 0x10
		public int selectedDifficulty; //Field offset: 0x18
		public string userId; //Field offset: 0x20

		public <>c__DisplayClass9_0() { }

		internal void <OnChallengeAchievementEnd>b__0(IData d) { }

	}

	private List<Beat> m_Beats; //Field offset: 0x10
	private int m_BeatIndex; //Field offset: 0x18
	public List<Int32> m_TutorialArray; //Field offset: 0x20
	[CompilerGenerated]
	private bool <isNormalTutorial>k__BackingField; //Field offset: 0x28

	public private bool isNormalTutorial
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public StatisticsManager() { }

	[CompilerGenerated]
	public bool get_isNormalTutorial() { }

	public string GetControllerName() { }

	public void OnBattleEnd(bool fail = false) { }

	public void OnBattleStart() { }

	public void OnChallengeAchievementEnd() { }

	public void OnGetScore(int noteId, int configId, int judge, string noteType, int offset, int score, Side side, int combo, int addTime, int feverStart, int feverEnd, int feverValue) { }

	public void OnNoteResult(int result) { }

	public void OnTutorialEnd() { }

	[CompilerGenerated]
	private void set_isNormalTutorial(bool value) { }

}

