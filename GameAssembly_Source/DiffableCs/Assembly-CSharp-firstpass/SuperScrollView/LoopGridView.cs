namespace SuperScrollView;

public class LoopGridView : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
{
	private class ItemRangeData
	{
		public int mMaxRow; //Field offset: 0x10
		public int mMinRow; //Field offset: 0x14
		public int mMaxColumn; //Field offset: 0x18
		public int mMinColumn; //Field offset: 0x1C
		public Vector2 mCheckedPosition; //Field offset: 0x20

		public ItemRangeData() { }

	}

	private class SnapData
	{
		public SnapStatus mSnapStatus; //Field offset: 0x10
		public RowColumnPair mSnapTarget; //Field offset: 0x14
		public Vector2 mSnapNeedMoveDir; //Field offset: 0x1C
		public float mTargetSnapVal; //Field offset: 0x24
		public float mCurSnapVal; //Field offset: 0x28
		public bool mIsForceSnapTo; //Field offset: 0x2C

		public SnapData() { }

		public void Clear() { }

	}

	private Dictionary<String, GridItemPool> mItemPoolDict; //Field offset: 0x18
	private List<GridItemPool> mItemPoolList; //Field offset: 0x20
	[SerializeField]
	private List<GridViewItemPrefabConfData> mItemPrefabDataList; //Field offset: 0x28
	[SerializeField]
	private GridItemArrangeType mArrangeType; //Field offset: 0x30
	private RectTransform mContainerTrans; //Field offset: 0x38
	private ScrollRect mScrollRect; //Field offset: 0x40
	private RectTransform mScrollRectTransform; //Field offset: 0x48
	private RectTransform mViewPortRectTransform; //Field offset: 0x50
	private int mItemTotalCount; //Field offset: 0x58
	[SerializeField]
	private int mFixedRowOrColumnCount; //Field offset: 0x5C
	[SerializeField]
	private RectOffset mPadding; //Field offset: 0x60
	[SerializeField]
	private Vector2 mItemPadding; //Field offset: 0x68
	[SerializeField]
	private Vector2 mItemSize; //Field offset: 0x70
	[SerializeField]
	private Vector2 mItemRecycleDistance; //Field offset: 0x78
	private Vector2 mItemSizeWithPadding; //Field offset: 0x80
	private Vector2 mStartPadding; //Field offset: 0x88
	private Vector2 mEndPadding; //Field offset: 0x90
	private Func<LoopGridView, Int32, Int32, Int32, LoopGridViewItem> mOnGetItemByRowColumn; //Field offset: 0x98
	private List<GridItemGroup> mItemGroupObjPool; //Field offset: 0xA0
	private List<GridItemGroup> mItemGroupList; //Field offset: 0xA8
	private bool mIsDraging; //Field offset: 0xB0
	private int mRowCount; //Field offset: 0xB4
	private int mColumnCount; //Field offset: 0xB8
	public Action<PointerEventData> mOnBeginDragAction; //Field offset: 0xC0
	public Action<PointerEventData> mOnDragingAction; //Field offset: 0xC8
	public Action<PointerEventData> mOnEndDragAction; //Field offset: 0xD0
	private float mSmoothDumpVel; //Field offset: 0xD8
	private float mSmoothDumpRate; //Field offset: 0xDC
	private float mSnapFinishThreshold; //Field offset: 0xE0
	private float mSnapVecThreshold; //Field offset: 0xE4
	[SerializeField]
	private bool mItemSnapEnable; //Field offset: 0xE8
	[SerializeField]
	private GridFixedType mGridFixedType; //Field offset: 0xEC
	public Action<LoopGridView, LoopGridViewItem> mOnSnapItemFinished; //Field offset: 0xF0
	public Action<LoopGridView> mOnSnapNearestChanged; //Field offset: 0xF8
	private int mLeftSnapUpdateExtraCount; //Field offset: 0x100
	[SerializeField]
	private Vector2 mViewPortSnapPivot; //Field offset: 0x104
	[SerializeField]
	private Vector2 mItemSnapPivot; //Field offset: 0x10C
	private SnapData mCurSnapData; //Field offset: 0x118
	private Vector3 mLastSnapCheckPos; //Field offset: 0x120
	private bool mListViewInited; //Field offset: 0x12C
	private int mListUpdateCheckFrameCount; //Field offset: 0x130
	private ItemRangeData mCurFrameItemRangeData; //Field offset: 0x138
	private int mNeedCheckContentPosLeftCount; //Field offset: 0x140
	private ClickEventListener mScrollBarClickEventListener1; //Field offset: 0x148
	private ClickEventListener mScrollBarClickEventListener2; //Field offset: 0x150
	private RowColumnPair mCurSnapNearestItemRowColumn; //Field offset: 0x158

	public GridItemArrangeType ArrangeType
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public RectTransform ContainerTrans
	{
		 get { } //Length: 5
	}

	public RowColumnPair CurSnapNearestItemRowColumn
	{
		 get { } //Length: 8
	}

	public bool IsDraging
	{
		 get { } //Length: 8
	}

	public Vector2 ItemPadding
	{
		 get { } //Length: 19
		 set { } //Length: 250
	}

	public List<GridViewItemPrefabConfData> ItemPrefabDataList
	{
		 get { } //Length: 5
	}

	public Vector2 ItemSize
	{
		 get { } //Length: 19
		 set { } //Length: 250
	}

	public Vector2 ItemSizeWithPadding
	{
		 get { } //Length: 25
	}

	public bool ItemSnapEnable
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public int ItemTotalCount
	{
		 get { } //Length: 4
	}

	public RectOffset Padding
	{
		 get { } //Length: 5
		 set { } //Length: 166
	}

