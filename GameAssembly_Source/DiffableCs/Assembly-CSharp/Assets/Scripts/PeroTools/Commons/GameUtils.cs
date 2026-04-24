namespace Assets.Scripts.PeroTools.Commons;

[Extension]
public static class GameUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Transform, Boolean> <>9__15_0; //Field offset: 0x8
		public static Func<Transform, GameObject> <>9__15_3; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <FindGameObjectsWithTag>b__15_0(Transform t) { }

		internal GameObject <FindGameObjectsWithTag>b__15_3(Transform t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__12
	{
		public static readonly <>c__12<T> <>9; //Field offset: 0x0
		public static Func<Transform, Boolean> <>9__12_0; //Field offset: 0x0

		private static <>c__12`1() { }

		public <>c__12`1() { }

		internal bool <FindObjectsByType>b__12_0(Transform t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__13
	{
		public static readonly <>c__13<T> <>9; //Field offset: 0x0
		public static Func<Transform, Boolean> <>9__13_0; //Field offset: 0x0

		private static <>c__13`1() { }

		public <>c__13`1() { }

		internal bool <FindObjectsOfType>b__13_0(Transform t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public GameObject gameObject; //Field offset: 0x10
		public bool includeInactive; //Field offset: 0x18
		public bool isTo; //Field offset: 0x19
		public Action<Component> <>9__1; //Field offset: 0x20

		public <>c__DisplayClass10_0() { }

		internal void <Enable>b__0(Type c) { }

		internal void <Enable>b__1(Component cpn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public List<GameObject> list; //Field offset: 0x10
		public string tag; //Field offset: 0x18
		public Func<Transform, Boolean> <>9__2; //Field offset: 0x20

		public <>c__DisplayClass15_0() { }

		internal void <FindGameObjectsWithTag>b__1(Transform transform) { }

		internal bool <FindGameObjectsWithTag>b__2(Transform t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public AnimatorStateInfo state; //Field offset: 0x10

		public <>c__DisplayClass27_0() { }

		internal bool <GetCurrentAnimName>b__0(AnimationClip a) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public Type[] types; //Field offset: 0x10
		public List<Component> components; //Field offset: 0x18
		public bool enabled; //Field offset: 0x20

		public <>c__DisplayClass8_0() { }

		internal void <EnableAllComponents>b__0(Component c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public bool isVisisble; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal void <SetVisible>b__0(Renderer r) { }

		internal void <SetVisible>b__1(SpriteRenderer s) { }

		internal void <SetVisible>b__2(Graphic s) { }

	}


	[Extension]
	public static void Enable(GameObject gameObject, bool isTo = true, bool includeInactive = true, Type[] components) { }

	[Extension]
	public static List<Component> EnableAllComponents(GameObject go, bool enabled = true, Type[] types) { }

	public static List<Component> EnableAllComponents(Component[] cs, bool enabled = true, Type[] types) { }

	private static void FindAllChilds(Transform tf, List<Transform> buffer, bool includeAllChild) { }

	public static List<GameObject> FindGameObjectsWithTag(string tag) { }

	public static T FindObjectOfType(Transform parent = null, bool includeInactive = true) { }

	public static List<T> FindObjectsByType(Transform parent = null, bool includeInactive = true) { }

	public static List<T> FindObjectsOfType(Transform parent = null, bool includeInactive = true) { }

	[Extension]
	public static List<T> GetAllComponents(GameObject go, bool inactive = true) { }

	[Extension]
	public static float GetAnimLength(Animator anim, string clipName) { }

	[Extension]
	public static bool GetChilds(GameObject go, List<Transform> buffer, bool clear = true, bool includeAllChild = false) { }

	[Extension]
	public static bool GetChilds(Transform tf, List<Transform> buffer, bool clear = true, bool includeAllChild = false) { }

	[Extension]
	public static int GetCurrentAnimHash(Animator animator) { }

	[Extension]
	public static string GetCurrentAnimName(Animator animator) { }

	public static T GetObject(object obj) { }

	[Extension]
	public static T GetObject(object obj) { }

	[Extension]
	public static object GetObject(object obj, string type) { }

	[Extension]
	public static Component GetOrAddComponent(GameObject gameObject, Type type) { }

	[Extension]
	public static T GetOrAddComponent(GameObject gameObject) { }

	[Extension]
	public static T GetOrAddComponent(Component cmp) { }

	[Extension]
	public static string GetPathInScene(Transform transform) { }

	[Extension]
	public static float GetTime(Animator animator) { }

	[Extension]
	public static bool IsComplete(Animator animator) { }

	[Extension]
	public static void SetEnable(Behaviour[] behaviours, bool enable) { }

	[Extension]
	public static void SetTime(Animator animator, float time) { }

	[Extension]
	public static void SetVisible(GameObject go, bool isVisisble) { }

	[Extension]
	public static void SortChildren(Transform t, Comparison<Transform> comparison, bool includeInActive = false) { }

	public static bool TryParse(string s, out Vector3 res) { }

	public static bool TryParse(string s, out Vector2 res) { }

}

