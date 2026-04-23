using System.Text;
using Cpp2ILInjected;

[Token(Token = "0x20001AF")]
public static class DebugUtils
{
	[Token(Token = "0x2000A54")]
	public enum LogType
	{
		[Token(Token = "0x40036B8")]
		Normal,
		[Token(Token = "0x40036B9")]
		Warning,
		[Token(Token = "0x40036BA")]
		Error
	}

	[Token(Token = "0x4000A7E")]
	private static StringBuilder m_StringBuilder;

	[Token(Token = "0x4000A7F")]
	private static string m_Title;

	[Address(RVA = "0x99DF70", Offset = "0x99C770", Length = "0xE1")]
	[Token(Token = "0x6000C17")]
	public static void RestartWithNewTitle(string title)
	{
	}

	[Address(RVA = "0x99DE50", Offset = "0x99C650", Length = "0x74")]
	[Token(Token = "0x6000C18")]
	public static void Append(string log)
	{
	}

	[Token(Token = "0x6000C19")]
	[Address(RVA = "0x99DED0", Offset = "0x99C6D0", Length = "0x92")]
	public static void End(LogType type)
	{
	}
}
