using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Managers;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x2000648")]
public struct InputMapDefines
{
	[Token(Token = "0x4002350")]
	public const string ui_map = "UI";

	[Token(Token = "0x4002351")]
	public const string battle_map = "Battle";

	[Token(Token = "0x4002352")]
	public const string default_map = "Default";
}
