using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000136")]
public class SelectedItemHandle : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400079D")]
	public List<Graphic> listGraphic;

	[Token(Token = "0x400079E")]
	[FieldOffset(Offset = "0x20")]
	public Color selectedColor;

	[Token(Token = "0x400079F")]
	[FieldOffset(Offset = "0x30")]
	public Color unSelectedColor;

	[Token(Token = "0x40007A0")]
	private static Action OnRefreshCurSelectColor;

	[Token(Token = "0x60008C6")]
	[Address(RVA = "0x62C7F0", Offset = "0x62AFF0", Length = "0xBA")]
	private void Awake()
	{
	}

	[Address(RVA = "0x62CB20", Offset = "0x62B320", Length = "0x7")]
	[Token(Token = "0x60008C7")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x62C970", Offset = "0x62B170", Length = "0x1A7")]
	[Token(Token = "0x60008C8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60008C9")]
	[Address(RVA = "0x62C8B0", Offset = "0x62B0B0", Length = "0xBA")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60008CA")]
	[Address(RVA = "0x62CE30", Offset = "0x62B630", Length = "0x45")]
	public void RefreshAllItem()
	{
	}

	[Token(Token = "0x60008CB")]
	[Address(RVA = "0x62CB30", Offset = "0x62B330", Length = "0x2FB")]
	private void RefeshCurColor()
	{
	}

	[Address(RVA = "0x62CE80", Offset = "0x62B680", Length = "0xC5")]
	[Token(Token = "0x60008CC")]
	private void SetColor(Graphic graphic, Color color)
	{
	}

	[Token(Token = "0x60008CD")]
	[Address(RVA = "0x62CF50", Offset = "0x62B750", Length = "0x69")]
	public SelectedItemHandle()
	{
	}
}
