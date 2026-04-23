using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Account;
using Assets.Scripts.PeroTools.Nice.Interface;
using Assets.Scripts.UI.PnlAccount;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;
using PeroTools2.UI;
using TMPro;
using UI.PnlAccount;
using UnityEngine;
using UnityEngine.UI;
using ZenFulcrum.EmbeddedBrowser;

[Token(Token = "0x2000094")]
public class AccountCanvas : MonoBehaviour
{
	[Token(Token = "0x20009CC")]
	public struct MDAccountProtocolData
	{
		[Token(Token = "0x400350A")]
		[FieldOffset(Offset = "0x0")]
		public bool isFirstAgree;

		[FieldOffset(Offset = "0x1")]
		[Token(Token = "0x400350B")]
		public bool isAgree;

		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400350C")]
		public string agreementVersion;

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400350D")]
		public bool isAgreeChange;
	}

	[Token(Token = "0x20009CD")]
	public struct SaveDataEntity
	{
		[Token(Token = "0x400350E")]
		[FieldOffset(Offset = "0x0")]
		public Dictionary<string, IData> userData;

		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400350F")]
		public int curExp;

		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4003510")]
		public int localExp;

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003511")]
		public int cloudExp;

		[Token(Token = "0x4003512")]
		[FieldOffset(Offset = "0x18")]
		public string lastSaveDate;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003513")]
		public int platform;
	}

