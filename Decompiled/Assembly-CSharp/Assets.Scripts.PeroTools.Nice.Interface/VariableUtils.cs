using System;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Nice.Interface;

[Token(Token = "0x20005EB")]
public static class VariableUtils
{
	[Token(Token = "0x6003A20")]
	[Address(RVA = "0x989360", Offset = "0x987B60", Length = "0x1F9")]
	public static void SetResult(this IVariable data, object value)
	{
	}

	[Token(Token = "0x6003A21")]
	[Address(RVA = "0x988E40", Offset = "0x987640", Length = "0x483")]
	public static object GetResult(this IVariable data, Type type)
	{
		return null;
	}

	[Token(Token = "0x6003A22")]
	[Address(RVA = "0x9207D0", Offset = "0x91EFD0", Length = "0x5DC")]
	public static T GetResult<T>(this IVariable data)
	{
		return (T)null;
	}

	[Token(Token = "0x6003A23")]
	[Address(RVA = "0x988850", Offset = "0x987050", Length = "0x1D4")]
	public static IValue CreateIValue(Type resultType)
	{
		return null;
	}

	[Token(Token = "0x6003A24")]
	[Address(RVA = "0x988A30", Offset = "0x987230", Length = "0x405")]
	public static IValue CreateIValue(object result)
	{
		return null;
	}

	[Address(RVA = "0x989560", Offset = "0x987D60", Length = "0x85")]
	[Token(Token = "0x6003A25")]
	public static void Set(this IVariable variable, string name, object value)
	{
	}

	[Token(Token = "0x6003A26")]
	[Address(RVA = "0x9892D0", Offset = "0x987AD0", Length = "0x8A")]
	public static object Get(this IVariable variable, string name)
	{
		return null;
	}
}
