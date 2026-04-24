using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Assets.Scripts.Purchase;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x20006BD")]
public struct IAPArgDefines
{
	[Token(Token = "0x400245B")]
	public const uint none = 0u;

	[Token(Token = "0x400245C")]
	public const uint hide_ui_tip = 1u;
}
