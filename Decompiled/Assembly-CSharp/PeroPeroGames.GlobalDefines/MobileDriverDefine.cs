using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[Token(Token = "0x2000519")]
public static class MobileDriverDefine
{
	[Token(Token = "0x4001CC6")]
	private static string[] s_AudioTearingDriverModels;

	[Token(Token = "0x6003737")]
	[Address(RVA = "0x4F5BA0", Offset = "0x4F43A0", Length = "0x6A")]
	public static bool CheckAudioTearing(string driverModel)
	{
		return default(bool);
	}
}
