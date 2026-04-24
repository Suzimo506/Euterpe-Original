namespace Assets.Scripts.UI.Panels;

public abstract class AbstractTabItem : MonoBehaviour
{
	public Color enableBgColor; //Field offset: 0x18
	public Color disableBgColor; //Field offset: 0x28
	public Color enableTextBgColor; //Field offset: 0x38
	public Color disableTextBgColor; //Field offset: 0x48
	[SerializeField]
	protected Button m_TabButton; //Field offset: 0x58
	[SerializeField]
	protected Text m_Text; //Field offset: 0x60
	[SerializeField]
	protected Image m_Image; //Field offset: 0x68
	protected AbstractTabContainer m_Parent; //Field offset: 0x70
	protected int m_Index; //Field offset: 0x78
	protected ulong m_DirtyIndex; //Field offset: 0x80
	private List<GameObject> m_SelectGameObjects; //Field offset: 0x88

	public override GameObject defaultSelectedObject
	{
		 get { } //Length: 3
	}

	protected List<GameObject> selectGameObjects
	{
		 get { } //Length: 8
	}

	public int tabIndex
	{
		 get { } //Length: 4
	}

	protected AbstractTabItem() { }

	public override void Destroy() { }

	protected override void DirtyHandler() { }

	public override void Disable(int curTabIndex) { }

	public override void Enable(int curTabIndex) { }

	public override GameObject get_defaultSelectedObject() { }

	protected List<GameObject> get_selectGameObjects() { }

	public int get_tabIndex() { }

	public override string GetAreaTitle(int treeIndex) { }

	public override bool GetSelectGameObject(List<GameObject> buffer) { }

	public abstract void InitBaseUiAndData(int curIndex) { }

	public override void InitItem(AbstractTabContainer parent, List<GameObject> selectedObjects, int index) { }

	public abstract bool InvokeEvent(int eventType) { }

	public override bool ItemUpdate() { }

	public override bool OnAxisDown(ButtonDirection dir, ButtonDirection nullDir, GameObject current, GameObject lastGameObject) { }

	public override void OnItemChanged(int prevIndex, int curIndex, bool init = false) { }

	public override bool OnSelect(GameObject currentObj) { }

	public override bool OnSelectEmpty(GameObject lastSelObj) { }

	protected override void OnTabBtnClicked() { }

	public override bool SetDirty(int curTabIndex, ulong dirtyIndex = 0) { }

}

