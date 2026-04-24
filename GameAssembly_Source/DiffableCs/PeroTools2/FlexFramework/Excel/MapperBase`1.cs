namespace FlexFramework.Excel;

public abstract class MapperBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0
		public static Func<MemberInfo, Mapping> <>9__6_0; //Field offset: 0x0
		public static Func<Mapping, Boolean> <>9__11_0; //Field offset: 0x0
		public static Action<Mapping> <>9__19_0; //Field offset: 0x0
		public static Action<Mapping> <>9__20_0; //Field offset: 0x0
		public static Func<Mapping, Boolean> <>9__21_0; //Field offset: 0x0
		public static Func<Mapping, MemberInfo> <>9__21_1; //Field offset: 0x0
		public static Action<Mapping> <>9__21_2; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal Mapping <.ctor>b__6_0(MemberInfo m) { }

		internal bool <Cast>b__11_0(Mapping m) { }

		internal void <Clear>b__19_0(Mapping m) { }

		internal void <Copy>b__20_0(Mapping m) { }

		internal bool <Instantiate>b__21_0(Mapping m) { }

		internal MemberInfo <Instantiate>b__21_1(Mapping m) { }

		internal void <Instantiate>b__21_2(Mapping m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public string member; //Field offset: 0x0

		public <>c__DisplayClass12_0() { }

		internal bool <Map>b__0(Mapping m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public string member; //Field offset: 0x0

		public <>c__DisplayClass13_0() { }

		internal bool <Map>b__0(Mapping m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public string member; //Field offset: 0x0

		public <>c__DisplayClass18_0() { }

		internal bool <Remove>b__0(Mapping m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public Mapping source; //Field offset: 0x0

		public <>c__DisplayClass20_0() { }

		internal bool <Copy>b__1(Mapping m) { }

	}

	[CompilerGenerated]
	private sealed class <Cast>d__11 : IEnumerable<Object>, IEnumerable, IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private object <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		public MapperBase<T> <>4__this; //Field offset: 0x0
		private Row row; //Field offset: 0x0
		public Row <>3__row; //Field offset: 0x0
		private IEnumerator<Mapping> <>7__wrap1; //Field offset: 0x0

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <Cast>d__11(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	protected readonly Mapping[] mappings; //Field offset: 0x0
	protected readonly Type type; //Field offset: 0x0
	[CompilerGenerated]
	private bool <SafeMode>k__BackingField; //Field offset: 0x0

	public bool SafeMode
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected MapperBase`1(Type type) { }

	protected override void Assign(object obj, MemberInfo[] members, Object[] data) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected IEnumerable<Object> Cast(Row row) { }

	public T Clear() { }

	public T Copy(T mapping) { }

	protected override object CreateInstance() { }

	public override void Extract() { }

	[CompilerGenerated]
	public bool get_SafeMode() { }

	protected override MemberInfo[] GetMembers() { }

	protected object Instantiate(Row row) { }

	public T Map(string member, string column) { }

	public T Map(string member, string column, object default) { }

	public T Map(string expression) { }

	public T Map(IEnumerable<Cell> row) { }

	public T Map(string member, int column, object default) { }

	public T Map(string member, int column) { }

	public T Remove(string member) { }

	[CompilerGenerated]
	public void set_SafeMode(bool value) { }

}

