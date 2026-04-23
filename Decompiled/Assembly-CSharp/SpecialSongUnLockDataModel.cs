using System.Collections.Generic;
using Assets.Scripts.Database;
using Cpp2ILInjected;

[Token(Token = "0x2000024")]
public class SpecialSongUnLockDataModel : DataModel
{
	[Token(Token = "0x40000A2")]
	public const string echoes_of_seraphim_locked_cover = "echoes_of_seraphim_cover_locked";

	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0x10")]
	private DBConfigAlbums m_AlbumsInfo;

	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, List<string>> m_CompleteArchiDic;

	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x20")]
	private List<string> m_UnlockedSpecialSongUids;

	[Token(Token = "0x17000020")]
	public Dictionary<string, List<string>> CompleteArchiDic
	{
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000021")]
	public List<string> UnlockedSpecialSongUids
	{
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x6346B0", Offset = "0x632EB0", Length = "0x159")]
	[Token(Token = "0x60000F5")]
	public override void Init()
	{
	}

	[Address(RVA = "0x634130", Offset = "0x632930", Length = "0x74")]
	[Token(Token = "0x60000F6")]
	public static bool CheckIsSpecialSong(string songUid)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x634490", Offset = "0x632C90", Length = "0x104")]
	public static bool CheckSpecialSongIsUnlocked(string songUid)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x634610", Offset = "0x632E10", Length = "0x9B")]
	public static string GetSpecialSongLockedCoverName(string songUid)
	{
		return null;
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x633EB0", Offset = "0x6326B0", Length = "0x272")]
	public bool CheckCanUnlockSpecialSong(string songUid)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x634810", Offset = "0x633010", Length = "0xB3")]
	public void SaveSpecialUnlockSongToAccount(string songUid)
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x6345A0", Offset = "0x632DA0", Length = "0x64")]
	public string GetLockedTip(string songUid)
	{
		return null;
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x6341B0", Offset = "0x6329B0", Length = "0x2DD")]
	private bool CheckSongUnlock_87_5(DBConfigAlbums.AlbumsInfo albumInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	public SpecialSongUnLockDataModel()
	{
	}
}
