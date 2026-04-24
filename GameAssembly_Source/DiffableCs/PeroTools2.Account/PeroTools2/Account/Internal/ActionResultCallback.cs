namespace PeroTools2.Account.Internal;

internal class ActionResultCallback : InternalResultCallback
{
	[CompilerGenerated]
	private sealed class <ActionCoroutine>d__3 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ActionResultCallback <>4__this; //Field offset: 0x20
		public string action; //Field offset: 0x28
		public Dictionary<String, Object> jdict; //Field offset: 0x30
		private UnityWebRequest <request>5__2; //Field offset: 0x38

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
		public <ActionCoroutine>d__3(int <>1__state) { }

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


	private static Dictionary<String, String> action_url_map
	{
		private get { } //Length: 169
	}

	public ActionResultCallback(AccountCallback callback) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator ActionCoroutine(string action, Dictionary<String, Object> jdict) { }

	private PeroWebRequest ActionReq(string action, Dictionary<String, Object> resDict) { }

	private static Dictionary<String, String> get_action_url_map() { }

	public virtual void OnCompleted() { }

	public virtual void OnSucceed(string res) { }

}

