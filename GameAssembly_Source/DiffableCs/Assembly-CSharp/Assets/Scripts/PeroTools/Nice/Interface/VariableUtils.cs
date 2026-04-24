namespace Assets.Scripts.PeroTools.Nice.Interface;

[Extension]
public static class VariableUtils
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public Type type; //Field offset: 0x10
		public Type resultType; //Field offset: 0x18

		public <>c__DisplayClass3_0() { }

		internal bool <CreateIValue>b__0(Type t) { }

		internal bool <CreateIValue>b__1(Type t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public Type type; //Field offset: 0x10
		public Type resultType; //Field offset: 0x18

		public <>c__DisplayClass4_0() { }

		internal bool <CreateIValue>b__0(Type t) { }

		internal bool <CreateIValue>b__1(Type t) { }

	}


	public static IValue CreateIValue(Type resultType) { }

	public static IValue CreateIValue(object result) { }

	[Extension]
	public static object Get(IVariable variable, string name) { }

	[Extension]
	public static object GetResult(IVariable data, Type type) { }

	[Extension]
	public static T GetResult(IVariable data) { }

	[Extension]
	public static void Set(IVariable variable, string name, object value) { }

	[Extension]
	public static void SetResult(IVariable data, object value) { }

}

