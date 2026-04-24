namespace Assets.Scripts.UI.Panels.PnlMusicTag;

public class MusicButtonCell : BaseMusicButton
{
	[SerializeField]
	private GameObject m_WeekFreeIcon; //Field offset: 0x28
	[SerializeField]
	private GameObject m_ImgLvLockIcon; //Field offset: 0x30
	[SerializeField]
	private GameObject m_ImgBuyLockIcon; //Field offset: 0x38
	[SerializeField]
	private GameObject m_ImgAnchorIcon; //Field offset: 0x40
	[SerializeField]
	private GameObject m_MasterLockIcon; //Field offset: 0x48
	[SerializeField]
	private LongSongNameController m_LongTxtCtrl; //Field offset: 0x50
	[SerializeField]
	private Image m_Img; //Field offset: 0x58
	[SerializeField]
	private Text m_LevelTxt; //Field offset: 0x60
	[SerializeField]
	private Image m_BgImg; //Field offset: 0x68
	[SerializeField]
	public RectTransform m_RectTransform; //Field offset: 0x70
	[SerializeField]
	private CanvasGroup m_CanvasGroup; //Field offset: 0x78
	private int m_TabIndex; //Field offset: 0x80
	private int m_ClickCount; //Field offset: 0x84
	[CompilerGenerated]
	private Action<MusicButtonCell, Int32> OnClicked; //Field offset: 0x88

	public event Action<MusicButtonCell, Int32> OnClicked
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public MusicInfo musicInfo
	{
		 get { } //Length: 5
	}

	public MusicButtonCell() { }

	[CompilerGenerated]
	public void add_OnClicked(Action<MusicButtonCell, Int32> value) { }

	private void Awake() { }

	public MusicInfo get_musicInfo() { }

	public void InitMusicCell(MusicInfo initMusicInfo, int tabIndex) { }

	private void OnButtonClicked() { }

	[CompilerGenerated]
	public void remove_OnClicked(Action<MusicButtonCell, Int32> value) { }

	private void ResetIcon() { }

	private bool SetAnchorIcon() { }

	private bool SetBuyIcon() { }

	private void SetIcon() { }

	private bool SetLevelIcon() { }

	private bool SetMasterIcon() { }

	private bool SetWeekFreeIcon() { }

	public void UiRefresh() { }

}