	[SerializeField]
	[Token(Token = "0x40003A4")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7C420", Offset = "0x7B820")]
	private GameObject m_PnlWelcomeAccount;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003A5")]
	[SerializeField]
	private Text m_TxtAccountName;

	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40003A6")]
	private Button m_BtnChangeAccount;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003A7")]
	[SerializeField]
	private Button m_BtnLogin;

	[SerializeField]
	[Token(Token = "0x40003A8")]
	[FieldOffset(Offset = "0x38")]
	private Button m_BtnR12;

	[Token(Token = "0x40003A9")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Popup m_PopupPnlR12;

	[SerializeField]
	[Token(Token = "0x40003AA")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7DF00", Offset = "0x7D300")]
	[FieldOffset(Offset = "0x48")]
	private PnlWelcomeAccountInfo m_WelcomeAccountInfo;

	[Token(Token = "0x40003AB")]
	[SerializeField]
	[FieldOffset(Offset = "0x50")]
	private PopupPeroLoginV2 m_PeroLoginV2;

	[SerializeField]
	[Token(Token = "0x40003AC")]
	[FieldOffset(Offset = "0x58")]
	private Button m_BtnLoginOthers;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40003AD")]
	[SerializeField]
	private Button m_BtnApple;

	[SerializeField]
	[Token(Token = "0x40003AE")]
	[FieldOffset(Offset = "0x68")]
	private Button m_BtnGoogle;

	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x40003AF")]
	private Button m_BtnFacebook;

	[SerializeField]
	[Token(Token = "0x40003B0")]
	[FieldOffset(Offset = "0x78")]
	private Toggle m_TglAgree;

	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x40003B1")]
	private ClickableText m_CTxtAgree;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40003B2")]
	[SerializeField]
	private Animator m_AnimAgreeTip;

	[Token(Token = "0x40003B3")]
	[SerializeField]
	[FieldOffset(Offset = "0x90")]
	private ContentSizeFitter m_ContentSizeFitter;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40003B4")]
	[SerializeField]
	private Button m_BtnQuestion1;

	[Token(Token = "0x40003B5")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private Text m_TxtVersion;

	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7ED10", Offset = "0x7E110")]
	[Token(Token = "0x40003B6")]
	[FieldOffset(Offset = "0xA8")]
	private Popup m_PopupPnlUpdateAgreement;

	[SerializeField]
	[Token(Token = "0x40003B7")]
	[FieldOffset(Offset = "0xB0")]
	private Text m_TxtUpdateAgreement;

	[SerializeField]
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40003B8")]
	private ClickableText m_CTxtAgreeUpdate;

	[Token(Token = "0x40003B9")]
	[SerializeField]
	[FieldOffset(Offset = "0xC0")]
	private Button m_BtnUpdateYes;

	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40003BA")]
	[SerializeField]
	private Button m_BtnUpdateNo;

	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40003BB")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F2B0", Offset = "0x7E6B0")]
	private Popup m_PopupPnlUserAgreement;

	[SerializeField]
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40003BC")]
	private TextMeshProUGUI m_TxtUserAgreement;

	[Token(Token = "0x40003BD")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F660", Offset = "0x7EA60")]
	[FieldOffset(Offset = "0xE0")]
	private Popup m_PopupPnlPrivacyAgreement;

	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40003BE")]
	[SerializeField]
	private TextMeshProUGUI m_TxtPrivacyAgreement;

	[Token(Token = "0x40003BF")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F660", Offset = "0x7EA60")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private Popup m_PopupPnlChildPrivacyAgreement;

	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[Token(Token = "0x40003C0")]
	private TextMeshProUGUI m_TxtChildPrivacyAgreement;

	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40003C1")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FBB0", Offset = "0x7EFB0")]
	private Popup m_PopupPnlDisagreement;

	[SerializeField]
	[Token(Token = "0x40003C2")]
	[FieldOffset(Offset = "0x108")]
	private ClickableText m_CTxtAgreeFinal;

	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40003C3")]
	[SerializeField]
	private Button m_BtnYesAgreeFinal;

	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Token(Token = "0x40003C4")]
	private Button m_BtnNoAgreeFinal;

	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x801D0", Offset = "0x7F5D0")]
	[SerializeField]
	[Token(Token = "0x40003C5")]
	[FieldOffset(Offset = "0x120")]
	private Popup m_PopupPnlEmptyAccount;

	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[Token(Token = "0x40003C6")]
	private Text m_PnlEmptyAccountText;

	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x40003C7")]
	[SerializeField]
	private Button m_BtnEmptyAccountBack;

	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x40003C8")]
	[SerializeField]
	private Button m_BtnEmptyAccountYes;

	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[Token(Token = "0x40003C9")]
	private Button m_BtnEmptyFindAccount;

	[SerializeField]
	[Token(Token = "0x40003CA")]
	[FieldOffset(Offset = "0x148")]
	private Button m_BtnQuestion2;

	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x80840", Offset = "0x7FC40")]
	[Token(Token = "0x40003CB")]
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	private Popup m_PopPnlHavingData;

	[SerializeField]
	[Token(Token = "0x40003CC")]
	[FieldOffset(Offset = "0x158")]
	private Button m_BtnHavingDataLogin;

	[SerializeField]
	[Token(Token = "0x40003CD")]
	[FieldOffset(Offset = "0x160")]
	private Button m_BtnNextLoginType;

	[SerializeField]
	[Token(Token = "0x40003CE")]
	[FieldOffset(Offset = "0x168")]
	private Text m_TxtAccountName1;

	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x40003CF")]
	[SerializeField]
	private Text m_TxtLevel;

	[SerializeField]
	[Token(Token = "0x40003D0")]
	[FieldOffset(Offset = "0x178")]
	private Text m_TxtLoginTime;

	[SerializeField]
	[Token(Token = "0x40003D1")]
	[FieldOffset(Offset = "0x180")]
	private Button m_BtnQuestion3;

	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x82290", Offset = "0x81690")]
	[SerializeField]
	[Token(Token = "0x40003D2")]
	[FieldOffset(Offset = "0x188")]
	private Popup m_PopupPnlMandatroyBinding;

	[SerializeField]
	[Token(Token = "0x40003D3")]
	[FieldOffset(Offset = "0x190")]
	private Button m_BtnChangeAccount1;

	[SerializeField]
	[Token(Token = "0x40003D4")]
	[FieldOffset(Offset = "0x198")]
	private Button m_BtnSendCode;

	[SerializeField]
	[Token(Token = "0x40003D5")]
	[FieldOffset(Offset = "0x1A0")]
	private InputField m_IFNumber;

	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x827A0", Offset = "0x81BA0")]
	[SerializeField]
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x40003D6")]
	private Popup m_PopupPnlVerificationCode;

	[SerializeField]
	[Token(Token = "0x40003D7")]
	[FieldOffset(Offset = "0x1B0")]
	private Text m_TxtNumber;

	[Token(Token = "0x40003D8")]
	[FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	private Button m_BtnVerificationYes;

	[SerializeField]
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x40003D9")]
	private Button m_BtnResend;

	[SerializeField]
	[Token(Token = "0x40003DA")]
	[FieldOffset(Offset = "0x1C8")]
	private Text m_TxtTime;

	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x40003DB")]
	[SerializeField]
	private Text m_TxtResend;

	[SerializeField]
	[Token(Token = "0x40003DC")]
	[FieldOffset(Offset = "0x1D8")]
	private InputField m_IFCode;

	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x82FD0", Offset = "0x823D0")]
	[Token(Token = "0x40003DD")]
	[FieldOffset(Offset = "0x1E0")]
	private PopupPnlCloudAsk m_PopupPnlCloudAsk;

	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x40003DE")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x830A0", Offset = "0x824A0")]
	private Popup m_PopupPnlRealName;

