//Type is in global namespace

public class MusicTagManager : Singleton<MusicTagManager>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Int64, String> <>9__16_4; //Field offset: 0x8
		public static Func<Boolean> <>9__16_1; //Field offset: 0x10
		public static Action <>9__16_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <InitDefaultInfo>b__16_1() { }

		internal void <InitDefaultInfo>b__16_2() { }

		internal void <InitDefaultInfo>b__16_4(long c, string f) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public MusicTagManager <>4__this; //Field offset: 0x10
		public DBConfigCustomTags info; //Field offset: 0x18
		public Action<JObject> <>9__3; //Field offset: 0x20

		public <>c__DisplayClass16_0() { }

		internal void <InitDefaultInfo>b__0() { }

		internal void <InitDefaultInfo>b__3(JObject o) { }

	}

	private DBMusicTag m_DbMusicTag; //Field offset: 0x10
	private bool m_InitFlag; //Field offset: 0x18

	public MusicTagManager() { }

	private void AllTagSort() { }

	private void CleanInvalidUid(List<String> buffer) { }

	private void CustomTagPaser(DBConfigCustomTags tags) { }

	public void EnterBattleInit() { }

	private void InitAlbumTagInfo() { }

	private void InitAllMusicInfo() { }

	private void InitBaseMusicTagsData() { }

	public void InitDatas() { }

	private void InitDefaultInfo() { }

	private void InitNewAlbum() { }

	private bool InitStageMusicInfoByDiff() { }

	private bool InitStageMusicInfoBySearch() { }

	private void InitTagState() { }

	private void OnWeekFreeRefreshed() { }

	public bool RefreshStageDisplayMusics(List<String> uids, int tagIndex) { }

	public bool RefreshStageDisplayMusics(List<String> musicUids) { }

	public bool RefreshStageDisplayMusics(int tagIndex = -1) { }

}

