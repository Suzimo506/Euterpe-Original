namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DontApplyToListElements]
public sealed class OnInspectorGUIAttribute : ShowInInspectorAttribute
{
	public string Prepend; //Field offset: 0x10
	public string Append; //Field offset: 0x18
	[Obsolete]
	public string PrependMethodName; //Field offset: 0x20
	[Obsolete]
	public string AppendMethodName; //Field offset: 0x28

	public OnInspectorGUIAttribute() { }

	public OnInspectorGUIAttribute(string action, bool append = true) { }

	public OnInspectorGUIAttribute(string prepend, string append) { }

}

