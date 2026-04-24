namespace Assets.Scripts.UI.Panels;

public class WelcomeSelect : MonoBehaviour, IPreWarm
{
	public GameObject welcome; //Field offset: 0x18
	public CanvasScaler uiCanvas; //Field offset: 0x20
	private int m_WelcomeIndex; //Field offset: 0x28
	public PnlMandatoryUpdate pnlMandatory; //Field offset: 0x30
	public Button btnLogin; //Field offset: 0x38

	public WelcomeSelect() { }

	private void OnEnable() { }

	public override void PreWarm(int slice) { }

	private void Start() { }

}

