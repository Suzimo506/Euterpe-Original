namespace Assets.Scripts.UI.Panels.PnlAccount;

public class PnlChangeBindVerify : BaseMessageBox
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Int64, String> <>9__11_1; //Field offset: 0x8
		public static Action<Int64, String> <>9__12_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <OnConfirmClicked>b__11_1(long c, string s) { }

		internal void <OnResendClicked>b__12_1(long c, string s) { }

	}

	[CompilerGenerated]
	private sealed class <ResendCountDown>d__13 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PnlChangeBindVerify <>4__this; //Field offset: 0x20
		private int <i>5__2; //Field offset: 0x28

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
		public <ResendCountDown>d__13(int <>1__state) { }

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

	[SerializeField]
	private InputField m_CodeInputField; //Field offset: 0xD8
	[SerializeField]
	private Button m_ResendBtn; //Field offset: 0xE0
	[SerializeField]
	private Text m_TimeTxt; //Field offset: 0xE8
	private int m_ResendTimer; //Field offset: 0xF0
	private bool m_BeginCountDown; //Field offset: 0xF4
	private WaitForSeconds m_WaitForSeconds; //Field offset: 0xF8
	private Coroutine m_CountDown; //Field offset: 0x100

	public PnlChangeBindVerify() { }

	[CompilerGenerated]
	private void <OnConfirmClicked>b__11_0(JObject o) { }

	[CompilerGenerated]
	private void <OnResendClicked>b__12_0(JObject o) { }

	private void OnConfirmClicked() { }

	protected virtual void OnNoClicked() { }

	private void OnResendClicked() { }

	protected virtual void OnYesClicked() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator ResendCountDown() { }

	private void ResetResendButton() { }

	public virtual void Show() { }

	public virtual void StartInit() { }

}

