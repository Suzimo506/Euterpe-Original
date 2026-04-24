namespace SuperScrollView;

public abstract class AbstractTreeViewItemMgr
{
	protected bool mIsDirty; //Field offset: 0x10
	protected List<BaseTreeViewItemData> mTreeItemDataList; //Field offset: 0x18
	protected BaseTreeViewItemData mLastQueryResult; //Field offset: 0x20

	public int TreeViewItemCount
	{
		 get { } //Length: 59
	}

	protected AbstractTreeViewItemMgr() { }

	public void Clear() { }

	public int get_TreeViewItemCount() { }

	public int GetTotalItemAndChildCount() { }

	private BaseTreeViewItemData GetTreeItem(int treeIndex) { }

	public bool IsTreeItemExpand(int treeIndex) { }

	public void SetItemChildCount(int treeIndex, int count) { }

	public void SetItemExpand(int treeIndex, bool isExpand) { }

	public void ToggleItemExpand(int treeIndex) { }

	protected void UpdateAllTreeItemDataIndex() { }

}

