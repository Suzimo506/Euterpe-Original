namespace PeroTools2.Commons;

public class Timer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public OnTick callback; //Field offset: 0x10

		public <>c__DisplayClass23_0() { }

		internal bool <RemoveEvent>b__0(KeyValuePair<Int32, OnTick> e) { }

	}

	internal sealed class OnTick : MulticastDelegate
	{

		public OnTick(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int tick, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int tick) { }

	}

	public const float infinite = 3.4028235E+38; //Field offset: 0x0
	public const float interval = 0.001; //Field offset: 0x0
	[CompilerGenerated]
	private readonly float <totalTime>k__BackingField; //Field offset: 0x10
	private int m_Offset; //Field offset: 0x14
	private int m_PrePassTick; //Field offset: 0x18
	private readonly int m_LoopUid; //Field offset: 0x1C
	private readonly Stopwatch m_StopWatch; //Field offset: 0x20
	private readonly float m_Radio; //Field offset: 0x28
	private readonly Dictionary<Int32, OnTick> m_Events; //Field offset: 0x30
	private readonly List<OnTick> m_Steps; //Field offset: 0x38

	public int offset
	{
		 get { } //Length: 4
		 set { } //Length: 102
	}

	public int passedTick
	{
		 get { } //Length: 39
	}

	public float passedTime
	{
		 get { } //Length: 56
	}

	public float totalTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
	}

	public Timer(float _totalTime = 3.4028235E+38, LoopType _type = 1) { }

	public void AddTickEvent(OnTick callback, int tick = -1) { }

	public void AddTimeEvent(OnTick callback, float time = -1) { }

	public int get_offset() { }

	public int get_passedTick() { }

	public float get_passedTime() { }

	[CompilerGenerated]
	public float get_totalTime() { }

	public bool IsPause() { }

	public void Kill() { }

	public void Pause() { }

	public void Play() { }

	public void RemoveEvent(OnTick callback) { }

	public void Resume() { }

	public void set_offset(int value) { }

	public void Stop() { }

	private void Tick() { }

	private void TickEvent(int curTick) { }

	private void TickStep(int curTick) { }

}

