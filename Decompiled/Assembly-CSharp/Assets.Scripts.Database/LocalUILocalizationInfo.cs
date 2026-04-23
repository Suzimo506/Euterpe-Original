using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007FA")]
public class LocalUILocalizationInfo : BaseDataObject
{
	[Token(Token = "0x40029A0")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, string> m_UiLocalization;

	[Address(RVA = "0x483E40", Offset = "0x482640", Length = "0xC")]
	[Token(Token = "0x600486A")]
	public void InitLocal(Dictionary<string, string> dic)
	{
	}

	[Address(RVA = "0x4A0360", Offset = "0x49EB60", Length = "0x62")]
	[Token(Token = "0x600486B")]
	public bool TryGetValue(string key, out string value)
	{
		value = null;
		return default(bool);
	}

	[Address(RVA = "0x4A02D0", Offset = "0x49EAD0", Length = "0x86")]
	[Token(Token = "0x600486C")]
	public string TryGetValue(string key)
	{
		return null;
	}

	[Token(Token = "0x600486D")]
	[Address(RVA = "0x4A0250", Offset = "0x49EA50", Length = "0x73")]
	public string GetSceneName(string scene)
	{
		return null;
	}

	[Token(Token = "0x600486E")]
	[Address(RVA = "0x4A01A0", Offset = "0x49E9A0", Length = "0xAA")]
	public string GetDiff(int index)
	{
		return null;
	}

	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	[Token(Token = "0x600486F")]
	public LocalUILocalizationInfo()
	{
	}
}
