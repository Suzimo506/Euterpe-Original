namespace Assets.Scripts.GameCore.HostComponent;

public class TaskStageTarget : Singleton<TaskStageTarget>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MusicData, Boolean> <>9__29_0; //Field offset: 0x8
		public static Func<MusicData, Boolean> <>9__29_1; //Field offset: 0x10
		public static Func<MusicData, Boolean> <>9__29_2; //Field offset: 0x18
		public static Func<MusicData, Boolean> <>9__30_0; //Field offset: 0x20
		public static Func<MusicData, Boolean> <>9__30_1; //Field offset: 0x28
		public static Func<MusicData, Boolean> <>9__30_2; //Field offset: 0x30
		public static Func<MusicData, Boolean> <>9__73_0; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal bool <GetTotalNum>b__73_0(MusicData m) { }

		internal bool <GetTrueAccuracy>b__29_0(MusicData m) { }

		internal bool <GetTrueAccuracy>b__29_1(MusicData m) { }

		internal bool <GetTrueAccuracy>b__29_2(MusicData m) { }

		internal bool <GetTrueAccuracyNew>b__30_0(MusicData m) { }

		internal bool <GetTrueAccuracyNew>b__30_1(MusicData m) { }

		internal bool <GetTrueAccuracyNew>b__30_2(MusicData m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass73_0
	{
		public uint noteType; //Field offset: 0x10

		public <>c__DisplayClass73_0() { }

		internal bool <GetTotalNum>b__1(MusicData m) { }

	}

	private int m_EnergyCount; //Field offset: 0x10
	private int m_MusicCount; //Field offset: 0x14
	private int m_HitCount; //Field offset: 0x18
	private int m_LongPressCount; //Field offset: 0x1C
	private int m_MaxCombo; //Field offset: 0x20
	private int m_Score; //Field offset: 0x24
	private int m_Block; //Field offset: 0x28
	private int m_Blood; //Field offset: 0x2C
	private int m_LongPressHitCount; //Field offset: 0x30
	private int m_HitEnemy; //Field offset: 0x34
	private int m_BossNearHit; //Field offset: 0x38
	private int m_HurtMiss; //Field offset: 0x3C
	private int m_MissCombo; //Field offset: 0x40
	private int m_Recover; //Field offset: 0x44
	private int m_MaxDamage; //Field offset: 0x48
	private int m_Damage; //Field offset: 0x4C
	private int m_HideNote; //Field offset: 0x50
	private int m_RedPoint; //Field offset: 0x54
	private int m_BluePoint; //Field offset: 0x58
	private int m_MissResult; //Field offset: 0x5C
	private int m_CoolResult; //Field offset: 0x60
	private int m_GreatResult; //Field offset: 0x64
	private int m_PerfectResult; //Field offset: 0x68
	private int m_JumpOverResult; //Field offset: 0x6C
	private int m_FeverResult; //Field offset: 0x70

	public TaskStageTarget() { }

	public void AddBlock(int value) { }

	public void AddBlood(int value) { }

	public void AddBossNearHit(int value) { }

	public void AddComboMax(int value) { }

	public void AddComboMiss(int value) { }

	private void AddCount(uint result, int value) { }

	public void AddDamageMax(int value) { }

	public void AddEnergyItemCount(int value) { }

	public void AddHideNodeCount(int value) { }

	public void AddHitCount(ref MusicData md, bool isDouble = false) { }

	public void AddHitCount(TaskCount countType, int value) { }

	public void AddHitEnemy(int value) { }

	public void AddLongPressFinishCount(int value) { }

	public void AddLongPressHit(int value) { }

	public void AddMiss(int value) { }

	public void AddNoteItemCount(int value) { }

	public void AddScore(int value, int id, string noteType, bool isAir, float time = -1) { }

	public float GetAccuracy() { }

	public int GetAddScore() { }

	public int GetBlock() { }

	public int GetBlood() { }

	public int GetBossNearHit() { }

	public int GetComboMax() { }

	public int GetComboMiss() { }

	public int GetCountValue(TaskCount taskType) { }

	public int GetEnergyItemCount() { }

	public int GetHideNoteHitCount() { }

	public int GetHitCount() { }

	public int GetHitCountByResult(uint result) { }

	public int GetHitCountByResult(TaskResult result) { }

	public int GetHitEnemy() { }

	public float GetHitPercent(uint result) { }

	public int GetLongPressFinishCount() { }

	public int GetLongPressHit() { }

	public int GetMiss() { }

	public int GetNoteItemCount() { }

	public int GetRecover() { }

	public int GetScore() { }

	public KeyValuePair<String, Int32> GetStageEvaluate() { }

	public int GetTotalNum(uint noteType = 4294967295) { }

	[Obsolete]
	public float GetTrueAccuracy() { }

	public float GetTrueAccuracyNew() { }

	private void InvokeJudgeEvent(uint result) { }

	[Obsolete]
	public bool IsAll(String[] ibmsId, byte result) { }

	public bool IsAll(BmsNodeUid[] ibmsId, byte result) { }

	public bool IsFullCombo() { }

	public void SetPlayResult(int idx, uint result, bool isMulEnd = false) { }

	public void SetRecover(int value) { }

	public void TriggerNoteMiss() { }

}

