namespace Sirenix.Serialization;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class BindTypeNameToTypeAttribute : Attribute
{
	internal readonly Type NewType; //Field offset: 0x10
	internal readonly string OldTypeName; //Field offset: 0x18

	public BindTypeNameToTypeAttribute(string oldFullTypeName, Type newType) { }

}

