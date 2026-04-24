namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class RequiredAttribute : Attribute
{
	public string ErrorMessage; //Field offset: 0x10
	public InfoMessageType MessageType; //Field offset: 0x18

	public RequiredAttribute() { }

	public RequiredAttribute(string errorMessage, InfoMessageType messageType) { }

	public RequiredAttribute(string errorMessage) { }

	public RequiredAttribute(InfoMessageType messageType) { }

}

