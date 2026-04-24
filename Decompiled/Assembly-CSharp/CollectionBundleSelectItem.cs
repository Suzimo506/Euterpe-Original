using System;
using Assets.Scripts.UI.Panels.PnlDLC;
using Cpp2ILInjected;
using FancyScrollView;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000102")]
public class CollectionBundleSelectItem : FancyScrollRectCell<CollectionBundleSelectItemData, CollectionBundleGroupContext>
{
	[Serializable]
	[Token(Token = "0x2000A0E")]
	public class ColorParameter
	{
		[Token(Token = "0x40035E8")]
		[FieldOffset(Offset = "0x10")]
		public Color imgBgColor;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40035E9")]
		public Color imgSaleBgColor;

		[Token(Token = "0x40035EA")]
		[FieldOffset(Offset = "0x30")]
		public Color txtSalecolor;

		[Token(Token = "0x40035EB")]
		[FieldOffset(Offset = "0x40")]
		public Color imgLockColor;

		[Token(Token = "0x40035EC")]
		[FieldOffset(Offset = "0x50")]
		public Color txtNamecolor;

		[Token(Token = "0x600586C")]
		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		public ColorParameter()
		{
		}
	}

	[Token(Token = "0x2000A0F")]
	private static class AnimatorHash
	{
		[Token(Token = "0x40035ED")]
		public static readonly int SelectAni;
	}

	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000652")]
	private Button m_Button;

	[Token(Token = "0x4000653")]
	[FieldOffset(Offset = "0x30")]
	private CollectionBundleSelectItemData m_Data;

	[Token(Token = "0x4000654")]
	[FieldOffset(Offset = "0x38")]
	private RectTransform m_RectTransform;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000655")]
	private float currentPosition;

	[Token(Token = "0x4000656")]
	[FieldOffset(Offset = "0x48")]
	private PnlDlc m_PnlDlc;

	[Token(Token = "0x4000657")]
	[FieldOffset(Offset = "0x50")]
	public ColorParameter selectColorParameter;

	[Token(Token = "0x4000658")]
	[FieldOffset(Offset = "0x58")]
	public ColorParameter unselectColorParameter;

	[Token(Token = "0x4000659")]
	[FieldOffset(Offset = "0x60")]
	public Image imgBg;

	[Token(Token = "0x400065A")]
	[FieldOffset(Offset = "0x68")]
	public Image imgSaleBg;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400065B")]
	public Image imgLock;

	[Token(Token = "0x400065C")]
	[FieldOffset(Offset = "0x78")]
	public Text txtSale;

	[Token(Token = "0x400065D")]
	[FieldOffset(Offset = "0x80")]
	public Text txtName;

	[Token(Token = "0x400065E")]
	[FieldOffset(Offset = "0x88")]
	public Animator m_Animator;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400065F")]
	public OutlineEx m_OutlineEx;

	[Token(Token = "0x4000660")]
	[FieldOffset(Offset = "0x98")]
	public Transform tranTopBoundary;

	[Token(Token = "0x4000661")]
	[FieldOffset(Offset = "0xA0")]
	public Transform tranDownBoundary;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000662")]
	private bool m_IsSelect;

	[Token(Token = "0x4000663")]
	private const string aniName = "PackageGroupCellSelectAni";

	[Token(Token = "0x4000664")]
	private const string aniNameBack = "PackageGroupCellSelectAniBack";

	[Token(Token = "0x4000665")]
	[FieldOffset(Offset = "0xA9")]
	private bool isSelectItemOut;

	[Token(Token = "0x1700009D")]
	private bool isExBoundary
	{
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x468C70", Offset = "0x467470", Length = "0xD4")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6000783")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x468130", Offset = "0x466930", Length = "0xCB")]
	[Token(Token = "0x6000784")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6000785")]
	[Address(RVA = "0x468AA0", Offset = "0x4672A0", Length = "0x180")]
	protected override void UpdatePosition(float normalizedPosition, float localPosition)
	{
	}

	[Address(RVA = "0x4685A0", Offset = "0x466DA0", Length = "0x4F6")]
	[Token(Token = "0x6000786")]
	public override void UpdateContent(CollectionBundleSelectItemData pgData)
	{
	}

	[Address(RVA = "0x468450", Offset = "0x466C50", Length = "0xEC")]
	[Token(Token = "0x6000787")]
	private void PlayAnimation()
	{
	}

	[Token(Token = "0x6000788")]
	[Address(RVA = "0x4683E0", Offset = "0x466BE0", Length = "0x62")]
	private void PlayAnimationBackward()
	{
	}

	[Address(RVA = "0x4682C0", Offset = "0x466AC0", Length = "0x11C")]
	[Token(Token = "0x6000789")]
	private bool IsAnimationPlaying(string animationName)
	{
		return default(bool);
	}

	[Address(RVA = "0x468200", Offset = "0x466A00", Length = "0xBF")]
	[Token(Token = "0x600078A")]
	private bool IsAnimationFinished(string animationName)
	{
		return default(bool);
	}

	[Address(RVA = "0x4680A0", Offset = "0x4668A0", Length = "0x8D")]
	[Token(Token = "0x600078B")]
	public static bool FloatEquals(float val1, float val2)
	{
		return default(bool);
	}

	[Token(Token = "0x600078C")]
	[Address(RVA = "0x468C30", Offset = "0x467430", Length = "0x38")]
	public CollectionBundleSelectItem()
	{
		((FancyScrollRectCell<TItemData, TContext>)(object)this)._002Ector();
	}
}
