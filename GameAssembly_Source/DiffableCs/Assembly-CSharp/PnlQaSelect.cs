//Type is in global namespace

public class PnlQaSelect : UISelectManage
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public Button btn; //Field offset: 0x10
		public int delegateIndex; //Field offset: 0x18
		public PnlQaSelect <>4__this; //Field offset: 0x20

		public <>c__DisplayClass16_0() { }

		internal void <OnAwake>b__0() { }

	}

	public RectTransform content; //Field offset: 0x110
	public Scrollbar scrollbar; //Field offset: 0x118
	private List<GameObject> m_SelectableGameObjects; //Field offset: 0x120
	private bool m_IsPress; //Field offset: 0x128
	private int m_LastIndex; //Field offset: 0x12C
	[SerializeField]
	private List<Button> m_Btns; //Field offset: 0x130
	[SerializeField]
	private Button m_BackBtn; //Field offset: 0x138
	[SerializeField]
	private Animator m_PnlAnimator; //Field offset: 0x140
	private bool m_HandlerEvent; //Field offset: 0x148
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public GameObject Question8; //Field offset: 0x150
	public GameObject Question9; //Field offset: 0x158
	public Text Question12_Simple; //Field offset: 0x160
	public Button question9_Simple; //Field offset: 0x168
	public Button question12_Simple; //Field offset: 0x170

	public PnlQaSelect() { }

	[CompilerGenerated]
	private void <OnBackClicked>b__17_0() { }

	[CompilerGenerated]
	private float <SetScrollBar>b__24_0() { }

	[CompilerGenerated]
	private void <SetScrollBar>b__24_1(float x) { }

	public virtual GameObject DefaultSelectObj() { }

	public virtual void OnAwake() { }

	private void OnBackClicked() { }

	public virtual void OnDisablePnl() { }

	public virtual void OnEnablePnl() { }

	private void OnQAButtonClicked(Button btn, int index) { }

	protected virtual void OnSelect(GameObject currentObj) { }

	public virtual void OnUpdatePnl() { }

	public virtual Transform SetEdgeObj(GameObject currentObj) { }

	private void SetScrollBar(int currentIndex) { }

	public virtual List<GameObject> SetSelectableObj() { }

}

