//Type is in global namespace

public class PnlIllusCheck : BaseMessageBox
{
	public GameObject simpleIllus; //Field offset: 0xD8
	public GameObject specialIllus; //Field offset: 0xE0
	public GameObject verySpecialIllus; //Field offset: 0xE8
	[SerializeField]
	private GameObject m_SaveButton; //Field offset: 0xF0

	public PnlIllusCheck() { }

	public virtual void AwakeInit() { }

	private void OnDisable() { }

	public virtual void Show() { }

}

