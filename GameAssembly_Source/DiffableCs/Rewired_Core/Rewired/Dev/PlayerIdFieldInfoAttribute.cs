namespace Rewired.Dev;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class PlayerIdFieldInfoAttribute : Attribute
{
	public string friendlyName; //Field offset: 0x10

	public PlayerIdFieldInfoAttribute() { }

}

