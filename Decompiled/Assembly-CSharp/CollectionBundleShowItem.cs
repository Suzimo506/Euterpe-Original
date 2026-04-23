using System.Collections.Generic;
using Assets.Scripts.UI;
using Assets.Scripts.UI.Panels.PnlDLC;
using Cpp2ILInjected;
using FancyScrollView;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000103")]
public class CollectionBundleShowItem : FancyCellWithSpecial<CollectionBundleSelectItemData, CollectionBundleGroupContext>
{
	[Token(Token = "0x2000A10")]
	private static class AnimatorHash
	{
		[Token(Token = "0x40035EE")]
		public static readonly int Scroll;
	}

	[Token(Token = "0x4000666")]
	[FieldOffset(Offset = "0x40")]
	public Transform normalCellTrans;

	[Attribute(Name = "TooltipAttribute", RVA = "0x15500", Offset = "0x14900")]
	[Token(Token = "0x4000667")]
	[FieldOffset(Offset = "0x48")]
	public List<Vector2> peroGridLayoutReolutionScheme;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000668")]
	public PeroGridLayout peroGridLayout;

	[SerializeField]
	[Token(Token = "0x4000669")]
	[FieldOffset(Offset = "0x58")]
	private Animator m_Animator;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400066A")]
	public DLCInfoSubControl m_DlcInfoSubControl;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400066B")]
	private CollectionBundleSelectItemData m_Data;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400066C")]
	private Text m_TextName;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400066D")]
	private PnlDlc m_PnlDlc;

	[Token(Token = "0x400066E")]
	[FieldOffset(Offset = "0x80")]
	private float currentPosition;

	[Address(RVA = "0x468F20", Offset = "0x467720", Length = "0x7")]
	[Token(Token = "0x600078E")]
	private void Start()
	{
	}

	[Token(Token = "0x600078F")]
	[Address(RVA = "0x468ED0", Offset = "0x4676D0", Length = "0x19")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x468E40", Offset = "0x467640", Length = "0x83")]
	[Token(Token = "0x6000790")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6000791")]
	[Address(RVA = "0x468D50", Offset = "0x467550", Length = "0xBF")]
	private void BatchesDifferentResolutions()
	{
	}

	[Address(RVA = "0x469070", Offset = "0x467870", Length = "0xD7")]
	[Token(Token = "0x6000792")]
	public override void UpdatePosition(float position)
	{
	}

	[Address(RVA = "0x469150", Offset = "0x467950", Length = "0x4F")]
	[Token(Token = "0x6000793")]
	protected override void UpdateSpecialCellContent()
	{
	}

	[Token(Token = "0x6000794")]
	[Address(RVA = "0x468F30", Offset = "0x467730", Length = "0x13F")]
	protected override void UpdateNormalCellContent(CollectionBundleSelectItemData pgData)
	{
	}

	[Token(Token = "0x6000795")]
	[Address(RVA = "0x468E10", Offset = "0x467610", Length = "0x2F")]
	protected override void HiddenNormalCellContent()
	{
	}

	[Address(RVA = "0x468EF0", Offset = "0x4676F0", Length = "0x2F")]
	[Token(Token = "0x6000796")]
	protected override void ResumeNormalCellContent()
	{
	}

	[Address(RVA = "0x4691A0", Offset = "0x4679A0", Length = "0x6E")]
	[Token(Token = "0x6000797")]
	public CollectionBundleShowItem()
	{
		((FancyCellWithSpecial<TItemData, TContext>)(object)this)._002Ector();
	}
}
