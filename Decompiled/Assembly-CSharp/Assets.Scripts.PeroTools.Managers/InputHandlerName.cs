using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Managers;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x200064A")]
public struct InputHandlerName
{
	[Token(Token = "0x4002360")]
	public const string windows_ps4 = "Sony";

	[Token(Token = "0x4002361")]
	public const string windows_ps5 = "Sony DualShock";

	[Token(Token = "0x4002362")]
	public const string osx_ps5 = "DualSense";

	[Token(Token = "0x4002363")]
	public const string windows_xbox = "XInput";

	[Token(Token = "0x4002364")]
	public const string osx_xbox = "Xbox";

	[Token(Token = "0x4002365")]
	public const string windows_switch = "Pro Controller";

	[Token(Token = "0x4002366")]
	public const string osx_switch = "Nintendo Switch";

	[Token(Token = "0x4002367")]
	public const string windows_custom = "YuanCon";
}
