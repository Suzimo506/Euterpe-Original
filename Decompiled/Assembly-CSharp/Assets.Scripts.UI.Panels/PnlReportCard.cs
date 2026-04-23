using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using DaveGameFramework.GameInstanceData;
using MEC;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008F2")]
public class PnlReportCard : BaseMessageBox
{
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4002FAD")]
	public Image imgElfin;

	[Token(Token = "0x4002FAE")]
	[FieldOffset(Offset = "0xF8")]
	public Image imgCharacter;

	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4002FAF")]
	public Image imgBg;

	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4002FB0")]
	public Text txtPlayerName;

	[Token(Token = "0x4002FB1")]
	[FieldOffset(Offset = "0x110")]
	public Text txtPlayerLevel;

	[Token(Token = "0x4002FB2")]
	[FieldOffset(Offset = "0x118")]
	public Image imgPlayerHead;

	[Token(Token = "0x4002FB3")]
	[FieldOffset(Offset = "0x120")]
	public Image imgS;

	[Token(Token = "0x4002FB4")]
	[FieldOffset(Offset = "0x128")]
	public HorizontalLayoutGroup horizontalImgs;

	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4002FB5")]
	public GameObject imgTips;

	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4002FB6")]
	public Image imgFc;

	[Token(Token = "0x4002FB7")]
	[FieldOffset(Offset = "0x140")]
	public GameObject objTglShowRank;

	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4002FB8")]
	public GameObject objRankParentRoot;

	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4002FB9")]
	public GameObject objRankItemNormal;

	[Token(Token = "0x4002FBA")]
	[FieldOffset(Offset = "0x158")]
	public GameObject objRankItemLong;

	[Token(Token = "0x4002FBB")]
	[FieldOffset(Offset = "0x160")]
	public GameObject objTotalPassCount;

	[Token(Token = "0x4002FBC")]
	[FieldOffset(Offset = "0x168")]
	public GameObject objPlaceHolder;

	[Token(Token = "0x4002FBD")]
	[FieldOffset(Offset = "0x170")]
	public GameObject objBestRecord;

	[Token(Token = "0x4002FBE")]
	[FieldOffset(Offset = "0x178")]
	public Image imgCover;

	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4002FBF")]
	public LongSongNameController longSongNameController;

	[Token(Token = "0x4002FC0")]
	[FieldOffset(Offset = "0x188")]
	public LongSongNameController longAuthorNameController;

	[Token(Token = "0x4002FC1")]
	[FieldOffset(Offset = "0x190")]
	public List<GameObject> starObjs;

	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4002FC2")]
	public List<Text> starTxtValues;

	[Token(Token = "0x4002FC3")]
	[FieldOffset(Offset = "0x1A0")]
	public Text txtRankNumNormal;

	[Token(Token = "0x4002FC4")]
	[FieldOffset(Offset = "0x1A8")]
	public Text txtRankNumLong;

	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4002FC5")]
	public Text txtTotalPassCountValue;

	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4002FC6")]
	public Text txtScrore;

	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4002FC7")]
	public Text txtAccuracy;

	[Token(Token = "0x4002FC8")]
	[FieldOffset(Offset = "0x1C8")]
	public Text txtCombo;

	[Token(Token = "0x4002FC9")]
	[SerializeField]
	[FieldOffset(Offset = "0x1D0")]
	public Dictionary<int, List<Graphic>> changeColors;

	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4002FCA")]
	private IData m_NewPassMusicData;

	[Token(Token = "0x4002FCB")]
	[FieldOffset(Offset = "0x1E0")]
	public Image imgBase;

	[Token(Token = "0x4002FCC")]
	[FieldOffset(Offset = "0x1E8")]
	public Image imgScreenShotBg;

	[Token(Token = "0x4002FCD")]
	[FieldOffset(Offset = "0x1F0")]
	public Image imgBgMask;

	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4002FCE")]
	public OutlineEx outlineEx;

	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4002FCF")]
	public ScreenShotSaver shotSaver;

	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4002FD0")]
	public Button btnChangeBg;

	[Token(Token = "0x4002FD1")]
	[FieldOffset(Offset = "0x210")]
	public Button btnSaveImg;

	[Token(Token = "0x4002FD2")]
	[FieldOffset(Offset = "0x218")]
	public Toggle tglShowRankMsg;

	[Token(Token = "0x4002FD3")]
	[FieldOffset(Offset = "0x220")]
	public Button btnShowRankMsg;

	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4002FD4")]
	public Button btnRefreshRankMsg;

	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4002FD5")]
	public Text txtShowRankMsg;

	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4002FD6")]
	public Text txtGetRankMsgFail;

	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4002FD7")]
	public RectTransform cardRoot;

	[Token(Token = "0x4002FD8")]
	[FieldOffset(Offset = "0x248")]
	public Vector3 scale4x3;

