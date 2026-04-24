namespace ZenFulcrum.EmbeddedBrowser;

public class Promise : IPromise<PromisedT>, IPendingPromise<PromisedT>, IRejectable, IPromiseInfo
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<PromisedT> <>9; //Field offset: 0x0
		public static Action<PromisedT> <>9__50_0; //Field offset: 0x0
		public static Action<Exception> <>9__50_1; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <ToWaitFor>b__50_0(PromisedT x) { }

		internal void <ToWaitFor>b__50_1(Exception ex) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public Promise<PromisedT> <>4__this; //Field offset: 0x0
		public Exception ex; //Field offset: 0x0

		public <>c__DisplayClass23_0() { }

		internal void <InvokeRejectHandlers>b__0(RejectHandler handler) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public Promise<PromisedT> resultPromise; //Field offset: 0x0
		public Action<Exception> onRejected; //Field offset: 0x0

		public <>c__DisplayClass31_0() { }

		internal void <Catch>b__0(PromisedT v) { }

		internal void <Catch>b__1(Exception ex) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public Func<PromisedT, IPromise`1<ConvertedT>> onResolved; //Field offset: 0x0
		public Promise<ConvertedT> resultPromise; //Field offset: 0x0
		public Action<Exception> onRejected; //Field offset: 0x0
		public Action<ConvertedT> <>9__2; //Field offset: 0x0
		public Action<Exception> <>9__3; //Field offset: 0x0

		public <>c__DisplayClass35_0`1() { }

		internal void <Then>b__0(PromisedT v) { }

		internal void <Then>b__1(Exception ex) { }

		internal void <Then>b__2(ConvertedT chainedValue) { }

		internal void <Then>b__3(Exception ex) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public Func<PromisedT, IPromise> onResolved; //Field offset: 0x0
		public Promise resultPromise; //Field offset: 0x0
		public Action<Exception> onRejected; //Field offset: 0x0
		public Action <>9__2; //Field offset: 0x0
		public Action<Exception> <>9__3; //Field offset: 0x0

		public <>c__DisplayClass36_0() { }

		internal void <Then>b__0(PromisedT v) { }

		internal void <Then>b__1(Exception ex) { }

		internal void <Then>b__2() { }

		internal void <Then>b__3(Exception ex) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass37_0
	{
		public Action<PromisedT> onResolved; //Field offset: 0x0
		public Promise<PromisedT> resultPromise; //Field offset: 0x0
		public Action<Exception> onRejected; //Field offset: 0x0

		public <>c__DisplayClass37_0() { }

		internal void <Then>b__0(PromisedT v) { }

		internal void <Then>b__1(Exception ex) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public Func<PromisedT, ConvertedT> transform; //Field offset: 0x0

		public <>c__DisplayClass38_0`1() { }

		internal IPromise<ConvertedT> <Then>b__0(PromisedT value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass39_0
	{
		public Func<PromisedT, ConvertedT> transform; //Field offset: 0x0

		public <>c__DisplayClass39_0`1() { }

		internal IPromise<ConvertedT> <Transform>b__0(PromisedT value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass41_0
	{
		public Func<PromisedT, IEnumerable`1<IPromise`1<ConvertedT>>> chain; //Field offset: 0x0

		public <>c__DisplayClass41_0`1() { }

		internal IPromise<IEnumerable`1<ConvertedT>> <ThenAll>b__0(PromisedT value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_0
	{
		public Func<PromisedT, IEnumerable`1<IPromise>> chain; //Field offset: 0x0

		public <>c__DisplayClass42_0() { }

		internal IPromise <ThenAll>b__0(PromisedT value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public Promise<IEnumerable`1<PromisedT>> resultPromise; //Field offset: 0x0
		public PromisedT[] results; //Field offset: 0x0
		public int remainingCount; //Field offset: 0x0
		public Action<Exception> <>9__1; //Field offset: 0x0

		public <>c__DisplayClass44_0() { }

		internal void <All>b__0(IPromise<PromisedT> promise, int index) { }

		internal void <All>b__1(Exception ex) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_1
	{
		public int index; //Field offset: 0x0
		public <>c__DisplayClass44_0<PromisedT> CS$<>8__locals1; //Field offset: 0x0

		public <>c__DisplayClass44_1() { }

		internal void <All>b__2(PromisedT result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		public Func<PromisedT, IEnumerable`1<IPromise`1<ConvertedT>>> chain; //Field offset: 0x0

		public <>c__DisplayClass45_0`1() { }

		internal IPromise<ConvertedT> <ThenRace>b__0(PromisedT value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass46_0
	{
		public Func<PromisedT, IEnumerable`1<IPromise>> chain; //Field offset: 0x0

		public <>c__DisplayClass46_0() { }

		internal IPromise <ThenRace>b__0(PromisedT value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass52_0
	{
		public Promise<PromisedT> resultPromise; //Field offset: 0x0
		public Action<Exception> <>9__1; //Field offset: 0x0
		public Action<PromisedT> <>9__2; //Field offset: 0x0

		public <>c__DisplayClass52_0() { }

		internal void <Race>b__0(IPromise<PromisedT> promise, int index) { }

		internal void <Race>b__1(Exception ex) { }

		internal void <Race>b__2(PromisedT result) { }

	}

	private class Enumerated : IEnumerator
	{
		private Promise<T> promise; //Field offset: 0x0
		private bool abortOnFail; //Field offset: 0x0

		public override object Current
		{
			 get { } //Length: 3
		}

		public Enumerated`1(Promise<T> promise, bool abortOnFail) { }

		public override object get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	private Exception rejectionException; //Field offset: 0x0
	private PromisedT resolveValue; //Field offset: 0x0
	private List<RejectHandler> rejectHandlers; //Field offset: 0x0
	private List<Action`1<PromisedT>> resolveCallbacks; //Field offset: 0x0
	private List<IRejectable> resolveRejectables; //Field offset: 0x0
	[CompilerGenerated]
	private int <Id>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private PromiseState <CurState>k__BackingField; //Field offset: 0x0

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

	public override PromisedT Value
	{
		 get { } //Length: 202
	}

	public Promise`1() { }

	public Promise`1(Action<Action`1<PromisedT>, Action`1<Exception>> resolver) { }

	[CompilerGenerated]
	private void <.ctor>b__18_0(PromisedT value) { }

	[CompilerGenerated]
	private void <.ctor>b__18_1(Exception ex) { }

	[CompilerGenerated]
	private void <Done>b__27_0(Exception ex) { }

	[CompilerGenerated]
	private void <Done>b__28_0(Exception ex) { }

	[CompilerGenerated]
	private void <Done>b__29_0(Exception ex) { }

	private void ActionHandlers(IRejectable resultPromise, Action<PromisedT> resolveHandler, Action<Exception> rejectHandler) { }

	private void AddRejectHandler(Action<Exception> onRejected, IRejectable rejectable) { }

	private void AddResolveHandler(Action<PromisedT> onResolved, IRejectable rejectable) { }

	public static IPromise<IEnumerable`1<PromisedT>> All(IPromise<PromisedT>[] promises) { }

	public static IPromise<IEnumerable`1<PromisedT>> All(IEnumerable<IPromise`1<PromisedT>> promises) { }

	public override IPromise<PromisedT> Catch(Action<Exception> onRejected) { }

	private void ClearHandlers() { }

	public override void Done() { }

	public override void Done(Action<PromisedT> onResolved, Action<Exception> onRejected) { }

	public override void Done(Action<PromisedT> onResolved) { }

	[CompilerGenerated]
	public PromiseState get_CurState() { }

	[CompilerGenerated]
	public override int get_Id() { }

	[CompilerGenerated]
	public override string get_Name() { }

	public override PromisedT get_Value() { }

	private void InvokeHandler(Action<T> callback, IRejectable rejectable, T value) { }

	private void InvokeRejectHandlers(Exception ex) { }

	private void InvokeResolveHandlers(PromisedT value) { }

	public static IPromise<PromisedT> Race(IEnumerable<IPromise`1<PromisedT>> promises) { }

	public static IPromise<PromisedT> Race(IPromise<PromisedT>[] promises) { }

	public override void Reject(Exception ex) { }

	public static IPromise<PromisedT> Rejected(Exception ex) { }

	public override void Resolve(PromisedT value) { }

	public static IPromise<PromisedT> Resolved(PromisedT promisedValue) { }

	[CompilerGenerated]
	private void set_CurState(PromiseState value) { }

	[CompilerGenerated]
	private void set_Id(int value) { }

	[CompilerGenerated]
	private void set_Name(string value) { }

	public override IPromise<PromisedT> Then(Action<PromisedT> onResolved) { }

	public override IPromise<ConvertedT> Then(Func<PromisedT, ConvertedT> transform) { }

	public override IPromise<PromisedT> Then(Action<PromisedT> onResolved, Action<Exception> onRejected) { }

	public override IPromise Then(Func<PromisedT, IPromise> onResolved, Action<Exception> onRejected) { }

	public override IPromise<ConvertedT> Then(Func<PromisedT, IPromise`1<ConvertedT>> onResolved, Action<Exception> onRejected) { }

	public override IPromise Then(Func<PromisedT, IPromise> onResolved) { }

	public override IPromise<ConvertedT> Then(Func<PromisedT, IPromise`1<ConvertedT>> onResolved) { }

	public override IPromise<IEnumerable`1<ConvertedT>> ThenAll(Func<PromisedT, IEnumerable`1<IPromise`1<ConvertedT>>> chain) { }

	public override IPromise ThenAll(Func<PromisedT, IEnumerable`1<IPromise>> chain) { }

	public override IPromise<ConvertedT> ThenRace(Func<PromisedT, IEnumerable`1<IPromise`1<ConvertedT>>> chain) { }

	public override IPromise ThenRace(Func<PromisedT, IEnumerable`1<IPromise>> chain) { }

	public override IEnumerator ToWaitFor(bool abortOnFail) { }

	[Obsolete]
	public override IPromise<ConvertedT> Transform(Func<PromisedT, ConvertedT> transform) { }

	public override IPromise<PromisedT> WithName(string name) { }

}

