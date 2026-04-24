namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class TableMatrixAttribute : Attribute
{
	public bool IsReadOnly; //Field offset: 0x10
	public bool ResizableColumns; //Field offset: 0x11
	public string VerticalTitle; //Field offset: 0x18
	public string HorizontalTitle; //Field offset: 0x20
	public string DrawElementMethod; //Field offset: 0x28
	public int RowHeight; //Field offset: 0x30
	public bool SquareCells; //Field offset: 0x34
	public bool HideColumnIndices; //Field offset: 0x35
	public bool HideRowIndices; //Field offset: 0x36
	public bool RespectIndentLevel; //Field offset: 0x37
	public bool Transpose; //Field offset: 0x38

	public TableMatrixAttribute() { }

}

