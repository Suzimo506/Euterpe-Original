namespace Assets.Scripts.GameCore.Managers;

public class AchievementManager : Singleton<AchievementManager>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MusicData, Boolean> <>9__7_0; //Field offset: 0x8
		public static Func<IData, Int32> <>9__9_2; //Field offset: 0x10
		public static Func<String, Boolean> <>9__10_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <DoGlobalAchievement>b__10_0(string s) { }

		internal bool <GetGlobalAchievementArgs>b__7_0(MusicData m) { }

		internal int <RecordBattleArgs>b__9_2(IData f) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public string uid; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal bool <RecordBattleArgs>b__0(IData d) { }

		internal bool <RecordBattleArgs>b__1(IData fail) { }

	}

	[CompilerGenerated]
	private List<String> <achievements>k__BackingField; //Field offset: 0x10
	private int m_BaseStageAchiCount; //Field offset: 0x18

	public private List<String> achievements
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public AchievementManager() { }

	public void Do(bool isSuccess) { }

	public void Do() { }

	private void DoAchievement(string index, Int32[] targets, int value) { }

	private void DoGlobalAchievement(ref GlobalAchievementArgs args, bool isSuccess) { }

	public void DoTutorialAchievement() { }

	private void EasyDoAchievement(string index, bool isFinish) { }

	[CompilerGenerated]
	public List<String> get_achievements() { }

	private GlobalAchievementArgs GetGlobalAchievementArgs(bool isSuccess) { }

	private void Init() { }

	public bool IsDone(string uid) { }

	private void RecordBattleArgs(ref GlobalAchievementArgs args, bool isSuccess) { }

	private void Reward(string uid) { }

	[CompilerGenerated]
	private void set_achievements(List<String> value) { }

}

