namespace Sirenix.OdinInspector;

[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ChildGameObjectsOnlyAttribute : Attribute
{
	public bool IncludeSelf; //Field offset: 0x10
	public bool IncludeInactive; //Field offset: 0x11

	public ChildGameObjectsOnlyAttribute() { }

}

