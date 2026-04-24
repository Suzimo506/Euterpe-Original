namespace PeroPeroGames.GlobalDefines;

public static class DBMusicTagDefine
{
	private static Int32[] s_NewAlbumUids; //Field offset: 0x0
	private static String[] s_NewMusicUids; //Field offset: 0x8
	private static String[] s_HiddenLocal; //Field offset: 0x10
	private static String[] s_BarrageModeSongUid; //Field offset: 0x18
	private static String[] s_CullingMusicUids; //Field offset: 0x20

	public static int cullingMusicCount
	{
		 get { } //Length: 100
	}

	public static Int32[] newAlbumUids
	{
		 get { } //Length: 86
	}

	public static String[] newMusicUids
	{
		 get { } //Length: 87
	}

	private static DBMusicTagDefine() { }

	public static int get_cullingMusicCount() { }

	public static Int32[] get_newAlbumUids() { }

	public static String[] get_newMusicUids() { }

	public static void GetAllHiddenMusicUids(List<String> buffer, bool normalHide, bool touhou) { }

	public static int GetBarrageIndex(string uid) { }

	public static bool IsCullingMusicUid(string uid) { }

}

