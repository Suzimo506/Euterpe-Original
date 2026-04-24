namespace PeroTools2.Datas.Variables;

[Extension]
public static class VariableUtils
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public IVariable variable; //Field offset: 0x10
		public IValue iValue; //Field offset: 0x18
		public Type type; //Field offset: 0x20

		public <>c__DisplayClass4_0() { }

		internal void <GetValue>b__0(IVariable var) { }

	}


	internal static IValue CreateValue(Type resultType) { }

	internal static IValue CreateValue(object result, Type valueType = null) { }

	[Extension]
	public static object GetResult(IVariable variable) { }

	[Extension]
	public static T GetResult(IVariable variable) { }

	[Extension]
	public static IValue GetValue(IVariable variable) { }

	[Extension]
	internal static IValue GetValue(IVariable variable, IValue iValue, object result, Type type) { }

	[Extension]
	public static void SetResult(IVariable variable, object result) { }

}

