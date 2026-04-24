namespace System.ComponentModel;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class DesignOnlyAttribute : Attribute
{
	public static readonly DesignOnlyAttribute Yes; //Field offset: 0x0
	public static readonly DesignOnlyAttribute No; //Field offset: 0x8
	public static readonly DesignOnlyAttribute Default; //Field offset: 0x10
	private bool isDesignOnly; //Field offset: 0x10

	public bool IsDesignOnly
	{
		 get { } //Length: 5
	}

	private static DesignOnlyAttribute() { }

	public DesignOnlyAttribute(bool isDesignOnly) { }

	public virtual bool Equals(object obj) { }

	public bool get_IsDesignOnly() { }

	public virtual int GetHashCode() { }

	public virtual bool IsDefaultAttribute() { }

}

