namespace Assets.Scripts.PeroTools.Managers;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class UIManager : Singleton<UIManager>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<CanvasScaler, Boolean> <>9__9_0; //Field offset: 0x8
		public static Comparison<GameObject> <>9__12_0; //Field offset: 0x10
		public static Func<GameObject, String> <>9__18_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal string <get_pnlNames>b__18_0(GameObject p) { }

		internal bool <get_rectTransform>b__9_0(CanvasScaler c) { }

		internal int <get_top>b__12_0(GameObject l, GameObject r) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public string n; //Field offset: 0x10

		public <>c__DisplayClass20_0() { }

		internal bool <get_Item>b__0(GameObject p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public GameObject go; //Field offset: 0x10

		public <>c__DisplayClass22_0() { }

		internal bool <Pop>b__0(GameObject g) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public GameObject go; //Field offset: 0x10
		public UIManager <>4__this; //Field offset: 0x18

		public <>c__DisplayClass25_0() { }

		internal void <InitEachScene>b__0(Event obj) { }

	}

	private EventSystem m_Es; //Field offset: 0x10
	private GameObject m_PreSelected; //Field offset: 0x18
	private List<GameObject> m_PnlGameObjects; //Field offset: 0x20
	private RectTransform m_RectTransform; //Field offset: 0x28
	[CompilerGenerated]
	private Camera <camera>k__BackingField; //Field offset: 0x30
	private readonly Stack<GameObject> m_InactiveStack; //Field offset: 0x38

	public private Camera camera
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public GameObject Item
	{
		 get { } //Length: 198
	}

	public GameObject peek
	{
		 get { } //Length: 81
	}

	public String[] pnlNames
	{
		 get { } //Length: 313
	}

	public RectTransform rectTransform
	{
		 get { } //Length: 460
	}

	public float scale
	{
		 get { } //Length: 46
	}

	public GameObject top
	{
		 get { } //Length: 346
	}

	public UIManager() { }

	[CompilerGenerated]
	private void <.ctor>b__24_0(Scene <p0>, Scene <p1>) { }

	private void AutoResetSelectedObj(float arg0) { }

	[CompilerGenerated]
	public Camera get_camera() { }

	public GameObject get_Item(string n) { }

	public GameObject get_peek() { }

	public String[] get_pnlNames() { }

	public RectTransform get_rectTransform() { }

	public float get_scale() { }

	public GameObject get_top() { }

	public void Init() { }

	private void InitEachScene() { }

	public void Pop(object pnlGO) { }

	public void Push(object pnlGO) { }

	[CompilerGenerated]
	private void set_camera(Camera value) { }

	public static void SetNull() { }

}

