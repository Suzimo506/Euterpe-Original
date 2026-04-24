namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DontApplyToListElements]
public sealed class OnValueChangedAttribute : Attribute
{
	public string Action; //Field offset: 0x10
	public bool IncludeChildren; //Field offset: 0x18
	public bool InvokeOnUndoRedo; //Field offset: 0x19
	public bool InvokeOnInitialize; //Field offset: 0x1A

	[Obsolete]
	public string MethodName
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public OnValueChangedAttribute(string action, bool includeChildren = false) { }

	public string get_MethodName() { }

	public void set_MethodName(string value) { }

}

