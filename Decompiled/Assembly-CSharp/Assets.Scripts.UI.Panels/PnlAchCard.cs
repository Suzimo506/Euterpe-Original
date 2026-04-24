using System.Collections.Generic;
using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.Nice.Interface;
using Assets.Scripts.UI.Panels.PnlDLC;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008EE")]
public class PnlAchCard : BaseMessageBox
{
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4002F77")]
	public Image imgElfin;

	[Token(Token = "0x4002F78")]
	[FieldOffset(Offset = "0xF8")]
	public Image imgCharacter;

	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4002F79")]
	public Image imgBg;

	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4002F7A")]
	public Image imgBgUI;

	[Token(Token = "0x4002F7B")]
	[FieldOffset(Offset = "0x110")]
	public Text txtNumEasy;

	[Token(Token = "0x4002F7C")]
	[FieldOffset(Offset = "0x118")]
	public Text txtNumHard;

	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4002F7D")]
	public Text txtNumMaster;

	[Token(Token = "0x4002F7E")]
	[FieldOffset(Offset = "0x128")]
	public Text txtNumFC;

	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4002F7F")]
	public Text txtRedS;

	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4002F80")]
	public Text txtNumSilverS;

	[Token(Token = "0x4002F81")]
	[FieldOffset(Offset = "0x140")]
	public Text txtNumGoldS;

	[Attribute(Name = "TooltipAttribute", RVA = "0x63D50", Offset = "0x63150")]
	[Token(Token = "0x4002F82")]
	[FieldOffset(Offset = "0x148")]
	public GameObject NewPassMusicCellRootUp;

	[Attribute(Name = "TooltipAttribute", RVA = "0x63D50", Offset = "0x63150")]
	[Token(Token = "0x4002F83")]
	[FieldOffset(Offset = "0x150")]
	public GameObject NewPassMusicCellRootDown;

	[Attribute(Name = "TooltipAttribute", RVA = "0x63D50", Offset = "0x63150")]
	[Token(Token = "0x4002F84")]
	[FieldOffset(Offset = "0x158")]
	public GameObject NewFavoriteCharacterCellRoot;

	[Token(Token = "0x4002F85")]
	[FieldOffset(Offset = "0x160")]
	public List<NewPassMusicCell> newPassMusicCells;

	[Token(Token = "0x4002F86")]
	[FieldOffset(Offset = "0x168")]
	public List<NewFavoriteCharacterCell> newFavoriteCharacterCells;

	[Token(Token = "0x4002F87")]
	[FieldOffset(Offset = "0x170")]
	private List<IData> m_NewPassMusicDatas;

	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x4002F88")]
	private List<(string, int)> m_NewFavoriteCharacterDatas;

	[Token(Token = "0x4002F89")]
	[FieldOffset(Offset = "0x180")]
	public Text txtPlayerName;

	[Token(Token = "0x4002F8A")]
	[FieldOffset(Offset = "0x188")]
	public Text txtPlayerLevel;

	[Token(Token = "0x4002F8B")]
	[FieldOffset(Offset = "0x190")]
	public Image imgPlayerHead;

	[Token(Token = "0x4002F8C")]
	[FieldOffset(Offset = "0x198")]
	public Image imgStickerTop;

	[Token(Token = "0x4002F8D")]
	[FieldOffset(Offset = "0x1A0")]
	public Image imgStikerDown;

	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4002F8E")]
	private Vector2 originPosImgStickerTop;

	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4002F8F")]
	private Vector2 originPosImgStickerDown;

	[Token(Token = "0x4002F90")]
	[FieldOffset(Offset = "0x1B8")]
	private Vector2 tempVector2;

	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4002F91")]
	public ScreenShotSaver shotSaver;

	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4002F92")]
	public Button btnChangeBg;

	[Token(Token = "0x4002F93")]
	[FieldOffset(Offset = "0x1D0")]
	public Button btnChangeSticker;

	[Token(Token = "0x4002F94")]
	[FieldOffset(Offset = "0x1D8")]
	public Button btnSaveImg;

	[Token(Token = "0x4002F95")]
	[FieldOffset(Offset = "0x1E0")]
	public Button btnChangeBg4x3;

	[Token(Token = "0x4002F96")]
	[FieldOffset(Offset = "0x1E8")]
	public Button btnChangeSticker4x3;

	[Token(Token = "0x4002F97")]
	[FieldOffset(Offset = "0x1F0")]
	public Button btnSaveImg4x3;

	[Token(Token = "0x4002F98")]
	[FieldOffset(Offset = "0x1F8")]
	private List<StageBackgroundData> m_UnlockBgDatas;

	[Token(Token = "0x4002F99")]
	[FieldOffset(Offset = "0x200")]
	private List<StickerInfo> m_UnlockStickerInfo;

	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4002F9A")]
	public Image imgBase;

	[Token(Token = "0x4002F9B")]
	[FieldOffset(Offset = "0x210")]
	public Image imgScreenShotBg;

	[Token(Token = "0x4002F9C")]
	[FieldOffset(Offset = "0x218")]
	public OutlineEx outlineEx;

	[Token(Token = "0x4002F9D")]
	[FieldOffset(Offset = "0x220")]
	public Vector3 scale4x3;

	[Token(Token = "0x4002F9E")]
	[FieldOffset(Offset = "0x230")]
	public GameObject rootBtn4x3;

	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4002F9F")]
	public GameObject rootBtnNormal;

	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4002FA0")]
	public RectTransform cardRoot;

