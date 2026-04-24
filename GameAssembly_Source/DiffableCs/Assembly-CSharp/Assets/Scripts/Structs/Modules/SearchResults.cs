namespace Assets.Scripts.Structs.Modules;

public class SearchResults
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public SearchResults <>4__this; //Field offset: 0x10
		public string findText; //Field offset: 0x18

		public <>c__DisplayClass31_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_1
	{
		public int mreIndex; //Field offset: 0x10
		public List<MusicInfo> buffer; //Field offset: 0x18
		public <>c__DisplayClass31_0 CS$<>8__locals1; //Field offset: 0x20

		public <>c__DisplayClass31_1() { }

		internal void <RefreshData>b__0(object state) { }

	}

	private MusicInfoResult m_MusicResult; //Field offset: 0x10
	private MusicInfoResult m_AuthorResult; //Field offset: 0x18
	private MusicInfoResult m_LevelDesignerResult; //Field offset: 0x20
	private MusicInfoResult[] m_MusicResults; //Field offset: 0x28
	private MusicInfoResult[] m_AuthorResults; //Field offset: 0x30
	private MusicInfoResult[] m_LevelDesignerResults; //Field offset: 0x38
	private PeroString[] m_PeroStrings; //Field offset: 0x40
	private ManualResetEvent[] m_ManualResetEvent; //Field offset: 0x48
	private List<List`1<MusicInfo>> m_Buffers; //Field offset: 0x50

	public MusicInfoResult authorResult
	{
		 get { } //Length: 5
	}

	public int count
	{
		 get { } //Length: 239
	}

	public MusicInfoResult levelDesignerResult
	{
		 get { } //Length: 5
	}

	public MusicInfoResult musicResult
	{
		 get { } //Length: 5
	}

	public SearchResults() { }

	private void AppendAuthor(MusicInfo info, int index, bool isUnlock) { }

	private void AppendLevelDesigner(MusicInfo info, int index, bool isUnlock) { }

	private void AppendMusic(MusicInfo info, int index, bool isUnlock) { }

	private void ClearAll() { }

	private void FindMusicJobs(int threadIndex, List<MusicInfo> buffer, string findText, PeroString strBuffer, object state) { }

	public MusicInfoResult get_authorResult() { }

	public int get_count() { }

	public MusicInfoResult get_levelDesignerResult() { }

	public MusicInfoResult get_musicResult() { }

	private void InitLanguageResources() { }

	private MusicInfoResult[] InitList(int core) { }

	private void InitManualResetEvent(int coreCount) { }

	private void Merge() { }

	private bool PeroContains(PeroString peroString, string oriText, string containsText) { }

	private bool PeroLevelDesigner(PeroString peroString, MusicInfo musicInfo, string containsText) { }

	public void RefreshData(string keyword) { }

	private void ReleaseJobs() { }

	public void ToList(List<String> buffer) { }

}

