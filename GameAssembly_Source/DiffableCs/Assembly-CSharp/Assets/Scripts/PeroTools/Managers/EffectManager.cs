namespace Assets.Scripts.PeroTools.Managers;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class EffectManager : Singleton<EffectManager>, IPause
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public EffectManager <>4__this; //Field offset: 0x10
		public int preload; //Field offset: 0x18
		public int capacity; //Field offset: 0x1C
		public Transform parent; //Field offset: 0x20

		public <>c__DisplayClass11_0() { }

		internal void <Preload>b__0(string preloadEffect) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public EffectManager <>4__this; //Field offset: 0x10
		public int preload; //Field offset: 0x18
		public int capacity; //Field offset: 0x1C
		public Transform parent; //Field offset: 0x20

		public <>c__DisplayClass12_0() { }

		internal void <Preload>b__0(GameObject go) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public string uid; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal bool <get_Item>b__0(Effect e) { }

	}

	private readonly List<Effect> m_Effects; //Field offset: 0x10
	private GameObject m_Center; //Field offset: 0x18

	public GameObject center
	{
		 get { } //Length: 152
	}

	public override bool IsGlobal
	{
		 get { } //Length: 3
	}

	public Effect Item
	{
		 get { } //Length: 180
	}

	public EffectManager() { }

	[CompilerGenerated]
	private void <Init>b__1_0(Scene scene1, Scene scene2) { }

	public GameObject get_center() { }

	public override bool get_IsGlobal() { }

	public Effect get_Item(string uid) { }

	private void Init() { }

	public override void Pause(bool pauseCorountine) { }

	public GameObject Play(string uid, int preload = 5, int capacity = -1, Transform parent = null) { }

	public GameObject Play(GameObject go, int preload = 5, int capacity = -1, Transform parent = null) { }

	public void Preload(String[] preloadUids, int preload = 5, int capacity = -1, Transform parent = null) { }

	public void Preload(GameObject[] gos, int preload = 5, int capacity = -1, Transform parent = null) { }

	public Effect Preload(GameObject go, int preload = 5, int capacity = -1, Transform parent = null) { }

	public Effect Preload(string uid, int preload = 5, int capacity = -1, Transform parent = null) { }

	public override void Resume() { }

	public void Unload(string uid) { }

	public void Unload(Effect effect) { }

	public void UnloadAll() { }

}

