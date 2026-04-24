namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DontApplyToListElements]
public sealed class ListDrawerSettingsAttribute : Attribute
{
	public bool HideAddButton; //Field offset: 0x10
	public bool HideRemoveButton; //Field offset: 0x11
	public string ListElementLabelName; //Field offset: 0x18
	public string CustomAddFunction; //Field offset: 0x20
	public string CustomRemoveIndexFunction; //Field offset: 0x28
	public string CustomRemoveElementFunction; //Field offset: 0x30
	public string OnBeginListElementGUI; //Field offset: 0x38
	public string OnEndListElementGUI; //Field offset: 0x40
	public bool AlwaysAddDefaultValue; //Field offset: 0x48
	public bool AddCopiesLastElement; //Field offset: 0x49
	public string ElementColor; //Field offset: 0x50
	private string onTitleBarGUI; //Field offset: 0x58
	private int numberOfItemsPerPage; //Field offset: 0x60
	private bool paging; //Field offset: 0x64
	private bool draggable; //Field offset: 0x65
	private bool isReadOnly; //Field offset: 0x66
	private bool showItemCount; //Field offset: 0x67
	private bool pagingHasValue; //Field offset: 0x68
	private bool draggableHasValue; //Field offset: 0x69
	private bool isReadOnlyHasValue; //Field offset: 0x6A
	private bool showItemCountHasValue; //Field offset: 0x6B
	private bool expanded; //Field offset: 0x6C
	private bool expandedHasValue; //Field offset: 0x6D
	private bool numberOfItemsPerPageHasValue; //Field offset: 0x6E
	private bool showIndexLabels; //Field offset: 0x6F
	private bool showIndexLabelsHasValue; //Field offset: 0x70

	public bool DraggableHasValue
	{
		 get { } //Length: 5
	}

	public bool DraggableItems
	{
		 get { } //Length: 5
		 set { } //Length: 8
	}

	public bool Expanded
	{
		 get { } //Length: 5
		 set { } //Length: 8
	}

	public bool ExpandedHasValue
	{
		 get { } //Length: 5
	}

	public bool IsReadOnly
	{
		 get { } //Length: 5
		 set { } //Length: 8
	}

	public bool IsReadOnlyHasValue
	{
		 get { } //Length: 5
	}

	public int NumberOfItemsPerPage
	{
		 get { } //Length: 4
		 set { } //Length: 8
	}

	public bool NumberOfItemsPerPageHasValue
	{
		 get { } //Length: 5
	}

	public string OnTitleBarGUI
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public bool PagingHasValue
	{
		 get { } //Length: 5
	}

	public bool ShowIndexLabels
	{
		 get { } //Length: 5
		 set { } //Length: 8
	}

	public bool ShowIndexLabelsHasValue
	{
		 get { } //Length: 5
	}

	public bool ShowItemCount
	{
		 get { } //Length: 5
		 set { } //Length: 8
	}

	public bool ShowItemCountHasValue
	{
		 get { } //Length: 5
	}

	public bool ShowPaging
	{
		 get { } //Length: 5
		 set { } //Length: 8
	}

	public ListDrawerSettingsAttribute() { }

	public bool get_DraggableHasValue() { }

	public bool get_DraggableItems() { }

	public bool get_Expanded() { }

	public bool get_ExpandedHasValue() { }

	public bool get_IsReadOnly() { }

	public bool get_IsReadOnlyHasValue() { }

	public int get_NumberOfItemsPerPage() { }

	public bool get_NumberOfItemsPerPageHasValue() { }

	public string get_OnTitleBarGUI() { }

	public bool get_PagingHasValue() { }

	public bool get_ShowIndexLabels() { }

	public bool get_ShowIndexLabelsHasValue() { }

	public bool get_ShowItemCount() { }

	public bool get_ShowItemCountHasValue() { }

	public bool get_ShowPaging() { }

	public void set_DraggableItems(bool value) { }

	public void set_Expanded(bool value) { }

	public void set_IsReadOnly(bool value) { }

	public void set_NumberOfItemsPerPage(int value) { }

	public void set_OnTitleBarGUI(string value) { }

	public void set_ShowIndexLabels(bool value) { }

	public void set_ShowItemCount(bool value) { }

	public void set_ShowPaging(bool value) { }

}

