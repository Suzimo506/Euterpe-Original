namespace Assets.Scripts.UI.Panels.PnlDLC;

public class OpenDlc : MonoBehaviour
{
	[SerializeField]
	private Button m_Button; //Field offset: 0x18
	[SerializeField]
	private Animator m_PnlStageAnimator; //Field offset: 0x20
	[SerializeField]
	private GameObject m_PnlDlc; //Field offset: 0x28

	public OpenDlc() { }

	private void Awake() { }

	private void OnButtonClicked() { }

}

