namespace Assets.Scripts.Purchase;

internal class TapTapStorePurchase : IStoreListener
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Boolean> <>9__30_0; //Field offset: 0x8
		public static Action<TransactionResult> <>9__30_1; //Field offset: 0x10
		public static Action <>9__30_2; //Field offset: 0x18
		public static Action<String[]> <>9__30_3; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__30_0(bool <p0>) { }

		internal void <.ctor>b__30_1(TransactionResult <p0>) { }

		internal void <.ctor>b__30_2() { }

		internal void <.ctor>b__30_3(String[] <p0>) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public string id; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal bool <InitProducts>b__1(Product p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public string productId; //Field offset: 0x10
		public TapTapStorePurchase <>4__this; //Field offset: 0x18
		public decimal price; //Field offset: 0x20
		public Action<String> <>9__3; //Field offset: 0x30
		public Action<Int32, String> <>9__4; //Field offset: 0x38

		public <>c__DisplayClass23_0() { }

		internal bool <Private_Purchase>b__0(Product p) { }

		internal void <Private_Purchase>b__1(JObject jObj) { }

		internal void <Private_Purchase>b__2(long l, string s) { }

		internal void <Private_Purchase>b__3(string res) { }

		internal void <Private_Purchase>b__4(int c, string e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public TapTapStorePurchase <>4__this; //Field offset: 0x10
		public string productId; //Field offset: 0x18

		public <>c__DisplayClass25_0() { }

		internal void <TapTapRefreshPeroUid>b__0(JObject jObj) { }

		internal void <TapTapRefreshPeroUid>b__1(long l, string s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public TransactionResult transactionResult; //Field offset: 0x10
		public Action<Boolean> callback; //Field offset: 0x40
		public string productId; //Field offset: 0x48

		public <>c__DisplayClass29_0() { }

		internal void <SecondaryVerify>b__0(JObject jObj) { }

		internal void <SecondaryVerify>b__1(long l, string s) { }

	}

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
	private String[] m_ProductIds; //Field offset: 0x40

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

	public TapTapStorePurchase() { }

	[CompilerGenerated]
	private void <InitProducts>b__21_0(JObject jObj) { }

	[CompilerGenerated]
	private void <RestoreAll>b__27_0(JObject jObj) { }

	[CompilerGenerated]
	private void <RestoreAll>b__27_1(long l, string s) { }

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

	private void InitFailed(long l, string s) { }

	private void InitProducts() { }

	public override void InitStoreIAP(String[] productIds) { }

	public override bool IsStoreAvailable() { }

	private void PeroUidCheckFail(string productId) { }

	private void Private_Purchase(string productId) { }

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

	public override void SecondaryVerify(TransactionResult transactionResult, Action<Boolean> callback) { }

	private void TapTapRefreshPeroUid(string productId) { }

}