	public ScrollRect ScrollRect
	{
		 get { } //Length: 5
	}

	public float ViewPortHeight
	{
		 get { } //Length: 56
	}

	public float ViewPortWidth
	{
		 get { } //Length: 56
	}

	public LoopGridView() { }

	private void AdjustContainerAnchorAndPivot() { }

	private void AdjustItemAnchorAndPivot(RectTransform rtf) { }

	private void AdjustViewPortPivot() { }

	private bool CanSnap() { }

	public void ClearAllTmpRecycledItem() { }

	public void ClearSnapData() { }

	private GridItemGroup CreateItemGroup(int groupIndex) { }

	private void FillCurSnapData(int row, int column) { }

	private RowColumnPair FindNearestItemWithLocalPos(float x, float y) { }

	public void FinishSnapImmediately() { }

	public void ForceSnapUpdateCheck() { }

	public void ForceToCheckContentPos() { }

	public GridItemArrangeType get_ArrangeType() { }

	public RectTransform get_ContainerTrans() { }

	public RowColumnPair get_CurSnapNearestItemRowColumn() { }

	public bool get_IsDraging() { }

	public Vector2 get_ItemPadding() { }

	public List<GridViewItemPrefabConfData> get_ItemPrefabDataList() { }

	public Vector2 get_ItemSize() { }

	public Vector2 get_ItemSizeWithPadding() { }

	public bool get_ItemSnapEnable() { }

	public int get_ItemTotalCount() { }

	public RectOffset get_Padding() { }

	public ScrollRect get_ScrollRect() { }

	public float get_ViewPortHeight() { }

	public float get_ViewPortWidth() { }

	private RowColumnPair GetCeilItemRowColumnAtGivenAbsPos(float ax, float ay) { }

	private Vector2 GetContainerMovedDistance() { }

	private Vector2 GetContainerVaildPos(float curX, float curY) { }

	public Vector2 GetItemAbsPos(int row, int column) { }

	public int GetItemIndexByRowColumn(int row, int column) { }

	public Vector2 GetItemPos(int row, int column) { }

	public GridViewItemPrefabConfData GetItemPrefabConfData(string prefabName) { }

	private Vector2 GetItemSnapPivotLocalPos(int row, int column) { }

	private LoopGridViewItem GetNewItemByRowColumn(int row, int column) { }

	private GridItemGroup GetOneItemGroupObj() { }

	public RowColumnPair GetRowColumnByItemIndex(int itemIndex) { }

	private GridItemGroup GetShownGroup(int groupIndex) { }

	public LoopGridViewItem GetShownItemByItemIndex(int itemIndex) { }

	public LoopGridViewItem GetShownItemByRowColumn(int row, int column) { }

	private Vector2 GetViewPortSnapPivotLocalPos(Vector2 pos) { }

	public void InitGridView(int itemTotalCount, Func<LoopGridView, Int32, Int32, Int32, LoopGridViewItem> onGetItemByRowColumn, LoopGridViewSettingParam settingParam = null, LoopGridViewInitParam initParam = null) { }

	private void InitItemPool() { }

	private bool IsContainerTransCanMove() { }

	public void MovePanelToItemByIndex(int itemIndex, float offsetX = 0, float offsetY = 0) { }

	public void MovePanelToItemByRowColumn(int row, int column, float offsetX = 0, float offsetY = 0) { }

	public LoopGridViewItem NewListViewItem(string itemPrefabName) { }

	public override void OnBeginDrag(PointerEventData eventData) { }

	public override void OnDrag(PointerEventData eventData) { }

	public override void OnEndDrag(PointerEventData eventData) { }

	private void OnPointerDownInScrollBar(GameObject obj) { }

	private void OnPointerUpInScrollBar(GameObject obj) { }

	public void RecycleAllItem() { }

	private void RecycleItemGroupTmp(GridItemGroup group) { }

	private void RecycleItemTmp(LoopGridViewItem item) { }

	private void RecycleOneItemGroupObj(GridItemGroup obj) { }

	public void RefreshAllShownItem() { }

	public void RefreshItemByItemIndex(int itemIndex) { }

	public void RefreshItemByRowColumn(int row, int column) { }

	public void set_ArrangeType(GridItemArrangeType value) { }

	public void set_ItemPadding(Vector2 value) { }

	public void set_ItemSize(Vector2 value) { }

	public void set_ItemSnapEnable(bool value) { }

	public void set_Padding(RectOffset value) { }

	public void SetGridFixedGroupCount(GridFixedType fixedType, int count) { }

	public void SetItemPadding(Vector2 newPadding) { }

	public void SetItemSize(Vector2 newSize) { }

	public void SetListItemCount(int itemCount, bool resetPos = true) { }

	public void SetPadding(RectOffset newPadding) { }

	private void SetScrollbarListener() { }

	public void SetSnapTargetItemRowColumn(int row, int column) { }

	private void Update() { }

	public void UpdateAllGridSetting() { }

	private void UpdateColumnItemGroupForRecycleAndNew(GridItemGroup group) { }

	public void UpdateColumnRowCount() { }

	public void UpdateContentSize() { }

	private void UpdateCurFrameItemRangeData() { }

	private void UpdateCurSnapData() { }

	private void UpdateFromSettingParam(LoopGridViewSettingParam param) { }

	public void UpdateGridViewContent() { }

	public void UpdateItemSize() { }

	private void UpdateNearestSnapItem(bool forceSendEvent) { }

	private void UpdateRowItemGroupForRecycleAndNew(GridItemGroup group) { }

	private void UpdateSnapMove(bool immediate = false, bool forceSendEvent = false) { }

	public void UpdateStartEndPadding() { }

	public void VaildAndSetContainerPos() { }

}