	[SerializeField]
	[Token(Token = "0x40003DF")]
	[FieldOffset(Offset = "0x1F0")]
	private InputField m_IFName;

	[Token(Token = "0x40003E0")]
	[FieldOffset(Offset = "0x1F8")]
	[SerializeField]
	private InputField m_IFIdNumber;

	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x40003E1")]
	[SerializeField]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x83550", Offset = "0x82950")]
	private Button m_BtnRealNameCancel;

	[Token(Token = "0x40003E2")]
	[SerializeField]
	[FieldOffset(Offset = "0x208")]
	private Button m_BtnRealNameCommit;

	[FieldOffset(Offset = "0x210")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x83940", Offset = "0x82D40")]
	[Token(Token = "0x40003E3")]
	private Popup m_TesterVerificationPanel;

	[SerializeField]
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x40003E4")]
	private Button m_BtnComfirm;

	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x40003E5")]
	[SerializeField]
	private Button m_BtnCanel;

	[SerializeField]
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x40003E6")]
	private InputField m_IFTesterID;

	[Token(Token = "0x40003E7")]
	[SerializeField]
	[FieldOffset(Offset = "0x230")]
	private InputField m_IFTesterPWd;

	[SerializeField]
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x40003E8")]
	private Text m_Tips;

	[FieldOffset(Offset = "0x240")]
	[SerializeField]
	[Token(Token = "0x40003E9")]
	private GameObject m_PnlWaterMark;

	[FieldOffset(Offset = "0x248")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x85750", Offset = "0x84B50")]
	[SerializeField]
	[Token(Token = "0x40003EA")]
	private Popup m_PopupPnlRealNameAgain;

	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x40003EB")]
	[SerializeField]
	private Button m_BtnRealNameAgainYes;

	[SerializeField]
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x40003EC")]
	private Text m_TxtRealNameName;

	[SerializeField]
	[Token(Token = "0x40003ED")]
	[FieldOffset(Offset = "0x260")]
	private Text m_TxtRealNameId;

	[SerializeField]
	[Token(Token = "0x40003EE")]
	[FieldOffset(Offset = "0x268")]
	private GameObject m_AdultGO;

	[SerializeField]
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x40003EF")]
	private GameObject m_NoAdultGO;

	[SerializeField]
	[Token(Token = "0x40003F0")]
	[FieldOffset(Offset = "0x278")]
	private ClickableText m_CTxtNoAdult;

	[SerializeField]
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x40003F1")]
	private Popup m_PopupPnlMinorNotification;

	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x40003F2")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x87280", Offset = "0x86680")]
	private Popup m_PnlRealNamePhoneVerify;

	[Token(Token = "0x40003F3")]
	[FieldOffset(Offset = "0x290")]
	[SerializeField]
	private Button m_BtnRealNamePhoneVerifyConfirm;

	[SerializeField]
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x40003F4")]
	private Button m_BtnRealNamePhoneVerifySendCode;

	[Token(Token = "0x40003F5")]
	[FieldOffset(Offset = "0x2A0")]
	[SerializeField]
	private Text m_TxtRealNamePhoneVerifySendCode;

	[Token(Token = "0x40003F6")]
	[SerializeField]
	[FieldOffset(Offset = "0x2A8")]
	private InputField m_InputRealNamePhoneNumber;

