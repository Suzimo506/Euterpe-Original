namespace Assets.Scripts.PeroTools.Commons;

[Extension]
public static class ReflectionUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, MemberInfo>, Boolean> <>9__3_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<String, MemberInfo>, Boolean> <>9__3_1; //Field offset: 0x10
		public static Func<KeyValuePair`2<String, MemberInfo>, String> <>9__3_2; //Field offset: 0x18
		public static Func<Type, String> <>9__18_0; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal string <GetSubClassNameOf>b__18_0(Type t) { }

		internal bool <LimitMemeberInfo>b__3_0(KeyValuePair<String, MemberInfo> m) { }

		internal bool <LimitMemeberInfo>b__3_1(KeyValuePair<String, MemberInfo> m) { }

		internal string <LimitMemeberInfo>b__3_2(KeyValuePair<String, MemberInfo> m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public Type type; //Field offset: 0x10
		public Dictionary<String, MemberInfo> members; //Field offset: 0x18

		public <>c__DisplayClass1_0() { }

		internal void <GetTypeMemberNames>b__0(MemberInfo m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public Type type; //Field offset: 0x10
		public int num; //Field offset: 0x18

		public <>c__DisplayClass11_0() { }

		internal void <ArrayDepth>b__0(string mi) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public Type type; //Field offset: 0x10

		public <>c__DisplayClass17_0() { }

		internal bool <GetSubClassOf>b__0(Type t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public bool get; //Field offset: 0x10
		public bool set; //Field offset: 0x11
		public BindingFlags bf; //Field offset: 0x14
		public Dictionary<String, MemberInfo> members; //Field offset: 0x18
		public Func<MemberInfo, Boolean> predicate; //Field offset: 0x20

		public <>c__DisplayClass2_0() { }

		internal void <GetMemberNames>b__0(object obj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public Dictionary<String, MemberInfo> members; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal void <LimitMemeberInfo>b__3(string l) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public MemberInfo memberInfo; //Field offset: 0x10
		public object obj; //Field offset: 0x18
		public int idxsNum; //Field offset: 0x20
		public String[] idxs; //Field offset: 0x28

		public <>c__DisplayClass7_0() { }

		internal void <Reflect>b__0(string m) { }

	}

	internal class ReflectObject
	{
		public object sourceObject; //Field offset: 0x10
		public string reflectName; //Field offset: 0x18

		public ReflectObject() { }

	}


	public static int ArrayDepth(Type type, string path) { }

	public static Type GetElementType(Type type) { }

	public static string GetFuncName(object obj, string method) { }

	[Extension]
	public static Dictionary<String, MemberInfo> GetMemberNames(GameObject gameObject, bool get = true, bool set = true, Func<MemberInfo, Boolean> predicate = null) { }

	public static Type GetMemberType(MemberInfo memberInfo) { }

	public static String[] GetSubClassNameOf(Type type) { }

	public static Type[] GetSubClassOf(Type type) { }

	public static Dictionary<String, MemberInfo> GetTypeMemberNames(Type type, bool get = true, bool set = true, BindingFlags bf = 60) { }

	public static object GetValue(object sourceObj, string name, Object[] objs = null, BindingFlags bf = 52) { }

	public static bool IsArray(Type type) { }

	public static bool IsArrayFromType(Type t) { }

	public static bool IsClass(Type type) { }

	public static bool IsList(Type type) { }

	public static bool IsSubClassOf(Type type, Type baseType) { }

	public static Dictionary<String, MemberInfo> LimitMemeberInfo(Dictionary<String, MemberInfo> members, bool get, bool set) { }

	public static string NickNameToReflectName(string str) { }

	public static object Reflect(object obj, string path, String[] idxs) { }

	public static string Reflect(object sourceObj, string fieldName, Object[] idxs) { }

	public static string Reflect(ReflectObject reflectObj, Object[] idxs) { }

}

