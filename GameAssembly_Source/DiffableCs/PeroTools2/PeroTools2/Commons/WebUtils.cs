namespace PeroTools2.Commons;

public static class WebUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, Object>, String> <>9__2_1; //Field offset: 0x8
		public static Func<KeyValuePair`2<String, Object>, String> <>9__2_2; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <SendToUrl>b__2_1(KeyValuePair<String, Object> d) { }

		internal string <SendToUrl>b__2_2(KeyValuePair<String, Object> d) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		private sealed class <<SendToUrl>g__Receive|0>d : IEnumerator<Object>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private object <>2__current; //Field offset: 0x18
			public <>c__DisplayClass2_0 <>4__this; //Field offset: 0x20

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
			public <<SendToUrl>g__Receive|0>d(int <>1__state) { }

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

		public UnityWebRequest request; //Field offset: 0x10
		public PeroWebRequest webRequest; //Field offset: 0x18

		public <>c__DisplayClass2_0() { }

		[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
		internal IEnumerator <SendToUrl>g__Receive|0() { }

	}

	internal class PeroWebRequest
	{
		public string url; //Field offset: 0x10
		public string method; //Field offset: 0x18
		public Dictionary<String, Object> datas; //Field offset: 0x20
		public Action<DownloadHandler> succeedCallback; //Field offset: 0x28
		public Action<Int64, String> faillCallback; //Field offset: 0x30
		public Action startCallback; //Field offset: 0x38
		public Action completeCallback; //Field offset: 0x40
		public Dictionary<String, String> headers; //Field offset: 0x48
		public int timeout; //Field offset: 0x50
		public UnityWebRequest request; //Field offset: 0x58
		public Coroutine coroutine; //Field offset: 0x60

		public PeroWebRequest() { }

	}


	public static DateTime GetDateTime(int timeStamp) { }

	public static long GetTimeStamp(DateTime dateTime) { }

	public static PeroWebRequest SendToUrl(string url, string method = null, Dictionary<String, Object> datas = null, Action<DownloadHandler> succeedCallback = null, Action<Int64, String> faillCallback = null, Action startCallback = null, Action completeCallback = null, Dictionary<String, String> headers = null, int timeout = 0) { }

	public static PeroWebRequest SendToUrl(PeroWebRequest webRequest) { }

}

