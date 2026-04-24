//Type is in global namespace

public class InputCustomizeSelect : UISelectManage
{
	private List<GameObject> m_Buttons; //Field offset: 0x110
	public Transform buttons; //Field offset: 0x118
	public Button cancel; //Field offset: 0x120
	private int m_LastSelectButtonIndex; //Field offset: 0x128
	public Button empty; //Field offset: 0x130

	public InputCustomizeSelect() { }

	public virtual GameObject DefaultSelectObj() { }

	public GameObject GetLastSelectObj() { }

	private void OnClickCancel() { }

	public void OnCustomKey(bool enable) { }

	public virtual void OnDisablePnl() { }

	public virtual void OnEnablePnl() { }

	public virtual void OnInit() { }

	protected virtual void OnSelect(GameObject currentObj) { }

	public virtual List<GameObject> SetSelectableObj() { }

}