	[SerializeField]
	[Token(Token = "0x40003F7")]
	[FieldOffset(Offset = "0x2B0")]
	private InputField m_InputRealNamePhoneVerifyCode;

	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x87CD0", Offset = "0x870D0")]
	[SerializeField]
	[Token(Token = "0x40003F8")]
	[FieldOffset(Offset = "0x2B8")]
	private Popup m_PopupPnlBound;

	[SerializeField]
	[Token(Token = "0x40003F9")]
	[FieldOffset(Offset = "0x2C0")]
	private Button m_BtnChangeType;

	[SerializeField]
	[Token(Token = "0x40003FA")]
	[FieldOffset(Offset = "0x2C8")]
	private Button m_BtnBoundYes;

	[Token(Token = "0x40003FB")]
	[SerializeField]
	[FieldOffset(Offset = "0x2D0")]
	private Text m_TxtBoundNickName;

	[Token(Token = "0x40003FC")]
	[SerializeField]
	[FieldOffset(Offset = "0x2D8")]
	private Text m_TxtBoundLevel;

	[SerializeField]
	[Token(Token = "0x40003FD")]
	[FieldOffset(Offset = "0x2E0")]
	private Text m_TxtBoundIAP;

	[SerializeField]
	[Token(Token = "0x40003FE")]
	[FieldOffset(Offset = "0x2E8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x87FC0", Offset = "0x873C0")]
	private Popup m_PopupPnlOldAccountBinding;

	[SerializeField]
	[Token(Token = "0x40003FF")]
	[FieldOffset(Offset = "0x2F0")]
	private Button m_BtnBindingYes;

	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x88230", Offset = "0x87630")]
	[SerializeField]
	[Token(Token = "0x4000400")]
	[FieldOffset(Offset = "0x2F8")]
	private Popup m_PopupPnlPaymentLimit;

