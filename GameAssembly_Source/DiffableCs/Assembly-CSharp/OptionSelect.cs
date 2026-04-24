//Type is in global namespace

public class OptionSelect : UISelectManage
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public KeyValuePair<Int32, Button> delegateKvp; //Field offset: 0x10
		public OptionSelect <>4__this; //Field offset: 0x20

		public <>c__DisplayClass9_0() { }

		internal void <OnAwake>b__0() { }

	}

	private struct OptionIndexDefines
	{
		public const int how_to_play = 0; //Field offset: 0x0
		public const int switch_language = 1; //Field offset: 0x0
		public const int volume = 2; //Field offset: 0x0
		public const int display = 3; //Field offset: 0x0
		public const int input = 4; //Field offset: 0x0
		public const int offset = 5; //Field offset: 0x0
		public const int anchor = 6; //Field offset: 0x0
		public const int credit = 7; //Field offset: 0x0
		public const int rate_us = 8; //Field offset: 0x0
		public const int follow_us = 9; //Field offset: 0x0
		public const int q_a = 10; //Field offset: 0x0
		public const int feedback = 11; //Field offset: 0x0
		public const int terminal = 12; //Field offset: 0x0
		public const int bulletin = 13; //Field offset: 0x0
		public const int account = 14; //Field offset: 0x0
		public const int pero_shop = 15; //Field offset: 0x0

	}

	private const int m_GridLineCount = 5; //Field offset: 0x0
	private const int m_TotalCount = 10; //Field offset: 0x0
	[SerializeField]
	private Animator m_Animator; //Field offset: 0x110
	public AudioClip pnlMusic; //Field offset: 0x118
	[SerializeField]
	private Dictionary<Int32, Button> m_SelectedButtonList; //Field offset: 0x120
	[SerializeField]
	private Dictionary<Int32, GameObject> m_ShowWindows; //Field offset: 0x128
	[SerializeField]
	private GameObject m_GmButtons; //Field offset: 0x130
	[SerializeField]
	private GameObject m_DebugButtons; //Field offset: 0x138
	[SerializeField]
	private GameObject[] m_Blanks; //Field offset: 0x140
	[SerializeField]
	private Text m_Version; //Field offset: 0x148
	private bool m_LanguageChangedDirty; //Field offset: 0x150

	public OptionSelect() { }

	public virtual GameObject DefaultSelectObj() { }

	private void GoogleButtonInit() { }

	private void IOSButtonInit() { }

	private void NSButtonInit() { }

	public virtual void OnAwake() { }

	private void OnClicked(Button btn, int btnIndex) { }

	private void OnDestroy() { }

	public virtual void OnEnablePnl() { }

	public virtual void OnInit() { }

	private void OnLanguageChanged(int languageIndex) { }

	protected virtual void OnSelect(GameObject currentObj) { }

	private void RefreshAnchorModeBtnState() { }

	private void SetBlankVisual(int index, bool enable) { }

	private void SetButtonVisual(int index, bool enable) { }

	public virtual Transform SetEdgeObj(GameObject currentObj) { }

	public virtual List<GameObject> SetSelectableObj() { }

	private void SteamButtonInit() { }

	private void TapTapButtonInit() { }

	private void WeGameButtonInit() { }

}

