using System;
using Assets.Scripts.PeroTools.Nice.Components;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Structs;

[Serializable]
[Token(Token = "0x2000570")]
public struct FsvCompsFromUi
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400200D")]
	public Color enableBtnColor;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400200E")]
	public Color disableBtnColor;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400200F")]
	public Color enableBgColor;

	[Token(Token = "0x4002010")]
	[FieldOffset(Offset = "0x30")]
	public Color disableBgColor;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002011")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView fsv;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002012")]
	public Button prevBtn;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002013")]
	public Button nextBtn;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002014")]
	public Image fsvBackground;

	[Token(Token = "0x4002015")]
	[FieldOffset(Offset = "0x60")]
	private bool m_Enable;

	[Address(RVA = "0x655F70", Offset = "0x654770", Length = "0x294")]
	[Token(Token = "0x600384F")]
	public void ToggleColor(bool enable)
	{
	}
}
