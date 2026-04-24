using System;
using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x200075D")]
public struct WeekFreeExInfo
{
	[Token(Token = "0x40026F9")]
	[FieldOffset(Offset = "0x0")]
	public string[] m_FreeSongUids;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40026FA")]
	public string[] m_FreeAlbumUids;

	[Token(Token = "0x40026FB")]
	[FieldOffset(Offset = "0x10")]
	public int[] m_FreeAlbumIndexs;

	[Token(Token = "0x40026FC")]
	[FieldOffset(Offset = "0x18")]
	public DateTime m_UpdateTime;

	[Address(RVA = "0x7E0AF0", Offset = "0x7DF2F0", Length = "0x3B6")]
	[Token(Token = "0x6004522")]
	public void InitExInfo()
	{
	}
}
