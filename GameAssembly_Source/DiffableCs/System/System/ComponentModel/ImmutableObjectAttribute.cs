namespace System.ComponentModel;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class ImmutableObjectAttribute : Attribute
{
	public static readonly ImmutableObjectAttribute Yes; //Field offset: 0x0
	public static readonly ImmutableObjectAttribute No; //Field offset: 0x8
	public static readonly ImmutableObjectAttribute Default; //Field offset: 0x10
	private bool immutable; //Field offset: 0x10

	public bool Immutable
	{
		 get { } //Length: 5
	}

	private static ImmutableObjectAttribute() { }

	public ImmutableObjectAttribute(bool immutable) { }

	public virtual bool Equals(object obj) { }

	public bool get_Immutable() { }

	public virtual int GetHashCode() { }

	public virtual bool IsDefaultAttribute() { }

}

