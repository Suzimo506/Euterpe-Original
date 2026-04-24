namespace PeroTools2.Commons;

public class BMS
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<JObject> <>9__9_2; //Field offset: 0x8
		public static Comparison<JToken> <>9__9_0; //Field offset: 0x10
		public static Func<String, Boolean> <>9__11_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal int <.ctor>b__9_0(JToken l, JToken r) { }

		internal int <.ctor>b__9_2(JObject l, JObject r) { }

		internal bool <LoadAll>b__11_0(string file) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public char splitChar; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal BMS <LoadAll>b__1(string file) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public decimal theTick; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal bool <.ctor>b__1(JObject b) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_1
	{
		public int index; //Field offset: 0x10

		public <>c__DisplayClass9_1() { }

		internal bool <.ctor>b__3(JToken pc) { }

	}

	public const string scene_event_tone = "01"; //Field offset: 0x0
	public const string beat_percent_tone = "02"; //Field offset: 0x0
	public const string bpm_tone = "03"; //Field offset: 0x0
	public const string bpm_float_tone = "08"; //Field offset: 0x0
	public JObject info; //Field offset: 0x10
	public JArray notes; //Field offset: 0x18
	public JArray notesPercent; //Field offset: 0x20
	public string md5; //Field offset: 0x28
	public Dictionary<String, Decimal> m_BpmTones; //Field offset: 0x30

	public BMS(string bmsPath) { }

	public float GetBpm() { }

	public static List<BMS> LoadAll(string path) { }

}

