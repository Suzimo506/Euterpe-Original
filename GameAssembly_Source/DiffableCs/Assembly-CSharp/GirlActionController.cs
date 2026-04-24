//Type is in global namespace

public class GirlActionController : BaseSpineObjectController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static TweenCallback <>9__49_1; //Field offset: 0x8
		public static Action <>9__53_0; //Field offset: 0x10
		public static Action <>9__53_1; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal void <AttackQuick>b__53_0() { }

		internal void <AttackQuick>b__53_1() { }

		internal void <GhostDisappear>b__49_1() { }

	}

	[CompilerGenerated]
	private static GirlActionController <instance>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private SpineActionController <spineActionCtrl>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private Material[] <ghostMtrl>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private Animation <ghostAnimation>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private ParticleSystem <ghostParticles>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private Animator <ghostAnimator>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private SkeletonAnimation <ghostSk>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private GameObject <go>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private Animator <animator>k__BackingField; //Field offset: 0x88
	private Tweener[] m_GhostDisapparTwn; //Field offset: 0x90
	private Sequence m_GhostDisapparSeq; //Field offset: 0x98

	public private Animator animator
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public private Animation ghostAnimation
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private Animator ghostAnimator
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private Material[] ghostMtrl
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private ParticleSystem ghostParticles
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private SkeletonAnimation ghostSk
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private GameObject go
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private static GirlActionController instance
	{
		[CompilerGenerated]
		 get { } //Length: 53
		[CompilerGenerated]
		private set { } //Length: 66
	}

	public private SpineActionController spineActionCtrl
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	private void __Attack(string actKey, uint result) { }

	public GirlActionController() { }

	[CompilerGenerated]
	private void <GhostDisappear>b__49_0() { }

	public void Attack(string actKey, uint result) { }

	public void AttackQuick(string actKey, uint result, int id = -1) { }

	public virtual bool ControllerMissCheck(int idx, decimal currentTick) { }

	[CompilerGenerated]
	public Animator get_animator() { }

	[CompilerGenerated]
	public Animation get_ghostAnimation() { }

	[CompilerGenerated]
	public Animator get_ghostAnimator() { }

	[CompilerGenerated]
	public Material[] get_ghostMtrl() { }

	[CompilerGenerated]
	public ParticleSystem get_ghostParticles() { }

	[CompilerGenerated]
	public SkeletonAnimation get_ghostSk() { }

	[CompilerGenerated]
	public GameObject get_go() { }

	[CompilerGenerated]
	public static GirlActionController get_instance() { }

	[CompilerGenerated]
	public SpineActionController get_spineActionCtrl() { }

	private void GhostAttack(uint result, int id) { }

	public void GhostDisappear(float dt = 0.3) { }

	private void GhostSetPause(bool pause) { }

	public virtual void Init(int scene) { }

	private void InvokeGhostAttack(bool hitStart, bool ghostAir, uint result) { }

	private string JumpAttack(string atkName, uint result, int id = -1) { }

	public virtual void OnControllerAttacked(int result, bool isDeaded) { }

	public virtual bool OnControllerMiss(int idx) { }

	public virtual void OnControllerStart() { }

	private void OnFail() { }

	public virtual void Pause(bool pauseCorountine) { }

	public static void ReleaseReferences() { }

	public virtual void Resume() { }

	[CompilerGenerated]
	private void set_animator(Animator value) { }

	[CompilerGenerated]
	private void set_ghostAnimation(Animation value) { }

	[CompilerGenerated]
	private void set_ghostAnimator(Animator value) { }

	[CompilerGenerated]
	private void set_ghostMtrl(Material[] value) { }

	[CompilerGenerated]
	private void set_ghostParticles(ParticleSystem value) { }

	[CompilerGenerated]
	private void set_ghostSk(SkeletonAnimation value) { }

	[CompilerGenerated]
	private void set_go(GameObject value) { }

	[CompilerGenerated]
	private static void set_instance(GirlActionController value) { }

	[CompilerGenerated]
	private void set_spineActionCtrl(SpineActionController value) { }

	public virtual void SetIdx(int idx) { }

}

