namespace Assets.Scripts.UI.Panels;

public class PnlRank : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public PnlRank <>4__this; //Field offset: 0x10
		public string uid; //Field offset: 0x18

		public <>c__DisplayClass28_0() { }

		internal void <RefreshGeneral>b__0(JToken token, JToken selfRank, int code) { }

		internal void <RefreshGeneral>b__1(long c, string e) { }

	}

	private const float move_speed = 0.005; //Field offset: 0x0
	public Transform parent; //Field offset: 0x18
	public GameObject rankCell; //Field offset: 0x20
	public GameObject loading; //Field offset: 0x28
	public GameObject loadingTipSwitch; //Field offset: 0x30
	public GameObject noNet; //Field offset: 0x38
	public GameObject scrollView; //Field offset: 0x40
	public GameObject noRank; //Field offset: 0x48
	public GameObject repairing; //Field offset: 0x50
	public GameObject tooFast; //Field offset: 0x58
	public Button refresh; //Field offset: 0x60
	public GameObject serverBusyTip; //Field offset: 0x68
	public GameObject logoutTip; //Field offset: 0x70
	public Scrollbar rankScrollbar; //Field offset: 0x78
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public GameObject server; //Field offset: 0x80
	public Text txtServerRank; //Field offset: 0x88
	public Text txtServerName; //Field offset: 0x90
	public Text txtServerAcc; //Field offset: 0x98
	public Text txtServerScore; //Field offset: 0xA0
	public Transform m_RankCellBuffer; //Field offset: 0xA8
	private FastPool m_RankPool; //Field offset: 0xB0
	private readonly Dictionary<String, JToken> m_Ranks; //Field offset: 0xB8
	private readonly Dictionary<String, JToken> m_SelfRank; //Field offset: 0xC0
	private bool m_Init; //Field offset: 0xC8

	public PnlRank() { }

	private void FastDestroyAll() { }

	private void Init() { }

	private void NsRefreshFail(ErrorType errorType, string uid) { }

	private void NsRefreshSuccess(JToken token, JObject selfRank, string uid) { }

	private void OnDestroy() { }

	private void PoolInit() { }

	public void Refresh(bool force = false) { }

	private void RefreshGeneral(string uid) { }

	private void UIRefresh(string uid) { }

	private void Update() { }

}

