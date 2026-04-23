using System;
using System.Collections.Generic;
using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.UI;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000949")]
public class VipDisPlayControl : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400328F")]
	public GameObject rootDesMobile;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4003290")]
	public GameObject rootDesPC;

	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C830", Offset = "0x9BC30")]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4003291")]
	public Text txtVipPrice;

	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9CA20", Offset = "0x9BE20")]
	[Token(Token = "0x4003292")]
	[FieldOffset(Offset = "0x30")]
	public Text txtOnSaleCountDown;

	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9CC60", Offset = "0x9C060")]
	[Token(Token = "0x4003293")]
	[FieldOffset(Offset = "0x38")]
	public Text txtOnSaleCountDown_En;

	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9CD90", Offset = "0x9C190")]
	[Token(Token = "0x4003294")]
	public Text txtExpirationTime;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4003295")]
	public GameObject rootOnSale;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4003296")]
	public GameObject rootPurchased;

	[Token(Token = "0x4003297")]
	[FieldOffset(Offset = "0x58")]
	public GameObject rootNotOnSale;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4003298")]
	public List<Button> btnVipTips;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4003299")]
	public Button btnPurchase;

	[SerializeField]
	[Token(Token = "0x400329A")]
	[FieldOffset(Offset = "0x70")]
	public List<VipTimeLimitedUnit> vipTimeLimitedUnits;

	[Token(Token = "0x400329B")]
	[FieldOffset(Offset = "0x78")]
	private VipShowState m_VipShowState;

	[Token(Token = "0x400329C")]
	private const string priceError = "ERROR";

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400329D")]
	private ProductVip m_ProductVip;

	[Token(Token = "0x400329E")]
	[FieldOffset(Offset = "0xE0")]
	private DateTime m_EndTime;

	[SerializeField]
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x400329F")]
	private BtnIAP m_BtnPurchaseIAP;

	[Token(Token = "0x40032A0")]
	private const string m_PointRegex = "[0]+$";

	[Token(Token = "0x40032A1")]
	private const string m_ThousandRegex = "^.?\\d{4,}\\.?";

	[Token(Token = "0x40032A2")]
	private const string m_NumberRegex = "[\\d]+";

	[Token(Token = "0x170008D8")]
	public VipShowState vipShowState
	{
		[Address(RVA = "0x837CF0", Offset = "0x8364F0", Length = "0x7")]
		[Token(Token = "0x6005462")]
		get
		{
			return default(VipShowState);
		}
	}

	[Token(Token = "0x170008D9")]
	private bool m_VipOnSale
	{
		[Token(Token = "0x6005463")]
		[Address(RVA = "0x837C70", Offset = "0x836470", Length = "0x75")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x836BE0", Offset = "0x8353E0", Length = "0x252")]
	[Token(Token = "0x6005464")]
	public void Init()
	{
	}

	[Address(RVA = "0x8370F0", Offset = "0x8358F0", Length = "0x14B")]
	[Token(Token = "0x6005465")]
	public void OnReset()
	{
	}

	[Address(RVA = "0x837480", Offset = "0x835C80", Length = "0x57")]
	[Token(Token = "0x6005466")]
	private void RefreshVipTitleAndDes()
	{
	}

	[Token(Token = "0x6005467")]
	[Address(RVA = "0x837240", Offset = "0x835A40", Length = "0x23F")]
	private void RefreshVipButtonAndState()
	{
	}

	[Token(Token = "0x6005468")]
	[Address(RVA = "0x8367E0", Offset = "0x834FE0", Length = "0x79")]
	private void DisableAllVipButton()
	{
	}

	[Address(RVA = "0x836AE0", Offset = "0x8352E0", Length = "0xF8")]
	[Token(Token = "0x6005469")]
	private void GetServerTimeToRefresh()
	{
	}

	[Address(RVA = "0x837500", Offset = "0x835D00", Length = "0x6F6")]
	[Token(Token = "0x600546A")]
	private void UpdateDisplay(bool getServerTimeTimeFailed = false)
	{
	}

	[Address(RVA = "0x837000", Offset = "0x835800", Length = "0x49")]
	[Token(Token = "0x600546B")]
	public void OnClickRestroePurchase()
	{
	}

	[Address(RVA = "0x836F40", Offset = "0x835740", Length = "0xBB")]
	[Token(Token = "0x600546C")]
	public void OnClickPurchase()
	{
	}

	[Token(Token = "0x600546D")]
	[Address(RVA = "0x836E40", Offset = "0x835640", Length = "0xF5")]
	public void OnClickInvokePnlVipTip()
	{
	}

	[Address(RVA = "0x837050", Offset = "0x835850", Length = "0x9C")]
	[Token(Token = "0x600546E")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x836860", Offset = "0x835060", Length = "0x273")]
	[Token(Token = "0x600546F")]
	private string GetPriceFormat(string priceString)
	{
		return null;
	}

	[Address(RVA = "0x837C00", Offset = "0x836400", Length = "0x69")]
	[Token(Token = "0x6005470")]
	public VipDisPlayControl()
	{
	}
}
