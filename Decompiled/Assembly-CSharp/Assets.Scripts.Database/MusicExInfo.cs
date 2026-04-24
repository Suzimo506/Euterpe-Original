using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000789")]
public struct MusicExInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40027C9")]
	public int m_AlbumIndex;

	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40027CA")]
	public int m_AlbumUidIndex;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40027CB")]
	public int m_MusicIndex;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40027CC")]
	public string m_AlbumUidName;

	[Token(Token = "0x40027CD")]
	[FieldOffset(Offset = "0x18")]
	public string m_AlbumJsonName;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40027CE")]
	public int[] m_ChangedDiff;
}
