namespace xdsdk.Unity;

[DisallowMultipleComponent]
public class Net : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <Get>d__5 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Dictionary<String, String> parameters; //Field offset: 0x20
		public string url; //Field offset: 0x28
		public Action<Int32, String> methodForError; //Field offset: 0x30
		public Action<String> methodForResult; //Field offset: 0x38
		private WWW <w>5__2; //Field offset: 0x40

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
		public <Get>d__5(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <Post>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Dictionary<String, Object> parameters; //Field offset: 0x20
		public Dictionary<String, String> headers; //Field offset: 0x28
		public string url; //Field offset: 0x30
		public Action<Int32, String> methodForError; //Field offset: 0x38
		public Action<String> methodForResult; //Field offset: 0x40
		private WWW <w>5__2; //Field offset: 0x48

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
		public <Post>d__4(int <>1__state) { }

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


	public Net() { }

	public static string DictToQueryString(IDictionary<String, String> dict) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator Get(string url, Dictionary<String, String> parameters, Action<String> methodForResult, Action<Int32, String> methodForError) { }

	public void GetOnServer(string url, Dictionary<String, String> parameters, Action<String> methodForResult, Action<Int32, String> methodForError) { }

	public void GetOnServer(string url, Action<String> methodForResult, Action<Int32, String> methodForError) { }

	public static int GetResponseCode(WWW request) { }

	public static int ParseResponseCode(string statusLine) { }

	public static void ParseUrl(string url, out string baseUrl, out NameValueCollection nvc) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator Post(string url, Dictionary<String, String> headers, Dictionary<String, Object> parameters, Action<String> methodForResult, Action<Int32, String> methodForError) { }

	public void PostOnServer(string url, Dictionary<String, Object> parameters, Action<String> methodForResult, Action<Int32, String> methodForError) { }

	public void PostOnServer(string url, Dictionary<String, String> headers, Dictionary<String, Object> parameters, Action<String> methodForResult, Action<Int32, String> methodForError) { }

}