	[Token(Token = "0x4002FD9")]
	[FieldOffset(Offset = "0x258")]
	private List<ReportBackgroundInfo> m_UnlockBgDatas;

	[Token(Token = "0x4002FDA")]
	[FieldOffset(Offset = "0x260")]
	private bool m_ShowBestRecordInfo;

	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4002FDB")]
	private GlobalScriptableObjectData globalData;

	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4002FDC")]
	private int m_CurOrder;

	[Token(Token = "0x4002FDD")]
	[FieldOffset(Offset = "0x278")]
	private ScreenShotTextHandle[] m_AllScreenShotTextHandles;

	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4002FDE")]
	private List<RectTransform> m_AllHorizontalRects;

	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4002FDF")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x64130", Offset = "0x63530")]
	public Image imgBgShine;

	[Token(Token = "0x4002FE1")]
	[FieldOffset(Offset = "0x290")]
	private readonly List<string> m_UseAssignCharacterMusicUids;

	[Token(Token = "0x4002FE2")]
	[FieldOffset(Offset = "0x298")]
	private int m_MinOrder;

	[Token(Token = "0x4002FE3")]
	[FieldOffset(Offset = "0x29C")]
	private int m_MaxOrder;

	[Token(Token = "0x4002FE4")]
	[FieldOffset(Offset = "0x2A0")]
	private ResultRankData m_ResultRankData;

	[Token(Token = "0x4002FE5")]
	[FieldOffset(Offset = "0x2A8")]
	private CoroutineHandle m_StoreVersionRequestCoroutine;

	[Token(Token = "0x4002FE6")]
	[FieldOffset(Offset = "0x2AC")]
	private float timeout_duration;

	[Token(Token = "0x4002FE7")]
	private static Dictionary<string, Sprite> m_SpriteCache;

	[Token(Token = "0x4002FE8")]
	[FieldOffset(Offset = "0x2B0")]
	private List<ContentSizeFitter> contentSizeFitters;

	[Token(Token = "0x170008A7")]
	private GameObject objRankItem
	{
		[Token(Token = "0x600512A")]
		[Address(RVA = "0x68E1A0", Offset = "0x68C9A0", Length = "0xB4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008A8")]
	private Text txtRankNum
	{
		[Token(Token = "0x600512B")]
		[Address(RVA = "0x68E2B0", Offset = "0x68CAB0", Length = "0xB4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008A9")]
	private int selectedRecordBgIndex
	{
		[Address(RVA = "0x68E260", Offset = "0x68CA60", Length = "0x48")]
		[Token(Token = "0x600512C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170008AA")]
	public static string m_TempSelectChaImgName
	{
		[Address(RVA = "0x68E0E0", Offset = "0x68C8E0", Length = "0xB6")]
		[Token(Token = "0x600512D")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Address(RVA = "0x68E370", Offset = "0x68CB70", Length = "0x60")]
		[Token(Token = "0x600512E")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Address(RVA = "0x689C60", Offset = "0x688460", Length = "0x463")]
	[Token(Token = "0x600512F")]
	public override void AwakeInit()
	{
	}

	[Address(RVA = "0x68D710", Offset = "0x68BF10", Length = "0x20")]
	[Token(Token = "0x6005130")]
	private void ResetResultData()
	{
	}

	[Token(Token = "0x6005131")]
	[Address(RVA = "0x68D740", Offset = "0x68BF40", Length = "0xA0")]
	private void SaveTempUseCharacterVicImage(string img)
	{
	}

	[Address(RVA = "0x4C6650", Offset = "0x4C4E50", Length = "0x2B")]
	[Token(Token = "0x6005132")]
	protected override void OnNoClicked()
	{
	}

	[Address(RVA = "0x68B4B0", Offset = "0x689CB0", Length = "0x188")]
	[Token(Token = "0x6005133")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x68D990", Offset = "0x68C190", Length = "0x188")]
	[Token(Token = "0x6005134")]
	public override void Show(params object[] param)
	{
	}

	[Address(RVA = "0x68D7E0", Offset = "0x68BFE0", Length = "0x1A2")]
	[Token(Token = "0x6005135")]
	public void ShowCustomData(MusicInfo musicInfo, int selectDiff, DaveGameResultData resData)
	{
	}

	[Address(RVA = "0x68BB80", Offset = "0x68A380", Length = "0x3FB")]
	[Token(Token = "0x6005136")]
	private void RefreshCurRecord()
	{
	}

	[Address(RVA = "0x68AB40", Offset = "0x689340", Length = "0xD8")]
	[Token(Token = "0x6005137")]
	private bool IsCurScoreLessThenHighestScore()
	{
		return default(bool);
	}

	[Token(Token = "0x6005138")]
	[Address(RVA = "0x68D5B0", Offset = "0x68BDB0", Length = "0x151")]
	private void ResetRankUIByCurRankData()
	{
	}

	[Address(RVA = "0x68A910", Offset = "0x689110", Length = "0x81")]
	[Token(Token = "0x6005139")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x66370", Offset = "0x65770")]
	private IEnumerator<float> GetRankFromPeroServer(Action successCallback = null)
	{
		return null;
	}

	[Address(RVA = "0x68B6E0", Offset = "0x689EE0", Length = "0x321")]
	[Token(Token = "0x600513A")]
	private void RefreshBestRecord()
	{
	}

	[Address(RVA = "0x68A6B0", Offset = "0x688EB0", Length = "0x255")]
	[Token(Token = "0x600513B")]
	private IData GetCurHighestScoreData()
	{
		return null;
	}

	[Address(RVA = "0x68C820", Offset = "0x68B020", Length = "0x6DA")]
	[Token(Token = "0x600513C")]
	private void RefreshRecord(MusicInfo musicInfo, int selectDiff, int score, int combo, string accuracyStr, int evaluate, string totalPassCount = null, int order = -1)
	{
	}

	[Token(Token = "0x600513D")]
	[Address(RVA = "0x68A0D0", Offset = "0x6888D0", Length = "0xE4")]
	private void CheckSIsInMiddle()
	{
	}

	[Address(RVA = "0x68C490", Offset = "0x68AC90", Length = "0x387")]
	[Token(Token = "0x600513E")]
	private void RefreshRankUI(int order)
	{
	}

	[Token(Token = "0x600513F")]
	[Address(RVA = "0x68AAD0", Offset = "0x6892D0", Length = "0x6A")]
	private void InitUnlockBgDatas()
	{
	}

	[Token(Token = "0x6005140")]
	[Address(RVA = "0x68AC20", Offset = "0x689420", Length = "0x10B")]
	private bool IsCurSelectSongUseSpecialCharacter()
	{
		return default(bool);
	}

	[Token(Token = "0x6005141")]
	[Address(RVA = "0x68BF80", Offset = "0x68A780", Length = "0x503")]
	private void RefreshLeftArea(bool isVictory = false)
	{
	}

	[Address(RVA = "0x68BA10", Offset = "0x68A210", Length = "0x165")]
	[Token(Token = "0x6005142")]
	private void RefreshBgAndPlayerData()
	{
	}

	[Token(Token = "0x6005143")]
	[Address(RVA = "0x68CF00", Offset = "0x68B700", Length = "0x6AC")]
	private void ResetBg(int index)
	{
	}

	[Token(Token = "0x6005144")]
	[Address(RVA = "0x689B00", Offset = "0x688300", Length = "0x159")]
	private void AdaptScreen()
	{
	}

	[Token(Token = "0x6005145")]
	[Address(RVA = "0x68AEC0", Offset = "0x6896C0", Length = "0x25A")]
	private void OnClickSaveCardImg()
	{
	}

	[Address(RVA = "0x68DB20", Offset = "0x68C320", Length = "0xF8")]
	[Token(Token = "0x6005146")]
	private void StartScreenShot()
	{
	}

	[Address(RVA = "0x68A1C0", Offset = "0x6889C0", Length = "0x205")]
	[Token(Token = "0x6005147")]
	private void EndScreenShot()
	{
	}

	[Token(Token = "0x6005148")]
	[Address(RVA = "0x68AD30", Offset = "0x689530", Length = "0x14B")]
	private void OnClickChangeScheme()
	{
	}

	[Token(Token = "0x6005149")]
	[Address(RVA = "0x68B120", Offset = "0x689920", Length = "0xA3")]
	private void OnClickTglShowRankMsg()
	{
	}

	[Token(Token = "0x600514A")]
	[Address(RVA = "0x68AE80", Offset = "0x689680", Length = "0x30")]
	private void OnClickRefreshRankMsg()
	{
	}

	[Address(RVA = "0x68B450", Offset = "0x689C50", Length = "0x54")]
	[Token(Token = "0x600514B")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600514C")]
	[Address(RVA = "0x68A9A0", Offset = "0x6891A0", Length = "0x125")]
	public static Sprite GetSprite(string key)
	{
		return null;
	}

	[Token(Token = "0x600514D")]
	[Address(RVA = "0x68B1D0", Offset = "0x6899D0", Length = "0x275")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600514E")]
	[Address(RVA = "0x68A3D0", Offset = "0x688BD0", Length = "0x2DA")]
	private void FindContentSizeFitters(Transform parent)
	{
	}

	[Address(RVA = "0x68B640", Offset = "0x689E40", Length = "0x95")]
	[Token(Token = "0x600514F")]
	private void RefreshAllContentSizeFittersAndHorizontal()
	{
	}

	[Address(RVA = "0x68DF20", Offset = "0x68C720", Length = "0x1B4")]
	[Token(Token = "0x6005150")]
	public PnlReportCard()
	{
	}
}
