namespace Sirenix.Serialization;

public static class FormatterLocator
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x68400

		private static <>c() { }

		public <>c() { }

		internal int <.cctor>b__7_0(FormatterInfo a, FormatterInfo b) { }

		internal int <.cctor>b__7_1(FormatterLocatorInfo a, FormatterLocatorInfo b) { }

	}

	[CompilerGenerated]
	private sealed class <GetAllPossibleMissingAOTTypes>d__14 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private Type type; //Field offset: 0x28
		public Type <>3__type; //Field offset: 0x30
		private Type <arg>5__1; //Field offset: 0x38
		private Type[] <>7__wrap1; //Field offset: 0x40
		private int <>7__wrap2; //Field offset: 0x48
		private IEnumerator<String> <>7__wrap3; //Field offset: 0x50

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
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
		public <GetAllPossibleMissingAOTTypes>d__14(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private struct FormatterInfo
	{
		public Type FormatterType; //Field offset: 0x0
		public Type TargetType; //Field offset: 0x8
		public bool AskIfCanFormatTypes; //Field offset: 0x10
		public int Priority; //Field offset: 0x14

	}

	private struct FormatterLocatorInfo
	{
		public IFormatterLocator LocatorInstance; //Field offset: 0x0
		public int Priority; //Field offset: 0x8

	}

	private static readonly object LOCK; //Field offset: 0x0
	private static readonly Dictionary<Type, IFormatter> FormatterInstances; //Field offset: 0x8
	private static readonly DoubleLookupDictionary<Type, ISerializationPolicy, IFormatter> TypeFormatterMap; //Field offset: 0x10
	private static readonly List<FormatterLocatorInfo> FormatterLocators; //Field offset: 0x18
	private static readonly List<FormatterInfo> FormatterInfos; //Field offset: 0x20

	[Obsolete]
	public static event Func<Type, IFormatter> FormatterResolve
	{
		 add { } //Length: 73
		 remove { } //Length: 73
	}

	private static FormatterLocator() { }

	public static void add_FormatterResolve(Func<Type, IFormatter> value) { }

	private static IFormatter CreateFormatter(Type type, ISerializationPolicy policy) { }

	internal static List<IFormatter> GetAllCompatiblePredefinedFormatters(Type type, ISerializationPolicy policy) { }

	private static IEnumerable<String> GetAllPossibleMissingAOTTypes(Type type) { }

	public static IFormatter<T> GetFormatter(ISerializationPolicy policy) { }

	public static IFormatter GetFormatter(Type type, ISerializationPolicy policy) { }

	private static IFormatter GetFormatterInstance(Type type) { }

	private static void LogAOTError(Type type, Exception ex) { }

	public static void remove_FormatterResolve(Func<Type, IFormatter> value) { }

}

