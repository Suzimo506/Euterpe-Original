namespace Assets.Scripts.Purchase;

public interface IStoreListener
{

	public event Action<Boolean> onInitSucceed
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<String[]> onReceiptCompleted
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action onRestoreCompleted
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<TransactionResult> onTransactionCompleted
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool Inited
	{
		 get { } //Length: 0
	}

	public Product[] products
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_onInitSucceed(Action<Boolean> value) { }

	[CompilerGenerated]
	public void add_onReceiptCompleted(Action<String[]> value) { }

	[CompilerGenerated]
	public void add_onRestoreCompleted(Action value) { }

	[CompilerGenerated]
	public void add_onTransactionCompleted(Action<TransactionResult> value) { }

	public bool get_Inited() { }

	public Product[] get_products() { }

	public void InitStoreIAP(String[] productIds) { }

	public bool IsStoreAvailable() { }

	public void Purchase(string productId) { }

	[CompilerGenerated]
	public void remove_onInitSucceed(Action<Boolean> value) { }

	[CompilerGenerated]
	public void remove_onReceiptCompleted(Action<String[]> value) { }

	[CompilerGenerated]
	public void remove_onRestoreCompleted(Action value) { }

	[CompilerGenerated]
	public void remove_onTransactionCompleted(Action<TransactionResult> value) { }

	public void Restore(string productId) { }

	public void RestoreAll() { }

	public void SecondaryVerify(TransactionResult transactionResult, Action<Boolean> callback) { }

}

