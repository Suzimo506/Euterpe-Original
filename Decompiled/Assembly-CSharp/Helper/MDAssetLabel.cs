using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Helper;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x200045B")]
public struct MDAssetLabel
{
	[Token(Token = "0x40017AC")]
	public const string optional_download = "optional_download";

	[Token(Token = "0x40017AD")]
	public const string mandatory_update = "mandatory_update";
}
