using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace DaveGameFramework.GameComponents.AnimaControl;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x20004D6")]
public struct DaveGameAnimationDefines
{
	[Token(Token = "0x4001A5C")]
	public const string prefix_atk = "atk";

	[Token(Token = "0x4001A5D")]
	public const string atk_light = "atk_L";

	[Token(Token = "0x4001A5E")]
	public const string atk_heavy = "atk_H";

	[Token(Token = "0x4001A5F")]
	public const string stand_by = "standby";

	[Token(Token = "0x4001A60")]
	public const string prefix_start = "start";

	[Token(Token = "0x4001A61")]
	public const string prefix_win = "win";

	[Token(Token = "0x4001A62")]
	public const string prefix_lose = "lose";
}
