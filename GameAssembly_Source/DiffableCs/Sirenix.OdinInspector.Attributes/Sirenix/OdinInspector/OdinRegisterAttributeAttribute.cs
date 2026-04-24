namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class OdinRegisterAttributeAttribute : Attribute
{
	public Type AttributeType; //Field offset: 0x10
	public string Categories; //Field offset: 0x18
	public string Description; //Field offset: 0x20
	public string DocumentationUrl; //Field offset: 0x28
	public bool IsEnterprise; //Field offset: 0x30

	public OdinRegisterAttributeAttribute(Type attributeType, string category, string description, bool isEnterprise) { }

	public OdinRegisterAttributeAttribute(Type attributeType, string category, string description, bool isEnterprise, string url) { }

}

