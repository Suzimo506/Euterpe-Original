namespace Assets.Scripts.GameCore.Controller;

public class NsController : Controller<NsButtonConfig>
{
	private List<Int32> m_DownList; //Field offset: 0x18
	private List<Int32> m_MoveList; //Field offset: 0x20
	private List<Int32> m_UpList; //Field offset: 0x28
	private Dictionary<String, List`1<NpadButton>> m_Dict; //Field offset: 0x30
	private string m_ProposalName; //Field offset: 0x38

	public NsController() { }

	public virtual List<Int32> GetButton(MDButtonType buttonName) { }

	public virtual List<Int32> GetButtonDown(MDButtonType buttonName) { }

	private List<Int32> GetButtonList(BUTTON_STATE buttonState) { }

	protected virtual bool GetButtonProposal(MDButtonType buttonName) { }

	public virtual List<Int32> GetButtonUp(MDButtonType buttonName) { }

	public virtual void OnInit() { }

	public virtual void SwitchProposal(string proposalName) { }

}

