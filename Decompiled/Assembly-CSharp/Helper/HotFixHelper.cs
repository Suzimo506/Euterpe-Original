using Assets.Scripts.Database;
using Cpp2ILInjected;

namespace Helper;

[Token(Token = "0x200045A")]
public static class HotFixHelper
{
	[Token(Token = "0x40017AA")]
	private const long max_download_bytes = 21474836480L;

	[Token(Token = "0x40017AB")]
	private const long auto_download_bytes = 52428800L;

	[Token(Token = "0x600328C")]
	[Address(RVA = "0x5C4F90", Offset = "0x5C3790", Length = "0x19")]
	public static bool DownloadSizeValidCheck(long size)
	{
		return default(bool);
	}

	[Token(Token = "0x600328D")]
	[Address(RVA = "0x5C4F70", Offset = "0x5C3770", Length = "0x11")]
	public static float BytesToMillionBytes(long size)
	{
		return default(float);
	}

	[Address(RVA = "0x5C5580", Offset = "0x5C3D80", Length = "0xB")]
	[Token(Token = "0x600328E")]
	public static bool SizeAllowAutoDownload(long byteSize)
	{
		return default(bool);
	}

	[Token(Token = "0x600328F")]
	[Address(RVA = "0x5C5300", Offset = "0x5C3B00", Length = "0x279")]
	public static string[] GetMusicAssetKeyByMusicInfo(MusicInfo musicInfo)
	{
		return null;
	}

	[Token(Token = "0x6003290")]
	[Address(RVA = "0x5C5180", Offset = "0x5C3980", Length = "0x176")]
	public static string[] GetMusicAssetByAlbumJsonIndex(int jsonIndex)
	{
		return null;
	}

	[Address(RVA = "0x5C5050", Offset = "0x5C3850", Length = "0x123")]
	[Token(Token = "0x6003291")]
	public static string GetDownloadInfoByMusicInfo(MusicInfo musicInfo)
	{
		return null;
	}

	[Address(RVA = "0x5C4FB0", Offset = "0x5C37B0", Length = "0x9F")]
	[Token(Token = "0x6003292")]
	public static string GetAlbumLocalName(MusicInfo musicInfo)
	{
		return null;
	}
}
