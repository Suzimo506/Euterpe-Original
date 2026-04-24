namespace Assets.Scripts.GameCore.Controller;

[CreateAssetMenu]
public class NsButtonConfig : ControllerConfig
{
	public string CurrentProposal; //Field offset: 0x58
	[SerializeField]
	private Dictionary<String, Dictionary`2<String, List`1<NpadButton>>> m_AssignedProposal; //Field offset: 0x60

	public Dictionary<String, Dictionary`2<String, List`1<NpadButton>>> assignedProposal
	{
		 get { } //Length: 5
	}

	public NsButtonConfig() { }

	public Dictionary<String, Dictionary`2<String, List`1<NpadButton>>> get_assignedProposal() { }

}

