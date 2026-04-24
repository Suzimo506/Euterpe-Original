namespace PeroTools2.Account.Internal;

internal class PaymentResultCallback : InternalResultCallback
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public PaymentResultCallback <>4__this; //Field offset: 0x10
		public string res; //Field offset: 0x18

		public <>c__DisplayClass4_0() { }

		internal void <OnSucceed>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <VerifyOrderCoroutine>d__3 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public string res; //Field offset: 0x20
		public PaymentResultCallback <>4__this; //Field offset: 0x28
		private int <i>5__2; //Field offset: 0x30
		private PeroWebRequest <webRequest>5__3; //Field offset: 0x38

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
		public <VerifyOrderCoroutine>d__3(int <>1__state) { }

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

	private const string check_order_paid_url = "api/purchase/apppay/queryorder"; //Field offset: 0x0
	private bool m_RetSuc; //Field offset: 0x18

	public PaymentResultCallback(AccountCallback callback) { }

	[CompilerGenerated]
	private void <OnCompleted>b__5_0() { }

	public virtual void OnCompleted() { }

	public virtual void OnSucceed(string res) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator VerifyOrderCoroutine(string res) { }

}

