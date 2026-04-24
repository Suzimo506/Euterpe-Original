namespace ThinkingSDK.PC.Config;

public class ThinkingSDKConfig
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public ThinkingSDKConfig <>4__this; //Field offset: 0x10
		public ResponseHandle callback; //Field offset: 0x18

		public <>c__DisplayClass24_0() { }

		internal void <UpdateConfig>b__0(Dictionary<String, Object> result) { }

	}

	[CompilerGenerated]
	private sealed class <GetWithFORM>d__25 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ThinkingSDKConfig <>4__this; //Field offset: 0x20
		public Dictionary<String, Object> param; //Field offset: 0x28
		public ResponseHandle responseHandle; //Field offset: 0x30

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
		public <GetWithFORM>d__25(int <>1__state) { }

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

	private static Dictionary<String, ThinkingSDKConfig> sInstances; //Field offset: 0x0
	private string mToken; //Field offset: 0x10
	private string mServerUrl; //Field offset: 0x18
	private string mNormalUrl; //Field offset: 0x20
	private string mDebugUrl; //Field offset: 0x28
	private string mConfigUrl; //Field offset: 0x30
	private Mode mMode; //Field offset: 0x38
	private TimeZoneInfo mTimeZone; //Field offset: 0x40
	public int mUploadInterval; //Field offset: 0x48
	public int mUploadSize; //Field offset: 0x4C
	private List<String> mDisableEvents; //Field offset: 0x50

	private static ThinkingSDKConfig() { }

	private ThinkingSDKConfig(string token, string serverUrl) { }

	public string DebugURL() { }

	public static ThinkingSDKConfig GetInstance(string token, string server) { }

	public Mode GetMode() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator GetWithFORM(string url, string appId, Dictionary<String, Object> param, ResponseHandle responseHandle) { }

	public bool IsDisabledEvent(string eventName) { }

	public string NormalURL() { }

	public void SetMode(Mode mode) { }

	public void SetTimeZone(TimeZoneInfo timeZoneInfo) { }

	public TimeZoneInfo TimeZone() { }

	public void UpdateConfig(MonoBehaviour mono, ResponseHandle callback = null) { }

	private string VerifyUrl(string serverUrl) { }

}

