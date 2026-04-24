namespace System.ComponentModel;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class ReadOnlyAttribute : Attribute
{
	public static readonly ReadOnlyAttribute Yes; //Field offset: 0x0
	public static readonly ReadOnlyAttribute No; //Field offset: 0x8
	public static readonly ReadOnlyAttribute Default; //Field offset: 0x10
	private bool isReadOnly; //Field offset: 0x10

	public bool IsReadOnly
	{
		 get { } //Length: 5
	}

	private static ReadOnlyAttribute() { }

	public ReadOnlyAttribute(bool isReadOnly) { }

	public virtual bool Equals(object value) { }

	public bool get_IsReadOnly() { }

	public virtual int GetHashCode() { }

	public virtual bool IsDefaultAttribute() { }

}

