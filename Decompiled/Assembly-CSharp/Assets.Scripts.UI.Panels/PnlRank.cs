using System.Collections.Generic;
using Cpp2ILInjected;
using DG.Tweening;
using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008DC")]
public class PnlRank : MonoBehaviour
{
	[Token(Token = "0x4002E79")]
	[FieldOffset(Offset = "0x18")]
	public Transform parent;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002E7A")]
	public GameObject rankCell;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002E7B")]
	public GameObject loading;

	[Token(Token = "0x4002E7C")]
	[FieldOffset(Offset = "0x30")]
	public GameObject loadingTipSwitch;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002E7D")]
	public GameObject noNet;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002E7E")]
	public GameObject scrollView;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002E7F")]
	public GameObject noRank;

	[Token(Token = "0x4002E80")]
	[FieldOffset(Offset = "0x50")]
	public GameObject repairing;

	[Token(Token = "0x4002E81")]
	[FieldOffset(Offset = "0x58")]
	public GameObject tooFast;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002E82")]
	public Button refresh;

	[Token(Token = "0x4002E83")]
	[FieldOffset(Offset = "0x68")]
	public GameObject serverBusyTip;

	[Token(Token = "0x4002E84")]
	[FieldOffset(Offset = "0x70")]
	public GameObject logoutTip;

	[Token(Token = "0x4002E85")]
	[FieldOffset(Offset = "0x78")]
	public Scrollbar rankScrollbar;

