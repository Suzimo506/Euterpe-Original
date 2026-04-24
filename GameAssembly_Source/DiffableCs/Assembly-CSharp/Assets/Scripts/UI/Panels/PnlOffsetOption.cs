namespace Assets.Scripts.UI.Panels;

public class PnlOffsetOption : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public int offset; //Field offset: 0x10
		public PnlOffsetOption <>4__this; //Field offset: 0x18
		public int totalTick; //Field offset: 0x20

		public <>c__DisplayClass31_0() { }

		internal void <OnEnable>b__0(int t) { }

	}

	public Transform start; //Field offset: 0x18
	public Transform end; //Field offset: 0x20
	public RectTransform touchRect; //Field offset: 0x28
	public Animator animator; //Field offset: 0x30
	public GameObject nonius; //Field offset: 0x38
	public GameObject fadeObject; //Field offset: 0x40
	public AudioClip audioClip; //Field offset: 0x48
	public Button btnNext; //Field offset: 0x50
	public Button btnPre; //Field offset: 0x58
	public Button tipButton; //Field offset: 0x60
	public Text text; //Field offset: 0x68
	public Transform line; //Field offset: 0x70
	public GameObject tip; //Field offset: 0x78
	public Button btnOffset; //Field offset: 0x80
	public GameObject title; //Field offset: 0x88
	public GameObject titleTvMode; //Field offset: 0x90
	private Timer m_Timer; //Field offset: 0x98
	private int m_Offset; //Field offset: 0xA0
	public bool isTvMode; //Field offset: 0xA4
	private float m_Acceleration; //Field offset: 0xA8
	private float m_AccelerationTimer; //Field offset: 0xAC
	private float m_LineDragX; //Field offset: 0xB0
	[HideInInspector]
	public bool isLineDraging; //Field offset: 0xB4
	public AudioClip optionBgmClip; //Field offset: 0xB8
	private Tween m_Tween; //Field offset: 0xC0

	public PnlOffsetOption() { }

	[CompilerGenerated]
	private void <OnApplicationPause>b__28_0() { }

	[CompilerGenerated]
	private void <Start>b__26_0(bool b) { }

	[CompilerGenerated]
	private void <Start>b__26_1() { }

	[CompilerGenerated]
	private void <Start>b__26_2(bool b) { }

	[CompilerGenerated]
	private void <Start>b__26_3() { }

	private void FixedUpdate() { }

	private void OnApplicationPause(bool isPause) { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnOffsetChanged(bool forward) { }

	private void OnTipClicked() { }

	public void SetTvMode(bool enable) { }

	private void Start() { }

	private void Tap() { }

	private void Update() { }

}

