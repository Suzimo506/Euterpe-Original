namespace Assets.Scripts.UI.Panels.Menu;

public class PnlMenuAccount : MonoBehaviour
{
	[SerializeField]
	private GameObject m_LoginImg; //Field offset: 0x18
	[SerializeField]
	private Button m_Button; //Field offset: 0x20
	[SerializeField]
	private Text m_TxtVersion; //Field offset: 0x28

	public PnlMenuAccount() { }

	private void Awake() { }

	private void OnAccountClicked() { }

	private void OnDestroy() { }

	private void OnEnable() { }

	private void OnLoginChanged() { }

}

