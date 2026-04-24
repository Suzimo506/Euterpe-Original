namespace Assets.Scripts.PeroTools.Managers;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class TimerManager : Singleton<TimerManager>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public string uid; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal bool <get_Item>b__0(Timer t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public Action callFunc; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal void <Delay>b__0(int t) { }

	}

	private readonly List<Timer> m_FixedTimers; //Field offset: 0x10
	private readonly List<Timer> m_UpdateTimers; //Field offset: 0x18

	public Timer Item
	{
		 get { } //Length: 246
	}

	public TimerManager() { }

	[CompilerGenerated]
	private void <Init>b__4_0(float time) { }

	[CompilerGenerated]
	private void <Init>b__4_1(float time) { }

	public void AddTimer(Timer timer) { }

	public Timer Delay(Action callFunc, float dt) { }

	public Timer get_Item(string uid) { }

	private void Init() { }

	public void Kill() { }

	public void Pause() { }

	public void RemoveTimer(Timer timer) { }

	public void Resume() { }

}

