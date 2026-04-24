//Type is in global namespace

public abstract class BaseEnemyObjectController : BaseSpineObjectController, IUpdate
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__29_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <OnControllerAttacked>b__29_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public BaseEnemyObjectController <>4__this; //Field offset: 0x10
		public TrackEntry track; //Field offset: 0x18

		public <>c__DisplayClass28_0() { }

		internal void <EnemySkAnimInit>b__0() { }

	}

	public const string POINT_CENTER = "pc"; //Field offset: 0x0
	private static String[] listResultMap; //Field offset: 0x0
	[SerializeField]
	public bool attackedDoNothing; //Field offset: 0x50
	private SpineMountController m_SpineMountController; //Field offset: 0x58
	protected SkeletonAnimation m_SkeletonAnimation; //Field offset: 0x60
	private GameObject m_CatchObj; //Field offset: 0x68
	protected MusicData m_MusicData; //Field offset: 0x70
	private int m_HpAdd; //Field offset: 0x1C8
	private SkeletonAnimation m_BloodAnimtion; //Field offset: 0x1D0
	private float m_ShowTick; //Field offset: 0x1D8
	private bool m_HasMiss; //Field offset: 0x1DC
	protected uint m_NodeType; //Field offset: 0x1E0
	protected bool m_IsBeAttacked; //Field offset: 0x1E4
	private bool m_HasDjmax; //Field offset: 0x1E5
	private bool m_HasNoteResult; //Field offset: 0x1E6
	public int nextNoteResult; //Field offset: 0x1E8
	protected bool m_IsBoom; //Field offset: 0x1EC
	private bool m_ReleaseFlag; //Field offset: 0x1ED

	public override LoopType LoopType
	{
		 get { } //Length: 6
	}

	private bool __OnControllerMiss(int idx) { }

	private static BaseEnemyObjectController() { }

	protected BaseEnemyObjectController() { }

	[CompilerGenerated]
	private void <OnControllerStart>b__26_0() { }

	[CompilerGenerated]
	private void <OnTouhouFever>b__40_0() { }

	public void AttackedSuccessful(uint result, bool isDead = true) { }

	public virtual bool ControllerMissCheck(int i, decimal currentTick) { }

	private void DjmaxInit() { }

	private void EnableVisible() { }

	private void EnemySkAnimInit() { }

	public override LoopType get_LoopType() { }

	private float GetSkeletonAnimShowDistance() { }

	public virtual void Init(int scene) { }

	public override bool IsShotPause() { }

	private void MakeBlood() { }

	private void NoteDisappearLogic(object sender, object reciever, Object[] args) { }

	public void OnBossIn(object sender, object rev, Object[] args) { }

	public void OnBossOut(object sender, object rev, Object[] args) { }

	public virtual void OnControllerAttacked(int result, bool isDeaded) { }

	public virtual bool OnControllerMiss(int idx) { }

	public virtual void OnControllerStart() { }

	public void OnTouhouFever(object sender, object rev, Object[] args) { }

	public override void OnUpdate() { }

	public virtual void Pause(bool pauseCorountine) { }

	protected override void Release() { }

	protected override void ReleaseEvent() { }

	public virtual void Resume() { }

	public virtual void SetIdx(int idx) { }

	public override void SetShotPause(decimal tick) { }

}

