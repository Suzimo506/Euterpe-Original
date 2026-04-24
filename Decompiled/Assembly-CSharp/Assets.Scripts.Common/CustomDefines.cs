using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Common;

[Token(Token = "0x200097C")]
public class CustomDefines
{
	[Token(Token = "0x4003400")]
	public static readonly Dictionary<string, object> entities;

	[Token(Token = "0x4003401")]
	public static readonly Dictionary<string, object> events;

	[Token(Token = "0x600566C")]
	[Address(RVA = "0x597CA0", Offset = "0x5964A0", Length = "0xDC")]
	public static void Login()
	{
	}

	[Token(Token = "0x600566D")]
	[Address(RVA = "0x597D80", Offset = "0x596580", Length = "0xB8")]
	public static void Logout()
	{
	}

	[Address(RVA = "0x912AB0", Offset = "0x9112B0", Length = "0x12D")]
	[Token(Token = "0x600566E")]
	public static T GetEntityValue<T>(string key)
	{
		return (T)null;
	}

	[Address(RVA = "0x912BE0", Offset = "0x9113E0", Length = "0x141")]
	[Token(Token = "0x600566F")]
	public static T GetEntityValue<T>(string key, object[] param)
	{
		return (T)null;
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6005670")]
	public CustomDefines()
	{
	}
}
