using System.Collections.Generic;
using Cpp2ILInjected;
using PeroTools.Saves;

namespace Platforms;

[Token(Token = "0x20001DA")]
public class StandalonePrefsHandler : PrefsHandler
{
	[Token(Token = "0x4000BB8")]
	[FieldOffset(Offset = "0x10")]
	private string m_SaveLocation;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000BB9")]
	private Dictionary<string, string> m_Content;

	[Address(RVA = "0x505580", Offset = "0x503D80", Length = "0x144")]
	[Token(Token = "0x6000D69")]
	public StandalonePrefsHandler()
	{
	}

	[Address(RVA = "0x505410", Offset = "0x503C10", Length = "0x95")]
	[Token(Token = "0x6000D6A")]
	private void LoadContent()
	{
	}

	[Address(RVA = "0x5054B0", Offset = "0x503CB0", Length = "0x56")]
	[Token(Token = "0x6000D6B")]
	private void SaveContent()
	{
	}

	[Address(RVA = "0x505510", Offset = "0x503D10", Length = "0x62")]
	[Token(Token = "0x6000D6C")]
	public override void SaveString(string key, string s)
	{
	}

	[Token(Token = "0x6000D6D")]
	[Address(RVA = "0x5053A0", Offset = "0x503BA0", Length = "0x66")]
	public override string GetString(string key)
	{
		return null;
	}

	[Token(Token = "0x6000D6E")]
	[Address(RVA = "0x505330", Offset = "0x503B30", Length = "0x6F")]
	public override void Delete(string key)
	{
	}

	[Address(RVA = "0x5054B0", Offset = "0x503CB0", Length = "0x56")]
	[Token(Token = "0x6000D6F")]
	public override void Save()
	{
	}

	[Address(RVA = "0x5052D0", Offset = "0x503AD0", Length = "0x57")]
	[Token(Token = "0x6000D70")]
	public override void ClearAllPrefs()
	{
	}
}
