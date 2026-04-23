using Cpp2ILInjected;

namespace Assets.Scripts.Platforms.Android;

[Token(Token = "0x20005A7")]
public static class AndroidSystemInfoHelper
{
	[Token(Token = "0x4002106")]
	private static int m_API_Level;

	[Token(Token = "0x60038EF")]
	[Address(RVA = "0x9732F0", Offset = "0x971AF0", Length = "0x19C")]
	public static int GetAPILevel()
	{
		return default(int);
	}

	[Address(RVA = "0x973490", Offset = "0x971C90", Length = "0xDE")]
	[Token(Token = "0x60038F0")]
	private static int RefreshAPILevel(string systemInfo)
	{
		return default(int);
	}
}
