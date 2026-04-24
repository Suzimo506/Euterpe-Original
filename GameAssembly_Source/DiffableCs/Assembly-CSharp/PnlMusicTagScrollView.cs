//Type is in global namespace

public class PnlMusicTagScrollView : LoopListView2<PnlMusicTagViewItem>
{
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	protected int m_FixedCount; //Field offset: 0x160
	[SerializeField]
	protected AlignType m_AlignType; //Field offset: 0x164
	public Vector2 masterPadding; //Field offset: 0x168
	protected Vector2 cellPadding; //Field offset: 0x170

	public AlignType alignType
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	public int fixedCount
	{
		 get { } //Length: 7
	}

	public PnlMusicTagScrollView() { }

	public AlignType get_alignType() { }

	public int get_fixedCount() { }

	public virtual void InitListView(int itemTotalCount, Func<LoopListView2`1<PnlMusicTagViewItem>, Int32, PnlMusicTagViewItem> onGetItemByIndex, LoopListViewInitParam initParam = null) { }

	public void MoveToViewPort(GameObject go) { }

	public void set_alignType(AlignType value) { }

	protected virtual void UpdateAllShownItemsPos() { }

	protected virtual bool UpdateForHorFirstItem(bool leftToRight) { }

	protected virtual bool UpdateForHorizontalList(float distanceForRecycleRight, float distanceForRecycleLeft, float distanceForShowRight, float distanceForShowLeft) { }

	public virtual void UpdatePrefabData() { }

}