	[Token(Token = "0x4002FA1")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x64130", Offset = "0x63530")]
	[FieldOffset(Offset = "0x248")]
	public Image imgBgShine;

	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4002FA2")]
	private List<RectTransform> m_AllHorizontalRects;

	[SerializeField]
	[Token(Token = "0x4002FA3")]
	[FieldOffset(Offset = "0x258")]
	private List<IGradientItem> m_GradientListForBg;

	[Token(Token = "0x4002FA4")]
	private static Dictionary<string, Sprite> m_SpriteCache;

	[Address(RVA = "0x6C4C70", Offset = "0x6C3470", Length = "0x645")]
	[Token(Token = "0x60050F8")]
	public override void AwakeInit()
	{
	}

	[Address(RVA = "0x4C6650", Offset = "0x4C4E50", Length = "0x2B")]
	[Token(Token = "0x60050F9")]
	protected override void OnNoClicked()
	{
	}

	[Address(RVA = "0x6C7590", Offset = "0x6C5D90", Length = "0xFB")]
	[Token(Token = "0x60050FA")]
	public override void Show()
	{
	}

	[Address(RVA = "0x6C6050", Offset = "0x6C4850", Length = "0x1C1")]
	[Token(Token = "0x60050FB")]
	private void RefreshHorizontals()
	{
	}

	[Address(RVA = "0x6C52C0", Offset = "0x6C3AC0", Length = "0x9A")]
	[Token(Token = "0x60050FC")]
	private void CheckChangeBgBtnShow()
	{
	}

	[Address(RVA = "0x6C4AA0", Offset = "0x6C32A0", Length = "0x1CD")]
	[Token(Token = "0x60050FD")]
	private void AdaptScreen()
	{
	}

	[Token(Token = "0x60050FE")]
	[Address(RVA = "0x6C6220", Offset = "0x6C4A20", Length = "0x32E")]
	private void RefreshLeftArea()
	{
	}

	[Token(Token = "0x60050FF")]
	[Address(RVA = "0x6C5BE0", Offset = "0x6C43E0", Length = "0x25D")]
	private void RefreshBgAndPlayerData()
	{
	}

	[Address(RVA = "0x6C5E40", Offset = "0x6C4640", Length = "0x20F")]
	[Token(Token = "0x6005100")]
	private void RefreshCurSelectedSticker()
	{
	}

	[Token(Token = "0x6005101")]
	[Address(RVA = "0x6C6700", Offset = "0x6C4F00", Length = "0x24A")]
	private void RefreshLevelPassStatistic()
	{
	}

	[Token(Token = "0x6005102")]
	[Address(RVA = "0x6C6550", Offset = "0x6C4D50", Length = "0x1A6")]
	private void RefreshLevelEvaluteUI()
	{
	}

	[Token(Token = "0x6005103")]
	[Address(RVA = "0x6C6BC0", Offset = "0x6C53C0", Length = "0x398")]
	private void RefreshNewPassRecord()
	{
	}

	[Token(Token = "0x6005104")]
	[Address(RVA = "0x6C6950", Offset = "0x6C5150", Length = "0x264")]
	private void RefreshNewFavoriteCharacterDatas()
	{
	}

	[Token(Token = "0x6005105")]
	[Address(RVA = "0x6C5510", Offset = "0x6C3D10", Length = "0x15C")]
	private void OnClickChangeToNextStageBg()
	{
	}

	[Address(RVA = "0x6C7430", Offset = "0x6C5C30", Length = "0x15C")]
	[Token(Token = "0x6005106")]
	private void ResetUnlockBgDatas()
	{
	}

	[Address(RVA = "0x6C6F60", Offset = "0x6C5760", Length = "0x1C3")]
	[Token(Token = "0x6005107")]
	private void ResetBgScheme(StageBackgroundData data)
	{
	}

	[Address(RVA = "0x6C5670", Offset = "0x6C3E70", Length = "0x20D")]
	[Token(Token = "0x6005108")]
	private void OnClickChangeToNextSticker()
	{
	}

	[Address(RVA = "0x6C7130", Offset = "0x6C5930", Length = "0x2FA")]
	[Token(Token = "0x6005109")]
	private void ResetStickerImg(int stickerIndex)
	{
	}

	[Address(RVA = "0x6C58D0", Offset = "0x6C40D0", Length = "0x108")]
	[Token(Token = "0x600510A")]
	private void OnClickSaveCardImg()
	{
	}

	[Token(Token = "0x600510B")]
	[Address(RVA = "0x6C7690", Offset = "0x6C5E90", Length = "0x7A")]
	private void StartScreenShot()
	{
	}

	[Token(Token = "0x600510C")]
	[Address(RVA = "0x6C5360", Offset = "0x6C3B60", Length = "0x7A")]
	private void EndScreenShot()
	{
	}

	[Token(Token = "0x600510D")]
	[Address(RVA = "0x6C5880", Offset = "0x6C4080", Length = "0x48")]
	private void OnClickPlayButtonMusic()
	{
	}

	[Address(RVA = "0x6C5B90", Offset = "0x6C4390", Length = "0x43")]
	[Token(Token = "0x600510E")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600510F")]
	[Address(RVA = "0x6C53E0", Offset = "0x6C3BE0", Length = "0x123")]
	public static Sprite GetSprite(string key)
	{
		return null;
	}

	[Token(Token = "0x6005110")]
	[Address(RVA = "0x6C59E0", Offset = "0x6C41E0", Length = "0x1A0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6005111")]
	[Address(RVA = "0x6C78D0", Offset = "0x6C60D0", Length = "0x15C")]
	public PnlAchCard()
	{
	}
}
