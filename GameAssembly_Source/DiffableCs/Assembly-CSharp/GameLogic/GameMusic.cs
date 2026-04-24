namespace GameLogic;

public class GameMusic
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__46_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <BattleEnd>b__46_0() { }

	}

	public const uint TOUCH_ACTION_NONE = 0; //Field offset: 0x0
	private const string DEFAULT_ANIMATION = "AttackTargetObject/EnemyNormal"; //Field offset: 0x0
	public const string wheel_destroy = "destroy"; //Field offset: 0x0
	public const int NODE_IS_BOSS_THROW_ATTACK = 2; //Field offset: 0x0
	public const int NODE_IS_BOSS_BODY_ATTACK = 1; //Field offset: 0x0
	public const int B_GREAT_RANGE_INDEX = 3; //Field offset: 0x0
	public const int B_PERFECT_RANGE_INDEX = 2; //Field offset: 0x0
	public const int NODE_IS_NOT_A_BOSS = 0; //Field offset: 0x0
	public const int A_PERFECT_RANGE_INDEX = 0; //Field offset: 0x0
	public const uint TOUCH_ACTION_SLIDE_DOWN = 5; //Field offset: 0x0
	public const uint TOUCH_ACTION_SLIDE_UP = 4; //Field offset: 0x0
	public const uint TOUCH_ACTION_LONG_PRESS = 2; //Field offset: 0x0
	public const uint TOUCH_ACTION_SIGNLE_PRESS = 1; //Field offset: 0x0
	public const int A_GREAT_RANGE_INDEX = 1; //Field offset: 0x0
	private FixUpdateTimer objTimer; //Field offset: 0x10
	private FixUpdateTimer stepTimer; //Field offset: 0x18
	private FixUpdateTimer sceneObjTimer; //Field offset: 0x20
	private float m_LastMusicTick; //Field offset: 0x28
	private Dictionary<Int32, List`1<Int32>> m_MissMap; //Field offset: 0x30
	private int m_TnoIdx; //Field offset: 0x38
	private Coroutine m_ShowVictoryCoroutine; //Field offset: 0x40
	private Coroutine m_EndCoroutine; //Field offset: 0x48
	private int m_BlockNoDamageAirIndex; //Field offset: 0x50
	private int m_BlockNoDamageGroundIndex; //Field offset: 0x54
	private bool m_DevilDebuffFlag; //Field offset: 0x58
	private decimal m_CurTnoTime; //Field offset: 0x5C
	private bool m_IsVictoryShow; //Field offset: 0x6C
	private bool m_IsEnd; //Field offset: 0x6D
	private float m_Gap; //Field offset: 0x70
	public bool invoke; //Field offset: 0x74
	private decimal m_DoubleBlockGap; //Field offset: 0x78
	public List<Int32> catchHeadNotes; //Field offset: 0x88
	public List<Int32> catchNotes; //Field offset: 0x90
	public List<Int32> fingers; //Field offset: 0x98
	private float m_CurTime; //Field offset: 0xA0
	private float m_IntervalTime; //Field offset: 0xA4
	private bool m_IsTriggerHurt; //Field offset: 0xA8
	private float m_MulHitTime; //Field offset: 0xAC
	private float m_MulHitHardTime; //Field offset: 0xB0

	public decimal CurTnoTime
	{
		 get { } //Length: 11
	}

	public GameMusic() { }

	private void BattleEnd() { }

	private void Catch(TimeNodeOrder tno, int groundIndex, int airIndex, ref bool oneHint, bool roadCatch, bool airCatch) { }

	public void GameMusicFixTimerUpdate() { }

	public void GameMusicTimerUpdate() { }

	public decimal get_CurTnoTime() { }

	public int GetMusicIndexByGenTick(decimal genTick) { }

	public string GetNodePrefabName(int idx) { }

	private void InitEventTrigger() { }

	private void InitLyrithData() { }

	public void InitMusicData() { }

	private void InitTimer(decimal total) { }

	public void LoadMusicDataByFileName() { }

	private void LyrithLogic(ref decimal ts, int hp) { }

	public void ReleaseReferences() { }

	private void Reset() { }

	public void Run() { }

	public void SetSceneObjTimer(FixUpdateTimer timer) { }

	public void SetStepTimer(FixUpdateTimer timer) { }

	public void SetTimer(FixUpdateTimer timer) { }

	public void Stop() { }

	private void StopVictoryCoroutine() { }

	private void SuperBattlewornInsomniacAnimator(ref decimal ts) { }

	public void TimerStepTrigger(decimal ts) { }

	public void TimerTrigger(decimal ts) { }

}

