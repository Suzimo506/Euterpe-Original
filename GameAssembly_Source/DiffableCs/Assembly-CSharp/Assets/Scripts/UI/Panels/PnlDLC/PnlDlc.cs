namespace Assets.Scripts.UI.Panels.PnlDLC;

public class PnlDlc : MonoBehaviour, IPreWarm
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x16ED60

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__34_0(int <p0>) { }

	}

	private static PnlDlc m_Instance; //Field offset: 0x0
	[CompilerGenerated]
	private static Action<Int32> onFinalItemChange; //Field offset: 0x8
	public FancyScrollView fancyScrollView; //Field offset: 0x18
	public Text txtTitle; //Field offset: 0x20
	public Text txtMusicAuthor; //Field offset: 0x28
	public BtnIAP btnIAP; //Field offset: 0x30
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Button btnBack; //Field offset: 0x38
	public Animator pnlAnimator; //Field offset: 0x40
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public GameObject buttonBase; //Field offset: 0x48
	public Button btnJustAsPlanned; //Field offset: 0x50
	public Button btnQuestion; //Field offset: 0x58
	private GameObject m_NormalButtonBase; //Field offset: 0x60
	private GameObject m_JustAsPlanButtonBase; //Field offset: 0x68
	public Text txtJustAsPlannedPlusPurchased; //Field offset: 0x70
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public AudioClip clickSfx; //Field offset: 0x78
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private Button m_FeedbackBtn; //Field offset: 0x80
	private Coroutine m_AutoPlayCoroutine; //Field offset: 0x88
	private CoroutineManager m_CoroutineManager; //Field offset: 0x90
	private AudioManager m_AudioManager; //Field offset: 0x98
	private string m_CurMusicName; //Field offset: 0xA0
	private Animator m_Animator; //Field offset: 0xA8
	private int m_DlcInAnim; //Field offset: 0xB0
	private List<String> m_DemoMusicBuffer; //Field offset: 0xB8
	private Dictionary<String, MusicInfo> m_MusicInfoBuffer; //Field offset: 0xC0
	private bool m_HasImgButton; //Field offset: 0xC8
	private int m_ImgButtonCount; //Field offset: 0xCC

	public static event Action<Int32> onFinalItemChange
	{
		[CompilerGenerated]
		 add { } //Length: 254
		[CompilerGenerated]
		 remove { } //Length: 254
	}

	public int ImgButtonCount
	{
		 get { } //Length: 7
	}

	public static PnlDlc instance
	{
		 get { } //Length: 86
	}

	private static PnlDlc() { }

	public PnlDlc() { }

	[CompilerGenerated]
	public static void add_onFinalItemChange(Action<Int32> value) { }

	public int get_ImgButtonCount() { }

	public static PnlDlc get_instance() { }

	public override void PreWarm(int slice) { }

	[CompilerGenerated]
	public static void remove_onFinalItemChange(Action<Int32> value) { }

}