	[SerializeField]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4002E86")]
	private Button m_BtnAttention;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4002E87")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x54A20", Offset = "0x53E20")]
	public GameObject server;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4002E88")]
	public Text txtServerRank;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4002E89")]
	public Text txtServerName;

	[Token(Token = "0x4002E8A")]
	[FieldOffset(Offset = "0xA0")]
	public Text txtServerAcc;

	[Token(Token = "0x4002E8B")]
	[FieldOffset(Offset = "0xA8")]
	public Text txtServerScore;

	[Token(Token = "0x4002E8C")]
	[FieldOffset(Offset = "0xB0")]
	public Transform m_RankCellBuffer;

	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4002E8D")]
	private FastPool m_RankPool;

	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4002E8E")]
	private readonly Dictionary<string, JToken> m_Ranks;

	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4002E8F")]
	private readonly Dictionary<string, JToken> m_SelfRank;

	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4002E90")]
	private bool m_Init;

	[Token(Token = "0x4002E91")]
	[FieldOffset(Offset = "0xD8")]
	private UISelectManage m_PnlPreparationSelect;

	[Token(Token = "0x4002E92")]
	private const string vfx_btn_press = "vfx_level_config_btn_press";

	[Token(Token = "0x4002E93")]
	[FieldOffset(Offset = "0xE0")]
	private GameObject m_VfxBtnPressPref;

	[Token(Token = "0x4002E94")]
	[FieldOffset(Offset = "0xE8")]
	private ParticleSystem m_VfxBtnConfigPress;

	[Token(Token = "0x4002E95")]
	[FieldOffset(Offset = "0xF0")]
	private ParticleSystem m_VfxBtnRandomPress;

	[Token(Token = "0x4002E96")]
	private static bool s_IsDeviceRankCheat;

	[Token(Token = "0x4002E97")]
	private static bool s_IsThirdPartyRankCheat;

	[Token(Token = "0x4002E98")]
	private static bool s_IsAccountRankCheat;

	[Token(Token = "0x4002E99")]
	[FieldOffset(Offset = "0xF8")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x54C20", Offset = "0x54020")]
	public Button btnResetRandomLevelConfig;

	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4002E9A")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x54DF0", Offset = "0x541F0")]
	public Button btnLockLevelConfig;

	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4002E9B")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x54DF0", Offset = "0x541F0")]
	public Button btnOpenPnllevelConfig;

	[Attribute(Name = "HeaderAttribute", RVA = "0x54F90", Offset = "0x54390")]
	[Token(Token = "0x4002E9C")]
	[FieldOffset(Offset = "0x110")]
	public Transform transRandomOn;

	[Attribute(Name = "HeaderAttribute", RVA = "0x54F90", Offset = "0x54390")]
	[Token(Token = "0x4002E9D")]
	[FieldOffset(Offset = "0x118")]
	public Transform transRandomOff;

	[Attribute(Name = "HeaderAttribute", RVA = "0x551B0", Offset = "0x545B0")]
	[Token(Token = "0x4002E9E")]
	[FieldOffset(Offset = "0x120")]
	public Transform rootLevelConfigShow;

	[Token(Token = "0x4002E9F")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x552B0", Offset = "0x546B0")]
	[FieldOffset(Offset = "0x128")]
	public Image imgLevelLockBg;

	[Token(Token = "0x4002EA0")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x552B0", Offset = "0x546B0")]
	[FieldOffset(Offset = "0x130")]
	public Image imgLevelLock;

	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4002EA1")]
	public Image imgRandomFlagBg;

	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4002EA2")]
	public Image imgRandomFlag;

	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4002EA3")]
	public LongSongNameController longLevelConfigNameController;

	[Token(Token = "0x4002EA4")]
	[FieldOffset(Offset = "0x150")]
	private bool isLockLevelConfigStateOnce;

	[Token(Token = "0x4002EA5")]
	[FieldOffset(Offset = "0x158")]
	private (string, string) curLevelConfigNames;

	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4002EA6")]
	private GlobalScriptableObjectData m_GlobalData;

	[Token(Token = "0x4002EA7")]
	[FieldOffset(Offset = "0x170")]
	private Tween tweenRandomOnAni;

	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x4002EA8")]
	private Tween tweenRandomOffAni;

	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4002EA9")]
	private BaseMessageBox m_CannotRandomConfigTip;

	[Token(Token = "0x4002EAA")]
	private const float move_speed = 0.005f;

	[Token(Token = "0x4002EAB")]
	private static Dictionary<string, Sprite> m_SpriteCache;

	[Token(Token = "0x1700089D")]
	private GlobalScriptableObjectData globalData
	{
		[Address(RVA = "0x6898A0", Offset = "0x6880A0", Length = "0xCB")]
		[Token(Token = "0x6004FE3")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x686220", Offset = "0x684A20", Length = "0x7F7")]
	[Token(Token = "0x6004FE4")]
	private void Init()
	{
	}

	[Address(RVA = "0x688BF0", Offset = "0x6873F0", Length = "0x21D")]
	[Token(Token = "0x6004FE5")]
	private void ShowWarningMsgWindow()
	{
	}

	[Token(Token = "0x6004FE6")]
	[Address(RVA = "0x6872E0", Offset = "0x685AE0", Length = "0x156")]
	public void OnClickRandom()
	{
	}

	[Token(Token = "0x6004FE7")]
	[Address(RVA = "0x688BE0", Offset = "0x6873E0", Length = "0x8")]
	private void SetLockLevelConfigStateOnce()
	{
	}

	[Address(RVA = "0x687720", Offset = "0x685F20", Length = "0xCD")]
	[Token(Token = "0x6004FE8")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x6870F0", Offset = "0x6858F0", Length = "0x1EF")]
	[Token(Token = "0x6004FE9")]
	private void OnClickBtnLevelConfig()
	{
	}

	[Token(Token = "0x6004FEA")]
	[Address(RVA = "0x687E60", Offset = "0x686660", Length = "0x3D5")]
	private void RefreshLevelConfigUI()
	{
	}

	[Address(RVA = "0x688240", Offset = "0x686A40", Length = "0x650")]
	[Token(Token = "0x6004FEB")]
	private void RefreshRandomLevelConfigUI(bool showTip = false)
	{
	}

	[Address(RVA = "0x686A20", Offset = "0x685220", Length = "0x11D")]
	[Token(Token = "0x6004FEC")]
	private bool InvokeRandomSelectItem()
	{
		return default(bool);
	}

	[Address(RVA = "0x687B70", Offset = "0x686370", Length = "0x94")]
	[Token(Token = "0x6004FED")]
	private void PoolInit()
	{
	}

	[Address(RVA = "0x688B70", Offset = "0x687370", Length = "0x6A")]
	[Token(Token = "0x6004FEE")]
	public void ResetRankAniState()
	{
	}

	[Token(Token = "0x6004FEF")]
	[Address(RVA = "0x6877F0", Offset = "0x685FF0", Length = "0x371")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x687440", Offset = "0x685C40", Length = "0x2DB")]
	[Token(Token = "0x6004FF0")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x685FB0", Offset = "0x6847B0", Length = "0x13B")]
	[Token(Token = "0x6004FF1")]
	private void FastDestroyAll()
	{
	}

	[Address(RVA = "0x6888A0", Offset = "0x6870A0", Length = "0x2CF")]
	[Token(Token = "0x6004FF2")]
	public void Refresh(bool force = false)
	{
	}

	[Address(RVA = "0x687C40", Offset = "0x686440", Length = "0x21D")]
	[Token(Token = "0x6004FF3")]
	private void RefreshGeneral(string uid)
	{
	}

	[Address(RVA = "0x686B40", Offset = "0x685340", Length = "0x2C2")]
	[Token(Token = "0x6004FF4")]
	private void NsRefreshFail(NexResultDescription.ErrorType errorType, string uid)
	{
	}

	[Address(RVA = "0x686E10", Offset = "0x685610", Length = "0x2D1")]
	[Token(Token = "0x6004FF5")]
	private void NsRefreshSuccess(JToken token, JObject selfRank, string uid)
	{
	}

	[Address(RVA = "0x687C10", Offset = "0x686410", Length = "0x22")]
	[Token(Token = "0x6004FF6")]
	private void PreparationRoleConfigUIRefresh()
	{
	}

	[Address(RVA = "0x688F30", Offset = "0x687730", Length = "0x667")]
	[Token(Token = "0x6004FF7")]
	private void UIRefresh(string uid)
	{
	}

	[Address(RVA = "0x6895A0", Offset = "0x687DA0", Length = "0x1EB")]
	[Token(Token = "0x6004FF8")]
	private void Update()
	{
	}

	[Address(RVA = "0x6860F0", Offset = "0x6848F0", Length = "0x125")]
	[Token(Token = "0x6004FF9")]
	public static Sprite GetSprite(string key)
	{
		return null;
	}

	[Address(RVA = "0x689800", Offset = "0x688000", Length = "0x9C")]
	[Token(Token = "0x6004FFA")]
	public PnlRank()
	{
	}
}
