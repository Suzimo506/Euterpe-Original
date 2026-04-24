namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class TableColumnWidthAttribute : Attribute
{
	public int Width; //Field offset: 0x10
	public bool Resizable; //Field offset: 0x14

	public TableColumnWidthAttribute(int width, bool resizable = true) { }

}

