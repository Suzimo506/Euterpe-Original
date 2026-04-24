namespace Assets.Scripts.GameCore.Managers;

public class WeekFreeManager : Singleton<WeekFreeManager>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, Object>, String> <>9__19_1; //Field offset: 0x8
		public static Func<KeyValuePair`2<String, Object>, String> <>9__19_2; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <Refresh>b__19_1(KeyValuePair<String, Object> d) { }

		internal string <Refresh>b__19_2(KeyValuePair<String, Object> d) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public Random random; //Field offset: 0x10
		public WeekFreeManager <>4__this; //Field offset: 0x18

		public <>c__DisplayClass19_0() { }

		internal char <Refresh>b__0(string s) { }

		internal void <Refresh>b__3(DownloadHandler handle) { }

	}

	[CompilerGenerated]
	private static Action s_RefreshEndHandler; //Field offset: 0x0
	private WeekFreeExInfo m_WeekFreeExInfo; //Field offset: 0x10
	[CompilerGenerated]
	private Dictionary<String, String> <discounts>k__BackingField; //Field offset: 0x28
	private bool m_OldVersion; //Field offset: 0x30

	public static event Action s_RefreshEndHandler
	{
		[CompilerGenerated]
		 add { } //Length: 164
		[CompilerGenerated]
		 remove { } //Length: 164
	}

	public private Dictionary<String, String> discounts
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public Int32[] freeAlbumIndexs
	{
		 get { } //Length: 5
	}

	public String[] freeMusicUids
	{
		 get { } //Length: 5
	}

	public WeekFreeManager() { }

	[CompilerGenerated]
	public static void add_s_RefreshEndHandler(Action value) { }

	[CompilerGenerated]
	public Dictionary<String, String> get_discounts() { }

	public Int32[] get_freeAlbumIndexs() { }

	public String[] get_freeMusicUids() { }

	private void Init() { }

	public bool IsFreeAlbumUid(string albumUid) { }

	public bool IsFreeSongUid(string musicUid) { }

	private void OnSceneLoad(Scene scene, LoadSceneMode mode) { }

	private void OnSceneRefresh(string sceneName) { }

	private void Refresh() { }

	private void RefreshEnd() { }

	[CompilerGenerated]
	public static void remove_s_RefreshEndHandler(Action value) { }

	[CompilerGenerated]
	private void set_discounts(Dictionary<String, String> value) { }

}

