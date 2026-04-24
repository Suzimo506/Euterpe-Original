namespace System.ComponentModel;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class DesignerSerializationVisibilityAttribute : Attribute
{
	public static readonly DesignerSerializationVisibilityAttribute Content; //Field offset: 0x0
	public static readonly DesignerSerializationVisibilityAttribute Hidden; //Field offset: 0x8
	public static readonly DesignerSerializationVisibilityAttribute Visible; //Field offset: 0x10
	public static readonly DesignerSerializationVisibilityAttribute Default; //Field offset: 0x18
	private DesignerSerializationVisibility visibility; //Field offset: 0x10

	public DesignerSerializationVisibility Visibility
	{
		 get { } //Length: 4
	}

	private static DesignerSerializationVisibilityAttribute() { }

	public DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility visibility) { }

	public virtual bool Equals(object obj) { }

	public DesignerSerializationVisibility get_Visibility() { }

	public virtual int GetHashCode() { }

	public virtual bool IsDefaultAttribute() { }

}

