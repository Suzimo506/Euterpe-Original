namespace System.Diagnostics.Tracing;

internal struct ConcurrentSet
{
	private ItemType[] items; //Field offset: 0x0

	public ItemType GetOrAdd(ItemType newItem) { }

	public ItemType TryGet(KeyType key) { }

}

