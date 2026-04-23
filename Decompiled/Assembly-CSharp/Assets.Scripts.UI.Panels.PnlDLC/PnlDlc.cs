using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.Managers;
using Assets.Scripts.PeroTools.Nice.Components;
using Assets.Scripts.PeroTools.PreWarm;
using Assets.Scripts.Purchase;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000939")]
public class PnlDlc : MonoBehaviour, IPreWarm
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4003195")]
	[SerializeField]
	private Assets.Scripts.PeroTools.Nice.Components.FancyScrollView m_FancyScrollView;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4003196")]
	[SerializeField]
	private GameObject m_FSVCellPrefab;

	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4003197")]
	private DlcCharSubControl m_DlcCharSubControl;

	[SerializeField]
	[Token(Token = "0x4003198")]
	[FieldOffset(Offset = "0x30")]
	private PnlDlcBtnPurchase m_PnlDlcBtnPurchase;

	[SerializeField]
	[Token(Token = "0x4003199")]
	[FieldOffset(Offset = "0x38")]
	private PnlDlcFSVCellCache m_FsvCellCache;

	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400319A")]
	private PnlDlcTagControl[] m_DlcTagControls;

	[Token(Token = "0x400319B")]
	[FieldOffset(Offset = "0x48")]
	public LongSongNameController txtTitle;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400319C")]
	public TMP_Text txtMusicAuthor;

	[Token(Token = "0x400319D")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8F170", Offset = "0x8E570")]
	[FieldOffset(Offset = "0x58")]
	public Button btnBack;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400319E")]
	public Animator pnlAnimator;

	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8F260", Offset = "0x8E660")]
	[Token(Token = "0x400319F")]
	[FieldOffset(Offset = "0x68")]
	public GameObject buttonBase;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40031A0")]
	public Text txtJustAsPlannedPlusPurchased;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40031A1")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8F450", Offset = "0x8E850")]
	private Button m_FeedbackBtn;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40031A2")]
	private Coroutine m_AutoPlayCoroutine;

	[Token(Token = "0x40031A3")]
	[FieldOffset(Offset = "0x88")]
	private CoroutineManager m_CoroutineManager;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40031A4")]
	private AudioManager m_AudioManager;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40031A5")]
	private List<int> m_JustAsPlannedJsonIndex;

	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40031A6")]
	private List<int> m_StandardJsonIndex;

	[Token(Token = "0x40031A7")]
	[FieldOffset(Offset = "0xA8")]
	private List<int> m_DlcJsonIndex;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40031A8")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8F5A0", Offset = "0x8E9A0")]
	private GameObject m_PnlJustAsPlannedQA;

	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40031A9")]
	private List<string> m_DemoMusicBuffer;

	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40031AA")]
	private Dictionary<string, MusicInfo> m_MusicInfoBuffer;

	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40031AB")]
	private int m_PlayingDemoIndex;

	[Token(Token = "0x40031AC")]
	private static List<IPnlDlcCellData> s_DisplayPnlCellDataList;

	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x40031AD")]
	private bool m_HasBillboard;

	[Token(Token = "0x40031AE")]
	[FieldOffset(Offset = "0xD0")]
	private int m_ImgButtonCount;

	[SerializeField]
	[Token(Token = "0x40031AF")]
	[FieldOffset(Offset = "0xD8")]
	private PnlDlcGradientControl m_PnlDlcGradientControl;

	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8F9E0", Offset = "0x8EDE0")]
	[Token(Token = "0x40031B2")]
	[SerializeField]
	[FieldOffset(Offset = "0xF0")]
	private GameObject m_MusePlusButton;

	[SerializeField]
	[Token(Token = "0x40031B3")]
	[FieldOffset(Offset = "0xF8")]
	private Button m_BtnToMusePlus;

	[SerializeField]
	[Token(Token = "0x40031B4")]
	[FieldOffset(Offset = "0x100")]
	private RectTransform m_ImgDiscountRect;

	[SerializeField]
	[Token(Token = "0x40031B5")]
	[FieldOffset(Offset = "0x108")]
	private Text m_MpTxtDisCount;

	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x40031B6")]
	private Image m_Mask;

	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40031B7")]
	private readonly int MASKHASH_CENTER;

	[Token(Token = "0x40031B8")]
	[FieldOffset(Offset = "0x11C")]
	private readonly int MASKHASH_RADIUS;

	[Token(Token = "0x40031B9")]
	[FieldOffset(Offset = "0x120")]
	private bool m_IsMuseplusDiscountInited;

	[Token(Token = "0x40031BA")]
	[FieldOffset(Offset = "0x128")]
	private Material m_MatTargetMask;

	[Token(Token = "0x40031BB")]
	[FieldOffset(Offset = "0x130")]
	private Camera m_UiCamera;

	[SerializeField]
	[Token(Token = "0x40031BC")]
	[FieldOffset(Offset = "0x138")]
	private TMP_Text m_SoundEffectText;

	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40031BD")]
	private Canvas m_ParentCanvas;

	[Token(Token = "0x40031BE")]
	[FieldOffset(Offset = "0x148")]
	private TextGenerator textGen;

	[Token(Token = "0x40031BF")]
	[FieldOffset(Offset = "0x150")]
	private List<CarouselInfo> m_CurCarouselInfos;

	[Token(Token = "0x40031C0")]
	[FieldOffset(Offset = "0x158")]
	private Dictionary<string, bool> m_DicDlcPuchaseState;

	[Token(Token = "0x40031C1")]
	[FieldOffset(Offset = "0x160")]
	public int enterShopByButtonCount;

	[Token(Token = "0x40031C2")]
	[FieldOffset(Offset = "0x168")]
	private string m_LastSelectCollectionBundleUid;

	[Token(Token = "0x40031C3")]
	[FieldOffset(Offset = "0x170")]
	public Text txtJsonIndexAndUid;

	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x901A0", Offset = "0x8F5A0")]
	[Token(Token = "0x40031C4")]
	[FieldOffset(Offset = "0x178")]
	public GameObject[] arkKnight2HideObjs;

	[Token(Token = "0x40031C5")]
	[FieldOffset(Offset = "0x180")]
	private TimePeriod m_LastPeroidTime;

	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x40031C6")]
	private IPnlDlcCellData m_LastCellData;

	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x40031C7")]
	private bool m_NotShowArknight2Egg;

	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x40031C8")]
	private FoolDayHandle[] allFoolDayHanldes;

	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x40031C9")]
	private bool m_IsRegisterFoolDayHanlde;

	[SerializeField]
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x40031CA")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x90290", Offset = "0x8F690")]
	private Button m_BtnOverview;

	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x40031CB")]
	[SerializeField]
	private Button m_BtnOverviewBack;

	[SerializeField]
	[Token(Token = "0x40031CC")]
	[FieldOffset(Offset = "0x1B8")]
	private ToggleGroup m_TglGroup;

	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x40031CD")]
	private bool m_IsOverview;

	[Token(Token = "0x40031CE")]
	[FieldOffset(Offset = "0x1C8")]
	private Toggle[] m_TglList;

	[Token(Token = "0x40031CF")]
	[FieldOffset(Offset = "0x1D0")]
	private int m_CurJsonIndex;

	[Token(Token = "0x40031D0")]
	[FieldOffset(Offset = "0x1D4")]
	private int m_BaseCellIndex;

	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x40031D1")]
	private List<IPnlDlcCellData> m_BaseCellDataList;

	[Token(Token = "0x40031D2")]
	[FieldOffset(Offset = "0x1E0")]
	private List<IPnlDlcCellData> m_OverviewCellDataList;

	[Token(Token = "0x40031D3")]
	[FieldOffset(Offset = "0x1E8")]
	private PnlDlcTagControl m_TempTagControl;

	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x40031D4")]
	private List<CollectionBundle> allCollectionBundles;

	[Token(Token = "0x40031D5")]
	[FieldOffset(Offset = "0x1F8")]
	private DLCInfo m_DlcInfo;

	[Token(Token = "0x170008D0")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView fsv
	{
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		[Token(Token = "0x6005355")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008D1")]
	public PnlDlcFSVCellCache fsvCellCache
	{
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		[Token(Token = "0x6005356")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008D2")]
	public bool isOverview
	{
		[Token(Token = "0x600535B")]
		[Address(RVA = "0x43F3D0", Offset = "0x43DBD0", Length = "0x8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000096")]
	public event Action<int> onFinalItemChange
	{
		[CompilerGenerated]
		[Token(Token = "0x6005357")]
		[Address(RVA = "0x43F280", Offset = "0x43DA80", Length = "0x9E")]
		add
		{
		}
		[Token(Token = "0x6005358")]
		[CompilerGenerated]
		[Address(RVA = "0x43F3E0", Offset = "0x43DBE0", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x14000097")]
	public event Action<int> onItemChange
	{
		[CompilerGenerated]
		[Token(Token = "0x6005359")]
		[Address(RVA = "0x43F320", Offset = "0x43DB20", Length = "0x9E")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x600535A")]
		[Address(RVA = "0x43F480", Offset = "0x43DC80", Length = "0x9E")]
		remove
		{
		}
	}

	[Address(RVA = "0x43A8A0", Offset = "0x4390A0", Length = "0x854")]
	[Token(Token = "0x600535C")]
	public void PreWarm(int slice)
	{
	}

	[Address(RVA = "0x439710", Offset = "0x437F10", Length = "0x314")]
	[Token(Token = "0x600535D")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600535E")]
	[Address(RVA = "0x439390", Offset = "0x437B90", Length = "0xCD")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600535F")]
	[Address(RVA = "0x439180", Offset = "0x437980", Length = "0x20C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6005360")]
	[Address(RVA = "0x437F60", Offset = "0x436760", Length = "0x1C7")]
	private void InitTogglePanel()
	{
	}

	[Address(RVA = "0x437910", Offset = "0x436110", Length = "0xCA")]
	[Token(Token = "0x6005361")]
	private void InitMusePlusBtn()
	{
	}

	[Address(RVA = "0x43CC70", Offset = "0x43B470", Length = "0x181")]
	[Token(Token = "0x6005362")]
	private void RefreshMusePlusBtnShow(int cellIndex)
	{
	}

	[Address(RVA = "0x4388A0", Offset = "0x4370A0", Length = "0x169")]
	[Token(Token = "0x6005363")]
	private bool IsCurMuseplusButtonShow(int cellIndex)
	{
		return default(bool);
	}

	[Address(RVA = "0x435E50", Offset = "0x434650", Length = "0x32")]
	[Token(Token = "0x6005364")]
	private void CheckMusePlusDiscount(bool forceRefresh = false)
	{
	}

	[Token(Token = "0x6005365")]
	[Address(RVA = "0x4379E0", Offset = "0x4361E0", Length = "0x142")]
	private void InitMuseplusDiscountText(Product product, DateTime utcTime)
	{
	}

	[Token(Token = "0x6005366")]
	[Address(RVA = "0x43CE00", Offset = "0x43B600", Length = "0x352")]
	private void RefreshMuseplusDiscountText(Product product, DateTime utcTime)
	{
	}

	[Token(Token = "0x6005367")]
	[Address(RVA = "0x4361F0", Offset = "0x4349F0", Length = "0x1C6")]
	private void DoDisCountTextAni(int curDiscount, int targetDiscount, Action callback)
	{
	}

	[Address(RVA = "0x4363C0", Offset = "0x434BC0", Length = "0xA3")]
	[Token(Token = "0x6005368")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x908B0", Offset = "0x8FCB0")]
	private IEnumerator DoTargetMaskAni(Transform srcTrans, Action callback = null)
	{
		return null;
	}

	[Address(RVA = "0x43E090", Offset = "0x43C890", Length = "0x23")]
	[Token(Token = "0x6005369")]
	private void ShowJustAsPlannedQA()
	{
	}

	[Address(RVA = "0x438F60", Offset = "0x437760", Length = "0x213")]
	[Token(Token = "0x600536A")]
	private void OnCreatedItem(GameObject go)
	{
	}

	[Address(RVA = "0x439A30", Offset = "0x438230", Length = "0x31")]
	[Token(Token = "0x600536B")]
	private void OnFeedbackClicked()
	{
	}

	[Token(Token = "0x600536C")]
	[Address(RVA = "0x43A4F0", Offset = "0x438CF0", Length = "0x48")]
	private void PlayClickSfx()
	{
	}

	[Token(Token = "0x600536D")]
	[Address(RVA = "0x438C20", Offset = "0x437420", Length = "0x1BC")]
	private void OnBackBtnClicked()
	{
	}

	[Token(Token = "0x600536E")]
	[Address(RVA = "0x43E5F0", Offset = "0x43CDF0", Length = "0x86")]
	private void StopAutoPlayAlbumDemo()
	{
	}

	[Token(Token = "0x600536F")]
	[Address(RVA = "0x435200", Offset = "0x433A00", Length = "0xF3")]
	private void AddMusicDemoBuffer(string demo, MusicInfo musicInfo)
	{
	}

	[Address(RVA = "0x439A70", Offset = "0x438270", Length = "0x55F")]
	[Token(Token = "0x6005370")]
	private void OnFsvFinalChanged(int i)
	{
	}

	[Token(Token = "0x6005371")]
	[Address(RVA = "0x439FD0", Offset = "0x4387D0", Length = "0xAF")]
	public void OnPackageGroupIndexChange(int jsonIndex)
	{
	}

	[Token(Token = "0x6005372")]
	[Address(RVA = "0x43B5B0", Offset = "0x439DB0", Length = "0x206")]
	private void RefreshAlbumDemoList(int jsonIndex)
	{
	}

	[Token(Token = "0x6005373")]
	[Address(RVA = "0x43D2C0", Offset = "0x43BAC0", Length = "0x564")]
	private void RefreshUnlockDemoList()
	{
	}

	[Address(RVA = "0x43A310", Offset = "0x438B10", Length = "0x1D9")]
	[Token(Token = "0x6005374")]
	private void OnRemotePurchasedRefresh()
	{
	}

	[Address(RVA = "0x43DE10", Offset = "0x43C610", Length = "0x270")]
	[Token(Token = "0x6005375")]
	private void ShowDlcByAlbumJsonIndex(int albumJsonIndex)
	{
	}

	[Address(RVA = "0x43A300", Offset = "0x438B00", Length = "0x8")]
	[Token(Token = "0x6005376")]
	private void OnPnlDlcToggleChange(PnlDlcToggleType toggleType)
	{
	}

	[Address(RVA = "0x438DE0", Offset = "0x4375E0", Length = "0x173")]
	[Token(Token = "0x6005377")]
	public void OnClickToggle(PnlDlcToggleType toggleType)
	{
	}

	[Token(Token = "0x6005378")]
	[Address(RVA = "0x436CE0", Offset = "0x4354E0", Length = "0x207")]
	private int GetNotDlcPackageAlbumIdx()
	{
		return default(int);
	}

	[Address(RVA = "0x43B290", Offset = "0x439A90", Length = "0x238")]
	[Token(Token = "0x6005379")]
	private void RebuildFSV(List<IPnlDlcCellData> albumJsonIndexList, int cellIndex)
	{
	}

	[Address(RVA = "0x43DA70", Offset = "0x43C270", Length = "0x91")]
	[Token(Token = "0x600537A")]
	private void SetFancyScrollViewDrag(bool active)
	{
	}

	[Address(RVA = "0x43C170", Offset = "0x43A970", Length = "0x2E")]
	[Token(Token = "0x600537B")]
	public void RefreshItem()
	{
	}

	[Address(RVA = "0x43BC20", Offset = "0x43A420", Length = "0x548")]
	[Token(Token = "0x600537C")]
	private void RefreshItem(int i)
	{
	}

	[Token(Token = "0x600537D")]
	[Address(RVA = "0x436000", Offset = "0x434800", Length = "0x1E4")]
	private void DoArknight2AniIn()
	{
	}

	[Address(RVA = "0x43B4D0", Offset = "0x439CD0", Length = "0x49")]
	[Token(Token = "0x600537E")]
	public void RecoverAni()
	{
	}

	[Address(RVA = "0x43B520", Offset = "0x439D20", Length = "0x87")]
	[Token(Token = "0x600537F")]
	public void RecoverInput()
	{
	}

	[Address(RVA = "0x43D970", Offset = "0x43C170", Length = "0x77")]
	[Token(Token = "0x6005380")]
	public void SetArknightObjFalse()
	{
	}

	[Address(RVA = "0x43D9F0", Offset = "0x43C1F0", Length = "0x77")]
	[Token(Token = "0x6005381")]
	public void SetArknightObjTrue()
	{
	}

	[Token(Token = "0x6005382")]
	[Address(RVA = "0x43E0C0", Offset = "0x43C8C0", Length = "0x52E")]
	private void StartAutoPlayAlbumDemo(int index)
	{
	}

	[Address(RVA = "0x43A750", Offset = "0x438F50", Length = "0x148")]
	[Token(Token = "0x6005383")]
	internal void PlayNextDemo(int offset)
	{
	}

	[Address(RVA = "0x43E7C0", Offset = "0x43CFC0", Length = "0x159")]
	[Token(Token = "0x6005384")]
	private bool TryGetLocalMusicInfo(string audioName, out string localMusicInfo)
	{
		localMusicInfo = null;
		return default(bool);
	}

	[Address(RVA = "0x43E680", Offset = "0x43CE80", Length = "0x13F")]
	[Token(Token = "0x6005385")]
	private bool TryGetLocalAlbumInfo(string audioName, out string localAlbumInfo)
	{
		localAlbumInfo = null;
		return default(bool);
	}

	[Token(Token = "0x6005386")]
	[Address(RVA = "0x43E920", Offset = "0x43D120", Length = "0x89")]
	private int TryGetMusicAlbumIndex(string audioName)
	{
		return default(int);
	}

	[Token(Token = "0x6005387")]
	[Address(RVA = "0x43EB20", Offset = "0x43D320", Length = "0x3C8")]
	private void UnregisterEvent()
	{
	}

	[Address(RVA = "0x43D1E0", Offset = "0x43B9E0", Length = "0xDB")]
	[Token(Token = "0x6005388")]
	private void RefreshSelectCell()
	{
	}

	[Token(Token = "0x6005389")]
	[Address(RVA = "0x4353A0", Offset = "0x433BA0", Length = "0x2C3")]
	private void ArkNightMusicEggCheck(MusicInfo musicInfo)
	{
	}

	[Address(RVA = "0x4394F0", Offset = "0x437CF0", Length = "0x21B")]
	[Token(Token = "0x600538A")]
	public void OnDlcMusicClicked(MusicInfo info)
	{
	}

	[Token(Token = "0x600538B")]
	[Address(RVA = "0x439460", Offset = "0x437C60", Length = "0x8F")]
	public void OnDlcBillboardClicked(int jsonIndex, int buttonIndex, bool stopAll = false)
	{
	}

	[Token(Token = "0x600538C")]
	[Address(RVA = "0x4373E0", Offset = "0x435BE0", Length = "0x140")]
	internal PnlDlcToggleType GetToggleByAlbumJson(IPnlDlcCellData cellData)
	{
		return default(PnlDlcToggleType);
	}

	[Token(Token = "0x600538D")]
	[Address(RVA = "0x436EF0", Offset = "0x4356F0", Length = "0xDA")]
	internal static IPnlDlcCellData GetPnlDlcCellDataByCellIndex(int cellIndex)
	{
		return null;
	}

	[Token(Token = "0x600538E")]
	[Address(RVA = "0x437280", Offset = "0x435A80", Length = "0x152")]
	internal static DBConfigAlbums.AlbumsInfo GetSelectAlbumInfoIndexByCellIndex(int cellIndex)
	{
		return null;
	}

	[Token(Token = "0x600538F")]
	[Address(RVA = "0x436FD0", Offset = "0x4357D0", Length = "0x2A0")]
	internal static IPnlDlcCellData GetPnlDlcCellDataByJsonIndex(int JsonIndex)
	{
		return null;
	}

	[Address(RVA = "0x43B930", Offset = "0x43A130", Length = "0x284")]
	[Token(Token = "0x6005390")]
	private void RefreshDlcPurchaseState()
	{
	}

	[Address(RVA = "0x43BBC0", Offset = "0x43A3C0", Length = "0x51")]
	[Token(Token = "0x6005391")]
	private void RefreshDlcToggle()
	{
	}

	[Address(RVA = "0x438A10", Offset = "0x437210", Length = "0x144")]
	[Token(Token = "0x6005392")]
	public bool IsCurSelectAlbumIsCollectionBundle(ref string curSelectBundleUid)
	{
		return default(bool);
	}

	[Token(Token = "0x6005393")]
	[Address(RVA = "0x43CC50", Offset = "0x43B450", Length = "0x11")]
	private void RefreshJsonList()
	{
	}

	[Address(RVA = "0x43C1A0", Offset = "0x43A9A0", Length = "0xAA1")]
	[Token(Token = "0x6005394")]
	private void RefreshJsonListForBase()
	{
	}

	[Token(Token = "0x6005395")]
	[Address(RVA = "0x43B7C0", Offset = "0x439FC0", Length = "0xD8")]
	private void RefreshAllCellDataCellIndex()
	{
	}

	[Token(Token = "0x6005396")]
	[Address(RVA = "0x436470", Offset = "0x434C70", Length = "0x65")]
	private DlcCellAlbumData GenerateAlbumCellData(DBConfigAlbums.AlbumsInfo albumsInfo)
	{
		return null;
	}

	[Token(Token = "0x6005397")]
	[Address(RVA = "0x4364E0", Offset = "0x434CE0", Length = "0xAC")]
	private DlcCellCBData GenetateCBCellData(CollectionBundle collectionBundle, string selectUid)
	{
		return null;
	}

	[Token(Token = "0x6005398")]
	[Address(RVA = "0x436590", Offset = "0x434D90", Length = "0x43")]
	private DlcCellCollabData GenetateCollabCellListData()
	{
		return null;
	}

	[Token(Token = "0x6005399")]
	[Address(RVA = "0x435A70", Offset = "0x434270", Length = "0x3DC")]
	private void CheckDisplayALbumJsonIndexList()
	{
	}

	[Address(RVA = "0x43B8A0", Offset = "0x43A0A0", Length = "0x82")]
	[Token(Token = "0x600539A")]
	private void RefreshCollectionBundleDatas()
	{
	}

	[Address(RVA = "0x438130", Offset = "0x436930", Length = "0x2A9")]
	[Token(Token = "0x600539B")]
	private void InsertCollectionBundle(DlcCellCBData dlcCellCbData)
	{
	}

	[Address(RVA = "0x437B30", Offset = "0x436330", Length = "0x421")]
	[Token(Token = "0x600539C")]
	private void InitOverviewList()
	{
	}

	[Address(RVA = "0x437530", Offset = "0x435D30", Length = "0x1AB")]
	[Token(Token = "0x600539D")]
	private void GoToOverview()
	{
	}

	[Token(Token = "0x600539E")]
	[Address(RVA = "0x4358E0", Offset = "0x4340E0", Length = "0x153")]
	private void BackFromOverview()
	{
	}

	[Address(RVA = "0x435A40", Offset = "0x434240", Length = "0x24")]
	[Token(Token = "0x600539F")]
	public void BackToJAP()
	{
	}

	[Address(RVA = "0x43B100", Offset = "0x439900", Length = "0x180")]
	[Token(Token = "0x60053A0")]
	private void RandomList(List<string> source, string last, int topIndex)
	{
	}

	[Address(RVA = "0x435300", Offset = "0x433B00", Length = "0x97")]
	[Token(Token = "0x60053A1")]
	private void AlbumTimeoutCheck(string uid)
	{
	}

	[Token(Token = "0x60053A2")]
	[Address(RVA = "0x435670", Offset = "0x433E70", Length = "0x263")]
	private void Awake()
	{
	}

	[Token(Token = "0x60053A3")]
	[Address(RVA = "0x437770", Offset = "0x435F70", Length = "0x19A")]
	private void InitAllFoolDayHandle()
	{
	}

	[Token(Token = "0x60053A4")]
	[Address(RVA = "0x43D830", Offset = "0x43C030", Length = "0x134")]
	private void RemoveAllFoolDayHanlde()
	{
	}

	[Token(Token = "0x60053A5")]
	[Address(RVA = "0x435E90", Offset = "0x434690", Length = "0xF3")]
	private void CleanAll()
	{
	}

	[Address(RVA = "0x43A080", Offset = "0x438880", Length = "0x27C")]
	[Token(Token = "0x60053A6")]
	private void OnPlayAlbumDemo(int index, string audioName)
	{
	}

	[Token(Token = "0x60053A7")]
	[Address(RVA = "0x43DDD0", Offset = "0x43C5D0", Length = "0x36")]
	public void SetTxtMusicAuthor(string targetStr)
	{
	}

	[Address(RVA = "0x43D160", Offset = "0x43B960", Length = "0x74")]
	[Token(Token = "0x60053A8")]
	public void RefreshMusicAuthorInfoByAudioName(int billIndex, int jsonIndex, string audioName)
	{
	}

	[Token(Token = "0x60053A9")]
	[Address(RVA = "0x43DB10", Offset = "0x43C310", Length = "0x2BA")]
	public void SetTip(int billIndex, int jsonIndex)
	{
	}

	[Token(Token = "0x60053AA")]
	[Address(RVA = "0x4385B0", Offset = "0x436DB0", Length = "0x2E3")]
	private void IsContainSoundEffectChar(string str)
	{
	}

	[Token(Token = "0x60053AB")]
	[Address(RVA = "0x4365E0", Offset = "0x434DE0", Length = "0x45F")]
	public Vector3 GetCharacterPositions(Canvas canvas, TMP_Text tmpText, char character, int index)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60053AC")]
	[Address(RVA = "0x436A40", Offset = "0x435240", Length = "0x29C")]
	public Vector3 GetCharacterPositions(Canvas canvas, TMP_Text tmpText, string targetStr)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60053AD")]
	[Address(RVA = "0x43A540", Offset = "0x438D40", Length = "0x200")]
	public void PlayCurDlcSoundEffect()
	{
	}

	[Token(Token = "0x60053AE")]
	[Address(RVA = "0x4376E0", Offset = "0x435EE0", Length = "0x81")]
	private void HideSoundEffectText()
	{
	}

	[Address(RVA = "0x438B60", Offset = "0x437360", Length = "0xB8")]
	[Token(Token = "0x60053AF")]
	public bool NeedHideArknight2(int targetJsonIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x60053B0")]
	[Address(RVA = "0x4383E0", Offset = "0x436BE0", Length = "0x1C4")]
	public bool IsCellDataEqualToLastData(IPnlDlcCellData targetCellData)
	{
		return default(bool);
	}

	[Token(Token = "0x60053B1")]
	[Address(RVA = "0x435F90", Offset = "0x434790", Length = "0x6A")]
	public void Close()
	{
	}

	[Token(Token = "0x60053B2")]
	[Address(RVA = "0x43EF50", Offset = "0x43D750", Length = "0x32D")]
	public PnlDlc()
	{
	}
}
