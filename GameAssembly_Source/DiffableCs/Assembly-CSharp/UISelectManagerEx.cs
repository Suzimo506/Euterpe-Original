//Type is in global namespace

public class UISelectManagerEx : UISelectManage
{
	[SerializeField]
	protected UISetColor[] m_UiSelects; //Field offset: 0x110
	[SerializeField]
	protected Color m_HighlightColor; //Field offset: 0x118
	[SerializeField]
	protected Color m_NormalColor; //Field offset: 0x128
	protected List<KeyValuePair`2<GameObject, GameObject>> m_SelectButtons; //Field offset: 0x138

	public UISelectManagerEx() { }

	public virtual void OnInit() { }

	protected virtual void OnSelect(GameObject currentObj) { }

	public virtual List<GameObject> SetSelectableObj() { }

}

