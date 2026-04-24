namespace PeroTools2.Managers;

public class IAPManager : Singleton<IAPManager>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Product[]> <>9__28_0; //Field offset: 0x8
		public static Action<TransactionResult> <>9__28_1; //Field offset: 0x10
		public static Action <>9__28_2; //Field offset: 0x18
		public static Action<String[]> <>9__28_3; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__28_0(Product[] <p0>) { }

		internal void <.ctor>b__28_1(TransactionResult <p0>) { }

		internal void <.ctor>b__28_2() { }

		internal void <.ctor>b__28_3(String[] <p0>) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public IAPManager <>4__this; //Field offset: 0x10
		public Product[] products; //Field offset: 0x18

		public <>c__DisplayClass12_0() { }

		internal void <OnInitSucceed>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public IAPManager <>4__this; //Field offset: 0x10
		public TransactionResult result; //Field offset: 0x18

		public <>c__DisplayClass13_0() { }

		internal void <OnTransactionCompleted>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public IAPManager <>4__this; //Field offset: 0x10
		public String[] receipt; //Field offset: 0x18

		public <>c__DisplayClass15_0() { }

		internal void <OnReceiptCompleted>b__0() { }

	}

	[CompilerGenerated]
	private Action<Product[]> onInitSucceed; //Field offset: 0x10
	[CompilerGenerated]
	private Action<TransactionResult> onTransactionCompleted; //Field offset: 0x18
	[CompilerGenerated]
	private Action onRestoreCompleted; //Field offset: 0x20
	[CompilerGenerated]
	private Action<String[]> onReceiptCompleted; //Field offset: 0x28
	private IStoreListener m_StoreListener; //Field offset: 0x30

	public event Action<Product[]> onInitSucceed
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action<String[]> onReceiptCompleted
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action onRestoreCompleted
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action<TransactionResult> onTransactionCompleted
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public bool hasHandler
	{
		 get { } //Length: 9
	}

	public bool isInited
	{
		 get { } //Length: 69
	}

	public bool isPurchaseAvailable
	{
		 get { } //Length: 72
	}

	public IAPManager() { }

	[CompilerGenerated]
	private void <OnRestoreCompleted>b__14_0() { }

	[CompilerGenerated]
	public void add_onInitSucceed(Action<Product[]> value) { }

	[CompilerGenerated]
	public void add_onReceiptCompleted(Action<String[]> value) { }

	[CompilerGenerated]
	public void add_onRestoreCompleted(Action value) { }

	[CompilerGenerated]
	public void add_onTransactionCompleted(Action<TransactionResult> value) { }

	public bool get_hasHandler() { }

	public bool get_isInited() { }

	public bool get_isPurchaseAvailable() { }

	public void InitIAP(String[] productIds) { }

	private void OnInitSucceed(Product[] products) { }

	private void OnReceiptCompleted(String[] receipt) { }

	private void OnRestoreCompleted() { }

	private void OnTransactionCompleted(TransactionResult result) { }

	public void Purchase(string productId) { }

	[CompilerGenerated]
	public void remove_onInitSucceed(Action<Product[]> value) { }

	[CompilerGenerated]
	public void remove_onReceiptCompleted(Action<String[]> value) { }

	[CompilerGenerated]
	public void remove_onRestoreCompleted(Action value) { }

	[CompilerGenerated]
	public void remove_onTransactionCompleted(Action<TransactionResult> value) { }

	public void RestoreAll() { }

	private void SetListener(bool addCallback) { }

	public void SetStoreHandler(IStoreListener store) { }

}

