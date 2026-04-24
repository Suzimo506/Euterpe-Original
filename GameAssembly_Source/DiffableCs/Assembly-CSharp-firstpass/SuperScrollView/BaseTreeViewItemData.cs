namespace SuperScrollView;

public class BaseTreeViewItemData
{
	public int mTreeItemIndex; //Field offset: 0x10
	public int mChildCount; //Field offset: 0x14
	public bool mIsExpand; //Field offset: 0x18
	public int mBeginIndex; //Field offset: 0x1C
	public int mEndIndex; //Field offset: 0x20
	public int m_ChildBeganIndex; //Field offset: 0x24
	public int m_ChildEndIndex; //Field offset: 0x28
	public int m_ItemType; //Field offset: 0x2C

	public BaseTreeViewItemData() { }

	public override int GetChildIndex(int index) { }

	public override bool IsChild(int index) { }

}

