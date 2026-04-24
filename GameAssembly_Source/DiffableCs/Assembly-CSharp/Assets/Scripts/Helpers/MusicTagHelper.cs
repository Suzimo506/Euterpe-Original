namespace Assets.Scripts.Helpers;

public static class MusicTagHelper
{
	private static Dictionary<Int32, Boolean> s_IAPBuffer; //Field offset: 0x0
	private static bool s_IsUnlockAll; //Field offset: 0x8

	private static MusicTagHelper() { }

	public static void AddMusicUnlockMaster(string musicUid) { }

	public static void AllFilter(List<String> buffer, bool isHide = false) { }

	public static void AllFilter(List<MusicInfo> buffer, bool isHide = false) { }

	public static void AnchorFilter(List<String> buffer) { }

	public static void AnchorFilter(List<MusicInfo> buffer) { }

	public static bool CheckAlbumBuyAndUnlock(int jsonIndex) { }

	public static bool CheckAlbumBuyAndUnlock(AlbumsInfo albumInfo) { }

	public static bool CheckMusicBuyAndUnlock(MusicInfo musicInfo) { }

	public static bool CheckMusicUnlockMaster(MusicInfo musicInfo) { }

	public static bool CheckSkinIsBuy(RoleSkin roleSkin) { }

	public static bool FastCheckUnlock(MusicInfo musicInfo) { }

	public static void HideFilter(List<MusicInfo> buffer, bool isHide) { }

	public static void HideFilter(List<String> buffer, bool isHide) { }

	public static void RefreshIAPBuffer() { }

	public static void SpecialMusicFilter(List<String> buffer) { }

	public static void SpecialMusicFilter(List<MusicInfo> buffer) { }

}

