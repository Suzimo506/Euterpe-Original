using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Assets.Scripts.PeroTools.GeneralLocalization;

[ExecuteInEditMode]
[Token(Token = "0x2000656")]
public class Localization : SerializedMonoBehaviour
{
	[NonSerialized]
	[Token(Token = "0x40023AF")]
	[FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public OptionEntry lastActiveOptionEntry;

	[Token(Token = "0x40023B0")]
	[FieldOffset(Offset = "0x60")]
	private LocalizationSettings m_Manager;

	[Token(Token = "0x40023B1")]
	[FieldOffset(Offset = "0x68")]
	public List<OptionPair> optionPairs;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40023B2")]
	public SchemeEntry selectedSchemeEntry;

	[Token(Token = "0x40023B3")]
	[FieldOffset(Offset = "0x78")]
	public Source source;

	[Token(Token = "0x40023B4")]
	[FieldOffset(Offset = "0x80")]
	public Type sourceType;

	[Token(Token = "0x6003D22")]
	[Address(RVA = "0x7609F0", Offset = "0x75F1F0", Length = "0x13E")]
	public Option GetOption(OptionEntry entry)
	{
		return null;
	}

	[Token(Token = "0x6003D23")]
	[Address(RVA = "0x760910", Offset = "0x75F110", Length = "0xD1")]
	public OptionEntry FindEntry(Option option)
	{
		return null;
	}

	[Token(Token = "0x6003D24")]
	[Address(RVA = "0x7605C0", Offset = "0x75EDC0", Length = "0x34D")]
	public void ApplySchemeOption(SchemeEntry schemeEntry, OptionEntry optionEntry)
	{
	}

	[Token(Token = "0x6003D25")]
	[Address(RVA = "0x760C10", Offset = "0x75F410", Length = "0x67")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x760B30", Offset = "0x75F330", Length = "0xD5")]
	[Token(Token = "0x6003D26")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x760C80", Offset = "0x75F480", Length = "0xF2")]
	[Token(Token = "0x6003D27")]
	public Localization()
	{
	}
}
