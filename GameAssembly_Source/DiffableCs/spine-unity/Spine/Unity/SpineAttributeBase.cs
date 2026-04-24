namespace Spine.Unity;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class SpineAttributeBase : PropertyAttribute
{
	public string dataField; //Field offset: 0x10
	public string startsWith; //Field offset: 0x18
	public bool includeNone; //Field offset: 0x20
	public bool fallbackToTextField; //Field offset: 0x21

	protected SpineAttributeBase() { }

}

