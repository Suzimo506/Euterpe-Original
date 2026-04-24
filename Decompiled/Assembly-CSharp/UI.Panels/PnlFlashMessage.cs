using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Panels;

[Token(Token = "0x20001C1")]
public class PnlFlashMessage : MonoBehaviour
{
	[Token(Token = "0x4000B08")]
	public static PnlFlashMessage instance;

	[Token(Token = "0x4000B09")]
	private const string sfx_show = "sfx_crystal";

	[Token(Token = "0x4000B0A")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x54990", Offset = "0x53D90")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float m_PopMsgDuration;

	[SerializeField]
	[Token(Token = "0x4000B0B")]
	[FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x54B50", Offset = "0x53F50")]
	private float m_PopCloseDuration;

	[SerializeField]
	[Token(Token = "0x4000B0C")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_ViewObj;

	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B0D")]
	private Transform m_MsgLayout;

	[Token(Token = "0x4000B0E")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Button m_BtnDone;

	[Token(Token = "0x4000B0F")]
	[SerializeField]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_CreatePopObj;

	[Token(Token = "0x4000B10")]
	[FieldOffset(Offset = "0x40")]
	private List<string> m_CustomMsgs;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000B11")]
	private List<GameObject> m_PopObjects;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B12")]
	private Animator m_ViewAnima;

	[Token(Token = "0x4000B13")]
	[FieldOffset(Offset = "0x58")]
	private bool m_IsMsgOnShow;

	[FieldOffset(Offset = "0x59")]
	[Token(Token = "0x4000B14")]
	private bool m_FlashMsgIsShowing;

	[Address(RVA = "0x50B530", Offset = "0x509D30", Length = "0x198")]
	[Token(Token = "0x6000CA1")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000CA2")]
	[Address(RVA = "0x50B910", Offset = "0x50A110", Length = "0x4")]
	private void OnMessageStateChanged(bool state)
	{
	}

	[Address(RVA = "0x50B4D0", Offset = "0x509CD0", Length = "0x52")]
	[Token(Token = "0x6000CA3")]
	public void AddMsgToList(string msg)
	{
	}

	[Token(Token = "0x6000CA4")]
	[Address(RVA = "0x50B980", Offset = "0x50A180", Length = "0xA4")]
	public void ShowCustomMessages(Action callback = null)
	{
	}

	[Address(RVA = "0x50B920", Offset = "0x50A120", Length = "0x5D")]
	[Token(Token = "0x6000CA5")]
	private void PlayShowSfx()
	{
	}

	[Address(RVA = "0x50B820", Offset = "0x50A020", Length = "0x3C")]
	[Token(Token = "0x6000CA6")]
	private void ClosePop()
	{
	}

	[Address(RVA = "0x50B6D0", Offset = "0x509ED0", Length = "0x14B")]
	[Token(Token = "0x6000CA7")]
	private void ClearPopObjs()
	{
	}

	[Address(RVA = "0x50B860", Offset = "0x50A060", Length = "0xA9")]
	[Token(Token = "0x6000CA8")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x50BAB0", Offset = "0x50A2B0", Length = "0x15")]
	[Token(Token = "0x6000CA9")]
	public PnlFlashMessage()
	{
	}
}
