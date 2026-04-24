namespace ThinkingSDK.PC.Request;

public class ThinkingSDKDebugRequest : ThinkingSDKBaseRequest
{
	[CompilerGenerated]
	private sealed class <SendData_2>d__5 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ThinkingSDKDebugRequest <>4__this; //Field offset: 0x20
		public IList<Dictionary`2<String, Object>> data; //Field offset: 0x28
		public ResponseHandle responseHandle; //Field offset: 0x30
		private UnityWebRequest <webRequest>5__2; //Field offset: 0x38

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
		public <SendData_2>d__5(int <>1__state) { }

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

	private int mDryRun; //Field offset: 0x28
	private string mDeviceID; //Field offset: 0x30

	public ThinkingSDKDebugRequest(string appId, string url) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual IEnumerator SendData_2(ResponseHandle responseHandle, IList<Dictionary`2<String, Object>> data) { }

	public void SetDryRun(int dryRun) { }

}

