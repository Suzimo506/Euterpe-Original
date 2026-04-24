namespace Assets.Scripts.UI.Specials;

public class SwitchLanguages : MonoBehaviour
{
	public Button btnSwitch; //Field offset: 0x18
	public Text langText; //Field offset: 0x20
	public GameObject btnShop; //Field offset: 0x28
	private List<String> m_Options; //Field offset: 0x30
	private IVariable m_SaveVal; //Field offset: 0x38
	private int m_SelectedInd; //Field offset: 0x40

	public SwitchLanguages() { }

	private void Awake() { }

	private void OnClick() { }

	private void OnDestroy() { }

}

