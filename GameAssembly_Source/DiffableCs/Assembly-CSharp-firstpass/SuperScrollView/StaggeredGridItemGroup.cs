namespace SuperScrollView;

public class StaggeredGridItemGroup
{
	private LoopStaggeredGridView mParentGridView; //Field offset: 0x10
	private ListItemArrangeType mArrangeType; //Field offset: 0x18
	private List<LoopStaggeredGridViewItem> mItemList; //Field offset: 0x20
	private RectTransform mContainerTrans; //Field offset: 0x28
	private ScrollRect mScrollRect; //Field offset: 0x30
	public int mGroupIndex; //Field offset: 0x38
	private GameObject mGameObject; //Field offset: 0x40
	private List<Int32> mItemIndexMap; //Field offset: 0x48
	private RectTransform mScrollRectTransform; //Field offset: 0x50
	private RectTransform mViewPortRectTransform; //Field offset: 0x58
	private float mItemDefaultWithPaddingSize; //Field offset: 0x60
	private int mItemTotalCount; //Field offset: 0x64
	private bool mIsVertList; //Field offset: 0x68
	private Func<Int32, Int32, LoopStaggeredGridViewItem> mOnGetItemByIndex; //Field offset: 0x70
	private Vector3[] mItemWorldCorners; //Field offset: 0x78
	private Vector3[] mViewPortRectLocalCorners; //Field offset: 0x80
	private int mCurReadyMinItemIndex; //Field offset: 0x88
	private int mCurReadyMaxItemIndex; //Field offset: 0x8C
	private bool mNeedCheckNextMinItem; //Field offset: 0x90
	private bool mNeedCheckNextMaxItem; //Field offset: 0x91
	private ItemPosMgr mItemPosMgr; //Field offset: 0x98
	private bool mSupportScrollBar; //Field offset: 0xA0
	private int mLastItemIndex; //Field offset: 0xA4
	private float mLastItemPadding; //Field offset: 0xA8
	private Vector3 mLastFrameContainerPos; //Field offset: 0xAC
	private int mListUpdateCheckFrameCount; //Field offset: 0xB8

	public int HadCreatedItemCount
	{
		 get { } //Length: 59
	}

	private bool IsDraging
	{
		private get { } //Length: 30
	}

	public List<Int32> ItemIndexMap
	{
		 get { } //Length: 5
	}

	public float ViewPortHeight
	{
		 get { } //Length: 56
	}

	public float ViewPortSize
	{
		 get { } //Length: 105
	}

	public float ViewPortWidth
	{
		 get { } //Length: 56
	}

	public StaggeredGridItemGroup() { }

	public void CheckIfNeedUpdateItemPos() { }

	public void ClearAllTmpRecycledItem() { }

	public int get_HadCreatedItemCount() { }

	private bool get_IsDraging() { }

	public List<Int32> get_ItemIndexMap() { }

	public float get_ViewPortHeight() { }

	public float get_ViewPortSize() { }

	public float get_ViewPortWidth() { }

	public float GetContentPanelSize() { }

	public int GetIndexInShownItemList(LoopStaggeredGridViewItem item) { }

	public Vector3 GetItemCornerPosInViewPort(LoopStaggeredGridViewItem item, ItemCornerEnum corner = 0) { }

	public float GetItemPos(int itemIndex) { }

	private LoopStaggeredGridViewItem GetNewItemByIndexInGroup(int indexInGroup) { }

	private bool GetPlusItemIndexAndPosAtGivenPos(float pos, ref int index, ref float itemPos) { }

	public LoopStaggeredGridViewItem GetShownItemByIndexInGroup(int indexInGroup) { }

	public LoopStaggeredGridViewItem GetShownItemByItemIndex(int itemIndex) { }

	public float GetShownItemPosMaxValue() { }

	public void Init(LoopStaggeredGridView parent, int itemTotalCount, int groupIndex, Func<Int32, Int32, LoopStaggeredGridViewItem> onGetItemByIndex) { }

	public void OnItemSizeChanged(int indexInGroup) { }

	public void RecycleAllItem() { }

	public void RecycleItemTmp(LoopStaggeredGridViewItem item) { }

	public void RefreshAllShownItem() { }

	public void RefreshAllShownItemWithFirstIndexAndPos(int firstItemIndexInGroup, Vector3 pos) { }

	public void RefreshAllShownItemWithFirstIndexInGroup(int firstItemIndexInGroup) { }

	public void RefreshItemByIndexInGroup(int indexInGroup) { }

	public void ResetListView() { }

	private void SetItemSize(int itemIndex, float itemSize, float padding) { }

	public void SetListItemCount(int itemCount) { }

	public void UpdateAllShownItemsPos() { }

	public bool UpdateForHorizontalListPart1(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1) { }

	public bool UpdateForHorizontalListPart2(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1) { }

	public bool UpdateForVertListPart1(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1) { }

	public bool UpdateForVertListPart2(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1) { }

	private void UpdateItemIndexMap(int oldItemTotalCount) { }

	public void UpdateListViewPart1(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1) { }

	public bool UpdateListViewPart2(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1) { }

}

