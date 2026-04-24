//Type is in global namespace

public class PauseSelect : UISelectManage
{
	public Transform buttons; //Field offset: 0x110

	public PauseSelect() { }

	public virtual void OnEnablePnl() { }

	protected virtual void OnSelect(GameObject currentObj) { }

	public virtual Transform SetEdgeObj(GameObject currentObj) { }

	public virtual void SetKeyBindings(GameObject obj, bool enable, bool isStart = false) { }

	public virtual List<GameObject> SetSelectableObj() { }

}

