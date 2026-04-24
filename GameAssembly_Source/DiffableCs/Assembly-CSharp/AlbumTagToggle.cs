//Type is in global namespace

public class AlbumTagToggle : MonoBehaviour
{
	[SerializeField]
	public Toggle m_Toggle; //Field offset: 0x18
	[SerializeField]
	private Image m_Background; //Field offset: 0x20
	[SerializeField]
	private RawImage m_IconImg; //Field offset: 0x28
	[SerializeField]
	private Text m_Txt; //Field offset: 0x30
	[SerializeField]
	private GameObject m_WeekFreeIcon; //Field offset: 0x38
	[SerializeField]
	private GameObject m_NewIcon; //Field offset: 0x40
	[SerializeField]
	private Image m_SelectedImg; //Field offset: 0x48
	public AlbumTagInfo tagInfo; //Field offset: 0x50
	[CompilerGenerated]
	private Action<Int32> toggleChangedHandler; //Field offset: 0x58
	public Color allBgColor; //Field offset: 0x60
	public Color baseBgColor; //Field offset: 0x70
	public Color collectionBgColor; //Field offset: 0x80
	public Color otherBgColor; //Field offset: 0x90
	public Color allTxtColor; //Field offset: 0xA0
	public Color collectionTxtColor; //Field offset: 0xB0
	public Color groupTxtColor1; //Field offset: 0xC0
	public Color groupTxtColor2; //Field offset: 0xD0
	[SerializeField]
	private AudioClip m_ClickSfx; //Field offset: 0xE0
	[SerializeField]
	private Animator m_Animator; //Field offset: 0xE8
	private int m_OnHash; //Field offset: 0xF0
	private int m_OffHash; //Field offset: 0xF4
	private bool m_HashInit; //Field offset: 0xF8
	private bool m_PrevTglValue; //Field offset: 0xF9

	public event Action<Int32> toggleChangedHandler
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public AlbumTagToggle() { }

	[CompilerGenerated]
	public void add_toggleChangedHandler(Action<Int32> value) { }

	private void Awake() { }

	public void InitHandler() { }

	private void InitHash() { }

	public void InitTag(int groupIndex) { }

	private void OnEnable() { }

	private void OnSelectToggle(bool isOn) { }

	private void PlayToggleAnimator(bool isOn) { }

	[CompilerGenerated]
	public void remove_toggleChangedHandler(Action<Int32> value) { }

	private void SetIconAsync(Texture2D tex) { }

	private void SetStateIcon(bool weekFree, bool newAlbum) { }

}

