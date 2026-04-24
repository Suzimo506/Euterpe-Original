using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001A5")]
public class SwitchLanguage : MonoBehaviour
{
	[Token(Token = "0x4000A4D")]
	[FieldOffset(Offset = "0x18")]
	private List<string> m_Options;

	[Token(Token = "0x4000A4E")]
	[FieldOffset(Offset = "0x20")]
	private IVariable m_SaveVal;

	[Token(Token = "0x4000A4F")]
	[FieldOffset(Offset = "0x28")]
	private int m_SelectedInd;

	[Address(RVA = "0x51BA00", Offset = "0x51A200", Length = "0x5E")]
	[Token(Token = "0x6000BE9")]
	private void Awake()
	{
	}

	[Address(RVA = "0x51BA60", Offset = "0x51A260", Length = "0x194")]
	[Token(Token = "0x6000BEA")]
	private void Init()
	{
	}

	[Address(RVA = "0x51BC00", Offset = "0x51A400", Length = "0x17A")]
	[Token(Token = "0x6000BEB")]
	private void Update()
	{
	}

	[Token(Token = "0x6000BEC")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public SwitchLanguage()
	{
	}
}
