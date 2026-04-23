using System.Collections.Generic;
using Cpp2ILInjected;
using FancyScrollView;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000FD")]
public class CBScrollRect : FancyScrollRect<CollectionBundleSelectItemData, CollectionBundleGroupContext>
{
	[SerializeField]
	[Token(Token = "0x400063C")]
	[FieldOffset(Offset = "0x68")]
	private float cellSize;

	[SerializeField]
	[Token(Token = "0x400063D")]
	[FieldOffset(Offset = "0x70")]
	private GameObject cellPrefab;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400063E")]
	[SerializeField]
	private Button m_BtnUp;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400063F")]
	[SerializeField]
	private Button m_BtnDown;

	[SerializeField]
	[Token(Token = "0x4000640")]
	[FieldOffset(Offset = "0x88")]
	private DLCInfoCBControl m_Parent;

	[Token(Token = "0x17000094")]
	protected override float CellSize
	{
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x462D10", Offset = "0x461510", Length = "0x6")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000095")]
	protected override GameObject CellPrefab
	{
		[Address(RVA = "0x462D00", Offset = "0x461500", Length = "0x5")]
		[Token(Token = "0x6000765")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000096")]
	public int DataCount
	{
		[Address(RVA = "0x462D20", Offset = "0x461520", Length = "0x45")]
		[Token(Token = "0x6000766")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000097")]
	public int curSelectIndex
	{
		[Address(RVA = "0x462DA0", Offset = "0x4615A0", Length = "0x3B")]
		[Token(Token = "0x6000767")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000098")]
	public float PaddingTop
	{
		[Address(RVA = "0x462D80", Offset = "0x461580", Length = "0x6")]
		[Token(Token = "0x6000768")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000769")]
		[Address(RVA = "0x462E00", Offset = "0x461600", Length = "0x16")]
		set
		{
		}
	}

	[Token(Token = "0x17000099")]
	public float PaddingBottom
	{
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x462D70", Offset = "0x461570", Length = "0x6")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x462DE0", Offset = "0x4615E0", Length = "0x16")]
		set
		{
		}
	}

	[Token(Token = "0x1700009A")]
	public float Spacing
	{
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x462D90", Offset = "0x461590", Length = "0x6")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x462E20", Offset = "0x461620", Length = "0x16")]
		set
		{
		}
	}

	[Token(Token = "0x600076E")]
	[Address(RVA = "0x462340", Offset = "0x460B40", Length = "0x2E4")]
	protected override void Initialize()
	{
	}

	[Token(Token = "0x600076F")]
	[Address(RVA = "0x462A40", Offset = "0x461240", Length = "0x37")]
	public void UpdateData(IList<CollectionBundleSelectItemData> items, int selectIndex = 0)
	{
	}

	[Address(RVA = "0x462300", Offset = "0x460B00", Length = "0x32")]
	[Token(Token = "0x6000770")]
	public void ForceUpdate()
	{
	}

	[Token(Token = "0x6000771")]
	[Address(RVA = "0x4626C0", Offset = "0x460EC0", Length = "0x97")]
	public void ScrollToIndex(int index, bool forceUpdatePosition = true)
	{
	}

	[Token(Token = "0x6000772")]
	[Address(RVA = "0x462760", Offset = "0x460F60", Length = "0x5A")]
	private void ScrollToScrollbarPointerDown(float position)
	{
	}

	[Address(RVA = "0x462A80", Offset = "0x461280", Length = "0x23A")]
	[Token(Token = "0x6000773")]
	public void UpdateSelection(int index)
	{
	}

	[Token(Token = "0x6000774")]
	[Address(RVA = "0x462630", Offset = "0x460E30", Length = "0x84")]
	public void RefreshItemCount(IList<CollectionBundleSelectItemData> items)
	{
	}

	[Address(RVA = "0x462910", Offset = "0x461110", Length = "0x120")]
	[Token(Token = "0x6000775")]
	private void TurnUp()
	{
	}

	[Address(RVA = "0x462830", Offset = "0x461030", Length = "0xDC")]
	[Token(Token = "0x6000776")]
	private void TurnDown()
	{
	}

	[Address(RVA = "0x4627C0", Offset = "0x460FC0", Length = "0x68")]
	[Token(Token = "0x6000777")]
	public void SetBtnActive(bool value)
	{
	}

	[Token(Token = "0x6000778")]
	[Address(RVA = "0x462CC0", Offset = "0x4614C0", Length = "0x3F")]
	public CBScrollRect()
	{
		((FancyScrollRect<TItemData, TContext>)(object)this)._002Ector();
	}
}
