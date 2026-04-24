namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class TableListAttribute : Attribute
{
	public int NumberOfItemsPerPage; //Field offset: 0x10
	public bool IsReadOnly; //Field offset: 0x14
	public int DefaultMinColumnWidth; //Field offset: 0x18
	public bool ShowIndexLabels; //Field offset: 0x1C
	public bool DrawScrollView; //Field offset: 0x1D
	public int MinScrollViewHeight; //Field offset: 0x20
	public int MaxScrollViewHeight; //Field offset: 0x24
	public bool AlwaysExpanded; //Field offset: 0x28
	public bool HideToolbar; //Field offset: 0x29
	public int CellPadding; //Field offset: 0x2C
	[HideInInspector]
	[SerializeField]
	private bool showPagingHasValue; //Field offset: 0x30
	[HideInInspector]
	[SerializeField]
	private bool showPaging; //Field offset: 0x31

	public int ScrollViewHeight
	{
		 get { } //Length: 98
		 set { } //Length: 7
	}

	public bool ShowPaging
	{
		 get { } //Length: 5
		 set { } //Length: 8
	}

	public bool ShowPagingHasValue
	{
		 get { } //Length: 5
	}

	public TableListAttribute() { }

	public int get_ScrollViewHeight() { }

	public bool get_ShowPaging() { }

	public bool get_ShowPagingHasValue() { }

	public void set_ScrollViewHeight(int value) { }

	public void set_ShowPaging(bool value) { }

}

