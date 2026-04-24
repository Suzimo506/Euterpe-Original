using System.Text;
using Assets.Scripts.PeroTools.Nice.Components;
using Assets.Scripts.PeroTools.PreWarm;
using Assets.Scripts.UI.Panels;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200012C")]
public class PnlPreparation : MonoBehaviour, IPreWarm
{
	[Token(Token = "0x4000758")]
	[FieldOffset(Offset = "0x18")]
	public Text stageAchievementValue;

	[Token(Token = "0x4000759")]
	[FieldOffset(Offset = "0x20")]
	public Button startButton;

	[Token(Token = "0x400075A")]
	[FieldOffset(Offset = "0x28")]
	public Button btnDownloadReport;

	[Token(Token = "0x400075B")]
	[FieldOffset(Offset = "0x30")]
	public PnlRank[] pnlRanks;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400075C")]
	public ButtonToggle buttonToggle;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400075D")]
	public PnlRecord pnlRecord;

	[Token(Token = "0x400075E")]
	[FieldOffset(Offset = "0x48")]
	public PnlPreparationLayAchv pnlPreparationLayAchv;

	[Token(Token = "0x400075F")]
	[FieldOffset(Offset = "0x50")]
	private PopupPresetConfigSelect m_ConfigSelect;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000760")]
	private ScreenCDrawingDetector m_TanocHideBmsDetector;

	[Token(Token = "0x4000761")]
	[FieldOffset(Offset = "0x60")]
	public LongSongNameController designerLongNameController;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000762")]
	public LongSongNameController songAuthorLongNameController;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000763")]
	private StringBuilder m_Sb;

	[Token(Token = "0x6000875")]
	[Address(RVA = "0x7B2C00", Offset = "0x7B1400", Length = "0x149")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000876")]
	[Address(RVA = "0x7B3CA0", Offset = "0x7B24A0", Length = "0x241")]
	private void OnPnlLevelConfigSelectShowOpen()
	{
	}

	[Token(Token = "0x6000877")]
	[Address(RVA = "0x7B2FB0", Offset = "0x7B17B0", Length = "0x15D")]
	protected virtual void OnAwake()
	{
	}

	[Address(RVA = "0x7B3110", Offset = "0x7B1910", Length = "0x1A2")]
	[Token(Token = "0x6000878")]
	protected virtual void OnBattleStart()
	{
	}

	[Address(RVA = "0x7B3FE0", Offset = "0x7B27E0", Length = "0x226")]
	[Token(Token = "0x6000879")]
	private bool VipTimeoutCheck()
	{
		return default(bool);
	}

	[Address(RVA = "0x7B36E0", Offset = "0x7B1EE0", Length = "0x144")]
	[Token(Token = "0x600087A")]
	protected void OnDownloadBestReport()
	{
	}

	[Token(Token = "0x600087B")]
	[Address(RVA = "0x7B2D50", Offset = "0x7B1550", Length = "0xA")]
	private void BeforeGameStart(long sizeNeedDonwload)
	{
	}

	[Token(Token = "0x600087C")]
	[Address(RVA = "0x7B2E60", Offset = "0x7B1660", Length = "0x14C")]
	private void GameStart()
	{
	}

	[Address(RVA = "0x7B2D60", Offset = "0x7B1560", Length = "0xF4")]
	[Token(Token = "0x600087D")]
	private bool CheckIsUnlockMasterLevel()
	{
		return default(bool);
	}

	[Address(RVA = "0x7B33F0", Offset = "0x7B1BF0", Length = "0x2E5")]
	[Token(Token = "0x600087E")]
	private void OnDiffTglChanged()
	{
	}

	[Token(Token = "0x600087F")]
	[Address(RVA = "0x7B3830", Offset = "0x7B2030", Length = "0x46E")]
	protected virtual void OnEnable()
	{
	}

	[Address(RVA = "0x7B3F80", Offset = "0x7B2780", Length = "0x1D")]
	[Token(Token = "0x6000880")]
	public void RefreshUi()
	{
	}

	[Token(Token = "0x6000881")]
	[Address(RVA = "0x7B3EF0", Offset = "0x7B26F0", Length = "0x84")]
	public virtual void PreWarm(int slice)
	{
	}

	[Token(Token = "0x6000882")]
	[Address(RVA = "0x7B32C0", Offset = "0x7B1AC0", Length = "0x121")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x7B2B90", Offset = "0x7B1390", Length = "0x64")]
	[Token(Token = "0x6000883")]
	public PnlPreparation()
	{
	}
}
