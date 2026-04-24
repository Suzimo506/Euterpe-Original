namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DontApplyToListElements]
public sealed class OnCollectionChangedAttribute : Attribute
{
	public string Before; //Field offset: 0x10
	public string After; //Field offset: 0x18

	public OnCollectionChangedAttribute() { }

	public OnCollectionChangedAttribute(string after) { }

	public OnCollectionChangedAttribute(string before, string after) { }

}

