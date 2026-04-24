namespace System.ComponentModel;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class ListBindableAttribute : Attribute
{
	public static readonly ListBindableAttribute Yes; //Field offset: 0x0
	public static readonly ListBindableAttribute No; //Field offset: 0x8
	public static readonly ListBindableAttribute Default; //Field offset: 0x10
	private bool listBindable; //Field offset: 0x10
	private bool isDefault; //Field offset: 0x11

	public bool ListBindable
	{
		 get { } //Length: 5
	}

	private static ListBindableAttribute() { }

	public ListBindableAttribute(bool listBindable) { }

	public virtual bool Equals(object obj) { }

	public bool get_ListBindable() { }

	public virtual int GetHashCode() { }

	public virtual bool IsDefaultAttribute() { }

}

