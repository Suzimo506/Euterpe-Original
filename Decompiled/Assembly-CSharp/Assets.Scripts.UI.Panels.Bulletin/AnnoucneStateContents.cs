using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.Panels.Bulletin;

[Token(Token = "0x200094D")]
public struct AnnoucneStateContents
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40032AF")]
	public AnnouncesRequestState state;

	[Token(Token = "0x40032B0")]
	[FieldOffset(Offset = "0x8")]
	public long resultCode;

	[Token(Token = "0x40032B1")]
	[FieldOffset(Offset = "0x10")]
	public bool isRandomShow;

	[Token(Token = "0x40032B2")]
	[FieldOffset(Offset = "0x18")]
	public Dictionary<string, List<string>> contents;
}
