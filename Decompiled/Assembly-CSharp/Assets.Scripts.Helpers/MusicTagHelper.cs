using System.Collections.Generic;
using Assets.Scripts.Database;
using Assets.Scripts.GameCore.Managers;
using Cpp2ILInjected;

namespace Assets.Scripts.Helpers;

[Token(Token = "0x20006E5")]
public static class MusicTagHelper
{
	[Token(Token = "0x4002505")]
	private static bool haveRefreshInvalidMusicUids;

	[Token(Token = "0x4002506")]
	private static List<string> s_InvalidMusicUids;

	[Token(Token = "0x4002507")]
	private static MusicTagDifficultyAdditionalConditionsManager s_AdditionalConditionsMgr;

	[Address(RVA = "0xC861D0", Offset = "0xC849D0", Length = "0xF8")]
	[Token(Token = "0x6004125")]
	public static void InitSongAchievementsIndexList()
	{
	}

	[Address(RVA = "0xC84EB0", Offset = "0xC836B0", Length = "0x32A")]
	[Token(Token = "0x6004126")]
	public static void AllFilter(List<string> buffer, bool isHide = false)
	{
	}

	[Token(Token = "0x6004127")]
	[Address(RVA = "0xC851E0", Offset = "0xC839E0", Length = "0x33E")]
	public static void AllFilter(List<MusicInfo> buffer, bool isHide = false)
	{
	}

	[Address(RVA = "0xC84C60", Offset = "0xC83460", Length = "0x240")]
	[Token(Token = "0x6004128")]
	public static void AllFilterWithAdditionalCondition(List<MusicInfo> buffer)
	{
	}

	[Address(RVA = "0xC856E0", Offset = "0xC83EE0", Length = "0xA0")]
	[Token(Token = "0x6004129")]
	public static void AutoMusicSelectAccordingToAdditionalCondition(DBMusicTag dbMusicTag)
	{
	}

	[Token(Token = "0x600412A")]
	[Address(RVA = "0xC84BE0", Offset = "0xC833E0", Length = "0x7F")]
	public static void AdditionalFilter(List<MusicInfo> buffer, int difficultyIndex)
	{
	}

	[Token(Token = "0x600412B")]
	[Address(RVA = "0xC86B40", Offset = "0xC85340", Length = "0x30F")]
	public static void UpdateAdditionalData(bool isSuccess)
	{
	}

	[Token(Token = "0x600412C")]
	[Address(RVA = "0xC86E50", Offset = "0xC85650", Length = "0xA0")]
	public static void UpdateSongAdditionAchievementData()
	{
	}

	[Address(RVA = "0xC84AE0", Offset = "0xC832E0", Length = "0x6F")]
	[Token(Token = "0x600412D")]
	public static void AddAdditionalCondition(DifficultyFilterDefines condition)
	{
	}

	[Token(Token = "0x600412E")]
	[Address(RVA = "0xC85D20", Offset = "0xC84520", Length = "0xA0")]
	public static DifficultyFilterDefines GetAdditionalConditions()
	{
		return default(DifficultyFilterDefines);
	}

	[Address(RVA = "0xC85CB0", Offset = "0xC844B0", Length = "0x67")]
	[Token(Token = "0x600412F")]
	public static void ClearAdditionalData()
	{
	}

	[Address(RVA = "0xC85DD0", Offset = "0xC845D0", Length = "0x65")]
	[Token(Token = "0x6004130")]
	public static AdditionalConditionSettings GetAdditionalSavedSettingData()
	{
		return null;
	}

	[Token(Token = "0x6004131")]
	[Address(RVA = "0xC86930", Offset = "0xC85130", Length = "0x67")]
	public static void SaveAdditionalSettingData()
	{
	}

	[Address(RVA = "0xC869A0", Offset = "0xC851A0", Length = "0xCD")]
	[Token(Token = "0x6004132")]
	public static void SpecialMusicFilter(List<MusicInfo> buffer)
	{
	}

	[Address(RVA = "0xC86A70", Offset = "0xC85270", Length = "0xC4")]
	[Token(Token = "0x6004133")]
	public static void SpecialMusicFilter(List<string> buffer)
	{
	}

	[Token(Token = "0x6004134")]
	[Address(RVA = "0xC862D0", Offset = "0xC84AD0", Length = "0x19B")]
	public static void InvalidMusicFilter(List<MusicInfo> buffer)
	{
	}

	[Address(RVA = "0xC86620", Offset = "0xC84E20", Length = "0xB0")]
	[Token(Token = "0x6004135")]
	public static bool IsMusicInvalid(string musicUid, bool isNeedRefreshInvalidMusicUid = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6004136")]
	[Address(RVA = "0xC86470", Offset = "0xC84C70", Length = "0x1A5")]
	private static void InvalidMusicFilter(List<string> buffer)
	{
	}

	[Token(Token = "0x6004137")]
	[Address(RVA = "0xC85E40", Offset = "0xC84640", Length = "0x1C6")]
	private static void HideFilter(List<MusicInfo> buffer, bool isHide)
	{
	}

	[Address(RVA = "0xC86010", Offset = "0xC84810", Length = "0x1BD")]
	[Token(Token = "0x6004138")]
	private static void HideFilter(List<string> buffer, bool isHide)
	{
	}

	[Address(RVA = "0xC85610", Offset = "0xC83E10", Length = "0xC7")]
	[Token(Token = "0x6004139")]
	public static void AnchorFilter(List<string> buffer)
	{
	}

	[Address(RVA = "0xC85520", Offset = "0xC83D20", Length = "0xE8")]
	[Token(Token = "0x600413A")]
	public static void AnchorFilter(List<MusicInfo> buffer)
	{
	}

	[Address(RVA = "0xC866E0", Offset = "0xC84EE0", Length = "0x245")]
	[Token(Token = "0x600413B")]
	public static void RefreshInvalidMusicUids()
	{
	}

	[Address(RVA = "0xC85BC0", Offset = "0xC843C0", Length = "0xEF")]
	[Token(Token = "0x600413C")]
	public static bool CheckSkinIsBuy(RoleSkin roleSkin)
	{
		return default(bool);
	}

	[Address(RVA = "0xC85790", Offset = "0xC83F90", Length = "0x8F")]
	[Token(Token = "0x600413D")]
	public static bool CheckAlbumBuyAndUnlock(int jsonIndex)
	{
		return default(bool);
	}

	[Address(RVA = "0xC85820", Offset = "0xC84020", Length = "0x196")]
	[Token(Token = "0x600413E")]
	public static bool CheckAlbumBuyAndUnlock(DBConfigAlbums.AlbumsInfo albumInfo)
	{
		return default(bool);
	}

	[Address(RVA = "0xC859C0", Offset = "0xC841C0", Length = "0x17C")]
	[Token(Token = "0x600413F")]
	public static bool CheckMusicBuyAndUnlock(MusicInfo musicInfo)
	{
		return default(bool);
	}

	[Address(RVA = "0xC85B40", Offset = "0xC84340", Length = "0x7B")]
	[Token(Token = "0x6004140")]
	public static bool CheckMusicUnlockMaster(MusicInfo musicInfo)
	{
		return default(bool);
	}

	[Address(RVA = "0xC84B50", Offset = "0xC83350", Length = "0x8D")]
	[Token(Token = "0x6004141")]
	public static void AddMusicUnlockMaster(string musicUid)
	{
	}
}
