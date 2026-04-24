namespace Assets.Scripts.UI.NetworkDetect;

public class PnlNetDetector : MonoBehaviour
{
	private const string m_SceneName = "GameMain"; //Field offset: 0x0
	private Popup m_Popup; //Field offset: 0x18
	private bool m_IsPoping; //Field offset: 0x20
	private string m_CurrSceneName; //Field offset: 0x28
	private int m_DelayFrame; //Field offset: 0x30

	private bool isAdult
	{
		private get { } //Length: 170
	}

	public PnlNetDetector() { }

	private bool get_isAdult() { }

	private void Start() { }

	private void Update() { }

}

