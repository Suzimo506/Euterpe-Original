namespace Sirenix.Serialization.Utilities;

internal class ReferenceEqualityComparer : IEqualityComparer<T>
{
	public static readonly ReferenceEqualityComparer<T> Default; //Field offset: 0x0

	private static ReferenceEqualityComparer`1() { }

	public ReferenceEqualityComparer`1() { }

	public override bool Equals(T x, T y) { }

	public override int GetHashCode(T obj) { }

}

