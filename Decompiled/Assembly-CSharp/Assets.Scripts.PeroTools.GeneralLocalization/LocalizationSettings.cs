using System;
using System.Collections.Generic;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.GeneralLocalization;

[Token(Token = "0x2000657")]
public class LocalizationSettings : SingletonScriptableObject<LocalizationSettings>
{
	[NonSerialized]
	[Token(Token = "0x40023B5")]
	[FieldOffset(Offset = "0x58")]
	private List<Localization> m_GlobalConfigs;

	[Token(Token = "0x40023B6")]
	[FieldOffset(Offset = "0x60")]
	public List<Scheme> schemes;

	[Token(Token = "0x6003D28")]
	[Address(RVA = "0x760270", Offset = "0x75EA70", Length = "0x212")]
	public void Register(Localization localization)
	{
	}

	[Token(Token = "0x6003D29")]
	[Address(RVA = "0x760490", Offset = "0x75EC90", Length = "0x82")]
	public void UnRegister(Localization localization)
	{
	}

	[Address(RVA = "0x75F910", Offset = "0x75E110", Length = "0x188")]
	[Token(Token = "0x6003D2A")]
	public void ActiveOption(string schemeName, string optionEntryName)
	{
	}

	[Token(Token = "0x6003D2B")]
	[Address(RVA = "0x75FCC0", Offset = "0x75E4C0", Length = "0x236")]
	public void ActiveOption(Scheme scheme, string optionEntryName)
	{
	}

	[Token(Token = "0x6003D2C")]
	[Address(RVA = "0x75FAA0", Offset = "0x75E2A0", Length = "0x21E")]
	public void ActiveOption(SchemeEntry schemeEntry, OptionEntry optionEntry)
	{
	}

	[Token(Token = "0x6003D2D")]
	[Address(RVA = "0x75F5F0", Offset = "0x75DDF0", Length = "0x31F")]
	public void ActiveOptionToLocalization(Localization localization, SchemeEntry schemeEntry, OptionEntry optionEntry)
	{
	}

	[Token(Token = "0x6003D2E")]
	[Address(RVA = "0x7600B0", Offset = "0x75E8B0", Length = "0xFB")]
	public Scheme GetScheme(SchemeEntry entry)
	{
		return null;
	}

	[Token(Token = "0x6003D2F")]
	[Address(RVA = "0x7601B0", Offset = "0x75E9B0", Length = "0xB4")]
	public Scheme GetScheme(string schemeName)
	{
		return null;
	}

	[Token(Token = "0x6003D30")]
	[Address(RVA = "0x75FF00", Offset = "0x75E700", Length = "0x89")]
	public OptionEntry GetActiveOption(SchemeEntry entry)
	{
		return null;
	}

	[Token(Token = "0x6003D31")]
	[Address(RVA = "0x75FF90", Offset = "0x75E790", Length = "0x115")]
	public string GetActiveOption(string schemeName)
	{
		return null;
	}

	[Token(Token = "0x6003D32")]
	[Address(RVA = "0x760520", Offset = "0x75ED20", Length = "0x9D")]
	public LocalizationSettings()
	{
		((SingletonScriptableObject<>)(object)this)._002Ector();
	}
}
