using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.Redot;

[Token(Token = "0x200084D")]
public class RedotsHandler
{
	[Token(Token = "0x4002B4B")]
	private static RedotsHandler s_Handler;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002B4C")]
	private Dictionary<string, IRedot> m_RedotInsResults;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002B4D")]
	private Dictionary<string, List<string>> m_RedotRelationships;

	[Token(Token = "0x17000860")]
	public static RedotsHandler Instance
	{
		[Token(Token = "0x6004C3E")]
		[Address(RVA = "0x6199A0", Offset = "0x6181A0", Length = "0x101")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004C3F")]
	[Address(RVA = "0x619900", Offset = "0x618100", Length = "0x96")]
	private RedotsHandler()
	{
	}

	[Token(Token = "0x6004C40")]
	[Address(RVA = "0x6193D0", Offset = "0x617BD0", Length = "0x188")]
	public void RegistRedot(string redotId, IRedot redot, string parentRedotId = null)
	{
	}

	[Token(Token = "0x6004C41")]
	[Address(RVA = "0x619560", Offset = "0x617D60", Length = "0x6F")]
	public void RemoveRedot(string redotId)
	{
	}

	[Address(RVA = "0x6195D0", Offset = "0x617DD0", Length = "0xBB")]
	[Token(Token = "0x6004C42")]
	public void SetRedotResult(string redotId, bool result)
	{
	}

	[Address(RVA = "0x6192E0", Offset = "0x617AE0", Length = "0x74")]
	[Token(Token = "0x6004C43")]
	public IRedot GetRedotInstance(string redotId)
	{
		return null;
	}

	[Token(Token = "0x6004C44")]
	[Address(RVA = "0x619360", Offset = "0x617B60", Length = "0x64")]
	public bool GetRedotResult(string redotId)
	{
		return default(bool);
	}

	[Token(Token = "0x6004C45")]
	[Address(RVA = "0x619690", Offset = "0x617E90", Length = "0x269")]
	private void UpdateParentRedotResult(string redotId)
	{
	}
}
