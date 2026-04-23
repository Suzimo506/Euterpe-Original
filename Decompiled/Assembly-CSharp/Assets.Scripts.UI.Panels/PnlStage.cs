using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.Managers;
using Assets.Scripts.PeroTools.Nice.Components;
using Assets.Scripts.PeroTools.PreWarm;
using Assets.Scripts.UI.Panels.PnlMusicTag;
using Assets.Scripts.UI.Specials;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008DD")]
public class PnlStage : VisBasePropertyModifier, IPreWarm
{
	[Token(Token = "0x2000D6E")]
	private class DiffItem
	{
		[Token(Token = "0x4003FB2")]
		[FieldOffset(Offset = "0x10")]
		public RectTransform diffImgRectTrans;

		[Token(Token = "0x4003FB3")]
		[FieldOffset(Offset = "0x18")]
		public Image diffImg;

		[Token(Token = "0x4003FB4")]
		[FieldOffset(Offset = "0x20")]
		public Text diffText;

		[Token(Token = "0x4003FB5")]
		[FieldOffset(Offset = "0x28")]
		public Outline diffOutline;

		[Token(Token = "0x4003FB6")]
		[FieldOffset(Offset = "0x30")]
		public Sprite originImgSprite;

		[Token(Token = "0x4003FB7")]
		[FieldOffset(Offset = "0x38")]
		public Color orginTextColor;

		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003FB8")]
		public Color originOutlineColor;

		[Token(Token = "0x4003FB9")]
		[FieldOffset(Offset = "0x58")]
		public Vector2 originWidthAnHeight;

		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4003FBA")]
		public Vector2 sWidthAndHeight;

		[Token(Token = "0x4003FBB")]
		private static Dictionary<string, Sprite> m_SpriteCache;

		[Token(Token = "0x600647F")]
		[Address(RVA = "0x4BF810", Offset = "0x4BE010", Length = "0x256")]
		public DiffItem(GameObject obj, Text text)
		{
		}

		[Address(RVA = "0x4BF700", Offset = "0x4BDF00", Length = "0xA5")]
		[Token(Token = "0x6006480")]
		private void SetWidthAndHeight(Vector2 newSize)
		{
		}

		[Address(RVA = "0x4BF110", Offset = "0x4BD910", Length = "0x2EC")]
		[Token(Token = "0x6006481")]
		public void ChangeSchemeByEvalue(int evaluateIndex, GlobalScriptableObjectData globalData)
		{
		}

		[Token(Token = "0x6006482")]
		[Address(RVA = "0x4BF420", Offset = "0x4BDC20", Length = "0x123")]
		public static Sprite GetSprite(string key)
		{
			return null;
		}

		[Token(Token = "0x6006483")]
		[Address(RVA = "0x4BF550", Offset = "0x4BDD50", Length = "0x1A0")]
		private void OnDestroy()
		{
		}
	}

	[Token(Token = "0x4002EAC")]
	[FieldOffset(Offset = "0x50")]
	public GameObject albumCellPrefabs;

	[Token(Token = "0x4002EAD")]
	[FieldOffset(Offset = "0x58")]
	public Text titleOwn;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002EAE")]
	public GameObject imgSearch;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4002EAF")]
	public Image musicTagImage;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4002EB0")]
	public GameObject imgFavoriteMusic;

	[Space]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4002EB1")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView musicFancyScrollView;

	[Token(Token = "0x4002EB2")]
	[FieldOffset(Offset = "0x80")]
	public Text musicNameTitle;

	[Token(Token = "0x4002EB3")]
	[FieldOffset(Offset = "0x88")]
	public LongSongNameController musicLongNameController;

	[Token(Token = "0x4002EB4")]
	[FieldOffset(Offset = "0x90")]
	public Text artistNameTitle;

	[Token(Token = "0x4002EB5")]
	[FieldOffset(Offset = "0x98")]
	public LongSongNameController artistLongNameController;

	[Token(Token = "0x4002EB6")]
	[FieldOffset(Offset = "0xA0")]
	[Space]
	public GameObject musicRoot;

	[Token(Token = "0x4002EB7")]
	[FieldOffset(Offset = "0xA8")]
	public Animator pnlStageAnimator;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4002EB8")]
	public string animNameAlbumIn;

	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4002EB9")]
	public string animNameAlbumOut;

