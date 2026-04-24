namespace ThinkingSDK.PC.Request;

public abstract class ThinkingSDKBaseRequest
{
	[CompilerGenerated]
	private sealed class <GetWithFORM_2>d__12 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public string url; //Field offset: 0x20
		public string appId; //Field offset: 0x28
		public Dictionary<String, Object> param; //Field offset: 0x30
		public ResponseHandle responseHandle; //Field offset: 0x38
		private UnityWebRequest <webRequest>5__2; //Field offset: 0x40

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
		public <GetWithFORM_2>d__12(int <>1__state) { }

		private void <>m__Finally1() { }

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

	private string mAppid; //Field offset: 0x10
	private string mURL; //Field offset: 0x18
	private IList<Dictionary`2<String, Object>> mData; //Field offset: 0x20

	public ThinkingSDKBaseRequest(string appId, string url) { }

	public string APPID() { }

	public IList<Dictionary`2<String, Object>> Data() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static IEnumerator GetWithFORM_2(string url, string appId, Dictionary<String, Object> param, ResponseHandle responseHandle) { }

	public abstract IEnumerator SendData_2(ResponseHandle responseHandle, IList<Dictionary`2<String, Object>> data) { }

	public void SetData(IList<Dictionary`2<String, Object>> data) { }

	public string URL() { }

}

