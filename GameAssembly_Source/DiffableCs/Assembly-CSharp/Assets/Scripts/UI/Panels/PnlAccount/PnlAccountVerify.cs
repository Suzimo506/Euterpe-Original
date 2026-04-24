namespace Assets.Scripts.UI.Panels.PnlAccount;

public class PnlAccountVerify : BaseMessageBox
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Int64, String> <>9__14_1; //Field offset: 0x8
		public static Action<Int64, String> <>9__15_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <OnResendClicked>b__15_1(long c, string s) { }

		internal void <SendVerifyCode>b__14_1(long c, string s) { }

	}

	[CompilerGenerated]
	private sealed class <ResendCountDown>d__18 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PnlAccountVerify <>4__this; //Field offset: 0x20
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
		public <ResendCountDown>d__18(int <>1__state) { }

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

	private int m_ResendTimer; //Field offset: 0xD8
	private bool m_BeginCountDown; //Field offset: 0xDC
	[SerializeField]
	private InputField m_CodeInputField; //Field offset: 0xE0
	[SerializeField]
	private Button m_ReSendBtn; //Field offset: 0xE8
	[SerializeField]
	private Text m_TimeTxt; //Field offset: 0xF0
	private Coroutine m_CountDown; //Field offset: 0xF8
	private InputType m_InputType; //Field offset: 0x100
	private string m_FinalSendText; //Field offset: 0x108
	private BindType m_BindType; //Field offset: 0x110

	public bool beginCountDown
	{
		 get { } //Length: 8
	}

	public PnlAccountVerify() { }

	[CompilerGenerated]
	private void <OnResendClicked>b__15_0(JObject o) { }

	[CompilerGenerated]
	private void <SendVerifyCode>b__14_0(JObject o) { }

	public bool get_beginCountDown() { }

	protected virtual void OnNoClicked() { }

	private void OnResendClicked() { }

	protected virtual void OnYesClicked() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator ResendCountDown() { }

	private void SendVerifyCode() { }

	public void SetSendType(InputType inputType, string finalSendText, BindType bindType) { }

	private void StartCountDown() { }

	public virtual void StartInit() { }

}

