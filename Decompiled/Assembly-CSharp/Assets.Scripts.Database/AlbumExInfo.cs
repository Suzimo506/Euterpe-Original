using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x200078D")]
public struct AlbumExInfo
{
	[Token(Token = "0x40027EE")]
	[FieldOffset(Offset = "0x0")]
	public int m_AlbumJsonIdx;

	[Token(Token = "0x40027EF")]
	[FieldOffset(Offset = "0x4")]
	public int m_AlbumUidIdx;
}
