using System;
using Assets.Scripts.UI;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[Token(Token = "0x2000153")]
public class ToggleDifficultySongFilter
{
	[Token(Token = "0x400083B")]
	[HideInInspector]
	[FieldOffset(Offset = "0x10")]
	public int index;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400083C")]
	public Text txtCondition;

	[Token(Token = "0x400083D")]
	[FieldOffset(Offset = "0x20")]
	public DifficultyFilterDefines filterType;

	[Token(Token = "0x400083E")]
	[FieldOffset(Offset = "0x28")]
	public ToggleWithClickEvent toggle;

	[Token(Token = "0x400083F")]
	[FieldOffset(Offset = "0x30")]
	public Color normalTxtColor;

	[Token(Token = "0x4000840")]
	[FieldOffset(Offset = "0x40")]
	public Color selectTxtColor;

	[Token(Token = "0x4000841")]
	[FieldOffset(Offset = "0x50")]
	public GameObject selectedOutline;

	[Token(Token = "0x4000842")]
	[FieldOffset(Offset = "0x58")]
	private Text[] m_TxtContents;

	[Token(Token = "0x4000843")]
	[FieldOffset(Offset = "0x60")]
	private Outline m_ToggleOnOutline;

	[Address(RVA = "0x51F2B0", Offset = "0x51DAB0", Length = "0x94")]
	[Token(Token = "0x600098B")]
	public void Init()
	{
	}

	[Token(Token = "0x600098C")]
	[Address(RVA = "0x51F390", Offset = "0x51DB90", Length = "0xAD")]
	public void OnToggleStateChanged(bool isOn)
	{
	}

	[Address(RVA = "0x51F350", Offset = "0x51DB50", Length = "0x36")]
	[Token(Token = "0x600098D")]
	public void OnSelectStateChanged(bool isSelected)
	{
	}

	[Token(Token = "0x600098E")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public ToggleDifficultySongFilter()
	{
	}
}
