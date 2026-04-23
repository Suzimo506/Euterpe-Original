using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x2000506")]
public struct GlobalDefine
{
	[Token(Token = "0x4001B62")]
	public const long utc_start_time = 621355968000000000L;

	[Token(Token = "0x4001B63")]
	public const bool close_boss_action_check = false;

	[Token(Token = "0x4001B64")]
	public const int collection_bundle_user_dictount = 10;

	[Address(RVA = "0x4F54E0", Offset = "0x4F3CE0", Length = "0x2B")]
	[Token(Token = "0x600371B")]
	public static string GetReturnUiSystem()
	{
		return null;
	}
}
