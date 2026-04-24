namespace SuperScrollView;

public class LoopStaggeredGridView : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
{
	private Dictionary<String, StaggeredGridItemPool> mItemPoolDict; //Field offset: 0x18
	private List<StaggeredGridItemPool> mItemPoolList; //Field offset: 0x20
	[SerializeField]
	private List<StaggeredGridItemPrefabConfData> mItemPrefabDataList; //Field offset: 0x28
	[SerializeField]
	private ListItemArrangeType mArrangeType; //Field offset: 0x30
	private RectTransform mContainerTrans; //Field offset: 0x38
	private ScrollRect mScrollRect; //Field offset: 0x40
	private int mGroupCount; //Field offset: 0x48
	private List<StaggeredGridItemGroup> mItemGroupList; //Field offset: 0x50
	private List<ItemIndexData> mItemIndexDataList; //Field offset: 0x58
	private RectTransform mScrollRectTransform; //Field offset: 0x60
	private RectTransform mViewPortRectTransform; //Field offset: 0x68
	private float mItemDefaultWithPaddingSize; //Field offset: 0x70
	private int mItemTotalCount; //Field offset: 0x74
	private bool mIsVertList; //Field offset: 0x78
	private Func<LoopStaggeredGridView, Int32, LoopStaggeredGridViewItem> mOnGetItemByItemIndex; //Field offset: 0x80
	private Vector3[] mItemWorldCorners; //Field offset: 0x88
	private Vector3[] mViewPortRectLocalCorners; //Field offset: 0x90
	private float mDistanceForRecycle0; //Field offset: 0x98
	private float mDistanceForNew0; //Field offset: 0x9C
	private float mDistanceForRecycle1; //Field offset: 0xA0
	private float mDistanceForNew1; //Field offset: 0xA4
	private bool mIsDraging; //Field offset: 0xA8
	private PointerEventData mPointerEventData; //Field offset: 0xB0
	public Action mOnBeginDragAction; //Field offset: 0xB8
	public Action mOnDragingAction; //Field offset: 0xC0
	public Action mOnEndDragAction; //Field offset: 0xC8
	private Vector3 mLastFrameContainerPos; //Field offset: 0xD0
	private bool mListViewInited; //Field offset: 0xDC
	private int mListUpdateCheckFrameCount; //Field offset: 0xE0
	private GridViewLayoutParam mLayoutParam; //Field offset: 0xE8

	public ListItemArrangeType ArrangeType
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public RectTransform ContainerTrans
	{
		 get { } //Length: 5
	}

	public int CurMaxCreatedItemIndexCount
	{
		 get { } //Length: 59
	}

	public bool IsDraging
	{
		 get { } //Length: 8
	}

	public bool IsInited
	{
		 get { } //Length: 8
	}

	public bool IsVertList
	{
		 get { } //Length: 5
	}

	public List<StaggeredGridItemPrefabConfData> ItemPrefabDataList
	{
		 get { } //Length: 5
	}

	public int ItemTotalCount
	{
		 get { } //Length: 4
	}

	public GridViewLayoutParam LayoutParam
	{
		 get { } //Length: 8
	}

	public int ListUpdateCheckFrameCount
	{
		 get { } //Length: 7
	}

	public ScrollRect ScrollRect
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

	public LoopStaggeredGridView() { }

	private void AdjustAnchor(RectTransform rtf) { }

	private void AdjustContainerAnchor(RectTransform rtf) { }

	private void AdjustContainerPivot(RectTransform rtf) { }

	private void AdjustPivot(RectTransform rtf) { }

	private void CacheDragPointerEventData(PointerEventData eventData) { }

	private void CheckAllGroupIfNeedUpdateItemPos() { }

	public void ClearAllTmpRecycledItem() { }

	public ListItemArrangeType get_ArrangeType() { }

	public RectTransform get_ContainerTrans() { }

	public int get_CurMaxCreatedItemIndexCount() { }

	public bool get_IsDraging() { }

	public bool get_IsInited() { }

	public bool get_IsVertList() { }

	public List<StaggeredGridItemPrefabConfData> get_ItemPrefabDataList() { }

	public int get_ItemTotalCount() { }

	public GridViewLayoutParam get_LayoutParam() { }

	public int get_ListUpdateCheckFrameCount() { }

	public ScrollRect get_ScrollRect() { }

	public float get_ViewPortHeight() { }

	public float get_ViewPortSize() { }

	public float get_ViewPortWidth() { }

	public float GetContentSize() { }

	private int GetCurShouldAddNewItemGroupIndex() { }

	public float GetItemAbsPosByItemIndex(int itemIndex) { }

	public StaggeredGridItemGroup GetItemGroupByIndex(int index) { }

	public ItemIndexData GetItemIndexData(int itemIndex) { }

	public StaggeredGridItemPrefabConfData GetItemPrefabConfData(string prefabName) { }

	public LoopStaggeredGridViewItem GetNewItemByGroupAndIndex(int groupIndex, int indexInGroup) { }

	public LoopStaggeredGridViewItem GetShownItemByItemIndex(int itemIndex) { }

	private void InitItemPool() { }

	public void InitListView(int itemTotalCount, GridViewLayoutParam layoutParam, Func<LoopStaggeredGridView, Int32, LoopStaggeredGridViewItem> onGetItemByItemIndex, StaggeredGridViewInitParam initParam = null) { }

	public void MovePanelToItemIndex(int itemIndex, float offset) { }

	public LoopStaggeredGridViewItem NewListViewItem(string itemPrefabName) { }

	public override void OnBeginDrag(PointerEventData eventData) { }

	public override void OnDrag(PointerEventData eventData) { }

	public override void OnEndDrag(PointerEventData eventData) { }

	public void OnItemSizeChanged(int itemIndex) { }

	public void RecycleAllItem() { }

	public void RecycleItemTmp(LoopStaggeredGridViewItem item) { }

	public void RefreshAllShownItem() { }

	public void RefreshItemByItemIndex(int itemIndex) { }

	public void ResetGridViewLayoutParam(int itemTotalCount, GridViewLayoutParam layoutParam) { }

	public void ResetListView(bool resetPos = true) { }

	public void set_ArrangeType(ListItemArrangeType value) { }

	private void SetAnchoredPositionX(RectTransform rtf, float x) { }

	private void SetAnchoredPositionY(RectTransform rtf, float y) { }

	public void SetListItemCount(int itemCount, bool resetPos = true) { }

	private void Update() { }

	public void UpdateAllGroupShownItemsPos() { }

	public void UpdateContentSize() { }

	private void UpdateLayoutParamAutoValue() { }

	public void UpdateListView(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1) { }

	public void UpdateListViewWithDefault() { }

}

