namespace Assets.Scripts.UI.Panels;

public class PnlMenu : MonoBehaviour
{
	public Button backBtn; //Field offset: 0x18
	[SerializeField]
	private Animator m_MenuAnimator; //Field offset: 0x20
	[SerializeField]
	private Animator m_RoleAnimator; //Field offset: 0x28
	[SerializeField]
	private Animator m_ElfinAnimator; //Field offset: 0x30
	[SerializeField]
	private Animator m_TroveAnimator; //Field offset: 0x38
	[SerializeField]
	private Animator m_OptionAnimator; //Field offset: 0x40
	[SerializeField]
	private Animator m_AchvAnimator; //Field offset: 0x48
	[SerializeField]
	private Animator m_Achv43Animator; //Field offset: 0x50
	[SerializeField]
	private MenuSelect m_MenuSelect; //Field offset: 0x58
	[SerializeField]
	private CanvasGroup m_CanvasGroup; //Field offset: 0x60

	public MenuSelect menuSelect
	{
		 get { } //Length: 5
	}

	public PnlMenu() { }

	[CompilerGenerated]
	private void <OnBackClicked>b__14_0() { }

	private void Awake() { }

	public MenuSelect get_menuSelect() { }

	private void OnBackClicked() { }

	private void OnEnable() { }

}

