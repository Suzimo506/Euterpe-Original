namespace Sirenix.Serialization.Utilities;

public class FastTypeComparer : IEqualityComparer<Type>
{
	public static readonly FastTypeComparer Instance; //Field offset: 0x68520

	private static FastTypeComparer() { }

	public FastTypeComparer() { }

	public override bool Equals(Type x, Type y) { }

	public override int GetHashCode(Type obj) { }

}

