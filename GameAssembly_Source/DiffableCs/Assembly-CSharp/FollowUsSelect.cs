//Type is in global namespace

public class FollowUsSelect : UISelectManage
{
	public Transform buttons; //Field offset: 0x110
	private List<Button> m_Buttons; //Field offset: 0x118
	public AudioClip optionBgmClip; //Field offset: 0x120

	public FollowUsSelect() { }

	public virtual void OnDisablePnl() { }

	public virtual void OnInit() { }

	protected virtual void OnSelect(GameObject currentObj) { }

	public virtual Transform SetEdgeObj(GameObject currentObj) { }

	public virtual List<GameObject> SetSelectableObj() { }

}

