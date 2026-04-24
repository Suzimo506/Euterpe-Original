namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DontApplyToListElements]
[HideInTables]
[IncludeMyAttributes]
public class OnInspectorDisposeAttribute : ShowInInspectorAttribute
{
	public string Action; //Field offset: 0x10

	public OnInspectorDisposeAttribute() { }

	public OnInspectorDisposeAttribute(string action) { }

}

