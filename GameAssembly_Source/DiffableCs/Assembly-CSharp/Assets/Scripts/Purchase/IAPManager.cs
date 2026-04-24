namespace Assets.Scripts.Purchase;

public abstract class IAPManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Boolean> <>9__32_0; //Field offset: 0x8
		public static Action<TransactionResult> <>9__32_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__32_0(bool <p0>) { }

		internal void <.ctor>b__32_1(TransactionResult <p0>) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public string productId; //Field offset: 0x10

		public <>c__DisplayClass31_0() { }

		internal bool <GetProduct>b__0(Product p) { }

	}

	protected static IAPManager s_Instance; //Field offset: 0x0
	protected Dictionary<String, Product> m_Products; //Field offset: 0x10
	protected uint m_Arg; //Field offset: 0x18
	protected Action<Boolean> OnGetProductsCompleted; //Field offset: 0x20
	protected Action<TransactionResult> OnTransactionCompleted; //Field offset: 0x28
	protected IStoreListener m_StoreListener; //Field offset: 0x30
	protected bool m_Initing; //Field offset: 0x38

	public event Action<Boolean> onGetProductsCompleted
	{
		 add { } //Length: 118
		 remove { } //Length: 118
	}

	public event Action<TransactionResult> onTransactionCompleted
	{
		 add { } //Length: 118
		 remove { } //Length: 118
	}

	public bool hasHandler
	{
		 get { } //Length: 9
	}

	public static IAPManager instance
	{
		 get { } //Length: 53
	}

	public bool isInited
	{
		 get { } //Length: 72
	}

	public bool isPurchaseAvailable
	{
		 get { } //Length: 72
	}

	protected IAPManager() { }

	public void add_onGetProductsCompleted(Action<Boolean> value) { }

	public void add_onTransactionCompleted(Action<TransactionResult> value) { }

	public override void ClearPurchase() { }

	public bool get_hasHandler() { }

	public static IAPManager get_instance() { }

	public bool get_isInited() { }

	public bool get_isPurchaseAvailable() { }

	public static T GetInstance() { }

	public Product GetProduct(string productId) { }

	public override void InitIAP(String[] productIds) { }

	private void InitProductDic() { }

	protected void InvokeTransactionCompleted(string msg, string productId, TransactionState state) { }

	public override void Purchase(string productId) { }

	public void remove_onGetProductsCompleted(Action<Boolean> value) { }

	public void remove_onTransactionCompleted(Action<TransactionResult> value) { }

	public void RestoreAll() { }

	public void SetArg(uint arg) { }

	public void SetStoreHandler(IStoreListener store) { }

	public bool TryGetProduct(string productId, out Product product) { }

}

