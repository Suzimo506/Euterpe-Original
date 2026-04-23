using System;
using Assets.Scripts.GameCore.Interface;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Controls;

[Token(Token = "0x20001D1")]
public class CommonMessageBox : BaseMessageBox, IInitialization
{
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000B8F")]
	public Button btnDefaultClose;

	[Token(Token = "0x4000B90")]
	private static CommonMessageBox s_Instance;

	[SerializeField]
	[Token(Token = "0x4000B91")]
	[FieldOffset(Offset = "0xF8")]
	private RectTransform imgBgRect;

	[Token(Token = "0x4000B92")]
	[SerializeField]
	[FieldOffset(Offset = "0x100")]
	private RectTransform[] m_BtnLayoutRects;

	[SerializeField]
	[Token(Token = "0x4000B93")]
	[FieldOffset(Offset = "0x108")]
	private Text[] textComponents;

	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000B94")]
	private Font m_DefaultLanguageFont;

	[Token(Token = "0x4000B95")]
	[FieldOffset(Offset = "0x118")]
	private Font m_KoreanFont;

	[Token(Token = "0x4000B96")]
	[FieldOffset(Offset = "0x120")]
	private Font m_EnglishFont;

	[Address(RVA = "0x509FF0", Offset = "0x5087F0", Length = "0xF2")]
	[Token(Token = "0x6000D16")]
	public static CommonMessageBox ShowOnlyWindowWithShut(string msg)
	{
		return null;
	}

	[Address(RVA = "0x50A0F0", Offset = "0x5088F0", Length = "0x8F")]
	[Token(Token = "0x6000D17")]
	public static CommonMessageBox ShowOnlyWindow(string msg)
	{
		return null;
	}

	[Address(RVA = "0x509BD0", Offset = "0x5083D0", Length = "0x13F")]
	[Token(Token = "0x6000D18")]
	public static CommonMessageBox ShowConfirm(string msg, Action onYesAct, bool shutEnable = true)
	{
		return null;
	}

	[Token(Token = "0x6000D19")]
	[Address(RVA = "0x509EA0", Offset = "0x5086A0", Length = "0x14A")]
	public static CommonMessageBox ShowConfrimAndCancel(string msg, Action onYesAct, Action onCancelAct = null)
	{
		return null;
	}

	[Token(Token = "0x6000D1A")]
	[Address(RVA = "0x509D10", Offset = "0x508510", Length = "0x189")]
	public static CommonMessageBox ShowConfrimAndCancelWithShut(string msg, Action onYesAct, Action onCancelAct = null)
	{
		return null;
	}

	[Address(RVA = "0x50A180", Offset = "0x508980", Length = "0x400")]
	[Token(Token = "0x6000D1B")]
	private static void Show(string msg)
	{
	}

	[Address(RVA = "0x509710", Offset = "0x507F10", Length = "0x1B5")]
	[Token(Token = "0x6000D1C")]
	public void OnAwake()
	{
	}

	[Address(RVA = "0x509950", Offset = "0x508150", Length = "0x13C")]
	[Token(Token = "0x6000D1D")]
	public void OnStart()
	{
	}

	[Address(RVA = "0x5098D0", Offset = "0x5080D0", Length = "0x79")]
	[Token(Token = "0x6000D1E")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000D1F")]
	[Address(RVA = "0x509640", Offset = "0x507E40", Length = "0x7")]
	public new void Destroy()
	{
	}

	[Token(Token = "0x6000D20")]
	[Address(RVA = "0x509A90", Offset = "0x508290", Length = "0x3A")]
	public void ResetImgBgSize(Vector2 newSize)
	{
	}

	[Address(RVA = "0x509650", Offset = "0x507E50", Length = "0xB7")]
	[Token(Token = "0x6000D21")]
	public void ForceRebuildBtnLayouts()
	{
	}

	[Address(RVA = "0x509AD0", Offset = "0x5082D0", Length = "0xF7")]
	[Token(Token = "0x6000D22")]
	private void ResetTransform()
	{
	}

	[Token(Token = "0x6000D23")]
	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	public CommonMessageBox()
	{
	}
}
