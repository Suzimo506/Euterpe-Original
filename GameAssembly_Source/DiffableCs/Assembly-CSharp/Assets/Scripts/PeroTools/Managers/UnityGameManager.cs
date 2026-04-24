namespace Assets.Scripts.PeroTools.Managers;

[ExecuteInEditMode]
public class UnityGameManager : SingletonMonoBehaviour<UnityGameManager>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public string uid; //Field offset: 0x10

		public <>c__DisplayClass20_0() { }

		internal bool <RegLoop>b__0(Looper l) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public string uid; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal bool <UnregLoop>b__0(Looper l) { }

		internal bool <UnregLoop>b__1(Looper l) { }

		internal bool <UnregLoop>b__2(Looper l) { }

	}

	internal class Looper
	{
		public const float infinite = 3.4028235E+38; //Field offset: 0x0
		[CompilerGenerated]
		private string <uid>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private LoopType <type>k__BackingField; //Field offset: 0x18
		public bool isPause; //Field offset: 0x1C
		private readonly UnityAction<Single> m_Action; //Field offset: 0x20
		private readonly float m_LoopTime; //Field offset: 0x28
		private float m_RunTime; //Field offset: 0x2C
		private readonly float m_DeltaTime; //Field offset: 0x30

		public bool isActive
		{
			 get { } //Length: 13
		}

		public private LoopType type
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private string uid
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public Looper(string u, UnityAction<Single> a, LoopType t, float time = 3.4028235E+38) { }

		public bool get_isActive() { }

		[CompilerGenerated]
		public LoopType get_type() { }

		[CompilerGenerated]
		public string get_uid() { }

		public void Loop() { }

		[CompilerGenerated]
		private void set_type(LoopType value) { }

		[CompilerGenerated]
		private void set_uid(string value) { }

	}

	internal enum LoopType
	{
		Update = 0,
		FixedUpdate = 1,
		LateUpdate = 2,
	}

	public const string touches = "Touches"; //Field offset: 0x0
	public const string keys = "Keys"; //Field offset: 0x0
	public const string showFps = "ShowFps"; //Field offset: 0x0
	public const string updateTimers = "UpdateTimers"; //Field offset: 0x0
	public const string fixedTimer = "FixedTimers"; //Field offset: 0x0
	[CompilerGenerated]
	private Action onApplicationQuit; //Field offset: 0x18
	[CompilerGenerated]
	private Action<Boolean> onApplicationFocusChange; //Field offset: 0x20
	private readonly List<Looper> m_UpdateLoops; //Field offset: 0x28
	private readonly List<Looper> m_FixedLoops; //Field offset: 0x30
	private readonly List<Looper> m_LateLoops; //Field offset: 0x38
	private Looper m_LoopFixedUpdate; //Field offset: 0x40
	private Looper m_LoopUpdate; //Field offset: 0x48
	private Looper m_UnregLooper; //Field offset: 0x50

	public event Action<Boolean> onApplicationFocusChange
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action onApplicationQuit
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public Transform persistenceRoot
	{
		 get { } //Length: 7
	}

	public UnityGameManager() { }

	[CompilerGenerated]
	public void add_onApplicationFocusChange(Action<Boolean> value) { }

	[CompilerGenerated]
	public void add_onApplicationQuit(Action value) { }

	private void FixedUpdate() { }

	public Transform get_persistenceRoot() { }

	private void Init() { }

	private void LateUpdate() { }

	public void LoopFixedUpdate() { }

	public void LoopLateUpdate() { }

	public void LoopUpdate() { }

	private void OnApplicationFocus(bool hasFocus) { }

	private void OnApplicationQuit() { }

	public Looper RegLoop(UnityAction<Single> action, LoopType type = 1, float loopTime = 3.4028235E+38) { }

	public Looper RegLoop(string uid, UnityAction<Single> action, LoopType type = 1, float loopTime = 3.4028235E+38) { }

	[CompilerGenerated]
	public void remove_onApplicationFocusChange(Action<Boolean> value) { }

	[CompilerGenerated]
	public void remove_onApplicationQuit(Action value) { }

	public void UnregLoop(string uid) { }

	private void Update() { }

}

