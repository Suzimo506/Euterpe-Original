//Type is in global namespace

public class GraphicSettingSelect : UISelectManage
{
	public FancyScrollView dpiFullScreen; //Field offset: 0x110
	public FancyScrollView dpiWindow; //Field offset: 0x118
	private FancyScrollView screenMode; //Field offset: 0x120
	public FancyScrollView screenMode_Win; //Field offset: 0x128
	public FancyScrollView screenMode_Mac; //Field offset: 0x130
	public FancyScrollView fpsFsv; //Field offset: 0x138
	public GameObject confirm; //Field offset: 0x140
	public GameObject enterBackgroundBtn; //Field offset: 0x148
	public GameObject enterBackgroundSelectImg; //Field offset: 0x150
	public GameObject feverSettingBtn; //Field offset: 0x158
	public GameObject feverSettingSelectImg; //Field offset: 0x160
	public Color highlightColor; //Field offset: 0x168
	public Color normalColor; //Field offset: 0x178
	[SerializeField]
	private List<UISetColor> m_UiSetColors; //Field offset: 0x188
	private int m_DpiFullScreenIndex; //Field offset: 0x190
	private int m_DpiWindowIndex; //Field offset: 0x194
	private int m_ScreenModeIndex; //Field offset: 0x198
	private bool m_IsFullScreen; //Field offset: 0x19C
	private bool m_HasBorder; //Field offset: 0x19D
	private bool m_IsInit; //Field offset: 0x19E
	public AudioClip optionBgmClip; //Field offset: 0x1A0
	private Vector2Int[] m_FullScreenResolutions; //Field offset: 0x1A8
	private Vector2Int[] m_WindowsResolutions; //Field offset: 0x1B0
	private Int32[] m_Fps; //Field offset: 0x1B8

	public GraphicSettingSelect() { }

	private void AdjustNavi(FancyScrollView fsv) { }

	public virtual GameObject DefaultSelectObj() { }

	private int GetFpsIndex() { }

	private Vector2Int GetResolutions(string uid) { }

	private int GetResolutionsIndex(string uid) { }

	private string GetResolutionsUid(Vector2 resolution) { }

	private void OnClickConfirm() { }

	public virtual void OnDisablePnl() { }

	private void OnFpsChange(int i) { }

	private void OnFullScreenDpiChange(int i) { }

	public virtual void OnInit() { }

	private void OnScreenModeChange(int i) { }

	protected virtual void OnSelect(GameObject currentObj) { }

	private void OnWindowDpiChange(int i) { }

	public virtual Transform SetEdgeObj(GameObject currentObj) { }

	public virtual List<GameObject> SetSelectableObj() { }

}

