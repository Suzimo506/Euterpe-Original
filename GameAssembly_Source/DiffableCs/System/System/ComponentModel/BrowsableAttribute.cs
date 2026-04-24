namespace System.ComponentModel;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class BrowsableAttribute : Attribute
{
	public static readonly BrowsableAttribute Yes; //Field offset: 0x0
	public static readonly BrowsableAttribute No; //Field offset: 0x8
	public static readonly BrowsableAttribute Default; //Field offset: 0x10
	private bool browsable; //Field offset: 0x10

	public bool Browsable
	{
		 get { } //Length: 5
	}

	private static BrowsableAttribute() { }

	public BrowsableAttribute(bool browsable) { }

	public virtual bool Equals(object obj) { }

	public bool get_Browsable() { }

	public virtual int GetHashCode() { }

	public virtual bool IsDefaultAttribute() { }

}

