namespace System.Diagnostics.Tracing;

internal abstract class ConcurrentSetItem
{

	protected ConcurrentSetItem`2() { }

	public abstract int Compare(KeyType key) { }

	public abstract int Compare(ItemType other) { }

}

