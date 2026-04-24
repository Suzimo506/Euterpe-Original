//Type is in global namespace

public class PnlElfin : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public int delegateElfinIndex; //Field offset: 0x10
		public PnlElfin <>4__this; //Field offset: 0x18

		public <>c__DisplayClass17_0() { }

		internal void <GetMessageBox>b__0() { }

	}

	[SerializeField]
	private Animator m_Animator; //Field offset: 0x18
	[SerializeField]
	private SelectableFancyPanel m_FancyPanel; //Field offset: 0x20
	private DBConfigElfin m_ConfigElfin; //Field offset: 0x28
	private int m_CurCellIndex; //Field offset: 0x30
	[SerializeField]
	private AudioClip m_MenuClip; //Field offset: 0x38
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private Text m_TxtElfinName; //Field offset: 0x40
	[SerializeField]
	private Text m_TxtSkill; //Field offset: 0x48
	[SerializeField]
	private Text m_TxtDescription; //Field offset: 0x50

	public SelectableFancyPanel fancyPanel
	{
		 get { } //Length: 5
	}

	public PnlElfin() { }

	public SelectableFancyPanel get_fancyPanel() { }

	private AbstractMessageBox GetMessageBox(int elfinIndex) { }

	private void JumpToDlc(int elfinIndex) { }

	private void OnApplyClicked() { }

	private void OnDestroy() { }

	private void OnEnable() { }

	private void OnFsvIndexChanged(int index) { }

	private void OnPnlDlcOut() { }

	private void PlayElfinBgm() { }

	private void SetProperties(ElfinInfo elfinInfo, LocalElfinInfo localElfinInfo) { }

	private void SilencerApplyHandler() { }

	private void Start() { }

}

