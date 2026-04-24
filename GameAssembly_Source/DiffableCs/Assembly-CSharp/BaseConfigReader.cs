//Type is in global namespace

public abstract class BaseConfigReader
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<MusicData> <>9__3_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <MusicTickDataSort>b__3_0(MusicData l, MusicData r) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public MusicData musicData; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal bool <MusicTickDataSort>b__1(MusicData m) { }

	}

	protected List<MusicData> m_DataBuffer; //Field offset: 0x10

	protected BaseConfigReader() { }

	public List<MusicData> CreateMusicDatas() { }

	protected abstract void Init() { }

	internal static void MusicTickDataSort(List<MusicData> musicTickData) { }

}

