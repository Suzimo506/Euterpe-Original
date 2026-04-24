namespace PeroTools2.Commons;

[Extension]
public static class GameUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Transform, Boolean> <>9__9_0; //Field offset: 0x8
		public static Func<Transform, GameObject> <>9__9_2; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <FindGameObjectsWithTag>b__9_0(Transform t) { }

		internal GameObject <FindGameObjectsWithTag>b__9_2(Transform t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__7
	{
		public static readonly <>c__7<T> <>9; //Field offset: 0x0
		public static Func<Transform, Boolean> <>9__7_0; //Field offset: 0x0

		private static <>c__7`1() { }

		public <>c__7`1() { }

		internal bool <FindObjectsOfType>b__7_0(Transform t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public AnimatorStateInfo state; //Field offset: 0x10

		public <>c__DisplayClass20_0() { }

		internal bool <GetCurrentAnimName>b__0(AnimationClip a) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public string tag; //Field offset: 0x10
		public Func<Transform, Boolean> <>9__1; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal bool <FindGameObjectsWithTag>b__1(Transform t) { }

	}


	public static Sprite CreateSpriteFromTexture(Texture2D texture) { }

	[Extension]
	public static void Enable(GameObject gameObject, bool isTo = true, bool includeInactive = true, Type[] components) { }

	public static List<Component> EnableAllComponents(Component[] cs, bool enabled = true, Type[] types) { }

	public static List<GameObject> FindGameObjectsWithTag(string tag) { }

	public static T FindObjectOfType(Transform parent = null, bool includeInactive = true) { }

	public static List<T> FindObjectsOfType(Transform parent = null, bool includeInactive = true) { }

	[Extension]
	public static string GetCurrentAnimName(Animator animator) { }

	[Extension]
	public static object GetObject(object obj, Type type) { }

	[Extension]
	public static T GetObject(object obj) { }

	public static T GetObject(object obj) { }

	[Extension]
	public static Component GetOrAddComponent(GameObject gameObject, Type type) { }

	[Extension]
	public static T GetOrAddComponent(GameObject gameObject) { }

	[Extension]
	public static T GetOrAddComponent(Component cmp) { }

	[Extension]
	public static string GetPathInScene(Transform transform, Transform parent = null) { }

	[Extension]
	public static float GetTime(Animator animator) { }

	[Extension]
	public static bool IsComplete(Animator animator) { }

	[Extension]
	public static void SetTime(Animator animator, float time) { }

	[Extension]
	public static void SetVisible(GameObject go, bool isVisisble) { }

	[Extension]
	public static void SortChildren(Transform t, Comparison<Transform> comparison, bool includeInActive = false) { }

	public static bool TryParse(string s, out Vector2 res) { }

	public static bool TryParse(string s, out Vector3 res) { }

}

