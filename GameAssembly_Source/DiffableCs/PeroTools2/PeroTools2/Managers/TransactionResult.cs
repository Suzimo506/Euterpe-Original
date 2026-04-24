namespace PeroTools2.Managers;

public class TransactionResult
{
	public TransactionState state; //Field offset: 0x10
	public string productId; //Field offset: 0x18
	public string receipt; //Field offset: 0x20

	public TransactionResult() { }

}

