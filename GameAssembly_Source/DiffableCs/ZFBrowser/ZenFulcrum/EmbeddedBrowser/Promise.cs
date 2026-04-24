namespace ZenFulcrum.EmbeddedBrowser;

public class Promise : IPromise, IPendingPromise, IRejectable, IPromiseInfo
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<IPromise, Func`1<IPromise>, IPromise> <>9__54_0; //Field offset: 0x8
		public static Action <>9__63_0; //Field offset: 0x10
		public static Action<Exception> <>9__63_1; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__0_0(object sender, ExceptionEventArgs args) { }

		internal IPromise <Sequence>b__54_0(IPromise prevPromise, Func<IPromise> fn) { }

		internal void <ToWaitFor>b__63_0() { }

		internal void <ToWaitFor>b__63_1(Exception ex) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public Promise <>4__this; //Field offset: 0x10
		public Exception ex; //Field offset: 0x18

		public <>c__DisplayClass32_0() { }

		internal void <InvokeRejectHandlers>b__0(RejectHandler handler) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_0
	{
		public Promise resultPromise; //Field offset: 0x10
		public Action<Exception> onRejected; //Field offset: 0x18

		public <>c__DisplayClass40_0() { }

		internal void <Catch>b__0() { }

		internal void <Catch>b__1(Exception ex) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public Func<IPromise`1<ConvertedT>> onResolved; //Field offset: 0x0
		public Promise<ConvertedT> resultPromise; //Field offset: 0x0
		public Action<Exception> onRejected; //Field offset: 0x0
		public Action<ConvertedT> <>9__2; //Field offset: 0x0
		public Action<Exception> <>9__3; //Field offset: 0x0

		public <>c__DisplayClass44_0`1() { }

		internal void <Then>b__0() { }

		internal void <Then>b__1(Exception ex) { }

		internal void <Then>b__2(ConvertedT chainedValue) { }

		internal void <Then>b__3(Exception ex) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		public Func<IPromise> onResolved; //Field offset: 0x10
		public Promise resultPromise; //Field offset: 0x18
		public Action<Exception> onRejected; //Field offset: 0x20
		public Action <>9__2; //Field offset: 0x28
		public Action<Exception> <>9__3; //Field offset: 0x30

		public <>c__DisplayClass45_0() { }

		internal void <Then>b__0() { }

		internal void <Then>b__1(Exception ex) { }

		internal void <Then>b__2() { }

		internal void <Then>b__3(Exception ex) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass46_0
	{
		public Action onResolved; //Field offset: 0x10
		public Promise resultPromise; //Field offset: 0x18
		public Action<Exception> onRejected; //Field offset: 0x20

		public <>c__DisplayClass46_0() { }

		internal void <Then>b__0() { }

		internal void <Then>b__1(Exception ex) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass48_0
	{
		public Func<IEnumerable`1<IPromise>> chain; //Field offset: 0x10

		public <>c__DisplayClass48_0() { }

		internal IPromise <ThenAll>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass49_0
	{
		public Func<IEnumerable`1<IPromise`1<ConvertedT>>> chain; //Field offset: 0x0

		public <>c__DisplayClass49_0`1() { }

		internal IPromise<IEnumerable`1<ConvertedT>> <ThenAll>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass51_0
	{
		public Promise resultPromise; //Field offset: 0x10
		public int remainingCount; //Field offset: 0x18
		public Action<Exception> <>9__1; //Field offset: 0x20
		public Action <>9__2; //Field offset: 0x28

		public <>c__DisplayClass51_0() { }

		internal void <All>b__0(IPromise promise, int index) { }

		internal void <All>b__1(Exception ex) { }

		internal void <All>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass52_0
	{
		public Func<IEnumerable`1<Func`1<IPromise>>> chain; //Field offset: 0x10

		public <>c__DisplayClass52_0() { }

		internal IPromise <ThenSequence>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_0
	{
		public Func<IPromise> fn; //Field offset: 0x10

		public <>c__DisplayClass54_0() { }

		internal IPromise <Sequence>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass55_0
	{
		public Func<IEnumerable`1<IPromise>> chain; //Field offset: 0x10

		public <>c__DisplayClass55_0() { }

		internal IPromise <ThenRace>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass56_0
	{
		public Func<IEnumerable`1<IPromise`1<ConvertedT>>> chain; //Field offset: 0x0

		public <>c__DisplayClass56_0`1() { }

		internal IPromise<ConvertedT> <ThenRace>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass58_0
	{
		public Promise resultPromise; //Field offset: 0x10
		public Action<Exception> <>9__1; //Field offset: 0x18
		public Action <>9__2; //Field offset: 0x20

		public <>c__DisplayClass58_0() { }

		internal void <Race>b__0(IPromise promise, int index) { }

		internal void <Race>b__1(Exception ex) { }

		internal void <Race>b__2() { }

	}

	private class Enumerated : IEnumerator
	{
		private Promise promise; //Field offset: 0x10
		private bool abortOnFail; //Field offset: 0x18

		public override object Current
		{
			 get { } //Length: 3
		}

		public Enumerated(Promise promise, bool abortOnFail) { }

		public override object get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	internal struct ResolveHandler
	{
		public Action callback; //Field offset: 0x0
		public IRejectable rejectable; //Field offset: 0x8

	}

	public static bool EnablePromiseTracking; //Field offset: 0x0
	private static EventHandler<ExceptionEventArgs> unhandlerException; //Field offset: 0x8
	internal static int nextPromiseId; //Field offset: 0x10
	internal static HashSet<IPromiseInfo> pendingPromises; //Field offset: 0x18
	private Exception rejectionException; //Field offset: 0x10
	private List<RejectHandler> rejectHandlers; //Field offset: 0x18
	private List<ResolveHandler> resolveHandlers; //Field offset: 0x20
	[CompilerGenerated]
	private int <Id>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private PromiseState <CurState>k__BackingField; //Field offset: 0x38

	public static event EventHandler<ExceptionEventArgs> UnhandledException
	{
		 add { } //Length: 166
		 remove { } //Length: 166
	}

	public private PromiseState CurState
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private override int Id
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private override string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	private static Promise() { }

	public Promise(Action<Action, Action`1<Exception>> resolver) { }

	public Promise() { }

	[CompilerGenerated]
	private void <.ctor>b__26_0() { }

	[CompilerGenerated]
	private void <.ctor>b__26_1(Exception ex) { }

	[CompilerGenerated]
	private void <Done>b__36_0(Exception ex) { }

	[CompilerGenerated]
	private void <Done>b__37_0(Exception ex) { }

	[CompilerGenerated]
	private void <Done>b__38_0(Exception ex) { }

	[CompilerGenerated]
	private void <InvokeResolveHandlers>b__33_0(ResolveHandler handler) { }

	private void ActionHandlers(IRejectable resultPromise, Action resolveHandler, Action<Exception> rejectHandler) { }

	public static void add_UnhandledException(EventHandler<ExceptionEventArgs> value) { }

	private void AddRejectHandler(Action<Exception> onRejected, IRejectable rejectable) { }

	private void AddResolveHandler(Action onResolved, IRejectable rejectable) { }

	public static IPromise All(IEnumerable<IPromise> promises) { }

	public static IPromise All(IPromise[] promises) { }

	public override IPromise Catch(Action<Exception> onRejected) { }

	private void ClearHandlers() { }

	public override void Done() { }

	public override void Done(Action onResolved) { }

	public override void Done(Action onResolved, Action<Exception> onRejected) { }

	[CompilerGenerated]
	public PromiseState get_CurState() { }

	[CompilerGenerated]
	public override int get_Id() { }

	[CompilerGenerated]
	public override string get_Name() { }

	public static IEnumerable<IPromiseInfo> GetPendingPromises() { }

	private void InvokeRejectHandler(Action<Exception> callback, IRejectable rejectable, Exception value) { }

	private void InvokeRejectHandlers(Exception ex) { }

	private void InvokeResolveHandler(Action callback, IRejectable rejectable) { }

	private void InvokeResolveHandlers() { }

	internal static void PropagateUnhandledException(object sender, Exception ex) { }

	public static IPromise Race(IPromise[] promises) { }

	public static IPromise Race(IEnumerable<IPromise> promises) { }

	public override void Reject(Exception ex) { }

	public static IPromise Rejected(Exception ex) { }

	public static void remove_UnhandledException(EventHandler<ExceptionEventArgs> value) { }

	public override void Resolve() { }

	public static IPromise Resolved() { }

	public static IPromise Sequence(IEnumerable<Func`1<IPromise>> fns) { }

	public static IPromise Sequence(Func<IPromise>[] fns) { }

	[CompilerGenerated]
	private void set_CurState(PromiseState value) { }

	[CompilerGenerated]
	private void set_Id(int value) { }

	[CompilerGenerated]
	private void set_Name(string value) { }

	public override IPromise Then(Func<IPromise> onResolved, Action<Exception> onRejected) { }

	public override IPromise Then(Action onResolved, Action<Exception> onRejected) { }

	public override IPromise<ConvertedT> Then(Func<IPromise`1<ConvertedT>> onResolved, Action<Exception> onRejected) { }

	public override IPromise Then(Action onResolved) { }

	public override IPromise Then(Func<IPromise> onResolved) { }

	public override IPromise<ConvertedT> Then(Func<IPromise`1<ConvertedT>> onResolved) { }

	public override IPromise<IEnumerable`1<ConvertedT>> ThenAll(Func<IEnumerable`1<IPromise`1<ConvertedT>>> chain) { }

	public override IPromise ThenAll(Func<IEnumerable`1<IPromise>> chain) { }

	public override IPromise ThenRace(Func<IEnumerable`1<IPromise>> chain) { }

	public override IPromise<ConvertedT> ThenRace(Func<IEnumerable`1<IPromise`1<ConvertedT>>> chain) { }

	public override IPromise ThenSequence(Func<IEnumerable`1<Func`1<IPromise>>> chain) { }

	public override IEnumerator ToWaitFor(bool abortOnFail = false) { }

	public override IPromise WithName(string name) { }

}

