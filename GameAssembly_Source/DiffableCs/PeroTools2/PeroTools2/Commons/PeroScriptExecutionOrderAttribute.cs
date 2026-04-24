namespace PeroTools2.Commons;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class PeroScriptExecutionOrderAttribute : Attribute
{
	internal int order; //Field offset: 0x10

	public PeroScriptExecutionOrderAttribute(int order) { }

}

