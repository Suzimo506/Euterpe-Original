namespace Sirenix.Utilities;

[Extension]
public static class DelegateExtensions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public bool hasValue; //Field offset: 0x0
		public TResult value; //Field offset: 0x0
		public Func<TResult> getValue; //Field offset: 0x0

		public <>c__DisplayClass0_0`1() { }

		internal TResult <Memoize>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public Dictionary<T, TResult> dic; //Field offset: 0x0
		public Func<T, TResult> func; //Field offset: 0x0

		public <>c__DisplayClass1_0`2() { }

		internal TResult <Memoize>b__0(T n) { }

	}


	[Extension]
	public static Func<TResult> Memoize(Func<TResult> getValue) { }

	[Extension]
	public static Func<T, TResult> Memoize(Func<T, TResult> func) { }

}

