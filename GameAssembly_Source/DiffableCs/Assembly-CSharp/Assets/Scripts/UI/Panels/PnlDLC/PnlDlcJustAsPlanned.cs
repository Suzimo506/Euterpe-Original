namespace Assets.Scripts.UI.Panels.PnlDLC;

public class PnlDlcJustAsPlanned : MonoBehaviour
{
	private class DisplayFsv
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Action<Boolean> <>9__15_0; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal void <.ctor>b__15_0(bool <p0>) { }

		}

		private FancyScrollView m_Fsv; //Field offset: 0x10
		private LongSongNameController m_Description; //Field offset: 0x18
		private Transform[] m_Cells; //Field offset: 0x20
		private Image[] m_CellImage; //Field offset: 0x28
		private Button m_Button; //Field offset: 0x30
		private List<DisplayInfo> m_Source; //Field offset: 0x38
		private Coroutine m_MoveNext; //Field offset: 0x40
		private bool m_IsScrolling; //Field offset: 0x48
		[CompilerGenerated]
		private int <fsvIndex>k__BackingField; //Field offset: 0x4C
		[CompilerGenerated]
		private Action<Boolean> onClick; //Field offset: 0x50

		public event Action<Boolean> onClick
		{
			[CompilerGenerated]
			 add { } //Length: 158
			[CompilerGenerated]
			 remove { } //Length: 158
		}

		public private int fsvIndex
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public DisplayFsv() { }

		[CompilerGenerated]
		public void add_onClick(Action<Boolean> value) { }

		[CompilerGenerated]
		public int get_fsvIndex() { }

		[CompilerGenerated]
		public void remove_onClick(Action<Boolean> value) { }

		[CompilerGenerated]
		private void set_fsvIndex(int value) { }

	}

	private class DisplayInfo
	{
		public string source; //Field offset: 0x10
		public string description; //Field offset: 0x18
		public string extra; //Field offset: 0x20

		public DisplayInfo() { }

	}

	private const string m_DisplayRegexPattern = "[\s-\.]"; //Field offset: 0x0
	private static int m_CharacterDisplayIndex; //Field offset: 0x0
	private static int m_ElfinDisplayIndex; //Field offset: 0x4
	private static int m_InterludeDisplayIndex; //Field offset: 0x8
	private static List<DisplayInfo> m_DisplayCharacter; //Field offset: 0x10
	private static List<DisplayInfo> m_DisplayElfin; //Field offset: 0x18
	private static List<DisplayInfo> m_DisplayInterlude; //Field offset: 0x20
	private static bool s_ForceRefresh; //Field offset: 0x28
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public FancyScrollView character; //Field offset: 0x18
	public Button btnCharacter; //Field offset: 0x20
	public LongSongNameController characterTitleController; //Field offset: 0x28
	public Animator characterAnim; //Field offset: 0x30
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public FancyScrollView elfin; //Field offset: 0x38
	public Button btnElfin; //Field offset: 0x40
	public LongSongNameController elfinTitleController; //Field offset: 0x48
	public Animator elfinAnim; //Field offset: 0x50
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public FancyScrollView interlude; //Field offset: 0x58
	public Button btnInterlude; //Field offset: 0x60
	public Animator interludeAnim; //Field offset: 0x68
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public LongSongNameController songNameController; //Field offset: 0x70
	public LongSongNameController albumNameController; //Field offset: 0x78
	public Button btnNextSong; //Field offset: 0x80
	public Button btnPreviousSong; //Field offset: 0x88
	private Animator m_BtnNextSongAnim; //Field offset: 0x90
	private Animator m_BtnPreviousSongAnim; //Field offset: 0x98
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public GameObject price; //Field offset: 0xA0
	public GameObject priceCountdown; //Field offset: 0xA8
	public GameObject imgDiscount; //Field offset: 0xB0
	public Text txtDiscount; //Field offset: 0xB8
	public Text txtCountDown; //Field offset: 0xC0
	private PnlPrice m_Price; //Field offset: 0xC8
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Button btnPurchase; //Field offset: 0xD0
	public Button btnRestorePurchase; //Field offset: 0xD8
	public Button btnPurchased; //Field offset: 0xE0
	private BtnIAP m_BtnPurchaseIAP; //Field offset: 0xE8
	private BtnIAP m_BtnRestorePurchaseIAP; //Field offset: 0xF0
	public GameObject purchaseMask; //Field offset: 0xF8
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public GameObject achvIcon; //Field offset: 0x100
	private Button m_BtnAchvIcon; //Field offset: 0x108
	private int m_WhiteAnim; //Field offset: 0x110
	private DisplayFsv m_CharacterDisplay; //Field offset: 0x118
	private DisplayFsv m_ElfinDisplay; //Field offset: 0x120
	private DisplayFsv m_InterludeDisplay; //Field offset: 0x128
	private bool m_IsUnlockAll; //Field offset: 0x130
	private bool m_Inited; //Field offset: 0x131

	private static PnlDlcJustAsPlanned() { }

	public PnlDlcJustAsPlanned() { }

}

