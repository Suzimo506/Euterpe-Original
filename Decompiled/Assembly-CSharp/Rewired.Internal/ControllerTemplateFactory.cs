using System;
using Cpp2ILInjected;

namespace Rewired.Internal;

[Token(Token = "0x20001F0")]
public static class ControllerTemplateFactory
{
	[Token(Token = "0x4000D8A")]
	private static readonly Type[] _defaultTemplateTypes;

	[Token(Token = "0x4000D8B")]
	private static readonly Type[] _defaultTemplateInterfaceTypes;

	[Token(Token = "0x17000315")]
	public static Type[] templateTypes
	{
		[Token(Token = "0x600103E")]
		[Address(RVA = "0x89AFC0", Offset = "0x8997C0", Length = "0x2F7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000316")]
	public static Type[] templateInterfaceTypes
	{
		[Address(RVA = "0x89AF60", Offset = "0x899760", Length = "0x57")]
		[Token(Token = "0x600103F")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x89A600", Offset = "0x898E00", Length = "0x3B3")]
	[Token(Token = "0x6001040")]
	public static IControllerTemplate Create(Guid typeGuid, object payload)
	{
		return null;
	}
}
