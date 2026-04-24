namespace Assets.Scripts.GameCore.Controller.Configs;

[CreateAssetMenu]
public class StandloneCtrlConfig : ControllerConfig
{
	public string CurrentProposal; //Field offset: 0x58
	[SerializeField]
	private Dictionary<String, Dictionary`2<String, List`1<KeyCode>>> m_ButtonKeyEnties; //Field offset: 0x60

	public Dictionary<String, Dictionary`2<String, List`1<KeyCode>>> buttonKeyEnties
	{
		 get { } //Length: 5
	}

	public StandloneCtrlConfig() { }

	public Dictionary<String, Dictionary`2<String, List`1<KeyCode>>> get_buttonKeyEnties() { }

}

