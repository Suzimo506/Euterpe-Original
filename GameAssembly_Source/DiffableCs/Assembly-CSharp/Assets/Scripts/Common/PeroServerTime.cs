namespace Assets.Scripts.Common;

public class PeroServerTime : Singleton<PeroServerTime>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<DateTime> <>9__28_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__28_0(DateTime <p0>) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public Action<DateTime> complete; //Field offset: 0x10
		public PeroServerTime <>4__this; //Field offset: 0x18
		public Action<Int64, String> failCallback; //Field offset: 0x20

		public <>c__DisplayClass27_0() { }

		internal void <RequireTime>b__0() { }

		internal bool <RequireTime>b__1() { }

		internal void <RequireTime>b__2() { }

		internal void <RequireTime>b__3() { }

		internal void <RequireTime>b__4(JObject jobj) { }

		internal void <RequireTime>b__5(long c, string s) { }

	}

	private const float down_cool_time = 60; //Field offset: 0x0
	private DateTime m_ServerUtcTime; //Field offset: 0x10
	private Stopwatch m_Stopwatch; //Field offset: 0x18
	private bool m_RequireDownCool; //Field offset: 0x20
	private Coroutine m_LimitCoroutine; //Field offset: 0x28
	private bool m_AcquiredServerTime; //Field offset: 0x30
	[CompilerGenerated]
	private Action<DateTime> onGetServerTime; //Field offset: 0x38
	private bool m_Requireing; //Field offset: 0x40

	public event Action<DateTime> onGetServerTime
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public bool acquiredServerTime
	{
		 get { } //Length: 5
	}

	public DateTime chinaServerTime
	{
		 get { } //Length: 108
	}

	public DateTime localServerTime
	{
		 get { } //Length: 5
	}

	public DateTime nowChinaServerTime
	{
		 get { } //Length: 156
	}

	public DateTime nowLocalServerTime
	{
		 get { } //Length: 122
	}

	public bool requireDownCool
	{
		 get { } //Length: 5
	}

	public DateTime serverTime
	{
		 get { } //Length: 5
	}

	public PeroServerTime() { }

	[CompilerGenerated]
	public void add_onGetServerTime(Action<DateTime> value) { }

	public bool get_acquiredServerTime() { }

	public DateTime get_chinaServerTime() { }

	public DateTime get_localServerTime() { }

	public DateTime get_nowChinaServerTime() { }

	public DateTime get_nowLocalServerTime() { }

	public bool get_requireDownCool() { }

	public DateTime get_serverTime() { }

	public void GetServerTime(Action<DateTime> callback, Action<Int64, String> failCallback, bool force = false) { }

	private void Init() { }

	[CompilerGenerated]
	public void remove_onGetServerTime(Action<DateTime> value) { }

	private void RequireTime(Action<DateTime> complete = null, Action<Int64, String> failCallback = null) { }

	public void ResetToLocal() { }

}

