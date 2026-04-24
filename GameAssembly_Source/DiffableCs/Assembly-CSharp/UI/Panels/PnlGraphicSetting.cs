namespace UI.Panels;

public class PnlGraphicSetting : MonoBehaviour
{
	[SerializeField]
	private Button m_BgSettingBtn; //Field offset: 0x18
	[SerializeField]
	private GameObject m_BgSetting; //Field offset: 0x20
	[SerializeField]
	private Button m_FeverSettingBtn; //Field offset: 0x28
	[SerializeField]
	private GameObject m_FeverSetting; //Field offset: 0x30
	public ToggleSettingGroup quality; //Field offset: 0x38
	public ToggleSettingGroup effect; //Field offset: 0x40
	public ToggleSettingGroup advanced; //Field offset: 0x48
	public ToggleSettingGroup ap; //Field offset: 0x50
	public ToggleSettingGroup fps; //Field offset: 0x58
	public GameObject hightImgSuggest; //Field offset: 0x60
	public GameObject lowImgSuggest; //Field offset: 0x68
	public Button apTipButton; //Field offset: 0x70
	private IVariable m_QualityData; //Field offset: 0x78
	private IVariable m_EffectData; //Field offset: 0x80
	private IVariable m_Advanced; //Field offset: 0x88
	private IVariable m_Ap; //Field offset: 0x90
	private IVariable m_Fps; //Field offset: 0x98
	private Int32[] m_FpsArray; //Field offset: 0xA0

	public PnlGraphicSetting() { }

	private void Awake() { }

	private int GetFpsIndex() { }

	private void InitVariable() { }

	private void OnAdvancedChanged(int index, bool enable) { }

	private void OnApChanged(int index, bool enable) { }

	private void OnApTipButtonClicked() { }

	private void OnBgSettingClicked() { }

	private void OnDisable() { }

	private void OnEffectChanged(int index, bool enable) { }

	private void OnFeverSettingClicked() { }

	private void OnFpsChanged(int index, bool enable) { }

	private void OnQualityChanged(int index, bool enable) { }

	private void PlaySfx() { }

}

