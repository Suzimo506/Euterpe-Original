namespace Assets.Scripts.Purchase;

public struct TransactionResult
{
	public TransactionState state; //Field offset: 0x0
	public string productId; //Field offset: 0x8
	public List<String> productIds; //Field offset: 0x10
	public string receipt; //Field offset: 0x18
	public string msg; //Field offset: 0x20
	public uint arg; //Field offset: 0x28

}

