namespace Assets.Scripts.Purchase;

internal class GoogleStorePurchase : IStoreListener
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

	public GoogleStorePurchase() { }

	private void AcknowledgePurchaseFailed(string msg) { }

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

	private void GooglePurchaseFailed(string e, int r) { }

	private void InitFailed(string s) { }

	public override void InitStoreIAP(String[] productIds) { }

	private void InitSucceeded() { }

	private void InventoryFailed(string msg) { }

	public override bool IsStoreAvailable() { }

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

}

