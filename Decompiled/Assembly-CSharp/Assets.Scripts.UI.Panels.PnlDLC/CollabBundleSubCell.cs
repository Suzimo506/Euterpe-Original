using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000911")]
public class CollabBundleSubCell : MonoBehaviour
{
	[Token(Token = "0x2000D9C")]
	private static class AnimatorHash
	{
		[Token(Token = "0x4004043")]
		public static readonly int SelectAni;
	}

	[Serializable]
	[Token(Token = "0x2000D9D")]
	public class ColorParameter
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4004044")]
		public Color imgSaleBgColor;

		[Token(Token = "0x4004045")]
		[FieldOffset(Offset = "0x20")]
		public Color txtSalecolor;

		[Token(Token = "0x4004046")]
		[FieldOffset(Offset = "0x30")]
		public Color imgLockColor;

		[Token(Token = "0x600652F")]
		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		public ColorParameter()
		{
		}
	}

	[Token(Token = "0x40030BB")]
	private const string aniName = "PackageGroupCellSelectAni";

	[Token(Token = "0x40030BC")]
	private const string aniNameBack = "PackageGroupCellSelectAniBack";

	[SerializeField]
	[Token(Token = "0x40030BD")]
	[FieldOffset(Offset = "0x18")]
	private Button m_Btn;

	[SerializeField]
	[Token(Token = "0x40030BE")]
	[FieldOffset(Offset = "0x20")]
	private Image m_ImgBox;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40030BF")]
	[SerializeField]
	private Image m_ImgSaleBg;

	[SerializeField]
	[Token(Token = "0x40030C0")]
	[FieldOffset(Offset = "0x30")]
	private Image m_ImgLock;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40030C1")]
	[SerializeField]
	private Text m_TxtSale;

	[Token(Token = "0x40030C2")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private LongSongNameController m_LongSongNameController;

	[Token(Token = "0x40030C3")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Animator m_Animator;

	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x40030C4")]
	private OutlineEx m_OutlineEx;

	[Token(Token = "0x40030C5")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private CanvasGroup m_CanvasGroup;

	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x40030C6")]
	private ColorParameter m_SelectColorParameter;

	[SerializeField]
	[Token(Token = "0x40030C7")]
	[FieldOffset(Offset = "0x68")]
	private ColorParameter m_UnselectColorParameter;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40030C8")]
	private CollabBundleCell m_Parent;

	[Token(Token = "0x40030C9")]
	[FieldOffset(Offset = "0x78")]
	private CollectionBundleSelectItemData m_Data;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40030CA")]
	private Sprite m_OriSprite;

	[Token(Token = "0x40030CB")]
	[FieldOffset(Offset = "0x88")]
	private bool m_IsSelected;

	[Token(Token = "0x40030CC")]
	[FieldOffset(Offset = "0x89")]
	private bool isSelectItemOut;

	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x40030CD")]
	private int m_Index;

	[Address(RVA = "0x421F80", Offset = "0x420780", Length = "0xA8")]
	[Token(Token = "0x600524C")]
	private void Awake()
	{
	}

	[Address(RVA = "0x422030", Offset = "0x420830", Length = "0xC")]
	[Token(Token = "0x600524D")]
	public void Init(CollabBundleCell parent)
	{
	}

	[Address(RVA = "0x4225B0", Offset = "0x420DB0", Length = "0x27D")]
	[Token(Token = "0x600524E")]
	public void SetData(CollectionBundleSelectItemData pgData)
	{
	}

	[Token(Token = "0x600524F")]
	[Address(RVA = "0x422470", Offset = "0x420C70", Length = "0x19")]
	public void ResetCell()
	{
	}

	[Token(Token = "0x6005250")]
	[Address(RVA = "0x422830", Offset = "0x421030", Length = "0x2DB")]
	public void SetSelected(bool value)
	{
	}

	[Address(RVA = "0x422490", Offset = "0x420C90", Length = "0x11E")]
	[Token(Token = "0x6005251")]
	public void SetAlpha(int value)
	{
	}

	[Token(Token = "0x6005252")]
	[Address(RVA = "0x422310", Offset = "0x420B10", Length = "0x15C")]
	private void PlayAnimation()
	{
	}

	[Token(Token = "0x6005253")]
	[Address(RVA = "0x422040", Offset = "0x420840", Length = "0x160")]
	private void OnSelected()
	{
	}

	[Token(Token = "0x6005254")]
	[Address(RVA = "0x4221B0", Offset = "0x4209B0", Length = "0x15F")]
	private void PlayAnimationBackward()
	{
	}

	[Token(Token = "0x6005255")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public CollabBundleSubCell()
	{
	}
}
