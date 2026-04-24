namespace System.ComponentModel.Design.Serialization;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Obsolete]
public sealed class RootDesignerSerializerAttribute : Attribute
{
	private bool reloadable; //Field offset: 0x10
	private string serializerTypeName; //Field offset: 0x18
	private string serializerBaseTypeName; //Field offset: 0x20
	private string typeId; //Field offset: 0x28

	public virtual object TypeId
	{
		 get { } //Length: 163
	}

	public RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable) { }

	public virtual object get_TypeId() { }

}

