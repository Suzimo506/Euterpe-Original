using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Specials;

[Token(Token = "0x200087A")]
public class SwitchLanguages : MonoBehaviour
{
	[Token(Token = "0x4002C3D")]
	[FieldOffset(Offset = "0x18")]
	public Button btnSwitch;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002C3E")]
	public Text langText;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002C3F")]
	public GameObject btnShop;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002C40")]
	private List<string> m_Options;

	[Token(Token = "0x4002C41")]
	[FieldOffset(Offset = "0x38")]
	private IVariable m_SaveVal;

	[Token(Token = "0x4002C42")]
	[FieldOffset(Offset = "0x40")]
	private int m_SelectedInd;

	[Address(RVA = "0x61C240", Offset = "0x61AA40", Length = "0x1AA")]
	[Token(Token = "0x6004D48")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004D49")]
	[Address(RVA = "0x61C5C0", Offset = "0x61ADC0", Length = "0x5A")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004D4A")]
	[Address(RVA = "0x61C3F0", Offset = "0x61ABF0", Length = "0x1C7")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6004D4B")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public SwitchLanguages()
	{
	}
}
