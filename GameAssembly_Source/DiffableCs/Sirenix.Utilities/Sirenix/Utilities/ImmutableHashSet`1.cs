namespace Sirenix.Utilities;

public class ImmutableHashSet : IEnumerable<T>, IEnumerable
{
	private readonly HashSet<T> hashSet; //Field offset: 0x0

	public ImmutableHashSet`1(HashSet<T> hashSet) { }

	public bool Contains(T item) { }

	public override IEnumerator<T> GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

