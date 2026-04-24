using Cpp2ILInjected;
using MEC;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.PnlMusicStage.MusicPromotion;

[Token(Token = "0x2000862")]
public class MusicStageCellPromotion : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4002BC3")]
	[FieldOffset(Offset = "0x18")]
	private Transform m_PromotionRoot;

	[Token(Token = "0x4002BC4")]
	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	private Button m_BtnPromotionTip;

	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002BC5")]
	private Image m_ImgPromotionSign;

	[Token(Token = "0x4002BC6")]
	[FieldOffset(Offset = "0x30")]
	private CoroutineHandle m_GetDataCoroutine;

	[Token(Token = "0x4002BC7")]
	[FieldOffset(Offset = "0x34")]
	private CoroutineHandle m_RendUICoroutine;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002BC8")]
	private PromotionIndexData m_PromoData;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002BC9")]
	private MusicStageCell.MusicStageCellInfo m_CurCellMusicInfo;

	[Token(Token = "0x6004CB2")]
	[Address(RVA = "0x4C1820", Offset = "0x4C0020", Length = "0x10D")]
	public void RefreshAndShow(MusicStageCell.MusicStageCellInfo musicInfo)
	{
	}

	[Address(RVA = "0x4C1630", Offset = "0x4BFE30", Length = "0x13E")]
	[Token(Token = "0x6004CB3")]
	public void HidePromotion()
	{
	}

	[Address(RVA = "0x4C1930", Offset = "0x4C0130", Length = "0x2BF")]
	[Token(Token = "0x6004CB4")]
	private void RefreshPromotionView()
	{
	}

	[Address(RVA = "0x4C1770", Offset = "0x4BFF70", Length = "0xA5")]
	[Token(Token = "0x6004CB5")]
	private void OnClickToShowPromotion()
	{
	}

	[Token(Token = "0x6004CB6")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public MusicStageCellPromotion()
	{
	}
}