	[SerializeField]
	[Token(Token = "0x4000401")]
	[FieldOffset(Offset = "0x300")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x88230", Offset = "0x87630")]
	private Popup m_PopupPnlPlayLimit;

	[FieldOffset(Offset = "0x308")]
	[SerializeField]
	[Token(Token = "0x4000402")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x88590", Offset = "0x87990")]
	private Popup m_PopupPnlChange;

	[FieldOffset(Offset = "0x310")]
	[SerializeField]
	[Token(Token = "0x4000403")]
	private ClickableText m_CTxtChange;

	[FieldOffset(Offset = "0x318")]
	[Token(Token = "0x4000404")]
	[SerializeField]
	private Button m_BtnChangeAgree1;

	[SerializeField]
	[Token(Token = "0x4000405")]
	[FieldOffset(Offset = "0x320")]
	private Button m_BtnChangeDisagree1;

	[Token(Token = "0x4000406")]
	[FieldOffset(Offset = "0x328")]
	[SerializeField]
	private Popup m_PopupPnlChangeAgreeAgain;

	[FieldOffset(Offset = "0x330")]
	[Token(Token = "0x4000407")]
	[SerializeField]
	private ClickableText m_CTxtChangeAgreeAgain;

	[SerializeField]
	[Token(Token = "0x4000408")]
	[FieldOffset(Offset = "0x338")]
	private Button m_BtnChangeAgree2;

	[SerializeField]
	[Token(Token = "0x4000409")]
	[FieldOffset(Offset = "0x340")]
	private Button m_BtnChangeDisagree2;

	[Token(Token = "0x400040A")]
	[SerializeField]
	[FieldOffset(Offset = "0x348")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8A300", Offset = "0x89700")]
	private Popup m_PopupPnlDataMigration;

	[FieldOffset(Offset = "0x350")]
	[Token(Token = "0x400040B")]
	[SerializeField]
	private Button m_BtnDataMigrationAgree1;

	[SerializeField]
	[Token(Token = "0x400040C")]
	[FieldOffset(Offset = "0x358")]
	private Button m_BtnDataMigrationDisagree1;

	[Token(Token = "0x400040D")]
	[SerializeField]
	[FieldOffset(Offset = "0x360")]
	private Popup m_PopupPnlDataMigrationAgain;

	[SerializeField]
	[Token(Token = "0x400040E")]
	[FieldOffset(Offset = "0x368")]
	private Button m_BtnDataMigrationAgree2;

	[SerializeField]
	[Token(Token = "0x400040F")]
	[FieldOffset(Offset = "0x370")]
	private Button m_BtnDataMigrationDisagree2;

	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8AB10", Offset = "0x89F10")]
	[SerializeField]
	[Token(Token = "0x4000410")]
	[FieldOffset(Offset = "0x378")]
	private PopupPnlPermissions m_PnlPermissions;

	[Token(Token = "0x4000411")]
	[SerializeField]
	[FieldOffset(Offset = "0x380")]
	private PopupPnlLoginExpiredTips m_PnlLoginExpiredTips;

	[Token(Token = "0x4000412")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8AE90", Offset = "0x8A290")]
	[FieldOffset(Offset = "0x388")]
	private Browser m_LoginWebView;

	[FieldOffset(Offset = "0x390")]
	[Token(Token = "0x4000413")]
	private MDAccountProtocolData m_AccountData;

	[Token(Token = "0x4000414")]
	[FieldOffset(Offset = "0x3A8")]
	private bool m_IsLocalSave;

	[FieldOffset(Offset = "0x3B0")]
	[Token(Token = "0x4000415")]
	private JObject m_JObjUpdateAgreement;

	[Token(Token = "0x4000416")]
	[FieldOffset(Offset = "0x3B8")]
	private JObject m_JObjAgreement;

	[Token(Token = "0x4000417")]
	[FieldOffset(Offset = "0x3C0")]
	private JToken m_JObjSave;

	[FieldOffset(Offset = "0x3C8")]
	[Token(Token = "0x4000418")]
	private JObject m_JObjNumber;

	[Token(Token = "0x4000419")]
	[FieldOffset(Offset = "0x3D0")]
	private UserBindInfo m_JObjUserInfo;

	[Token(Token = "0x400041A")]
	[FieldOffset(Offset = "0x3D8")]
	private JObject m_JObjUserProfile;

	[Token(Token = "0x400041B")]
	[FieldOffset(Offset = "0x3E0")]
	private Coroutine m_GetUserInfoCoroutine;

	[Token(Token = "0x400041C")]
	[FieldOffset(Offset = "0x3E8")]
	private string m_BrowserCopy;

	[Token(Token = "0x400041D")]
	[FieldOffset(Offset = "0x3F0")]
	private bool m_IsIOSLogin;

	[Token(Token = "0x400041E")]
	[FieldOffset(Offset = "0x3F1")]
	private bool m_IsShowPnlAgreementUpdate;

	[Token(Token = "0x4000423")]
	public const long vertify_time_gap = 60L;

	[Token(Token = "0x4000424")]
	public const int loginBan = -1;

	[Token(Token = "0x4000425")]
	public const int freezeBan = -2;

	[Token(Token = "0x4000426")]
	public const int loginExpired = -3;

	[Token(Token = "0x4000427")]
	public const int rankBan = -4;

	[Token(Token = "0x4000428")]
	public const int purchaseBan = -5;

	[Token(Token = "0x4000429")]
	public const string rankFunction = "rank";

	[Token(Token = "0x400042A")]
	public const string purchaseFunction = "purchase";

	[Token(Token = "0x1700006F")]
	public static AccountCanvas instance
	{
		[CompilerGenerated]
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x774060", Offset = "0x772860", Length = "0x35")]
		get
		{
			return null;
		}
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x7740E0", Offset = "0x7728E0", Length = "0x42")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000070")]
	public GameObject PanelWelcomeAccount
	{
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000071")]
	public string webViewCurLoginType
	{
		[Address(RVA = "0x7740D0", Offset = "0x7728D0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600042F")]
		private get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x774160", Offset = "0x772960", Length = "0xF")]
		set
		{
		}
	}

	[Token(Token = "0x17000072")]
	public bool isXdLogin
	{
		[CompilerGenerated]
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x7740A0", Offset = "0x7728A0", Length = "0x8")]
		private get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x774130", Offset = "0x772930", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x17000073")]
	public long vertifyClickTime
	{
		[Address(RVA = "0x7740C0", Offset = "0x7728C0", Length = "0x8")]
		[Token(Token = "0x6000433")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[CompilerGenerated]
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x774150", Offset = "0x772950", Length = "0x8")]
		set
		{
		}
	}

	[Token(Token = "0x17000074")]
	public string phoneLoginNumber
	{
		[CompilerGenerated]
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x7740B0", Offset = "0x7728B0", Length = "0x8")]
		private get
		{
			return null;
		}
		[Token(Token = "0x6000436")]
		[CompilerGenerated]
		[Address(RVA = "0x774140", Offset = "0x772940", Length = "0xF")]
		set
		{
		}
	}

	[Token(Token = "0x6000437")]
	[Address(RVA = "0x76BEE0", Offset = "0x76A6E0", Length = "0x30")]
	public void OnPayLimited()
	{
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0x76BF20", Offset = "0x76A720", Length = "0x104")]
	public void OnPlayTimeLimited()
	{
	}

	[Address(RVA = "0x76B790", Offset = "0x769F90", Length = "0x5C0")]
	[Token(Token = "0x6000439")]
	public void OnBtnLoginClick()
	{
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0x76CE50", Offset = "0x76B650", Length = "0x31")]
	public void OpenQuestionUrl()
	{
	}

	[Address(RVA = "0x76C620", Offset = "0x76AE20", Length = "0xBB")]
	[Token(Token = "0x600043B")]
	public void OpenAgreementText(string key)
	{
	}

	[Token(Token = "0x600043C")]
	[Address(RVA = "0x770280", Offset = "0x76EA80", Length = "0x6F")]
	public void SetPrivacyAgree()
	{
	}

	[Token(Token = "0x600043D")]
	[Address(RVA = "0x76AD30", Offset = "0x769530", Length = "0xAE")]
	public bool GetPrivacyAgree()
	{
		return default(bool);
	}

	[Address(RVA = "0x76F3F0", Offset = "0x76DBF0", Length = "0x274")]
	[Token(Token = "0x600043E")]
	public void PnlRealName()
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0x76F2A0", Offset = "0x76DAA0", Length = "0x14A")]
	public void PnlRealNameWithoutCheck()
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0x76F670", Offset = "0x76DE70", Length = "0x1F9")]
	private void PnlTesterVerification()
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0x76B270", Offset = "0x769A70", Length = "0x144")]
	private void InitWaterMarkInfo()
	{
	}

	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C460", Offset = "0x8B860")]
	[Token(Token = "0x6000442")]
	[Address(RVA = "0x770470", Offset = "0x76EC70", Length = "0xA3")]
	private IEnumerator TesterVerification(string testerID, string testerPWD)
	{
		return null;
	}

	[Address(RVA = "0x76B430", Offset = "0x769C30", Length = "0x19A")]
	[Token(Token = "0x6000443")]
	public bool IsIdentifyAdult(string num, ref bool isValidate)
	{
		return default(bool);
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0x7688E0", Offset = "0x7670E0", Length = "0x1A5")]
	public void ActionAfterHandledConflictSaveData(bool isLocalSave)
	{
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0x769780", Offset = "0x767F80", Length = "0x1D9")]
	private void Awake()
	{
	}

	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C660", Offset = "0x8BA60")]
	[Token(Token = "0x6000446")]
	[Address(RVA = "0x76B3C0", Offset = "0x769BC0", Length = "0x6B")]
	private IEnumerator Init()
	{
		return null;
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0x76ADE0", Offset = "0x7695E0", Length = "0xF3")]
	private void GetUserInfo(Action callback = null)
	{
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0x76B1C0", Offset = "0x7699C0", Length = "0xA6")]
	private void InitAccountData()
	{
	}

	[Address(RVA = "0x76A1B0", Offset = "0x7689B0", Length = "0x1A2")]
	[Token(Token = "0x6000449")]
	public void DevicePermissionsCheck(bool forceShowMessageBox, Action passCallback, Action banCallback)
	{
	}

	[Address(RVA = "0x76A820", Offset = "0x769020", Length = "0x17A")]
	[Token(Token = "0x600044A")]
	private void GetDeviceData(out Dictionary<string, string> headers, out Dictionary<string, object> datas)
	{
		headers = null;
		datas = null;
	}

	[Token(Token = "0x600044B")]
	[Address(RVA = "0x769AE0", Offset = "0x7682E0", Length = "0x548")]
	private void DevicePermissionsCheckCallback(JObject jObj, bool forceShowMessageBox, Action passCallback, Action banCallback)
	{
	}

	[Token(Token = "0x600044C")]
	[Address(RVA = "0x76AB00", Offset = "0x769300", Length = "0x22C")]
	private bool GetIsDeviceEnterBan()
	{
		return default(bool);
	}

	[Address(RVA = "0x76A030", Offset = "0x768830", Length = "0x171")]
	[Token(Token = "0x600044D")]
	private void DevicePermissionsCheckFailCallback(long failCode, string failMsg, bool foreceShowMessageBox, Action passCallback, Action banCallback)
	{
	}

	[Address(RVA = "0x7695D0", Offset = "0x767DD0", Length = "0x1A2")]
	[Token(Token = "0x600044E")]
	public void AllPermissionsCheck(bool forceShowMessageBox, Action passCallback = null, Action banCallback = null)
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x768D20", Offset = "0x767520", Length = "0x61C")]
	private void AllPermissionsCheckCallback(JObject jObj, bool forceShowMessageBox, Action passCallback, Action banCallback)
	{
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x76A9A0", Offset = "0x7691A0", Length = "0x15D")]
	private bool GetIsAllPermissionsEnterBan()
	{
		return default(bool);
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x769340", Offset = "0x767B40", Length = "0x28F")]
	private void AllPermissionsCheckFailCallback(long failCode, string failMsg, bool foreceShowMessageBox, Action passCallback, Action banCallback)
	{
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0x769AD0", Offset = "0x7682D0", Length = "0xC")]
	private void CheckValueForFinish(bool value)
	{
	}

	[Address(RVA = "0x442320", Offset = "0x440B20", Length = "0x2F")]
	[Token(Token = "0x6000453")]
	public void HideChangeAccount()
	{
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0x770240", Offset = "0x76EA40", Length = "0x36")]
	public void SetActiveWelcomeLogin(bool value)
	{
	}

	[Address(RVA = "0x76A5D0", Offset = "0x768DD0", Length = "0x24F")]
	[Token(Token = "0x6000455")]
	private void Finish()
	{
	}

	[Address(RVA = "0x76B630", Offset = "0x769E30", Length = "0x159")]
	[Token(Token = "0x6000456")]
	private void LoginFinished()
	{
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0x76A360", Offset = "0x768B60", Length = "0xC1")]
	public void EnterMainScene()
	{
	}

	[Address(RVA = "0x76B160", Offset = "0x769960", Length = "0x57")]
	[Token(Token = "0x6000458")]
	public void HideWelcomeAccountEntry()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6000459")]
	private void RestorePurchasedItems()
	{
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x76B5D0", Offset = "0x769DD0", Length = "0x55")]
	private bool IsReady()
	{
		return default(bool);
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x76FE70", Offset = "0x76E670", Length = "0x68")]
	private void SaveAccountData()
	{
	}

	[Address(RVA = "0x76FAB0", Offset = "0x76E2B0", Length = "0x3B1")]
	[Token(Token = "0x600045C")]
	private void PnlWelcomeAccount()
	{
	}

	[Address(RVA = "0x76A430", Offset = "0x768C30", Length = "0x197")]
	[Token(Token = "0x600045D")]
	private void EvtBtnLoginClicked()
	{
	}

	[Address(RVA = "0x76C1A0", Offset = "0x76A9A0", Length = "0x118")]
	[Token(Token = "0x600045E")]
	private void OnXDLoginSucceed1(string ac)
	{
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0x76C030", Offset = "0x76A830", Length = "0x163")]
	private void OnXDLoginFailed2(string msg)
	{
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0x76C2C0", Offset = "0x76AAC0", Length = "0x35A")]
	private void OnXDLoginSucceed2(string ac)
	{
	}

	[Address(RVA = "0x76C6E0", Offset = "0x76AEE0", Length = "0x1C5")]
	[Token(Token = "0x6000461")]
	private void OpenPeroLogin()
	{
	}

	[Address(RVA = "0x76E7C0", Offset = "0x76CFC0", Length = "0x6A8")]
	[Token(Token = "0x6000462")]
	private void PnlLogin()
	{
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x76CE90", Offset = "0x76B690", Length = "0x1FC")]
	private void PnlAgreementUpdate()
	{
	}

	[Address(RVA = "0x76F870", Offset = "0x76E070", Length = "0xD0")]
	[Token(Token = "0x6000464")]
	private void PnlUserPrivacyAgreement()
	{
	}

	[Address(RVA = "0x7738C0", Offset = "0x7720C0", Length = "0x3BB")]
	[Token(Token = "0x6000465")]
	private void UpdateAgreementText()
	{
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x76E070", Offset = "0x76C870", Length = "0x1E7")]
	private void PnlDisagreement()
	{
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0x76E260", Offset = "0x76CA60", Length = "0x23A")]
	private void PnlEmptyAccount()
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0x76E4A0", Offset = "0x76CCA0", Length = "0x317")]
	private void PnlLoginHavingData()
	{
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0x76BD80", Offset = "0x76A580", Length = "0x15A")]
	public void OnLoginFinished()
	{
	}

	[Address(RVA = "0x769960", Offset = "0x768160", Length = "0x162")]
	[Token(Token = "0x600046A")]
	private void CheckSaveData()
	{
	}

	[Address(RVA = "0x76AEE0", Offset = "0x7696E0", Length = "0x272")]
	[Token(Token = "0x600046B")]
	private void HandleDataAfterLogin(JObject userCloudSaveData, JObject userCloudProfileData)
	{
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0x7702F0", Offset = "0x76EAF0", Length = "0x172")]
	private void SetUserInfo(JObject userCloudSaveData, Action infoSetCallback = null)
	{
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0x76EEA0", Offset = "0x76D6A0", Length = "0x128")]
	private void PnlMandatoryBinding()
	{
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x76C8B0", Offset = "0x76B0B0", Length = "0x31D")]
	private void OpenPnlMandatroyBinding()
	{
	}

	[Address(RVA = "0x76FEE0", Offset = "0x76E6E0", Length = "0x359")]
	[Token(Token = "0x600046F")]
	private void SendVerifyCode()
	{
	}

	[Address(RVA = "0x76F950", Offset = "0x76E150", Length = "0x151")]
	[Token(Token = "0x6000470")]
	private void PnlVerificationCode()
	{
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0x773C80", Offset = "0x772480", Length = "0x3D1")]
	private void Update()
	{
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0x76D090", Offset = "0x76B890", Length = "0x35C")]
	private void PnlBound()
	{
	}

	[Address(RVA = "0x76EFD0", Offset = "0x76D7D0", Length = "0x8C")]
	[Token(Token = "0x6000473")]
	private void PnlOldAccountBinding()
	{
	}

	[Address(RVA = "0x76D820", Offset = "0x76C020", Length = "0x555")]
	[Token(Token = "0x6000474")]
	private void PnlCloud()
	{
	}

	[Address(RVA = "0x76D3F0", Offset = "0x76BBF0", Length = "0x42C")]
	[Token(Token = "0x6000475")]
	private void PnlChange()
	{
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0x768A90", Offset = "0x767290", Length = "0x6F")]
	private void AgreeChange()
	{
	}

	[Token(Token = "0x6000477")]
	[Address(RVA = "0x76DD80", Offset = "0x76C580", Length = "0x2E0")]
	private void PnlDataMigration()
	{
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0x768B00", Offset = "0x767300", Length = "0x105")]
	private void AgreeDataMigration()
	{
	}

	[Address(RVA = "0x76CBD0", Offset = "0x76B3D0", Length = "0x271")]
	[Token(Token = "0x6000479")]
	private void OpenPnlRealNameAgain()
	{
	}

	[Address(RVA = "0x76F060", Offset = "0x76D860", Length = "0x231")]
	[Token(Token = "0x600047A")]
	private void PnlRealNamePhoneVerify()
	{
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x768C10", Offset = "0x767410", Length = "0x103")]
	private bool AgreementVersionUpdate()
	{
		return default(bool);
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600047C")]
	public AccountCanvas()
	{
	}
}
