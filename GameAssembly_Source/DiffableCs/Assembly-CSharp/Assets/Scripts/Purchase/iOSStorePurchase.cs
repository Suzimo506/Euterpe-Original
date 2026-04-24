namespace Assets.Scripts.Purchase;

internal class iOSStorePurchase : IStoreListener
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Boolean> <>9__9_0; //Field offset: 0x8
		public static Action<TransactionResult> <>9__9_1; //Field offset: 0x10
		public static Action <>9__9_2; //Field offset: 0x18
		public static Action<String[]> <>9__9_3; //Field offset: 0x20
		public static Action<JObject, Boolean> <>9__31_2; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__9_0(bool <p0>) { }

		internal void <.ctor>b__9_1(TransactionResult <p0>) { }

		internal void <.ctor>b__9_2() { }

		internal void <.ctor>b__9_3(String[] <p0>) { }

		internal void <OnReceiptCompleted>b__31_2(JObject jObj, bool isOk) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public WWW www; //Field offset: 0x10
		public string receiptData; //Field offset: 0x18

		public <>c__DisplayClass31_0() { }

		internal void <OnReceiptCompleted>b__0() { }

		internal bool <OnReceiptCompleted>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public Action<Boolean> callback; //Field offset: 0x10
		public TransactionResult transactionResult; //Field offset: 0x18
		public Action<JObject, Boolean> <>9__1; //Field offset: 0x48

		public <>c__DisplayClass34_0() { }

		internal void <SecondaryVerify>b__0(JObject jObj) { }

		internal void <SecondaryVerify>b__1(JObject _, bool isOk) { }

	}

	[CompilerGenerated]
	private sealed class <SandBoxVerify>d__33 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public string receiptData; //Field offset: 0x20
		public Action<JObject, Boolean> callback; //Field offset: 0x28
		private UnityWebRequest <uwr>5__2; //Field offset: 0x30

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
		public <SandBoxVerify>d__33(int <>1__state) { }

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

	private const char splitChar = '\u2F'; //Field offset: 0x0
	private const char enterChar = '\uA'; //Field offset: 0x0
	private static iOSStorePurchase s_Instance; //Field offset: 0x0
	private bool m_IsInited; //Field offset: 0x10
	private Product[] m_Products; //Field offset: 0x18
	[CompilerGenerated]
	private Action<Boolean> onInitSucceed; //Field offset: 0x20
	[CompilerGenerated]
	private Action<TransactionResult> onTransactionCompleted; //Field offset: 0x28
	[CompilerGenerated]
	private Action onRestoreCompleted; //Field offset: 0x30
	[CompilerGenerated]
	private Action<String[]> onReceiptCompleted; //Field offset: 0x38

	public override event Action<Boolean> onInitSucceed
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public override event Action<String[]> onReceiptCompleted
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public override event Action onRestoreCompleted
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public override event Action<TransactionResult> onTransactionCompleted
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public override bool Inited
	{
		 get { } //Length: 5
	}

	public override Product[] products
	{
		 get { } //Length: 5
	}

	public iOSStorePurchase() { }

	[CompilerGenerated]
	public override void add_onInitSucceed(Action<Boolean> value) { }

	[CompilerGenerated]
	public override void add_onReceiptCompleted(Action<String[]> value) { }

	[CompilerGenerated]
	public override void add_onRestoreCompleted(Action value) { }

	[CompilerGenerated]
	public override void add_onTransactionCompleted(Action<TransactionResult> value) { }

	public override bool get_Inited() { }

	public override Product[] get_products() { }

	public override void InitStoreIAP(String[] productIds) { }

	public override bool IsStoreAvailable() { }

	[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void OnInitSucceed(bool succeed, string info) { }

	[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void OnReceiptCompleted(string receiptData) { }

	private static void OnReceiptDataVerify(JObject jObject) { }

	[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void OnRestoreCompleted(string info) { }

	[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void OnTransactionCompleted(string info) { }

	public override void Purchase(string productId) { }

	[CompilerGenerated]
	public override void remove_onInitSucceed(Action<Boolean> value) { }

	[CompilerGenerated]
	public override void remove_onReceiptCompleted(Action<String[]> value) { }

	[CompilerGenerated]
	public override void remove_onRestoreCompleted(Action value) { }

	[CompilerGenerated]
	public override void remove_onTransactionCompleted(Action<TransactionResult> value) { }

	public override void Restore(string productId) { }

	public override void RestoreAll() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static IEnumerator SandBoxVerify(string receiptData, Action<JObject, Boolean> callback) { }

	public override void SecondaryVerify(TransactionResult transactionResult, Action<Boolean> callback) { }

	private static TransactionState StringToState(string str) { }

}