	[Token(Token = "0x4002EBA")]
	[FieldOffset(Offset = "0xC0")]
	public Button btnAhcievement;

	[Token(Token = "0x4002EBB")]
	[FieldOffset(Offset = "0xC8")]
	public Button btnEnter;

	[Token(Token = "0x4002EBC")]
	[FieldOffset(Offset = "0xD0")]
	public Button btnBackInPnlMenu;

	[Token(Token = "0x4002EBD")]
	[FieldOffset(Offset = "0xD8")]
	public Button btnPlay;

	[Token(Token = "0x4002EBE")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject pnlPreparation;

	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4002EBF")]
	public PnlPreparation pnlPreparationScript;

	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4002EC0")]
	public float demoMusicFadeInTime;

	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4002EC1")]
	public GameObject difficulty1Lock;

	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4002EC2")]
	public GameObject difficulty2Lock;

	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4002EC3")]
	public GameObject difficulty3Lock;

	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4002EC4")]
	public Text difficulty1;

	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4002EC5")]
	public Text difficulty2;

	[Token(Token = "0x4002EC6")]
	[FieldOffset(Offset = "0x120")]
	public Text difficulty3;

	[Token(Token = "0x4002EC7")]
	[FieldOffset(Offset = "0x128")]
	public GameObject difficulty1Easy;

	[Token(Token = "0x4002EC8")]
	[FieldOffset(Offset = "0x130")]
	public GameObject difficulty2Hard;

	[Token(Token = "0x4002EC9")]
	[FieldOffset(Offset = "0x138")]
	public GameObject difficulty3Empty;

	[Token(Token = "0x4002ECA")]
	[FieldOffset(Offset = "0x140")]
	public GameObject difficulty3Master;

	[Token(Token = "0x4002ECB")]
	[FieldOffset(Offset = "0x148")]
	public GameObject emptyEasy;

	[Token(Token = "0x4002ECC")]
	[FieldOffset(Offset = "0x150")]
	public GameObject emptyMaster;

	[Token(Token = "0x4002ECD")]
	[FieldOffset(Offset = "0x158")]
	private DiffItem m_Diff1Item;

	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4002ECE")]
	private DiffItem m_Diff2Item;

	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4002ECF")]
	private DiffItem m_Diff3Item;

	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4002ED0")]
	private GlobalScriptableObjectData globalData;

	[SerializeField]
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x4002ED1")]
	private StageLikeToggle m_TglLikeScript;

	[Token(Token = "0x4002ED2")]
	[FieldOffset(Offset = "0x180")]
	public GameObject achievementObj;

	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4002ED3")]
	public Image achievementPercent;

	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4002ED4")]
	public GameObject stageAchievementPercent;

	[Token(Token = "0x4002ED5")]
	[FieldOffset(Offset = "0x198")]
	public GameObject nsNoCollectionTip;

	[Token(Token = "0x4002ED6")]
	[FieldOffset(Offset = "0x1A0")]
	public GameObject noMusicFromHide;

	[Token(Token = "0x4002ED7")]
	[FieldOffset(Offset = "0x1A8")]
	public GameObject noMusicSample;

	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4002ED8")]
	[SerializeField]
	public BgsRoot m_BgsRoot;

	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4002ED9")]
	public Toggle tglDifficultyEasy;

	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4002EDA")]
	public Toggle tglDifficultyHard;

	[Token(Token = "0x4002EDB")]
	[FieldOffset(Offset = "0x1C8")]
	public Toggle tglDifficultyMaster;

	[Token(Token = "0x4002EDC")]
	[FieldOffset(Offset = "0x1D0")]
	public Scrollbar musicFsvShow;

	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4002EDD")]
	public Scrollbar musicFsvPlay;

	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4002EDE")]
	private Animator m_MusicRootAnimator;

	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4002EDF")]
	private Coroutine m_PlayMusicCoroutine;

	[Token(Token = "0x4002EE0")]
	[FieldOffset(Offset = "0x1F0")]
	private bool m_CanPlayMusic;

	[FieldOffset(Offset = "0x1F4")]
	[Token(Token = "0x4002EE1")]
	private TimePeriod lastTimePeriod;

	[Token(Token = "0x4002EE2")]
	[FieldOffset(Offset = "0x1F8")]
	public AudioClip clickSfx;

	[Token(Token = "0x4002EE3")]
	[FieldOffset(Offset = "0x200")]
	public GameObject pnlItemAward;

	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4002EE4")]
	public GameObject visualizerManager;

	[Token(Token = "0x4002EE5")]
	[FieldOffset(Offset = "0x210")]
	public GameObject parFlyAwardCoin;

	[SerializeField]
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4002EE6")]
	private GameObject m_AlbumTitleObj;

	[SerializeField]
	[Token(Token = "0x4002EE7")]
	[FieldOffset(Offset = "0x220")]
	private LongSongNameController m_AlbumTitleTxt;

	[SerializeField]
	[Token(Token = "0x4002EE8")]
	[FieldOffset(Offset = "0x228")]
	private Button m_BtnOwn;

	[SerializeField]
	[Token(Token = "0x4002EE9")]
	[FieldOffset(Offset = "0x230")]
	private Assets.Scripts.UI.Panels.PnlMusicTag.PnlMusicTag m_PnlMusicTag;

	[Token(Token = "0x4002EEA")]
	private static bool s_StaticInited;

	[Token(Token = "0x4002EEB")]
	[FieldOffset(Offset = "0x238")]
	private bool m_InvokePreparation;

	[Token(Token = "0x4002EEC")]
	[FieldOffset(Offset = "0x240")]
	public EnableDisableHooker stageUiHook;

	[FieldOffset(Offset = "0x248")]
	[SerializeField]
	[Token(Token = "0x4002EED")]
	private FoolishAdvertiseGenerator m_AdvertiseGenerator;

	[Token(Token = "0x4002EEE")]
	private static bool s_AbilityDirty;

	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4002EEF")]
	private bool m_IsRandom;

	[Token(Token = "0x4002EF0")]
	[FieldOffset(Offset = "0x251")]
	private bool m_IsHideToNoMusic;

	[Token(Token = "0x1700089E")]
	private bool isCollection
	{
		[Address(RVA = "0x6521F0", Offset = "0x6509F0", Length = "0xBD")]
		[Token(Token = "0x6004FFF")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004FFE")]
	[Address(RVA = "0x64B280", Offset = "0x649A80", Length = "0x1B8")]
	private void InitDiffUIItemData()
	{
	}

	[Address(RVA = "0x64E0E0", Offset = "0x64C8E0", Length = "0x184")]
	[Token(Token = "0x6005000")]
	private void PlayCurrentSelectedMusicIfNeed()
	{
	}

	[Address(RVA = "0x650DC0", Offset = "0x64F5C0", Length = "0x32")]
	[Token(Token = "0x6005001")]
	public void SetInvokePreparation(bool value)
	{
	}

	[Token(Token = "0x6005002")]
	[Address(RVA = "0x64E970", Offset = "0x64D170", Length = "0x8FF")]
	public void PreWarm(int slice)
	{
	}

	[Address(RVA = "0x64CB60", Offset = "0x64B360", Length = "0x6E6")]
	[Token(Token = "0x6005003")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6005004")]
	[Address(RVA = "0x64C900", Offset = "0x64B100", Length = "0x1CE")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6005005")]
	[Address(RVA = "0x650B90", Offset = "0x64F390", Length = "0x57")]
	private static void SetDirty()
	{
	}

	[Token(Token = "0x6005006")]
	[Address(RVA = "0x64B900", Offset = "0x64A100", Length = "0x62")]
	private void OnBtnOwnClicked()
	{
	}

	[Token(Token = "0x6005007")]
	[Address(RVA = "0x64FAB0", Offset = "0x64E2B0", Length = "0x7D")]
	private void RefreshStageUI()
	{
	}

	[Token(Token = "0x6005008")]
	[Address(RVA = "0x6515C0", Offset = "0x64FDC0", Length = "0x8")]
	private void StageUiDisableHook(GameObject go, bool active)
	{
	}

	[Token(Token = "0x6005009")]
	[Address(RVA = "0x64D6A0", Offset = "0x64BEA0", Length = "0x21")]
	private void OnMusicFsvPlayValueChanged(float value)
	{
	}

	[Address(RVA = "0x649920", Offset = "0x648120", Length = "0x276")]
	[Token(Token = "0x600500A")]
	public void Awake()
	{
	}

	[Token(Token = "0x600500B")]
	[Address(RVA = "0x64C670", Offset = "0x64AE70", Length = "0x28C")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x600500C")]
	[Address(RVA = "0x651310", Offset = "0x64FB10", Length = "0x143")]
	private void ShowPnlStage()
	{
	}

	[Token(Token = "0x600500D")]
	[Address(RVA = "0x6515D0", Offset = "0x64FDD0", Length = "0x2BF")]
	public override void Start()
	{
	}

	[Token(Token = "0x600500E")]
	[Address(RVA = "0x64B440", Offset = "0x649C40", Length = "0x151")]
	private void InitTglLike()
	{
	}

	[Token(Token = "0x600500F")]
	[Address(RVA = "0x64D6D0", Offset = "0x64BED0", Length = "0x294")]
	private void OnRemoveCollection(MusicInfo musicInfo)
	{
	}

	[Token(Token = "0x6005010")]
	[Address(RVA = "0x64B890", Offset = "0x64A090", Length = "0x60")]
	private void OnAddCollection(MusicInfo musicInfo)
	{
	}

	[Token(Token = "0x6005011")]
	[Address(RVA = "0x64D250", Offset = "0x64BA50", Length = "0x368")]
	private void OnHideMusic(MusicInfo musicInfo)
	{
	}

	[Token(Token = "0x6005012")]
	[Address(RVA = "0x64D970", Offset = "0x64C170", Length = "0x315")]
	private void OnRemoveHideMusic(MusicInfo musicInfo)
	{
	}

	[Token(Token = "0x6005013")]
	[Address(RVA = "0x64B890", Offset = "0x64A090", Length = "0x60")]
	private void SetPnlMusicTagDirty()
	{
	}

	[Address(RVA = "0x64AEA0", Offset = "0x6496A0", Length = "0x32A")]
	[Token(Token = "0x6005014")]
	private void HandlerInit()
	{
	}

	[Address(RVA = "0x64DDE0", Offset = "0x64C5E0", Length = "0xDB")]
	[Token(Token = "0x6005015")]
	private void OnTriggerHideBmsEvent()
	{
	}

	[Address(RVA = "0x64ACB0", Offset = "0x6494B0", Length = "0x146")]
	[Token(Token = "0x6005016")]
	private static void DirtyHandler()
	{
	}

	[Token(Token = "0x6005017")]
	[Address(RVA = "0x651460", Offset = "0x64FC60", Length = "0x156")]
	private void ShowWeekFreeToDlcHandler()
	{
	}

	[Token(Token = "0x6005018")]
	[Address(RVA = "0x64AB20", Offset = "0x649320", Length = "0xE7")]
	public void CheckFirstOpenHideVersion()
	{
	}

	[Address(RVA = "0x64B970", Offset = "0x64A170", Length = "0x8E3")]
	[Token(Token = "0x6005019")]
	private void OnBtnPlayClicked()
	{
	}

	[Address(RVA = "0x64AC10", Offset = "0x649410", Length = "0x9C")]
	[Token(Token = "0x600501A")]
	private bool CheckIsAlbumTimeout(string uid)
	{
		return default(bool);
	}

	[Address(RVA = "0x652020", Offset = "0x650820", Length = "0x1AD")]
	[Token(Token = "0x600501B")]
	private bool VipTimeoutCheck(MusicInfo musicInfo, DBConfigAlbums.AlbumsInfo albumInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x600501C")]
	[Address(RVA = "0x651890", Offset = "0x650090", Length = "0x32D")]
	private void SwitchToAlbum1()
	{
	}

	[Address(RVA = "0x64D5D0", Offset = "0x64BDD0", Length = "0x7")]
	[Token(Token = "0x600501D")]
	private void OnLanguageChanged(int languageIndex)
	{
	}

	[Token(Token = "0x600501E")]
	[Address(RVA = "0x64FB30", Offset = "0x64E330", Length = "0x701")]
	private void RefreshTagTitle()
	{
	}

	[Token(Token = "0x600501F")]
	[Address(RVA = "0x64F6F0", Offset = "0x64DEF0", Length = "0x3B6")]
	private void RefreshMusicFSV()
	{
	}

	[Token(Token = "0x6005020")]
	[Address(RVA = "0x6502B0", Offset = "0x64EAB0", Length = "0x6A1")]
	private void SelectAllTagAndJumpToAssginIndex(string uid)
	{
	}

	[Token(Token = "0x6005021")]
	[Address(RVA = "0x64E2F0", Offset = "0x64CAF0", Length = "0x2EF")]
	private void PlayMusic()
	{
	}

	[Token(Token = "0x6005022")]
	[Address(RVA = "0x64F540", Offset = "0x64DD40", Length = "0x1A0")]
	private void RefreshDisplayMusic()
	{
	}

	[Token(Token = "0x6005023")]
	[Address(RVA = "0x64B1D0", Offset = "0x6499D0", Length = "0xA2")]
	private string HideSoundLogic(string uid, string musicName)
	{
		return null;
	}

	[Address(RVA = "0x64DEC0", Offset = "0x64C6C0", Length = "0x165")]
	[Token(Token = "0x6005024")]
	private void OnUnlockStage(string unlockMusicUid)
	{
	}

	[Token(Token = "0x6005025")]
	[Address(RVA = "0x64DC90", Offset = "0x64C490", Length = "0x146")]
	private void OnSpecialSongUnlock(string musicUid)
	{
	}

	[Token(Token = "0x6005026")]
	[Address(RVA = "0x651DA0", Offset = "0x6505A0", Length = "0x62")]
	private void UnlockAnchorModePlayMusic(object sender, object reciever, params object[] args)
	{
	}

	[Address(RVA = "0x64E5E0", Offset = "0x64CDE0", Length = "0x172")]
	[Token(Token = "0x6005027")]
	private void PlayRandomMusic()
	{
	}

	[Token(Token = "0x6005028")]
	[Address(RVA = "0x64E760", Offset = "0x64CF60", Length = "0xA8")]
	private void PlayStageAnimator(string name, float normalize = 0f)
	{
	}

	[Token(Token = "0x6005029")]
	[Address(RVA = "0x64E030", Offset = "0x64C830", Length = "0xA1")]
	private void PlayAlbumSwitchAnim(bool isFadeIn)
	{
	}

	[Token(Token = "0x600502A")]
	[Address(RVA = "0x64AE30", Offset = "0x649630", Length = "0x6B")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x56320", Offset = "0x55720")]
	private IEnumerator EnableAndPlayMusic1SecLater()
	{
		return null;
	}

	[Token(Token = "0x600502B")]
	[Address(RVA = "0x64AE00", Offset = "0x649600", Length = "0x26")]
	private void DisableBtnPlayWhenDynamic(Assets.Scripts.PeroTools.Nice.Components.FancyScrollView.State state)
	{
	}

	[Token(Token = "0x600502C")]
	[Address(RVA = "0x649BA0", Offset = "0x6483A0", Length = "0x447")]
	private void ChangeFinalMusic(int i)
	{
	}

	[Token(Token = "0x600502D")]
	[Address(RVA = "0x64E810", Offset = "0x64D010", Length = "0x150")]
	private void PnlStageCheckMusicValid(int i)
	{
	}

	[Address(RVA = "0x650E00", Offset = "0x64F600", Length = "0x99")]
	[Token(Token = "0x600502E")]
	private void SetLikeAchiEmpty(bool isEmpty)
	{
	}

	[Address(RVA = "0x650EA0", Offset = "0x64F6A0", Length = "0x21")]
	[Token(Token = "0x600502F")]
	private void SetLikeAndHideTglState(MusicInfo musicInfo, bool isUnlock)
	{
	}

	[Address(RVA = "0x649FF0", Offset = "0x6487F0", Length = "0xB26")]
	[Token(Token = "0x6005030")]
	private void ChangeMusic(int i)
	{
	}

	[Address(RVA = "0x64F2A0", Offset = "0x64DAA0", Length = "0x29C")]
	[Token(Token = "0x6005031")]
	private void RefreshDiffUI(MusicInfo musicInfo)
	{
	}

	[Address(RVA = "0x64F270", Offset = "0x64DA70", Length = "0x21")]
	[Token(Token = "0x6005032")]
	private void RefreshBg(MusicInfo musicInfo, bool hideText = false)
	{
	}

	[Token(Token = "0x6005033")]
	[Address(RVA = "0x650960", Offset = "0x64F160", Length = "0x22E")]
	private void SetAchievementPercent(MusicInfo musicInfo)
	{
	}

	[Token(Token = "0x6005034")]
	[Address(RVA = "0x64B5A0", Offset = "0x649DA0", Length = "0x12D")]
	private bool IsContainOffPlan(MusicInfo musicInfo)
	{
		return default(bool);
	}

	[Address(RVA = "0x64B6D0", Offset = "0x649ED0", Length = "0x1BA")]
	[Token(Token = "0x6005035")]
	private void LockMusic()
	{
	}

	[Token(Token = "0x6005036")]
	[Address(RVA = "0x651E10", Offset = "0x650610", Length = "0x186")]
	private void UnlockMusic()
	{
	}

	[Token(Token = "0x6005037")]
	[Address(RVA = "0x650240", Offset = "0x64EA40", Length = "0x7")]
	private void ReplayMusicWhenFormPnlMenuToPnlStage()
	{
	}

	[Token(Token = "0x6005038")]
	[Address(RVA = "0x650ED0", Offset = "0x64F6D0", Length = "0x233")]
	private void SetPnlNoMusicEnable(bool enable)
	{
	}

	[Token(Token = "0x6005039")]
	[Address(RVA = "0x651FA0", Offset = "0x6507A0", Length = "0x70")]
	private new void Update()
	{
	}

	[Token(Token = "0x600503A")]
	[Address(RVA = "0x650BF0", Offset = "0x64F3F0", Length = "0x1C0")]
	private void SetHideDifficulty()
	{
	}

	[Address(RVA = "0x64D5C0", Offset = "0x64BDC0", Length = "0x7")]
	[Token(Token = "0x600503B")]
	private void OnInvokeLongPressHideBms(object sender, object reciever, params object[] args)
	{
	}

	[Token(Token = "0x600503C")]
	[Address(RVA = "0x64D5E0", Offset = "0x64BDE0", Length = "0x59")]
	private void OnMusicDragBegin()
	{
	}

	[Token(Token = "0x600503D")]
	[Address(RVA = "0x64D640", Offset = "0x64BE40", Length = "0x59")]
	private void OnMusicDragEnd()
	{
	}

	[Address(RVA = "0x64E270", Offset = "0x64CA70", Length = "0x7C")]
	[Token(Token = "0x600503E")]
	private void PlayMusicDragAnimator(bool isIn, float normalize = 0f)
	{
	}

	[Address(RVA = "0x650250", Offset = "0x64EA50", Length = "0x5E")]
	[Token(Token = "0x600503F")]
	private void ResetMusicDragAnim()
	{
	}

	[Address(RVA = "0x64C260", Offset = "0x64AA60", Length = "0x177")]
	[Token(Token = "0x6005040")]
	public void OnClickMusicTagOkBtn(object sender, object reciever, params object[] args)
	{
	}

	[Address(RVA = "0x64CAD0", Offset = "0x64B2D0", Length = "0x8F")]
	[Token(Token = "0x6005041")]
	public void OnDontShowAnchorBanValueChanged(object sender, object reciever, params object[] args)
	{
	}

	[Address(RVA = "0x64C3E0", Offset = "0x64ABE0", Length = "0x28E")]
	[Token(Token = "0x6005042")]
	public void OnClickPreviewFromPnlMusicTag(object sender, object reciever, params object[] args)
	{
	}

	[Address(RVA = "0x651110", Offset = "0x64F910", Length = "0x1F0")]
	[Token(Token = "0x6005043")]
	public override void SetProperty(float propertyValue)
	{
	}

	[Token(Token = "0x6005044")]
	[Address(RVA = "0x6521D0", Offset = "0x6509D0", Length = "0x18")]
	public PnlStage()
	{
	}
}
