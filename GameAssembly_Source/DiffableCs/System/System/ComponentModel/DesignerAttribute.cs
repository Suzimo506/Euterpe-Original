namespace System.ComponentModel;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class DesignerAttribute : Attribute
{
	private readonly string designerTypeName; //Field offset: 0x10
	private readonly string designerBaseTypeName; //Field offset: 0x18
	private string typeId; //Field offset: 0x20

	public virtual object TypeId
	{
		 get { } //Length: 163
	}

	public DesignerAttribute(string designerTypeName, Type designerBaseType) { }

	public virtual bool Equals(object obj) { }

	public virtual object get_TypeId() { }

	public virtual int GetHashCode() { }

}

