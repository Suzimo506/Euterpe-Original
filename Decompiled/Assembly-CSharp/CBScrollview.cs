using System.Collections.Generic;
using Cpp2ILInjected;
using FancyScrollView;
using UnityEngine;

[Token(Token = "0x20000FE")]
public class CBScrollview : FancyScrollViewWithSpecial<CollectionBundleSelectItemData, CollectionBundleGroupContext>
{
	[Token(Token = "0x4000641")]
	[SerializeField]
	[FieldOffset(Offset = "0x60")]
	private Scroller scroller;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000642")]
	[SerializeField]
	private GameObject cellPrefab;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000643")]
	[SerializeField]
	private DLCInfoCBControl m_Parent;

	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x15080", Offset = "0x14480")]
	[SerializeField]
	[Token(Token = "0x4000644")]
	protected GameObject m_CollectionSpecialCell;

	[Token(Token = "0x4000645")]
	[FieldOffset(Offset = "0x80")]
	private CollectionBundleShowItem m_PackageGroupShowItem;

	[Token(Token = "0x4000646")]
	[FieldOffset(Offset = "0x88")]
	public new SpecialCells specialCells;

	[Token(Token = "0x1700009B")]
	protected override GameObject CellPrefab
	{
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x4293C0", Offset = "0x427BC0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009C")]
	public CollectionBundleShowItem selectShowItem
	{
		[Address(RVA = "0x4632A0", Offset = "0x461AA0", Length = "0x3C")]
		[Token(Token = "0x600077A")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x462E40", Offset = "0x461640", Length = "0xD3")]
	[Token(Token = "0x600077B")]
	protected override void Initialize()
	{
	}

	[Token(Token = "0x600077C")]
	[Address(RVA = "0x463200", Offset = "0x461A00", Length = "0x5E")]
	private void UpdateSelection(int index)
	{
	}

	[Address(RVA = "0x462F20", Offset = "0x461720", Length = "0x1FD")]
	[Token(Token = "0x600077D")]
	public void RefreshItemCount(IList<CollectionBundleSelectItemData> items)
	{
	}

	[Token(Token = "0x600077E")]
	[Address(RVA = "0x463120", Offset = "0x461920", Length = "0xDB")]
	public void SelectCell(int index)
	{
	}

	[Token(Token = "0x600077F")]
	[Address(RVA = "0x463260", Offset = "0x461A60", Length = "0x38")]
	public CBScrollview()
	{
		((FancyScrollViewWithSpecial<TItemData, TContext>)(object)this)._002Ector();
	}
}
