using System;
using Cpp2ILInjected;
using SuperScrollView;
using UnityEngine;

[Token(Token = "0x2000159")]
public class PnlMusicTagScrollView : LoopListView2<PnlMusicTagViewItem>
{
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000880")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2EF70", Offset = "0x2E370")]
	[SerializeField]
	protected int m_FixedCount;

	[FieldOffset(Offset = "0x164")]
	[Token(Token = "0x4000881")]
	[SerializeField]
	protected AlignType m_AlignType;

	[Token(Token = "0x4000882")]
	[FieldOffset(Offset = "0x168")]
	public Vector2 masterPadding;

	[Token(Token = "0x4000883")]
	[FieldOffset(Offset = "0x170")]
	protected Vector2 cellPadding;

	[Token(Token = "0x170000CF")]
	public AlignType alignType
	{
		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x7B0560", Offset = "0x7AED60", Length = "0x7")]
		get
		{
			return default(AlignType);
		}
		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x7B0580", Offset = "0x7AED80", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x170000D0")]
	public int fixedCount
	{
		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x7B0570", Offset = "0x7AED70", Length = "0x7")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60009E0")]
	[Address(RVA = "0x7AE6F0", Offset = "0x7ACEF0", Length = "0xA1")]
	public override void InitListView(int itemTotalCount, Func<LoopListView2<PnlMusicTagViewItem>, int, PnlMusicTagViewItem> onGetItemByIndex, LoopListViewInitParam initParam = null)
	{
	}

	[Address(RVA = "0x7B04B0", Offset = "0x7AECB0", Length = "0x6F")]
	[Token(Token = "0x60009E1")]
	public override void UpdatePrefabData()
	{
	}

	[Address(RVA = "0x7AF3B0", Offset = "0x7ADBB0", Length = "0x26A")]
	[Token(Token = "0x60009E2")]
	protected override bool UpdateForHorFirstItem(bool leftToRight)
	{
		return default(bool);
	}

	[Token(Token = "0x60009E3")]
	[Address(RVA = "0x7AF620", Offset = "0x7ADE20", Length = "0xE86")]
	protected override bool UpdateForHorizontalList(float distanceForRecycleRight, float distanceForRecycleLeft, float distanceForShowRight, float distanceForShowLeft)
	{
		return default(bool);
	}

	[Address(RVA = "0x7AEC70", Offset = "0x7AD470", Length = "0x73A")]
	[Token(Token = "0x60009E4")]
	protected override void UpdateAllShownItemsPos()
	{
	}

	[Address(RVA = "0x7AE7A0", Offset = "0x7ACFA0", Length = "0x4CE")]
	[Token(Token = "0x60009E5")]
	public void MoveToViewPort(GameObject go)
	{
	}

	[Address(RVA = "0x7B0520", Offset = "0x7AED20", Length = "0x38")]
	[Token(Token = "0x60009E6")]
	public PnlMusicTagScrollView()
	{
		((LoopListView2<T>)(object)this)._002Ector();
	}
}
