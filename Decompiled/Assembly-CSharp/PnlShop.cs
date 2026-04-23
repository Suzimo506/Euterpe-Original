using System.Collections.Generic;
using Assets.Scripts.GameCore.Interface;
using Assets.Scripts.PeroTools.PreWarm;
using Assets.Scripts.PeroTools.UI;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200015C")]
public class PnlShop : MonoBehaviour, IPreWarm, IRelease
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000892")]
	public GameObject itemGoods1Objs;

	[Token(Token = "0x4000893")]
	[FieldOffset(Offset = "0x20")]
	public GameObject itemGoods2Objs;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000894")]
	public GameObject itemGoods3Objs;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000895")]
	public GameObject itemGoods4Objs;

	[Token(Token = "0x4000896")]
	[FieldOffset(Offset = "0x38")]
	public Dictionary<int, FastPool> moduleObjs;

	[Token(Token = "0x4000897")]
	[FieldOffset(Offset = "0x40")]
	public Transform moduleTrans;

	[SerializeField]
	[Token(Token = "0x4000898")]
	[FieldOffset(Offset = "0x48")]
	private GameObject m_LoadingAnim;

	[SerializeField]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000899")]
	private CanvasGroup m_ShopViewPort;

	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x400089A")]
	private CanvasGroup m_ScorllViewRaycast;

	[SerializeField]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400089B")]
	private CanvasGroup m_ScorllBar;

	[Token(Token = "0x400089C")]
	[FieldOffset(Offset = "0x68")]
	private Scrollbar m_RealScrollBar;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400089D")]
	public LongPressButton longPressButtonLeft;

	[Token(Token = "0x400089E")]
	[FieldOffset(Offset = "0x78")]
	public LongPressButton longPressButtonRight;

	[Token(Token = "0x400089F")]
	[FieldOffset(Offset = "0x80")]
	private string m_PrevMusicName;

	[Token(Token = "0x40008A0")]
	[FieldOffset(Offset = "0x88")]
	private bool m_Dirty;

	[Token(Token = "0x60009F5")]
	[Address(RVA = "0x562A90", Offset = "0x561290", Length = "0x22D")]
	public void PreWarm(int slice)
	{
	}

	[Token(Token = "0x60009F6")]
	[Address(RVA = "0x562040", Offset = "0x560840", Length = "0x1E8")]
	private void Awake()
	{
	}

	[Address(RVA = "0x562920", Offset = "0x561120", Length = "0x8")]
	[Token(Token = "0x60009F7")]
	private void OnLanguageChanged(int languageIndex)
	{
	}

	[Address(RVA = "0x562530", Offset = "0x560D30", Length = "0x202")]
	[Token(Token = "0x60009F8")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x562930", Offset = "0x561130", Length = "0x158")]
	[Token(Token = "0x60009F9")]
	private void OnOpenShop()
	{
	}

	[Address(RVA = "0x562CC0", Offset = "0x5614C0", Length = "0x118")]
	[Token(Token = "0x60009FA")]
	private void PrewarmInit()
	{
	}

	[Address(RVA = "0x562740", Offset = "0x560F40", Length = "0x83")]
	[Token(Token = "0x60009FB")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x5627D0", Offset = "0x560FD0", Length = "0x140")]
	[Token(Token = "0x60009FC")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x562000", Offset = "0x560800", Length = "0x30")]
	[Token(Token = "0x60009FD")]
	private void AsyncEnable()
	{
	}

	[Token(Token = "0x60009FE")]
	[Address(RVA = "0x562230", Offset = "0x560A30", Length = "0x105")]
	private void FastAllDestroy()
	{
	}

	[Address(RVA = "0x562340", Offset = "0x560B40", Length = "0x8B")]
	[Token(Token = "0x60009FF")]
	private ShopModuleCell GetNewCell(int key)
	{
		return null;
	}

	[Token(Token = "0x6000A00")]
	[Address(RVA = "0x562DE0", Offset = "0x5615E0", Length = "0x1E5")]
	private void RefreshShopUI()
	{
	}

	[Token(Token = "0x6000A01")]
	[Address(RVA = "0x562FD0", Offset = "0x5617D0", Length = "0x7")]
	public void Release(bool isEditor)
	{
	}

	[Address(RVA = "0x5623D0", Offset = "0x560BD0", Length = "0xA6")]
	[Token(Token = "0x6000A02")]
	public void MoveScrollLeft(bool doMove)
	{
	}

	[Token(Token = "0x6000A03")]
	[Address(RVA = "0x562480", Offset = "0x560C80", Length = "0xA6")]
	public void MoveScrollRight(bool doMove)
	{
	}

	[Token(Token = "0x6000A04")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlShop()
	{
	}
}
