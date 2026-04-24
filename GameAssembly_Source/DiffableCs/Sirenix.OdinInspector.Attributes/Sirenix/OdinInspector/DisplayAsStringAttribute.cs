namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class DisplayAsStringAttribute : Attribute
{
	public bool Overflow; //Field offset: 0x10

	public DisplayAsStringAttribute() { }

	public DisplayAsStringAttribute(bool overflow) { }

}

