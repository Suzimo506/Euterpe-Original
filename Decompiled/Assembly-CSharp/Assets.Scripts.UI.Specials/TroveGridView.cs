using Assets.Scripts.UI.Panels;
using Cpp2ILInjected;
using FancyScrollView;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Specials;

[Token(Token = "0x2000867")]
public class TroveGridView : FancyGridView<TroveItemData, TroveItemGroupContext>
{
	[Token(Token = "0x2000D38")]
	private class CellGroup : DefaultCellGroup
	{
		[Token(Token = "0x60063C7")]
		[Address(RVA = "0x60C480", Offset = "0x60AC80", Length = "0x38")]
		public CellGroup()
		{
			((FancyGridView<TItemData, TContext>.DefaultCellGroup)(object)this)._002Ector();
		}
	}

	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x4002BF0")]
	private PnlTroveItem templateTroveItem;

	[SerializeField]
	[Token(Token = "0x4002BF1")]
	[FieldOffset(Offset = "0x90")]
	private Vector2 m_ChipModeCellSize;

	[Token(Token = "0x4002BF2")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Vector2 m_FullModeCellSize;

	[SerializeField]
	[Token(Token = "0x4002BF3")]
	[FieldOffset(Offset = "0xA0")]
	private int m_ChipModeCellLineCountFor169;

	[SerializeField]
	[Token(Token = "0x4002BF4")]
	[FieldOffset(Offset = "0xA4")]
	private int m_FullModeCellLineCountFor169;

	[Token(Token = "0x1700086A")]
	public int selectedIndex
	{
		[Token(Token = "0x6004CD8")]
		[Address(RVA = "0x61CCC0", Offset = "0x61B4C0", Length = "0x3B")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700086B")]
	public PnlTroveItem selectedTroveItem
	{
		[Token(Token = "0x6004CD9")]
		[Address(RVA = "0x61CD00", Offset = "0x61B500", Length = "0x3C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004CDA")]
	[Address(RVA = "0x61CB40", Offset = "0x61B340", Length = "0x66")]
	protected override void SetupCellTemplate()
	{
	}

	[Address(RVA = "0x61C9D0", Offset = "0x61B1D0", Length = "0xD7")]
	[Token(Token = "0x6004CDB")]
	protected override void Initialize()
	{
	}

	[Token(Token = "0x6004CDC")]
	[Address(RVA = "0x61CC30", Offset = "0x61B430", Length = "0x4B")]
	public void UpdateSelection(int index)
	{
	}

	[Token(Token = "0x6004CDD")]
	[Address(RVA = "0x61CAB0", Offset = "0x61B2B0", Length = "0x87")]
	public void SetPnlTroves(PnlTroves tempPnlTroves, ToggleGroup toggleGroup)
	{
	}

	[Token(Token = "0x6004CDE")]
	[Address(RVA = "0x5D2930", Offset = "0x5D1130", Length = "0x41")]
	public void ScrollToAssignIndex(int index)
	{
	}

	[Token(Token = "0x6004CDF")]
	[Address(RVA = "0x5C3CB0", Offset = "0x5C24B0", Length = "0x19")]
	public void JumpToAssignIndex(int index)
	{
	}

	[Address(RVA = "0x61C820", Offset = "0x61B020", Length = "0x1A6")]
	[Token(Token = "0x6004CE0")]
	public PnlTroveItem GetTroveItemByItemData(TroveItemData data)
	{
		return null;
	}

	[Address(RVA = "0x61CBB0", Offset = "0x61B3B0", Length = "0x77")]
	[Token(Token = "0x6004CE1")]
	protected override void UpdatePosition(float position, bool forceRefresh)
	{
	}

	[Token(Token = "0x6004CE2")]
	[Address(RVA = "0x61C740", Offset = "0x61AF40", Length = "0x27")]
	public void ChangeToChipMode()
	{
	}

	[Token(Token = "0x6004CE3")]
	[Address(RVA = "0x61C770", Offset = "0x61AF70", Length = "0x27")]
	public void ChangeToFullMode()
	{
	}

	[Address(RVA = "0x61C620", Offset = "0x61AE20", Length = "0x11B")]
	[Token(Token = "0x6004CE4")]
	private void ChangeMode(Vector2 cellSize, int lineCountFor169)
	{
	}

	[Address(RVA = "0x61C7A0", Offset = "0x61AFA0", Length = "0x7A")]
	[Token(Token = "0x6004CE5")]
	public int CustomRound(float number)
	{
		return default(int);
	}

	[Token(Token = "0x6004CE6")]
	[Address(RVA = "0x61CC80", Offset = "0x61B480", Length = "0x38")]
	public TroveGridView()
	{
		((FancyGridView<TItemData, TContext>)(object)this)._002Ector();
	}
}
