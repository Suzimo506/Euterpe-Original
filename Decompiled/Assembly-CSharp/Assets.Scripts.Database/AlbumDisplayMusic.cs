using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000815")]
public class AlbumDisplayMusic
{
	[Token(Token = "0x4002A1F")]
	[FieldOffset(Offset = "0x10")]
	public string displayTitle;

	[Token(Token = "0x4002A20")]
	[FieldOffset(Offset = "0x18")]
	public DBConfigAlbums.AlbumsInfo albumInfo;

	[Token(Token = "0x4002A21")]
	[FieldOffset(Offset = "0x20")]
	private readonly List<string> musicUids;

	[Token(Token = "0x17000777")]
	public int count
	{
		[Token(Token = "0x600494A")]
		[Address(RVA = "0x6EF0B0", Offset = "0x6ED8B0", Length = "0x3B")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6004947")]
	[Address(RVA = "0x6EEE50", Offset = "0x6ED650", Length = "0xB2")]
	~AlbumDisplayMusic()
	{
	}

	[Token(Token = "0x6004948")]
	[Address(RVA = "0x6EEF90", Offset = "0x6ED790", Length = "0x87")]
	public AlbumDisplayMusic(string title)
	{
	}

	[Token(Token = "0x6004949")]
	[Address(RVA = "0x6EF020", Offset = "0x6ED820", Length = "0x87")]
	public AlbumDisplayMusic(DBConfigAlbums.AlbumsInfo album)
	{
	}

	[Token(Token = "0x600494B")]
	[Address(RVA = "0x6EEDF0", Offset = "0x6ED5F0", Length = "0x55")]
	public void Clear()
	{
	}

	[Token(Token = "0x600494C")]
	[Address(RVA = "0x6EED20", Offset = "0x6ED520", Length = "0x6F")]
	public void AddMusicUid(string uid)
	{
	}

	[Token(Token = "0x600494D")]
	[Address(RVA = "0x6EEF10", Offset = "0x6ED710", Length = "0x79")]
	public void GetMusicUids(List<string> buffer, bool clear = false)
	{
	}

	[Token(Token = "0x600494E")]
	[Address(RVA = "0x6EED90", Offset = "0x6ED590", Length = "0x58")]
	public void AddRangeMusicUid(List<string> uids)
	{
	}
}
