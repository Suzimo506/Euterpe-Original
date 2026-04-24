//Type is in global namespace

public class PnlPMDPhoneLoginState : Singleton<PnlPMDPhoneLoginState>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Int64, String> <>9__10_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <IsBind>b__10_1(long c, string s) { }

	}

	[CompilerGenerated]
	private sealed class <Choose>d__9 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PnlPMDPhoneLoginState <>4__this; //Field offset: 0x20

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
		public <Choose>d__9(int <>1__state) { }

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

	internal enum BindType
	{
		NoBind = 0,
		ChangeBind = 1,
	}

	public bool isBind; //Field offset: 0x10
	public bool isBindGlobal; //Field offset: 0x11
	public bool isBindUser; //Field offset: 0x12
	public bool isOversea; //Field offset: 0x13
	public bool isNoYet; //Field offset: 0x14
	public bool isRunOnce; //Field offset: 0x15
	public bool isCloseBulletin; //Field offset: 0x16

	public PnlPMDPhoneLoginState() { }

	[CompilerGenerated]
	private void <IsBind>b__10_0(JObject o) { }

	public void CheckBind() { }

	public bool CheckFirstOpenAfterBindUpdate() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator Choose() { }

	public void Init() { }

	public void IsBind() { }

	public void IsUserBind() { }

}

