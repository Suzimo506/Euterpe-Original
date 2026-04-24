using System.Collections.Generic;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[Token(Token = "0x200050C")]
public static class DBMusicTagDefine
{
	[Token(Token = "0x4001C61")]
	private static string[] s_NewAheadMusicUids;

	[Token(Token = "0x4001C62")]
	private static int[] s_NewAlbumUids;

	[Token(Token = "0x4001C63")]
	private static string[] s_NewMusicUids;

	[Token(Token = "0x4001C64")]
	public static string[] s_HiddenLocal;

	[Token(Token = "0x4001C65")]
	private static string[] s_BarrageModeSongUid;

	[Token(Token = "0x4001C66")]
	private static string[] s_CullingMusicUids;

	[Token(Token = "0x4001C67")]
	private static string[] s_CryptonRinLenEggSongUids;

	[Token(Token = "0x4001C68")]
	private static string[] s_ArknightsDayNightEggSongUids;

	[Token(Token = "0x17000506")]
	public static string[] newAheadMusicUids
	{
		[Address(RVA = "0x4F3220", Offset = "0x4F1A20", Length = "0xB6")]
		[Token(Token = "0x6003722")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000507")]
	public static int[] newAlbumUids
	{
		[Token(Token = "0x6003723")]
		[Address(RVA = "0x4F32E0", Offset = "0x4F1AE0", Length = "0x173")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000508")]
	public static string[] newMusicUids
	{
		[Address(RVA = "0x4F3460", Offset = "0x4F1C60", Length = "0x389")]
		[Token(Token = "0x6003724")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000509")]
	public static int cullingMusicCount
	{
		[Address(RVA = "0x4F31B0", Offset = "0x4F19B0", Length = "0x64")]
		[Token(Token = "0x6003725")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600371E")]
	[Address(RVA = "0x4EEEB0", Offset = "0x4ED6B0", Length = "0x6B")]
	public static bool IsContainsBarrageSong(string uid)
	{
		return default(bool);
	}

	[Address(RVA = "0x4EECF0", Offset = "0x4ED4F0", Length = "0x6B")]
	[Token(Token = "0x600371F")]
	public static int GetBarrageIndex(string uid)
	{
		return default(int);
	}

	[Token(Token = "0x6003720")]
	[Address(RVA = "0x4EEF20", Offset = "0x4ED720", Length = "0x237")]
	public static bool IsCullingMusicUid(string uid)
	{
		return default(bool);
	}

	[Token(Token = "0x6003721")]
	[Address(RVA = "0x4EEA90", Offset = "0x4ED290", Length = "0x143")]
	public static void GetAllHiddenMusicUids(List<string> buffer, bool normalHide, bool touhou)
	{
	}

	[Address(RVA = "0x4EF330", Offset = "0x4EDB30", Length = "0x6B")]
	[Token(Token = "0x6003726")]
	public static bool IsRinLenEggSong(string uid)
	{
		return default(bool);
	}

	[Token(Token = "0x6003727")]
	[Address(RVA = "0x4EF160", Offset = "0x4ED960", Length = "0x15F")]
	public static bool IsHaveHideBmsStageAchievement()
	{
		return default(bool);
	}

	[Token(Token = "0x6003728")]
	[Address(RVA = "0x4EF2C0", Offset = "0x4EDAC0", Length = "0x6B")]
	public static bool IsMusicUidBelongsToArkNightEgg(string uid)
	{
		return default(bool);
	}

	[Token(Token = "0x6003729")]
	[Address(RVA = "0x4EED60", Offset = "0x4ED560", Length = "0x140")]
	public static string GetSpecialSongBgmName(string bgmName)
	{
		return null;
	}

	[Token(Token = "0x600372A")]
	[Address(RVA = "0x4EEBE0", Offset = "0x4ED3E0", Length = "0x109")]
	public static string GetArknightNotShowDayNightEggUid()
	{
		return null;
	}
}
