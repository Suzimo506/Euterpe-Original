using Assets.Scripts.Database;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008F8")]
public class BgsRoot : MonoBehaviour
{
	[Token(Token = "0x4003001")]
	private const string localization_key_nano_core = "pnl_stage_level_15_unlock_nano_core";

	[Token(Token = "0x4003002")]
	private const string localization_key_budget_burning_01 = "pnl_stage_level_30_unlock_budget_is_burning";

	[SerializeField]
	[Attribute(Name = "HeaderAttribute", RVA = "0x699F0", Offset = "0x68DF0")]
	[Token(Token = "0x4003003")]
	[FieldOffset(Offset = "0x18")]
	private PnlStageBgAlbum m_BgAlbumWeekFree;

	[Token(Token = "0x4003004")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private PnlStageBgAlbum m_BgAlbumLock;

	[SerializeField]
	[Attribute(Name = "HeaderAttribute", RVA = "0x69E20", Offset = "0x69220")]
	[Token(Token = "0x4003005")]
	[FieldOffset(Offset = "0x28")]
	private Image m_WeekFreeIcon;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4003006")]
	private Sprite m_WeekFreeIconCache;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4003007")]
	[SerializeField]
	[Attribute(Name = "HeaderAttribute", RVA = "0x6A050", Offset = "0x69450")]
	private Text m_TxtBgAlbumTips;

	[Token(Token = "0x4003008")]
	[FieldOffset(Offset = "0x40")]
	private readonly string m_NoDiscount;

	[Address(RVA = "0x6C1AB0", Offset = "0x6C02B0", Length = "0x9D")]
	[Token(Token = "0x600516C")]
	private void Start()
	{
	}

	[Token(Token = "0x600516D")]
	[Address(RVA = "0x6C1280", Offset = "0x6BFA80", Length = "0x59")]
	private void HideBgRootTips()
	{
	}

	[Address(RVA = "0x6C12E0", Offset = "0x6BFAE0", Length = "0x112")]
	[Token(Token = "0x600516E")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x6C1400", Offset = "0x6BFC00", Length = "0x480")]
	[Token(Token = "0x600516F")]
	public void RefreshBgAlbum(MusicInfo musicInfo, bool hideText = false)
	{
	}

	[Address(RVA = "0x6C1890", Offset = "0x6C0090", Length = "0x216")]
	[Token(Token = "0x6005170")]
	private void SetBgAlbumActive(string albumUidName, bool isWeekFreeMusic, bool isDlc, string disCount)
	{
	}

	[Token(Token = "0x6005171")]
	[Address(RVA = "0x6C11D0", Offset = "0x6BF9D0", Length = "0xA6")]
	private string GetBgAlbumTextInfoByMusicInfo(int albumJsonIndex, bool isWeekFreeMusic, bool isDlc, string albumLocalName)
	{
		return null;
	}

	[Token(Token = "0x6005172")]
	[Address(RVA = "0x6C1B50", Offset = "0x6C0350", Length = "0x17E")]
	private string TryGetProductDiscount(string musicInfoAlbumUidName)
	{
		return null;
	}

	[Token(Token = "0x6005173")]
	[Address(RVA = "0x6C0FE0", Offset = "0x6BF7E0", Length = "0x162")]
	private void ChangeDiscountIcon(string disCount)
	{
	}

	[Address(RVA = "0x6C1150", Offset = "0x6BF950", Length = "0x7F")]
	[Token(Token = "0x6005174")]
	private void DisableAll()
	{
	}

	[Address(RVA = "0x6C1CD0", Offset = "0x6C04D0", Length = "0x46")]
	[Token(Token = "0x6005175")]
	public BgsRoot()
	{
	}
}
