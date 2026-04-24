namespace SuperScrollView;

public abstract class LoopListView2 : BaseLoopListView2, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
{
	private Dictionary<String, ItemPool`1<T>> mItemPoolDict; //Field offset: 0x0
	protected List<T> mItemList; //Field offset: 0x0
	protected Func<LoopListView2`1<T>, Int32, T> mOnGetItemByIndex; //Field offset: 0x0
	public Action<LoopListView2`1<T>, T> mOnSnapItemFinished; //Field offset: 0x0
	public Action<LoopListView2`1<T>, T> mOnSnapNearestChanged; //Field offset: 0x0
	public Action<LoopListView2`1<T>> OnListViewStart; //Field offset: 0x0
	protected bool m_AutoScroll; //Field offset: 0x0
	protected Vector3 toPos; //Field offset: 0x0
	protected float m_Velocity; //Field offset: 0x0
	protected float m_smoothTime; //Field offset: 0x0

	public int CurSnapNearestItemIndex
	{
		 get { } //Length: 7
	}

	public List<T> ItemList
	{
		 get { } //Length: 8
	}

	public int ShownItemCount
	{
		 get { } //Length: 46
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

	protected LoopListView2`1() { }

	private void AdjustAnchor(RectTransform rtf) { }

	private void AdjustContainerAnchor(RectTransform rtf) { }

	private void AdjustContainerPivot(RectTransform rtf) { }

	private void AdjustPanelPos() { }

	private void AdjustPivot(RectTransform rtf) { }

	private static bool Approximately(double a, double b) { }

	private void CacheDragPointerEventData(PointerEventData eventData) { }

	private bool CanSnap() { }

	protected override void CheckIfNeedUpdataItemPos() { }

	private static void Clamp(ref float value, float min, float max) { }

	private void ClearAllTmpRecycledItem() { }

	public void ClearSnapData() { }

	public void DoActionForEachShownItem(Action<T, Object> action, object param) { }

	public void FinishSnapImmediately() { }

	public void ForceSnapUpdateCheck() { }

	public int get_CurSnapNearestItemIndex() { }

	public List<T> get_ItemList() { }

	public int get_ShownItemCount() { }

	public float get_ViewPortHeight() { }

	public float get_ViewPortSize() { }

	public float get_ViewPortWidth() { }

	private float GetContentPanelSize() { }

	public int GetIndexInShownItemList(T item) { }

	public Vector3 GetItemCornerPosInViewPort(T item, ItemCornerEnum corner = 0) { }

	protected float GetItemPos(int itemIndex) { }

	protected T GetNewItemByIndex(int index) { }

	protected bool GetPlusItemIndexAndPosAtGivenPos(float pos, ref int index, ref float itemPos) { }

	public T GetShownItemByIndex(int index) { }

	public T GetShownItemByIndexWithoutCheck(int index) { }

	public T GetShownItemByItemIndex(int itemIndex) { }

	public T GetShownItemNearestItemIndex(int itemIndex) { }

	protected void GetWorldCorners(RectTransform rectTransform, out Vector3 pos1, out Vector3 pos2) { }

	private void InitItemPool() { }

	public override void InitListView(int itemTotalCount, Func<LoopListView2`1<T>, Int32, T> onGetItemByIndex, LoopListViewInitParam initParam = null) { }

	public void MovePanelToItemIndex(int itemIndex, float offset) { }

	public T NewListViewItem(string itemPrefabName) { }

	public override void OnBeginDrag(PointerEventData eventData) { }

	private void OnDisable() { }

	public override void OnDrag(PointerEventData eventData) { }

	public override void OnEndDrag(PointerEventData eventData) { }

	public void OnItemPrefabChanged(string prefabName) { }

	public void OnItemSizeChanged(int itemIndex) { }

	private void OnPointerDownInScrollBar(GameObject obj) { }

	private void OnPointerUpInScrollBar(GameObject obj) { }

	protected void RecycleAllItem() { }

	public void RecycleItemTmp(T item) { }

	public void RefreshAllShownItem() { }

	public void RefreshAllShownItemWithFirstIndex(int firstItemIndex) { }

	public void RefreshAllShownItemWithFirstIndexAndPos(int firstItemIndex, Vector3 pos) { }

	public void RefreshItemByItemIndex(int itemIndex) { }

	public void ResetListView(bool resetPos = true) { }

	public void ScrollTo(Vector3 tPos, float time = 0.3) { }

	protected override void SetItemSize(int itemIndex, float itemSize, float padding) { }

	public void SetListItemCount(int itemCount, bool force = false, bool resetPos = true) { }

	public void SetListViewData(int itemTotalCount, Func<LoopListView2`1<T>, Int32, T> onGetItemByIndex) { }

	private void SetScrollbarListener() { }

	public void SetSnapTargetItemIndex(int itemIndex, float moveMaxAbsVec = -1) { }

	private void Start() { }

	protected void StopScroll() { }

	private void Update() { }

	public void UpdateAllShownItemSnapData() { }

	protected override void UpdateAllShownItemsPos() { }

	private void UpdateAutoScroll() { }

	protected void UpdateContentSize() { }

	private void UpdateCurSnapData() { }

	protected override bool UpdateForHorFirstItem(bool leftToRight) { }

	protected override bool UpdateForHorizontalList(float distanceForRecycleRight, float distanceForRecycleLeft, float distanceForShowRight, float distanceForShowLeft) { }

	protected override bool UpdateForVertList(float distanceForRecycleTop, float distanceForRecycleBottom, float distanceForShowTop, float distanceForShowBottom) { }

	public override void UpdateListView(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1) { }

	public override void UpdatePrefabData() { }

	private void UpdateSnapHorizontal(bool immediate = false, bool forceSendEvent = false) { }

	private void UpdateSnapMove(bool immediate = false, bool forceSendEvent = false) { }

	private void UpdateSnapVertical(bool immediate = false, bool forceSendEvent = false) { }

}

