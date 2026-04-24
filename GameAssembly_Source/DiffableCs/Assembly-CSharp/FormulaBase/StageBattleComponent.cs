namespace FormulaBase;

public class StageBattleComponent : Singleton<StageBattleComponent>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<TimeNodeOrder> <>9__38_0; //Field offset: 0x8
		public static Predicate<TimeNodeOrder> <>9__40_0; //Field offset: 0x10
		public static Action <>9__52_0; //Field offset: 0x18
		public static Action <>9__63_0; //Field offset: 0x20
		public static Predicate<IData> <>9__65_0; //Field offset: 0x28
		public static Action <>9__78_1; //Field offset: 0x30
		public static Action<GameObject> <>9__89_2; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal void <End>b__63_0() { }

		internal void <Exit>b__78_1() { }

		internal bool <get_curAirTimeNodeOrder>b__40_0(TimeNodeOrder t) { }

		internal bool <get_curTimeNodeOrder>b__38_0(TimeNodeOrder t) { }

		internal bool <Halloween>b__65_0(IData it) { }

		internal void <LoadMusicData>b__89_2(GameObject go) { }

		internal void <OnLoadComplete>b__52_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass59_0
	{
		public AudioSource bgm; //Field offset: 0x10
		public StageBattleComponent <>4__this; //Field offset: 0x18

		public <>c__DisplayClass59_0() { }

		internal void <FixedOffset>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass62_0
	{
		public StageBattleComponent <>4__this; //Field offset: 0x10
		public string filename; //Field offset: 0x18
		public Action<GameObject> callback; //Field offset: 0x20

		public <>c__DisplayClass62_0() { }

		internal void <AddObjAsync>b__0(GameObject obj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass78_0
	{
		public Action callback; //Field offset: 0x10
		public bool backToPnlStage; //Field offset: 0x18
		public StageBattleComponent <>4__this; //Field offset: 0x20
		public string loadingSceneName; //Field offset: 0x28
		public Action <>9__2; //Field offset: 0x30

		public <>c__DisplayClass78_0() { }

		internal void <Exit>b__0() { }

		internal void <Exit>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass89_0
	{
		public string ibmsId; //Field offset: 0x10
		public Predicate<String> <>9__0; //Field offset: 0x18

		public <>c__DisplayClass89_0() { }

		internal bool <LoadMusicData>b__0(string p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass89_1
	{
		public string prefab_name; //Field offset: 0x10

		public <>c__DisplayClass89_1() { }

		internal bool <LoadMusicData>b__1(NoteConfigData ncd) { }

	}

	[DecimalConstant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static readonly decimal add_end_time; //Field offset: 0x0
	private Hashtable m_PrefabCatchObj; //Field offset: 0x10
	private List<MusicData> m_MusicTickData; //Field offset: 0x18
	[CompilerGenerated]
	private bool <isPause>k__BackingField; //Field offset: 0x20
	private Dictionary<Int32, List`1<TimeNodeOrder>> m_TimeNodeOrders; //Field offset: 0x28
	public int musicStartTime; //Field offset: 0x30
	[CompilerGenerated]
	private int <lastTnoIndex>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private decimal <lastTnoTime>k__BackingField; //Field offset: 0x38
	public bool isInGame; //Field offset: 0x48
	public bool isDead; //Field offset: 0x49
	public string evaluate; //Field offset: 0x50
	public int evaluateNum; //Field offset: 0x58
	public float leastHpRate; //Field offset: 0x5C
	public float failTime; //Field offset: 0x60
	public bool unlockNextLevel; //Field offset: 0x64
	public bool isSucceed; //Field offset: 0x65
	public int rank; //Field offset: 0x68
	public int resizeAdd; //Field offset: 0x6C
	private List<ParticleSystem> m_ParticleSystems; //Field offset: 0x70
	public bool isSceneChangeType; //Field offset: 0x78
	private Coroutine m_MusicOffsetCoroutine; //Field offset: 0x80
	public readonly Dictionary<String, Int32> sceneInfo; //Field offset: 0x88
	public List<String> curSceneChangeType; //Field offset: 0x90
	private int m_Combo; //Field offset: 0x98
	public bool isNew; //Field offset: 0x9C
	private Coroutine m_DelayStartCoroutine; //Field offset: 0xA0
	[CompilerGenerated]
	private float <offset>k__BackingField; //Field offset: 0xA8
	private readonly TimeNodeOrder[] m_TmpTnos; //Field offset: 0xB0

	public TimeNodeOrder curAirTimeNodeOrder
	{
		 get { } //Length: 356
	}

	public TimeNodeOrder curTimeNodeOrder
	{
		 get { } //Length: 356
	}

	private int getMusicOffset
	{
		private get { } //Length: 428
	}

	public private bool isPause
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int lastTnoIndex
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private decimal lastTnoTime
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private float offset
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public long realTimeTick
	{
		 get { } //Length: 106
	}

	public float timeFromMusicStart
	{
		 get { } //Length: 123
	}

	public decimal timeFromMusicStartDecimal
	{
		 get { } //Length: 297
	}

	private static StageBattleComponent() { }

	public StageBattleComponent() { }

	[CompilerGenerated]
	private void <GameStart>b__72_0() { }

	private void ActivityReward(string musicUid, bool isHalloweenMap) { }

	public GameObject AddObj(string filename) { }

	public void AddObjAsync(string filename, Action<GameObject> callback) { }

	public void Dead() { }

	public void End() { }

	public void EnterGameBattle() { }

	public void Exit(string sceneName = "UISystem", Action callback = null, bool backToPnlStage = true) { }

	public void FindAllParticles() { }

	private void FixedMusicOffset(AudioSource bgm) { }

	public void FixedOffset() { }

	private void FoolHandler(List<MusicData> musicDatas) { }

	public void GameRestart() { }

	public void GameStart() { }

	public TimeNodeOrder get_curAirTimeNodeOrder() { }

	public TimeNodeOrder get_curTimeNodeOrder() { }

	private int get_getMusicOffset() { }

	[CompilerGenerated]
	public bool get_isPause() { }

	[CompilerGenerated]
	public int get_lastTnoIndex() { }

	[CompilerGenerated]
	public decimal get_lastTnoTime() { }

	[CompilerGenerated]
	public float get_offset() { }

	public long get_realTimeTick() { }

	public float get_timeFromMusicStart() { }

	public decimal get_timeFromMusicStartDecimal() { }

	public TimeNodeOrder[] GetAllTimeNodeByTick(decimal tick, out int count) { }

	public int GetCombo() { }

	public MusicData GetCurMusicData(bool isAir = false) { }

	public List<MusicData> GetMusicData() { }

	public MusicData GetMusicDataByIdx(int idx) { }

	private List<MusicData> GetMusicDataFromStageInfo(MusicInfo info) { }

	public string GetSceneName() { }

	public List<TimeNodeOrder> GetTimeNodeByTick(float tick) { }

	public List<TimeNodeOrder> GetTimeNodeByTick(decimal tick) { }

	public float GetTimeProgress() { }

	private bool Halloween(bool isRun, int getCount, int targetCount) { }

	public void InitData() { }

	public void InitGame() { }

	private void InitTimeNodeOrder() { }

	private void Load() { }

	private void LoadMusicData() { }

	public void OnFocusChangePauseGame() { }

	public void OnFocusChangePauseGame(bool focus) { }

	private void OnLoadComplete() { }

	public void Pause(bool pauseCorountine = true) { }

	private void PlayMusic(string musicPath, MusicInfo musicInfo = null) { }

	private void PreloadAudioSfx() { }

	private void Private_InitData() { }

	private void Release() { }

	public static void ReleaseReferences() { }

	private void ResetAll() { }

	public void Resume(bool isExit = false) { }

	[CompilerGenerated]
	private void set_isPause(bool value) { }

	[CompilerGenerated]
	private void set_lastTnoIndex(int value) { }

	[CompilerGenerated]
	private void set_lastTnoTime(decimal value) { }

	[CompilerGenerated]
	private void set_offset(float value) { }

	public void SetCombo(int combo, bool addCount = true) { }

	public void SetMusicData(MusicData md) { }

	private void SetSpecialSwitch() { }

	private void StopResumeCoroutine() { }

	private void UnregBattleEvent() { }

}

