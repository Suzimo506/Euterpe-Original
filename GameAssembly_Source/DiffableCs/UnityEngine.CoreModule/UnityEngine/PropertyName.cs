namespace UnityEngine;

[UsedByNativeCode]
public struct PropertyName : IEquatable<PropertyName>
{
	internal int id; //Field offset: 0x0

	public PropertyName(string name) { }

	public PropertyName(PropertyName other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(PropertyName other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(PropertyName lhs, PropertyName rhs) { }

	public virtual string ToString() { }

}

