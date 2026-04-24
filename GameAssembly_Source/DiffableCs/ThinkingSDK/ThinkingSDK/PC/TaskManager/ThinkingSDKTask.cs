namespace ThinkingSDK.PC.TaskManager;

[DisallowMultipleComponent]
public class ThinkingSDKTask : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <SendData>d__17 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ThinkingSDKBaseRequest mRequest; //Field offset: 0x20
		public ResponseHandle responseHandle; //Field offset: 0x28
		public IList<Dictionary`2<String, Object>> list; //Field offset: 0x30

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
		public <SendData>d__17(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private static readonly object _locker; //Field offset: 0x0
	private static ThinkingSDKTask mSingleTask; //Field offset: 0x8
	private List<ThinkingSDKBaseRequest> requestList; //Field offset: 0x18
	private List<ResponseHandle> responseHandleList; //Field offset: 0x20
	private List<Int32> batchSizeList; //Field offset: 0x28
	private List<String> appIdList; //Field offset: 0x30
	private bool isWaiting; //Field offset: 0x38
	private int mBatchSize; //Field offset: 0x3C

	private static ThinkingSDKTask() { }

	public ThinkingSDKTask() { }

	private void Awake() { }

	public void Release() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator SendData(ThinkingSDKBaseRequest mRequest, ResponseHandle responseHandle, IList<Dictionary`2<String, Object>> list) { }

	public static ThinkingSDKTask SingleTask() { }

	private void Start() { }

	public void StartRequest(ThinkingSDKBaseRequest mRequest, ResponseHandle responseHandle, int batchSize, string appId) { }

	private void StartRequestSendData() { }

	public void SyncInvokeAllTask() { }

	private void Update() { }

	public void WaitOne() { }

}

