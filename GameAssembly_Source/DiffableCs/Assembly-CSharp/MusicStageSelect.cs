//Type is in global namespace

public class MusicStageSelect : UISelectManage
{
	private List<GameObject> m_SelectObjs; //Field offset: 0x110
	private bool m_IsPress; //Field offset: 0x118
	private List<GameObject> m_CellObjs; //Field offset: 0x120
	private GameObject m_DefaultSelectObj; //Field offset: 0x128

	public MusicStageSelect() { }

	public virtual GameObject DefaultSelectObj() { }

	public void GetSelectedObj(List<GameObject> objs, List<GameObject> tgls, float musicCellWidth) { }

	public virtual void OnInit() { }

	protected virtual void OnSelect(GameObject currentObj) { }

	public virtual void OnUpdatePnl() { }

}

