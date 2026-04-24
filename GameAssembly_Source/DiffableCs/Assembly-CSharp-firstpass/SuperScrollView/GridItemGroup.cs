namespace SuperScrollView;

public class GridItemGroup
{
	private int mCount; //Field offset: 0x10
	private int mGroupIndex; //Field offset: 0x14
	private LoopGridViewItem mFirst; //Field offset: 0x18
	private LoopGridViewItem mLast; //Field offset: 0x20

	public int Count
	{
		 get { } //Length: 4
	}

	public LoopGridViewItem First
	{
		 get { } //Length: 5
	}

	public int GroupIndex
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public LoopGridViewItem Last
	{
		 get { } //Length: 5
	}

	public GridItemGroup() { }

	public void AddFirst(LoopGridViewItem newItem) { }

	public void AddLast(LoopGridViewItem newItem) { }

	public void Clear() { }

	public int get_Count() { }

	public LoopGridViewItem get_First() { }

	public int get_GroupIndex() { }

	public LoopGridViewItem get_Last() { }

	public LoopGridViewItem GetItemByColumn(int column) { }

	public LoopGridViewItem GetItemByRow(int row) { }

	public LoopGridViewItem RemoveFirst() { }

	public LoopGridViewItem RemoveLast() { }

	public void ReplaceItem(LoopGridViewItem curItem, LoopGridViewItem newItem) { }

	public void set_GroupIndex(int value) { }

}

