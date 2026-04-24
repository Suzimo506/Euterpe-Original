using System.Collections.Generic;
using Cpp2ILInjected;
using FancyScrollView;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.StageBackground.DaveMainShow.FsvFishType;

[Token(Token = "0x2000844")]
public class FsvFishType : FancyScrollView<FishTypeItemData, FsvFishTypeContext>
{
	[Token(Token = "0x4002B2E")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected Scroller m_Scroller;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002B2F")]
	[SerializeField]
	protected GameObject m_CellPrefab;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4002B30")]
	[SerializeField]
	private Button m_BtnNext;

	[Token(Token = "0x4002B31")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Button m_BtnPrevious;

	[Token(Token = "0x17000854")]
	public FsvFishTypeContext FsvContext
	{
		[Token(Token = "0x6004BFD")]
		[Address(RVA = "0x60FFB0", Offset = "0x60E7B0", Length = "0x38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000855")]
	protected override GameObject CellPrefab
	{
		[Token(Token = "0x6004BFE")]
		[Address(RVA = "0x4293D0", Offset = "0x427BD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004BFF")]
	[Address(RVA = "0x60FE60", Offset = "0x60E660", Length = "0x101")]
	public void UpdateData(List<string> dataList)
	{
	}

	[Token(Token = "0x6004C00")]
	[Address(RVA = "0x60FE20", Offset = "0x60E620", Length = "0x37")]
	public void ScrollTo(int index)
	{
	}

	[Token(Token = "0x6004C01")]
	[Address(RVA = "0x447090", Offset = "0x445890", Length = "0x11")]
	public void RefreshView()
	{
	}

	[Token(Token = "0x6004C02")]
	[Address(RVA = "0x60F9C0", Offset = "0x60E1C0", Length = "0x16D")]
	protected override void Initialize()
	{
	}

	[Token(Token = "0x6004C03")]
	[Address(RVA = "0x60FB30", Offset = "0x60E330", Length = "0xA4")]
	private void OnClickToNext()
	{
	}

	[Address(RVA = "0x60FBE0", Offset = "0x60E3E0", Length = "0x81")]
	[Token(Token = "0x6004C04")]
	private void OnClickToPrevious()
	{
	}

	[Address(RVA = "0x60FC70", Offset = "0x60E470", Length = "0x1A1")]
	[Token(Token = "0x6004C05")]
	private void OnSelectionConfirmed(int itemIdx)
	{
	}

	[Token(Token = "0x6004C06")]
	[Address(RVA = "0x60FF70", Offset = "0x60E770", Length = "0x38")]
	public FsvFishType()
	{
		((FancyScrollView<TItemData, TContent>)(object)this)._002Ector();
	}
}
