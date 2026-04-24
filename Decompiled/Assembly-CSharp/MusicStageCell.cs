using Assets.Scripts.PeroTools.Nice.Events;
using Assets.Scripts.PeroTools.Nice.Variables;
using Assets.Scripts.UI.PnlMusicStage.MusicPromotion;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000EB")]
public class MusicStageCell : MonoBehaviour
{
	[Token(Token = "0x2000A03")]
	public struct MusicStageCellInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40035B9")]
		internal int cellIndex;

		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40035BA")]
		internal string musicUid;

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40035BB")]
		internal int albumJsonIndex;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40035BC")]
		internal string musicName;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40035BD")]
		internal string coverName;

		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40035BE")]
		internal int unlockLevel;

		[Token(Token = "0x40035BF")]
		[FieldOffset(Offset = "0x2C")]
		internal bool uidIsRandom;
	}

	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005E0")]
	private OnFancyScrollViewCellUpdate m_OnFancyScrollViewCellUpdate;

	[SerializeField]
	[Token(Token = "0x40005E1")]
	[FieldOffset(Offset = "0x20")]
	private VariableBehaviour m_VariableBehaviour;

	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40005E2")]
	private Image m_StageImg;

	[Token(Token = "0x40005E3")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Image m_LockedBgImg;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005E4")]
	[SerializeField]
	private UnityEngine.UI.Text m_LockTxt;

	[Token(Token = "0x40005E5")]
	private static readonly int[] s_BaseAlbumUids;

	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xD9E0", Offset = "0xCDE0")]
	[Token(Token = "0x40005E6")]
	[SerializeField]
	private GameObject m_LockObj;

	[SerializeField]
	[Token(Token = "0x40005E7")]
	[FieldOffset(Offset = "0x48")]
	private Button m_BtnNeedDownload;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40005E8")]
	[SerializeField]
	private GameObject m_WeekFreeImg;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40005E9")]
	private GameObject m_DiscoMelodyObj;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40005EA")]
	private Sprite m_PreviousCoverCache;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40005EB")]
	[SerializeField]
	private MusicStageCellPromotion m_MusicPromotion;

	[Token(Token = "0x60006D8")]
	[Address(RVA = "0x8C6AE0", Offset = "0x8C52E0", Length = "0x3B")]
	public Color GetStageImgColor()
	{
		return default(Color);
	}

	[Token(Token = "0x60006D9")]
	[Address(RVA = "0x8C6470", Offset = "0x8C4C70", Length = "0xC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006DA")]
	[Address(RVA = "0x8C73D0", Offset = "0x8C5BD0", Length = "0x192")]
	private void Start()
	{
	}

	[Token(Token = "0x60006DB")]
	[Address(RVA = "0x8C6470", Offset = "0x8C4C70", Length = "0xC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60006DC")]
	[Address(RVA = "0x8C6D50", Offset = "0x8C5550", Length = "0x192")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60006DD")]
	[Address(RVA = "0x8C73D0", Offset = "0x8C5BD0", Length = "0x192")]
	private void RegisterEvent()
	{
	}

	[Address(RVA = "0x8C6D50", Offset = "0x8C5550", Length = "0x192")]
	[Token(Token = "0x60006DE")]
	private void UnregisterEvent()
	{
	}

	[Address(RVA = "0x8C6470", Offset = "0x8C4C70", Length = "0xC")]
	[Token(Token = "0x60006DF")]
	private void OnRefreshData(object sender, object reciever, params object[] args)
	{
	}

	[Address(RVA = "0x8C6470", Offset = "0x8C4C70", Length = "0xC")]
	[Token(Token = "0x60006E0")]
	private void ForceRefreshData()
	{
	}

	[Address(RVA = "0x8C6F60", Offset = "0x8C5760", Length = "0x461")]
	[Token(Token = "0x60006E1")]
	private void RefreshData(int targetCellIndex)
	{
	}

	[Address(RVA = "0x8C6970", Offset = "0x8C5170", Length = "0x164")]
	[Token(Token = "0x60006E2")]
	private MusicStageCellInfo GetMusicStageCellInfo(int cellIndex)
	{
		return default(MusicStageCellInfo);
	}

	[Token(Token = "0x60006E3")]
	[Address(RVA = "0x8C7570", Offset = "0x8C5D70", Length = "0x439")]
	private void SetCoverLogic(MusicStageCellInfo cellInfo)
	{
	}

	[Address(RVA = "0x8C6B20", Offset = "0x8C5320", Length = "0x22E")]
	[Token(Token = "0x60006E4")]
	private void IconLogic(MusicStageCellInfo cellInfo)
	{
	}

	[Token(Token = "0x60006E5")]
	[Address(RVA = "0x8C7B20", Offset = "0x8C6320", Length = "0x7E")]
	private bool WeekFreeLogic(MusicStageCellInfo cellInfo)
	{
		return default(bool);
	}

	[Address(RVA = "0x8C6800", Offset = "0x8C5000", Length = "0x16D")]
	[Token(Token = "0x60006E6")]
	private bool DownloadCheckLogic(MusicStageCellInfo cellInfo)
	{
		return default(bool);
	}

	[Address(RVA = "0x8C6700", Offset = "0x8C4F00", Length = "0xF3")]
	[Token(Token = "0x60006E7")]
	private void BasicAlbumLockLogic(MusicStageCellInfo cellInfo)
	{
	}

	[Token(Token = "0x60006E8")]
	[Address(RVA = "0x8C6480", Offset = "0x8C4C80", Length = "0x277")]
	private void BasicAlbumLevelLockSet(int musicUnlockLevel)
	{
	}

	[Token(Token = "0x60006E9")]
	[Address(RVA = "0x8C79B0", Offset = "0x8C61B0", Length = "0x16D")]
	private void SpecialSongLockSet(MusicStageCellInfo cellInfo)
	{
	}

	[Address(RVA = "0x8C6EF0", Offset = "0x8C56F0", Length = "0x64")]
	[Token(Token = "0x60006EA")]
	private void OnNeedDownloadClick()
	{
	}

	[Token(Token = "0x60006EB")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public MusicStageCell()
	{
	}
}
