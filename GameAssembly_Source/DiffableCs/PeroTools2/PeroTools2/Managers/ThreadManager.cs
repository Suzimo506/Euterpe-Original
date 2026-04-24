namespace PeroTools2.Managers;

public class ThreadManager : Singleton<ThreadManager>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public Action action; //Field offset: 0x10
		public ThreadManager <>4__this; //Field offset: 0x18

		public <>c__DisplayClass10_0() { }

		internal void <CreateThread>g__ac|0() { }

	}

	private readonly List<Thread> m_Threads; //Field offset: 0x10
	private readonly Queue<Action> m_Actions; //Field offset: 0x18
	private int m_MainThreadId; //Field offset: 0x20
	private int m_LoopIndex; //Field offset: 0x24

	public bool isOver
	{
		 get { } //Length: 63
	}

	private LoopType loopType
	{
		private get { } //Length: 26
	}

	public ThreadManager() { }

	public void AboutAllThread() { }

	public void AddAsyncAction(Action action) { }

	public Thread CreateThread(Action action) { }

	public bool CreateThreadFromPool(WaitCallback callback, object obj) { }

	public bool get_isOver() { }

	private LoopType get_loopType() { }

	private void Init() { }

	private void OnUpdate() { }

	private void OverRemoveThread() { }

}

