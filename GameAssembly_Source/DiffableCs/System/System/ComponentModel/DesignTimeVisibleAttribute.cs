namespace System.ComponentModel;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class DesignTimeVisibleAttribute : Attribute
{
	public static readonly DesignTimeVisibleAttribute Yes; //Field offset: 0x0
	public static readonly DesignTimeVisibleAttribute No; //Field offset: 0x8
	public static readonly DesignTimeVisibleAttribute Default; //Field offset: 0x10
	private bool visible; //Field offset: 0x10

	public bool Visible
	{
		 get { } //Length: 5
	}

	private static DesignTimeVisibleAttribute() { }

	public DesignTimeVisibleAttribute(bool visible) { }

	public virtual bool Equals(object obj) { }

	public bool get_Visible() { }

	public virtual int GetHashCode() { }

	public virtual bool IsDefaultAttribute() { }

}

