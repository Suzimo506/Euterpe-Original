namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DontApplyToListElements]
public sealed class ValidateInputAttribute : Attribute
{
	public string DefaultMessage; //Field offset: 0x10
	public string Condition; //Field offset: 0x18
	public InfoMessageType MessageType; //Field offset: 0x20
	public bool IncludeChildren; //Field offset: 0x24
	public bool ContinuousValidationCheck; //Field offset: 0x25

	[Obsolete]
	public bool ContiniousValidationCheck
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	[Obsolete]
	public string MemberName
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public ValidateInputAttribute(string condition, string defaultMessage = null, InfoMessageType messageType = 3) { }

	[Obsolete]
	public ValidateInputAttribute(string condition, string message, InfoMessageType messageType, bool rejectedInvalidInput) { }

	public bool get_ContiniousValidationCheck() { }

	public string get_MemberName() { }

	public void set_ContiniousValidationCheck(bool value) { }

	public void set_MemberName(string value) { }

}

