namespace Assets.Scripts.UI.Specials;

public class AutoPushPopPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__13_0; //Field offset: 0x8
		public static Action <>9__18_0; //Field offset: 0x10
		public static Action <>9__20_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal void <OnNavigationBackClicked>b__13_0() { }

		internal void <OnPnlMenuActiveChanged>b__20_0() { }

		internal void <OnPnlPreparationActiveChanged>b__18_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public AbstractMessageBox msg; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal void <OnNavigationBackClicked>b__1() { }

	}

	public Button btnNavigationBack; //Field offset: 0x18
	public CanvasGroup pnlHome; //Field offset: 0x20
	public CanvasGroup pnlMenu; //Field offset: 0x28
	public CanvasGroup pnlNavigation; //Field offset: 0x30
	public CanvasGroup pnlPreparation; //Field offset: 0x38
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public CanvasGroup pnlStage; //Field offset: 0x40
	public PnlMenu pnlMenuScript; //Field offset: 0x48
	public GameObject pnlStageBgsRoot; //Field offset: 0x50
	private CanvasGroup m_PreActivePanel; //Field offset: 0x58

	private CanvasGroup preActivePanel
	{
		private get { } //Length: 5
		private set { } //Length: 12
	}

	public AutoPushPopPanel() { }

	private void Awake() { }

	private void Close(CanvasGroup cg, bool changeGo = true) { }

	private CanvasGroup get_preActivePanel() { }

	private void OnMenuBackClicked() { }

	private void OnNavigationBackClicked() { }

	private void OnPnlHomeActiveChanged(GameObject go, bool active) { }

	private void OnPnlMenuActiveChanged(GameObject arg0, bool active) { }

	private void OnPnlPreparationActiveChanged(GameObject arg0, bool active) { }

	private void OnPnlStageActiveChanged(GameObject arg0, bool active) { }

	private void set_preActivePanel(CanvasGroup value) { }

	private void Show(CanvasGroup cg, bool changeGo = true) { }

}

