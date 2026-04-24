using Cpp2ILInjected;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000937")]
internal struct PnlDlcMusicInfo
{
	[Token(Token = "0x400318F")]
	[FieldOffset(Offset = "0x0")]
	internal string localAlbumName;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4003190")]
	internal string localMusicName;
}
