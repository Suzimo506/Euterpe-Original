namespace PeroTools2.Datas.Values;

[Extension]
public static class ValueUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Type, Boolean> <>9__14_0; //Field offset: 0x8
		public static Func<Type, Boolean> <>9__15_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <GetValueTypes>b__15_0(Type t) { }

		internal bool <GetVariableTypes>b__14_0(Type t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public MemberInfo[] memberInfos; //Field offset: 0x10

		public <>c__DisplayClass12_0() { }

		internal void <CreateSetResultDelegate>b__0(object v1, object v2) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public MemberInfo[] memberInfos; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal object <CreateGetResultDelegate>b__0(object v) { }

	}

	private static List<Type> s_VariableTypes; //Field offset: 0x0
	private static List<Type> s_ValueTypes; //Field offset: 0x8
	private static Dictionary<Type, Type> s_ResultTypes; //Field offset: 0x10
	private static readonly Dictionary<Type, Delegate> s_SetResultDelegates; //Field offset: 0x18
	private static readonly Dictionary<Type, Delegate> s_GetResultDelegates; //Field offset: 0x20

	private static ValueUtils() { }

	[Obsolete]
	internal static Delegate CreateGetResultDelegate(Type type) { }

	[Obsolete]
	internal static Delegate CreateSetResultDelegate(Type type) { }

	[Extension]
	public static void GenericNotify(IValue value, T result) { }

	[Extension]
	public static T Get(IValue value) { }

	[Extension]
	[Obsolete]
	public static object GetResult(IValue value) { }

	[Extension]
	[Obsolete]
	public static T GetResult(IValue value) { }

	internal static Dictionary<Type, Type> GetResultTypes() { }

	internal static KeyValuePair<Type, Type> GetTypePari(string typeName) { }

	internal static List<Type> GetValueTypes() { }

	internal static List<Type> GetVariableTypes() { }

	[Extension]
	public static void Observe(IValue value, Action<T> handler) { }

	[Extension]
	[Obsolete]
	public static void SetResult(IValue value, object result) { }

	[Extension]
	public static void Unobserve(IValue value, Action<T> handler) { }

}

