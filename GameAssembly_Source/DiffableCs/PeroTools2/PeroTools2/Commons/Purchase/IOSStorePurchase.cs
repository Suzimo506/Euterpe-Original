namespace PeroTools2.Commons.Purchase;

public class IOSStorePurchase : IStoreListener
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Product[]> <>9__8_0; //Field offset: 0x8
		public static Action<TransactionResult> <>9__8_1; //Field offset: 0x10
		public static Action <>9__8_2; //Field offset: 0x18
		public static Action<String[]> <>9__8_3; //Field offset: 0x20
		public static Action<Product[]> <>9__9_0; //Field offset: 0x28
		public static Action<TransactionResult> <>9__9_1; //Field offset: 0x30
		public static Action <>9__9_2; //Field offset: 0x38
		public static Action<String[]> <>9__9_3; //Field offset: 0x40

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__9_0(Product[] <p0>) { }

		internal void <.ctor>b__9_1(TransactionResult <p0>) { }

		internal void <.ctor>b__9_2() { }

		internal void <.ctor>b__9_3(String[] <p0>) { }

		internal void <Dispose>b__8_0(Product[] <p0>) { }

		internal void <Dispose>b__8_1(TransactionResult <p0>) { }

		internal void <Dispose>b__8_2() { }

		internal void <Dispose>b__8_3(String[] <p0>) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public WWW www; //Field offset: 0x10
		public IOSStorePurchase <>4__this; //Field offset: 0x18
		public Byte[] binaryData; //Field offset: 0x20
		public Func<Boolean> <>9__3; //Field offset: 0x28

		public <>c__DisplayClass31_0() { }

		internal void <ReceiptCompleted>b__0() { }

		internal bool <ReceiptCompleted>b__1() { }

		internal bool <ReceiptCompleted>b__3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_1
	{
		public JObject jObject; //Field offset: 0x10
		public int status; //Field offset: 0x18
		public <>c__DisplayClass31_0 CS$<>8__locals1; //Field offset: 0x20

		public <>c__DisplayClass31_1() { }

		internal void <ReceiptCompleted>b__2() { }

	}

	private static IOSStorePurchase s_Instance; //Field offset: 0x0
	private const char splitChar = '\u2F'; //Field offset: 0x0
	private bool m_IsInited; //Field offset: 0x10
	private Product[] m_Products; //Field offset: 0x18
	[CompilerGenerated]
	private Action<Product[]> onInitSucceed; //Field offset: 0x20
	[CompilerGenerated]
	private Action<TransactionResult> onTransactionCompleted; //Field offset: 0x28
	[CompilerGenerated]
	private Action onRestoreCompleted; //Field offset: 0x30
	[CompilerGenerated]
	private Action<String[]> onReceiptCompleted; //Field offset: 0x38

	public override event Action<Product[]> onInitSucceed
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

	public override bool inited
	{
		 get { } //Length: 5
	}

	public override Product[] products
	{
		 get { } //Length: 5
	}

	public IOSStorePurchase() { }

	[CompilerGenerated]
	public override void add_onInitSucceed(Action<Product[]> value) { }

	[CompilerGenerated]
	public override void add_onReceiptCompleted(Action<String[]> value) { }

	[CompilerGenerated]
	public override void add_onRestoreCompleted(Action value) { }

	[CompilerGenerated]
	public override void add_onTransactionCompleted(Action<TransactionResult> value) { }

	private void Dispose() { }

	public override bool get_inited() { }

	public override Product[] get_products() { }

	public override void InitStoreIAP(String[] productIds) { }

	public override bool IsStoreAvailable() { }

	[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void OnInitSucceed(string info) { }

	[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void OnReceiptCompleted(string receiptData) { }

	private void OnReceiptDataVerify(JObject jObject) { }

	[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void OnRestoreCompleted() { }

	[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void OnTransactionCompleted(string info) { }

	public override void Purchase(string productId) { }

	private void ReceiptCompleted(string receiptData) { }

	[CompilerGenerated]
	public override void remove_onInitSucceed(Action<Product[]> value) { }

	[CompilerGenerated]
	public override void remove_onReceiptCompleted(Action<String[]> value) { }

	[CompilerGenerated]
	public override void remove_onRestoreCompleted(Action value) { }

	[CompilerGenerated]
	public override void remove_onTransactionCompleted(Action<TransactionResult> value) { }

	public override void Restore(string productId) { }

	public override void RestoreAll() { }

}

