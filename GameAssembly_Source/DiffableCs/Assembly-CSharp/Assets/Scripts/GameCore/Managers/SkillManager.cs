namespace Assets.Scripts.GameCore.Managers;

public class SkillManager : Singleton<SkillManager>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Type, Boolean> <>9__3_0; //Field offset: 0x8
		public static Comparison<MusicData> <>9__20_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <InitCache>b__3_0(Type t) { }

		internal int <LoadJKSkill>b__20_0(MusicData l, MusicData r) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public BattleProperty bp; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_1
	{
		public AttackEffectManager aem; //Field offset: 0x10
		public <>c__DisplayClass10_0 CS$<>8__locals1; //Field offset: 0x18
		public Action <>9__1; //Field offset: 0x20

		public <>c__DisplayClass10_1() { }

		internal void <ZombieSkill>b__0() { }

		internal void <ZombieSkill>b__1() { }

	}

	private static bool s_SkillInvalid; //Field offset: 0x0
	private const int catch_head_notes = 1; //Field offset: 0x0
	private const int catch_notes = 2; //Field offset: 0x0
	private static Coroutine zombieSkillStart; //Field offset: 0x8
	private static Coroutine zombieSkillStop; //Field offset: 0x10
	private static float m_CatchReactAirTime; //Field offset: 0x18
	private static float m_CatchReactGroundTime; //Field offset: 0x1C
	private readonly Dictionary<Int32, Type> m_RoleSkills; //Field offset: 0x10
	private readonly Dictionary<Int32, Type> m_ElfinSkills; //Field offset: 0x18

	public SkillManager() { }

	public void Apply() { }

	public static bool ClearSkill(int index) { }

	private void InitCache() { }

	private static void JkAddCatchNotes(int index, int listIndex) { }

	public static void JkCatchInputCheck(int index) { }

	public static void JkRefreshCatch(bool isAir) { }

	public static void JkResetCatchTime(bool isAir) { }

	public static void JkResetCatchTime() { }

	public static void JkSetCatchTime(bool isAir, float time) { }

	public static void LoadJKSkill(List<MusicData> musicDatas) { }

	public static bool NekoSkill(int hp) { }

	private void PreloadElfinSkill(int index) { }

	public static void ReleaseReference() { }

	public static bool RhythmSkill(int index) { }

	public static bool RobotSkill(int index) { }

	public static void SisterSkill(List<MusicData> musicDatas) { }

	public static void YumeSkill(int index) { }

	public static void ZombieSkill(bool invoke) { }

}

