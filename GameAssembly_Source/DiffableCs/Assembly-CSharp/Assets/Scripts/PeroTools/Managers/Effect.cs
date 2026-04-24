namespace Assets.Scripts.PeroTools.Managers;

public class Effect
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<DOTweenAnimation> <>9__25_1; //Field offset: 0x8
		public static Func<DOTweenAnimation, Boolean> <>9__25_2; //Field offset: 0x10
		public static Func<DOTweenAnimation, Single> <>9__25_3; //Field offset: 0x18
		public static Func<ParticleSystem, Boolean> <>9__25_4; //Field offset: 0x20
		public static Func<Keyframe, Single> <>9__25_13; //Field offset: 0x28
		public static Func<Keyframe, Single> <>9__25_14; //Field offset: 0x30
		public static Func<Keyframe, Single> <>9__25_15; //Field offset: 0x38
		public static Func<ParticleSystem, Single> <>9__25_5; //Field offset: 0x40
		public static Func<Animator, Boolean> <>9__25_6; //Field offset: 0x48
		public static Func<Animator, Single> <>9__25_7; //Field offset: 0x50
		public static Func<Animation, Boolean> <>9__25_8; //Field offset: 0x58
		public static Func<Animation, Single> <>9__25_9; //Field offset: 0x60
		public static Func<SkeletonAnimation, Boolean> <>9__25_10; //Field offset: 0x68
		public static Func<SkeletonAnimation, Single> <>9__25_11; //Field offset: 0x70
		public static Comparison<Single> <>9__25_12; //Field offset: 0x78

		private static <>c() { }

		public <>c() { }

		internal void <Init>b__25_1(DOTweenAnimation t) { }

		internal bool <Init>b__25_10(SkeletonAnimation sa) { }

		internal float <Init>b__25_11(SkeletonAnimation sa) { }

		internal int <Init>b__25_12(float l, float r) { }

		internal float <Init>b__25_13(Keyframe k) { }

		internal float <Init>b__25_14(Keyframe k) { }

		internal float <Init>b__25_15(Keyframe k) { }

		internal bool <Init>b__25_2(DOTweenAnimation d) { }

		internal float <Init>b__25_3(DOTweenAnimation d) { }

		internal bool <Init>b__25_4(ParticleSystem p) { }

		internal float <Init>b__25_5(ParticleSystem p) { }

		internal bool <Init>b__25_6(Animator a) { }

		internal float <Init>b__25_7(Animator a) { }

		internal bool <Init>b__25_8(Animation a) { }

		internal float <Init>b__25_9(Animation a) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public Effect <>4__this; //Field offset: 0x10
		public GameObject gameObject; //Field offset: 0x18

		public <>c__DisplayClass18_0() { }

		internal void <CreateInstance>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public SkeletonAnimation sa; //Field offset: 0x10

		public <>c__DisplayClass25_0() { }

		internal bool <Init>b__16(Animation a) { }

	}

	[CompilerGenerated]
	private string <uid>k__BackingField; //Field offset: 0x10
	public float dieTime; //Field offset: 0x18
	[CompilerGenerated]
	private FastPool <pool>k__BackingField; //Field offset: 0x20
	public bool isAutoDestroy; //Field offset: 0x28
	private List<GameObject> m_GameObjects; //Field offset: 0x30
	private readonly Dictionary<GameObject, ParticleSystem[]> m_Pars; //Field offset: 0x38
	private readonly Dictionary<GameObject, DOTweenAnimation[]> m_Tweens; //Field offset: 0x40
	private readonly Dictionary<GameObject, Animator[]> m_Animators; //Field offset: 0x48
	private readonly Dictionary<GameObject, Animation[]> m_Animations; //Field offset: 0x50
	private readonly Dictionary<GameObject, SkeletonAnimation[]> m_SAnimations; //Field offset: 0x58
	private readonly Dictionary<GameObject, Sequence> m_DestroySeqs; //Field offset: 0x60

	public private FastPool pool
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private string uid
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public Effect(GameObject go, int preload, int capacity = -1, Transform parent = null) { }

	public Effect(string u, int preload, int capacity = -1, Transform parent = null) { }

	[CompilerGenerated]
	private void <Init>b__25_0(GameObject gameObject) { }

	public void Clear() { }

	public GameObject CreateInstance() { }

	private void FastDestroy(GameObject go) { }

	[CompilerGenerated]
	public FastPool get_pool() { }

	[CompilerGenerated]
	public string get_uid() { }

	private void Init() { }

	public void Pause() { }

	public void Reset(GameObject go) { }

	public void Resume() { }

	[CompilerGenerated]
	private void set_pool(FastPool value) { }

	[CompilerGenerated]
	private void set_uid(string value) { }

}

