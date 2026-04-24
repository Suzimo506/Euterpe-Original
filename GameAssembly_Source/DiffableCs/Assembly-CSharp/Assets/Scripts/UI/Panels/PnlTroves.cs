namespace Assets.Scripts.UI.Panels;

public class PnlTroves : MonoBehaviour
{
	[SerializeField]
	private Animator m_Animator; //Field offset: 0x18
	public AudioClip pnlTroveMusic; //Field offset: 0x20
	public AudioClip clickSfx; //Field offset: 0x28
	private bool hasNew; //Field offset: 0x30
	private bool m_IgnoreEvent; //Field offset: 0x31
	public Toggle tglUsed; //Field offset: 0x38
	public Button btnCheck_Pc; //Field offset: 0x40
	public Button btnCheck_Mobile; //Field offset: 0x48
	private Button m_BtnCheck; //Field offset: 0x50
	private List<Int32> m_UseLoadingIndexItem; //Field offset: 0x58
	private List<Int32> m_UseWelcomeIndexItem; //Field offset: 0x60
	private List<IData> m_Items; //Field offset: 0x68
	private string m_SelectItemType; //Field offset: 0x70
	private int m_SelectIndex; //Field offset: 0x78
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private GameObject m_ArtistArea; //Field offset: 0x80
	[SerializeField]
	private GameObject m_ButtonTips; //Field offset: 0x88
	[SerializeField]
	private Text m_Description; //Field offset: 0x90
	[SerializeField]
	private Button m_ArtistBtnBind; //Field offset: 0x98
	[SerializeField]
	private Button m_Artist1Btn; //Field offset: 0xA0
	[SerializeField]
	private Text m_Artist1Text; //Field offset: 0xA8
	[SerializeField]
	private GameObject m_Artist1Link; //Field offset: 0xB0
	[SerializeField]
	private GameObject m_AndGameObject; //Field offset: 0xB8
	[SerializeField]
	private Button m_Artist2Btn; //Field offset: 0xC0
	[SerializeField]
	private Text m_Artist2Text; //Field offset: 0xC8
	[SerializeField]
	private GameObject m_Artist2Link; //Field offset: 0xD0
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private GameObject m_Item; //Field offset: 0xD8
	[SerializeField]
	private Transform m_ItemContent; //Field offset: 0xE0
	[SerializeField]
	private ToggleGroup m_ParentGroup; //Field offset: 0xE8
	private List<GameObject> m_ItemGameObjects; //Field offset: 0xF0
	private string m_Artist1Home; //Field offset: 0xF8
	private string m_Artist2Home; //Field offset: 0x100
	private bool m_LanguageDirty; //Field offset: 0x108

	public PnlTroves() { }

	public void Init() { }

	private void OnArtist1Clicked() { }

	private void OnArtist2Clicked() { }

	private void OnArtistBindClicked() { }

	private void OnCheckClicked() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnItemChangedFromTgl(int index, string itemType, bool isUnlock) { }

	private void OnItemDoubleClicked(int index) { }

	private void OnItemSelected() { }

	private void OnItemSelectedFromCheck(string itemType, bool isUnlock) { }

	private void OnItemSelectSetArtist() { }

	private void OnLanguageChanged(int index) { }

	private void OnTglValueChanged(bool value) { }

	private void RefreshIndexs() { }

	private IData SetItemDatas(int index) { }

}

