//Type is in global namespace

public class OffsetAskSelect : UISelectManage
{
	public Button tvMode; //Field offset: 0x110
	public Button handheldMode; //Field offset: 0x118
	public PnlOffsetOption offsetOption; //Field offset: 0x120

	public OffsetAskSelect() { }

	public virtual GameObject DefaultSelectObj() { }

	protected virtual void OnSelect(GameObject currentObj) { }

	public virtual List<GameObject> SetSelectableObj() { }

}

