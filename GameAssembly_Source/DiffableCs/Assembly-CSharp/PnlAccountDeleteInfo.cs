//Type is in global namespace

public class PnlAccountDeleteInfo : BaseMessageBox
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Int64, String> <>9__8_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <OnDeleteAccountData>b__8_1(long c, string s) { }

	}

	[CompilerGenerated]
	private sealed class <Time>d__10 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PnlAccountDeleteInfo <>4__this; //Field offset: 0x20

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
		public <Time>d__10(int <>1__state) { }

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

	public Text txtDeleteAccountInfoYes; //Field offset: 0xD8
	public Button btnDeleteAccountInfoYes; //Field offset: 0xE0
	public Text txtDeleteAccountInfoBindNumber; //Field offset: 0xE8
	public GameObject imgBg; //Field offset: 0xF0
	private int m_TotalTime; //Field offset: 0xF8
	private string m_DeleteAccount; //Field offset: 0x100

	public PnlAccountDeleteInfo() { }

	[CompilerGenerated]
	private void <Awake>b__6_0() { }

	[CompilerGenerated]
	private void <OnDeleteAccountData>b__8_0(JObject jobj) { }

	private void Awake() { }

	private void OnDeleteAccountData() { }

	private void OnEnable() { }

	private void ResetAll() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator Time() { }

}

