namespace Assets.Scripts.PeroTools.Managers;

public class Timer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public Action<Int32> action; //Field offset: 0x10

		public <>c__DisplayClass35_0() { }

		internal bool <RemoveTickEvent>b__0(KeyValuePair<Int32, Action`1<Int32>> e) { }

	}

	public const float infinite = 3.4028235E+38; //Field offset: 0x0
	public LoopType type; //Field offset: 0x10
	public bool isPause; //Field offset: 0x14
	[CompilerGenerated]
	private float <interval>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <uid>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private float <totalTime>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Stopwatch <stopWatch>k__BackingField; //Field offset: 0x30
	private int m_PrePassTick; //Field offset: 0x38
	private readonly float m_Radio; //Field offset: 0x3C
	private readonly Dictionary<Int32, Action`1<Int32>> m_Events; //Field offset: 0x40
	private readonly List<Action`1<Int32>> m_Steps; //Field offset: 0x48

	public static float fixedInterval
	{
		 get { } //Length: 7
	}

	public private float interval
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public static int length
	{
		 get { } //Length: 224
	}

	public int passedTick
	{
		 get { } //Length: 53
	}

	public float passedTime
	{
		 get { } //Length: 65
	}

	public private Stopwatch stopWatch
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private float totalTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private string uid
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public static float updateInterval
	{
		 get { } //Length: 7
	}

	public Timer(string u, LoopType t = 1, float time = 3.4028235E+38) { }

	public void AddTickEvent(Action<Int32> action, float time = -1) { }

	public static float get_fixedInterval() { }

	[CompilerGenerated]
	public float get_interval() { }

	public static int get_length() { }

	public int get_passedTick() { }

	public float get_passedTime() { }

	[CompilerGenerated]
	public Stopwatch get_stopWatch() { }

	[CompilerGenerated]
	public float get_totalTime() { }

	[CompilerGenerated]
	public string get_uid() { }

	public static float get_updateInterval() { }

	public void Kill() { }

	public void Pause() { }

	public void Play() { }

	public void RemoveTickEvent(Action<Int32> action) { }

	public void Resume() { }

	[CompilerGenerated]
	private void set_interval(float value) { }

	[CompilerGenerated]
	private void set_stopWatch(Stopwatch value) { }

	[CompilerGenerated]
	private void set_totalTime(float value) { }

	[CompilerGenerated]
	private void set_uid(string value) { }

	public void Tick() { }

	private void TickEvent(int curTick) { }

	private void TickStep(int curTick) { }

}

