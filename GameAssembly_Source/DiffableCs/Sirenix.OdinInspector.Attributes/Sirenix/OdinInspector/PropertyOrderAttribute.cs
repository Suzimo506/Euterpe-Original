namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class PropertyOrderAttribute : Attribute
{
	public float Order; //Field offset: 0x10

	public PropertyOrderAttribute() { }

	public PropertyOrderAttribute(float order) { }

}

