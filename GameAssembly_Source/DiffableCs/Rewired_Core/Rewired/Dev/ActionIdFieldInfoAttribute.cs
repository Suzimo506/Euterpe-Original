namespace Rewired.Dev;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ActionIdFieldInfoAttribute : Attribute
{
	public string categoryName; //Field offset: 0x10
	public string friendlyName; //Field offset: 0x18

	public ActionIdFieldInfoAttribute() { }

}

