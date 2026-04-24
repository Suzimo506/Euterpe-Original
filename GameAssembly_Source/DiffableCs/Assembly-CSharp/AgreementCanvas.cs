//Type is in global namespace

public class AgreementCanvas : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction <>9__18_2; //Field offset: 0x8
		public static Action <>9__25_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <InitPnlChange>b__18_2() { }

		internal void <OnBtnAcceptAgreementClick>b__25_1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public Action<JObject> succeedCallback; //Field offset: 0x10

		public <>c__DisplayClass22_0() { }

		internal void <SendToBackendUrl>b__0(DownloadHandler handler) { }

	}

	[SerializeField]
	private GameObject m_AccountCanvas; //Field offset: 0x18
	[SerializeField]
	private GameObject m_MainManager; //Field offset: 0x20
	private JObject m_JObjAgreement; //Field offset: 0x28
	private MDAccountData m_AccountData; //Field offset: 0x30
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private Popup m_PopupPnlChange; //Field offset: 0x48
	[SerializeField]
	private ClickableText m_CTxtChange; //Field offset: 0x50
	[SerializeField]
	private Button m_BtnChangeAgree1; //Field offset: 0x58
	[SerializeField]
	private Button m_BtnChangeDisagree1; //Field offset: 0x60
	[SerializeField]
	private Popup m_PopupPnlChangeAgreeAgain; //Field offset: 0x68
	[SerializeField]
	private ClickableText m_CTxtChangeAgreeAgain; //Field offset: 0x70
	[SerializeField]
	private Button m_BtnChangeAgree2; //Field offset: 0x78
	[SerializeField]
	private Button m_BtnChangeDisagree2; //Field offset: 0x80
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private Popup m_PopupPnlUserAgreement; //Field offset: 0x88
	[SerializeField]
	private TextMeshProUGUI m_TxtUserAgreement; //Field offset: 0x90
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private Popup m_PopupPnlPrivacyAgreement; //Field offset: 0x98
	[SerializeField]
	private TextMeshProUGUI m_TxtPrivacyAgreement; //Field offset: 0xA0

	public AgreementCanvas() { }

	[CompilerGenerated]
	private void <GetUserPrivacyAgreementInfo>b__19_0(JObject jObj) { }

	[CompilerGenerated]
	private void <InitPnlChange>b__18_0() { }

	[CompilerGenerated]
	private void <InitPnlChange>b__18_1() { }

	[CompilerGenerated]
	private void <InitPnlChange>b__18_3(string s1, string s2) { }

	[CompilerGenerated]
	private void <InitPnlChange>b__18_4(string s1, string s2) { }

	[CompilerGenerated]
	private void <OnBtnAcceptAgreementClick>b__25_0() { }

	private void GetUserPrivacyAgreementInfo() { }

	private void InitAccountData() { }

	private void InitPnlChange() { }

	private void OnAcceptAgreement() { }

	private void OnBtnAcceptAgreementClick() { }

	private void OpenAgreementText(string key) { }

	private void SaveAccountData() { }

	private void SendToBackendUrl(string url, string method = "GET", Action<JObject> succeedCallback = null) { }

	private void Start() { }

	private void UpdateAgreementText() { }

}

