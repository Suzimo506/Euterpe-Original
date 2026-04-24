namespace Assets.Scripts.UI.Panels;

public class PnlFeverSetting : MonoBehaviour
{
	private const int select = 0; //Field offset: 0x0
	private const int selected = 1; //Field offset: 0x0
	private const int not_purchased = 2; //Field offset: 0x0
	[SerializeField]
	private Button m_BackButton; //Field offset: 0x18
	[SerializeField]
	private Animator m_Animator; //Field offset: 0x20
	[SerializeField]
	private Button m_BtnSelect; //Field offset: 0x28
	[SerializeField]
	private FancyScrollView m_ThemeFSV; //Field offset: 0x30
	[SerializeField]
	private FancyScrollView m_ThemeModeFSV; //Field offset: 0x38
	private Text m_Text; //Field offset: 0x40
	private bool m_DontHandlerEvent; //Field offset: 0x48
	private bool m_Init; //Field offset: 0x49
	[SerializeField]
	private AudioClip m_OptionBgmClip; //Field offset: 0x50

	public PnlFeverSetting() { }

	private bool CheckBuy(int theme) { }

	private void ClampSelect(ref int themeIndex, ref int themeMode) { }

	private void InitUI() { }

	private void OnBackClicked() { }

	private void OnDestroy() { }

	private void OnDlcOut() { }

	private void OnEnable() { }

	private void OnSelectClicked() { }

	private void OnThemeFinalChanged(int index) { }

	private void PopupBuyMessageBox(int themeIndex) { }

	private void RefreshUI(int themeIndex = -1, int themeMode = -1, bool refreshFsv = false, float scrollTime = 0.2) { }

	public void SetOptionBgm(AudioClip bgm) { }

	private void Start() { }

	private void ToggleSelected(Nullable<Boolean> enable, int tipIndex) { }

}

