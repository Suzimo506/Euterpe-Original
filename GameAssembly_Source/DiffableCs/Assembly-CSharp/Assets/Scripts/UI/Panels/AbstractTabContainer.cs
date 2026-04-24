namespace Assets.Scripts.UI.Panels;

public abstract class AbstractTabContainer : UISelectManage
{
	[SerializeField]
	protected AbstractTabItem[] m_Items; //Field offset: 0x110
	protected int m_CurTabIndex; //Field offset: 0x118
	[SerializeField]
	protected Single[] m_AnimFinalPosition; //Field offset: 0x120
	[SerializeField]
	protected float m_AnimTime; //Field offset: 0x128
	protected List<GameObject> m_SelectObjs; //Field offset: 0x130
	protected ulong m_DirtyType; //Field offset: 0x138
	private GameObject m_DefaultSelectObj; //Field offset: 0x140

	public int currentTabIndex
	{
		 get { } //Length: 7
	}

	public GameObject lastSelected
	{
		 get { } //Length: 8
	}

	public int tabCount
	{
		 get { } //Length: 29
	}

	protected AbstractTabContainer() { }

	public virtual GameObject DefaultSelectObj() { }

	protected override void Destroy() { }

	protected override void DirtyHandler() { }

	public int get_currentTabIndex() { }

	public GameObject get_lastSelected() { }

	public int get_tabCount() { }

	protected override void InitTabContainer() { }

	public override bool InvokeEvent(int eventIndex) { }

	protected override bool InvokeItemUpdate() { }

	public virtual void OnAwake() { }

	protected virtual void OnAxisDown(ButtonDirection dir, ButtonDirection nullDir, GameObject current, GameObject lastGameObject) { }

	protected void OnDestroy() { }

	public virtual void OnDisablePnl() { }

	public virtual void OnEnablePnl() { }

	protected virtual void OnSelect(GameObject currentObj) { }

	protected virtual void OnSelectEmpty(GameObject lastSelObj) { }

	public void SetDefaultSelectObj(GameObject go) { }

	public override void SetDirty(int tabIndex = -1, ulong dirtyIndex = 0) { }

	public virtual List<GameObject> SetSelectableObj() { }

	public void SetSelectedGameObject(GameObject go) { }

	public override bool SetTabIndex(int tabIndex) { }

}

