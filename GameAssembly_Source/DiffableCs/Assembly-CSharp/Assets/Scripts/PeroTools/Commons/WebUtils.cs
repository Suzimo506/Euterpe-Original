namespace Assets.Scripts.PeroTools.Commons;

[Extension]
public static class WebUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, Object>, String> <>9__1_3; //Field offset: 0x8
		public static Func<KeyValuePair`2<String, Object>, String> <>9__1_4; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <SendToUrl>b__1_3(KeyValuePair<String, Object> d) { }

		internal string <SendToUrl>b__1_4(KeyValuePair<String, Object> d) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public Action<String> faillCallback; //Field offset: 0x10
		public UnityWebRequest webRequest; //Field offset: 0x18
		public Coroutine abortCoroutine; //Field offset: 0x20
		public Action<DownloadHandler> callback; //Field offset: 0x28

		public <>c__DisplayClass1_0() { }

		internal void <SendToUrl>b__0() { }

		internal void <SendToUrl>b__1() { }

		internal bool <SendToUrl>b__2() { }

	}


	public static UnityWebRequest SendToUrl(string url, string method = "GET", Dictionary<String, Object> datas = null, Action<DownloadHandler> callback = null, Action<String> faillCallback = null, Dictionary<String, String> headers = null, int failTime = 0, bool autoSend = true) { }

	[Extension]
	public static string ToUrl(string url) { }

}

