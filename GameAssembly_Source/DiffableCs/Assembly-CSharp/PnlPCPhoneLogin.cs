//Type is in global namespace

public class PnlPCPhoneLogin : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Int64, String> <>9__18_6; //Field offset: 0x8
		public static UnityAction <>9__18_10; //Field offset: 0x10
		public static Action <>9__18_9; //Field offset: 0x18
		public static Action<JObject> <>9__18_7; //Field offset: 0x20
		public static Action<Int64, String> <>9__18_8; //Field offset: 0x28
		public static Action<Int64, String> <>9__18_12; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal void <Start>b__18_10() { }

		internal void <Start>b__18_12(long c, string s) { }

		internal void <Start>b__18_6(long c, string s) { }

		internal void <Start>b__18_7(JObject o) { }

		internal void <Start>b__18_8(long c, string s) { }

		internal void <Start>b__18_9() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public bool isSamePhone; //Field offset: 0x10
		public PnlPCPhoneLogin <>4__this; //Field offset: 0x18

		public <>c__DisplayClass18_0() { }

		internal void <Start>b__5(JObject o) { }

	}

	[CompilerGenerated]
	private sealed class <ResendCountDown>d__19 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PnlPCPhoneLogin <>4__this; //Field offset: 0x20
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
		public <ResendCountDown>d__19(int <>1__state) { }

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

	private enum InputType
	{
		Phone = 0,
		Email = 1,
	}

	[SerializeField]
	private InputField m_InputField_Phone; //Field offset: 0x18
	[SerializeField]
	private InputField m_InputField_Email; //Field offset: 0x20
	[SerializeField]
	private Button m_PhoneBtn; //Field offset: 0x28
	[SerializeField]
	private Button m_EmailBtn; //Field offset: 0x30
	[SerializeField]
	private Button m_SendBtn; //Field offset: 0x38
	[SerializeField]
	private GameObject m_PhoneLine; //Field offset: 0x40
	[SerializeField]
	private GameObject m_EmailLine; //Field offset: 0x48
	private InputType m_CurType; //Field offset: 0x50
	private string m_FinalSendTxt; //Field offset: 0x58
	[SerializeField]
	private InputField m_CodeInputField; //Field offset: 0x60
	[SerializeField]
	private Button m_SendCodeBtn; //Field offset: 0x68
	[SerializeField]
	private Button m_ReSendBtn; //Field offset: 0x70
	[SerializeField]
	private Text m_TimeTxt; //Field offset: 0x78
	private int m_ResendTimer; //Field offset: 0x80
	private bool m_BeginCountDown; //Field offset: 0x84
	[SerializeField]
	private Text m_PhoneTagTxt; //Field offset: 0x88
	[SerializeField]
	private Text m_EmailTagTxt; //Field offset: 0x90

	public PnlPCPhoneLogin() { }

	[CompilerGenerated]
	private void <Start>b__18_0() { }

	[CompilerGenerated]
	private void <Start>b__18_1() { }

	[CompilerGenerated]
	private void <Start>b__18_11(JObject o) { }

	[CompilerGenerated]
	private void <Start>b__18_2() { }

	[CompilerGenerated]
	private void <Start>b__18_3() { }

	[CompilerGenerated]
	private void <Start>b__18_4() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator ResendCountDown() { }

	private void Start() { }

}

