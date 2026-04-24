namespace System.Linq.Expressions.Interpreter;

internal class LightLambda
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass74_0
	{
		public MethodInfo targetMethod; //Field offset: 0x10
		public Type delegateType; //Field offset: 0x18

		public <>c__DisplayClass74_0() { }

		internal Delegate <MakeRunDelegateCtor>b__0(LightLambda lambda) { }

	}

	private static readonly CacheDict<Type, Func`2<LightLambda, Delegate>> _runCache; //Field offset: 0x0
	private readonly IStrongBox[] _closure; //Field offset: 0x10
	private readonly Interpreter _interpreter; //Field offset: 0x18
	private readonly LightDelegateCreator _delegateCreator; //Field offset: 0x20

	private static LightLambda() { }

	internal LightLambda(LightDelegateCreator delegateCreator, IStrongBox[] closure) { }

	private Delegate CreateCustomDelegate(Type delegateType) { }

	private static Func<LightLambda, Delegate> GetRunDelegateCtor(Type delegateType) { }

	internal Delegate MakeDelegate(Type delegateType) { }

	private InterpretedFrame MakeFrame() { }

	private static Func<LightLambda, Delegate> MakeRunDelegateCtor(Type delegateType) { }

	public object Run(Object[] arguments) { }

	public object RunVoid(Object[] arguments) { }

	internal void RunVoid0() { }

	internal void RunVoidRef2(ref T0 arg0, ref T1 arg1) { }

}

