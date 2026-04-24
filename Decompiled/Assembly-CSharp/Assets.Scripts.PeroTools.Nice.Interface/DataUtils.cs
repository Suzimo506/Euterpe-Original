using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Nice.Interface;

[Token(Token = "0x20005E7")]
public static class DataUtils
{
	[Address(RVA = "0x9787D0", Offset = "0x976FD0", Length = "0x94")]
	[Token(Token = "0x6003A14")]
	public static bool Exists(this IData data, string uid)
	{
		return default(bool);
	}

	[Token(Token = "0x6003A15")]
	[Address(RVA = "0x913080", Offset = "0x911880", Length = "0x374")]
	public static T Get<T>(this IData data)
	{
		return (T)null;
	}

	[Address(RVA = "0x978750", Offset = "0x976F50", Length = "0x77")]
	[Token(Token = "0x6003A16")]
	public static void Set(this IData data, string uid, IVariable variable)
	{
	}

	[Token(Token = "0x6003A17")]
	[Address(RVA = "0x978870", Offset = "0x977070", Length = "0x1DD")]
	public static IVariable Get(this IData data, string uid)
	{
		return null;
	}
}
