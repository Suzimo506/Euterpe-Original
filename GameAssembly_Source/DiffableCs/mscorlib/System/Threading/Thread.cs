namespace System.Threading;

[ClassInterface(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ComDefaultInterface(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class Thread : CriticalFinalizerObject, _Thread
{
	[ThreadStatic]
	private static LocalDataStoreHolder s_LocalDataStore; //Field offset: 0x80000000
	[ThreadStatic]
	internal static CultureInfo m_CurrentCulture; //Field offset: 0x80000008
	[ThreadStatic]
	internal static CultureInfo m_CurrentUICulture; //Field offset: 0x80000010
	[ThreadStatic]
	private static Thread current_thread; //Field offset: 0x80000018
	private static LocalDataStoreMgr s_LocalDataStoreMgr; //Field offset: 0x0
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture; //Field offset: 0x8
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture; //Field offset: 0x10
	private InternalThread internal_thread; //Field offset: 0x10
	private object m_ThreadStartArg; //Field offset: 0x18
	private object pending_exception; //Field offset: 0x20
	private IPrincipal principal; //Field offset: 0x28
	private int principal_version; //Field offset: 0x30
	private MulticastDelegate m_Delegate; //Field offset: 0x38
	private ExecutionContext m_ExecutionContext; //Field offset: 0x40
	private bool m_ExecutionContextBelongsToOuterScope; //Field offset: 0x48

	public static Context CurrentContext
	{
		 get { } //Length: 7
	}

	public CultureInfo CurrentCulture
	{
		 get { } //Length: 158
		 set { } //Length: 380
	}

	public static Thread CurrentThread
	{
		[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 66
	}

	internal static int CurrentThreadId
	{
		internal get { } //Length: 84
	}

	public CultureInfo CurrentUICulture
	{
		 get { } //Length: 158
		 set { } //Length: 423
	}

	internal bool ExecutionContextBelongsToCurrentScope
	{
		internal get { } //Length: 8
		internal set { } //Length: 7
	}

	private InternalThread Internal
	{
		private get { } //Length: 33
	}

	public bool IsAlive
	{
		 get { } //Length: 49
	}

	public bool IsBackground
	{
		 set { } //Length: 204
	}

	public bool IsThreadPoolThread
	{
		 get { } //Length: 50
	}

	internal bool IsThreadPoolThreadInternal
	{
		internal get { } //Length: 50
	}

	public int ManagedThreadId
	{
		[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 49
	}

	public string Name
	{
		 set { } //Length: 55
	}

	public ThreadState ThreadState
	{
		 get { } //Length: 40
	}

	public Thread(ThreadStart start) { }

	public Thread(ParameterizedThreadStart start) { }

	public void Abort() { }

	private static void Abort_internal(InternalThread thread, object stateInfo) { }

	private static void AsyncLocalSetCurrentCulture(AsyncLocalValueChangedArgs<CultureInfo> args) { }

	private static void AsyncLocalSetCurrentUICulture(AsyncLocalValueChangedArgs<CultureInfo> args) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void BeginCriticalRegion() { }

	private static void ClrState(InternalThread thread, ThreadState clr) { }

	private void ConstructInternalThread() { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void EndCriticalRegion() { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected virtual void Finalize() { }

	public static Context get_CurrentContext() { }

	public CultureInfo get_CurrentCulture() { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Thread get_CurrentThread() { }

	internal static int get_CurrentThreadId() { }

	public CultureInfo get_CurrentUICulture() { }

	internal bool get_ExecutionContextBelongsToCurrentScope() { }

	private InternalThread get_Internal() { }

	public bool get_IsAlive() { }

	public bool get_IsThreadPoolThread() { }

	internal bool get_IsThreadPoolThreadInternal() { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int get_ManagedThreadId() { }

	public ThreadState get_ThreadState() { }

	private CultureInfo GetCurrentCultureNoAppX() { }

	private static Thread GetCurrentThread() { }

	internal CultureInfo GetCurrentUICultureNoAppX() { }

	public static int GetDomainID() { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal Reader GetExecutionContextReader() { }

	[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual int GetHashCode() { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal ExecutionContext GetMutableExecutionContext() { }

	private static int GetProcessDefaultStackSize(int maxStackSize) { }

	private static ThreadState GetState(InternalThread thread) { }

	public void Join() { }

	private bool JoinInternal(int millisecondsTimeout) { }

	public static void MemoryBarrier() { }

	private static void nativeInitCultureAccessors() { }

	public void set_CurrentCulture(CultureInfo value) { }

	public void set_CurrentUICulture(CultureInfo value) { }

	internal void set_ExecutionContextBelongsToCurrentScope(bool value) { }

	public void set_IsBackground(bool value) { }

	public void set_Name(string value) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal void SetExecutionContext(Reader value, bool belongsToCurrentScope) { }

	private static void SetName_internal(InternalThread thread, string name) { }

	private void SetStart(MulticastDelegate start, int maxStackSize) { }

	private void SetStartHelper(Delegate start, int maxStackSize) { }

	private static void SetState(InternalThread thread, ThreadState set) { }

	public static void Sleep(int millisecondsTimeout) { }

	private static void SleepInternal(int millisecondsTimeout) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void SpinWait(int iterations) { }

	private static void SpinWait_nop() { }

	public void Start() { }

	private void Start(ref StackCrawlMark stackMark) { }

	public void Start(object parameter) { }

	private void StartInternal(IPrincipal principal, ref StackCrawlMark stackMark) { }

	private static int SystemMaxStackStize() { }

	private IntPtr Thread_internal(MulticastDelegate start) { }

	private ThreadState ValidateThreadState() { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static bool Yield() { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static bool YieldInternal() { }

}

