namespace Assets.Scripts.PeroTools.Nice.Actions;

public abstract class Group : Action
{
	[CompilerGenerated]
	private sealed class <>c__7
	{
		public static readonly <>c__7<T> <>9; //Field offset: 0x0
		public static Predicate<IPlayable> <>9__7_0; //Field offset: 0x0

		private static <>c__7`1() { }

		public <>c__7`1() { }

		internal bool <GetPlayables>b__7_0(IPlayable p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public IPlayable playable; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal void <Execute>b__0() { }

	}

	[SerializeField]
	protected List<IPlayable> m_Playables; //Field offset: 0x10
	protected Sequence m_Sequence; //Field offset: 0x18
	protected float m_Time; //Field offset: 0x20

	public virtual float duration
	{
		 get { } //Length: 259
	}

	public List<IPlayable> playables
	{
		 get { } //Length: 5
	}

	protected Group() { }

	public virtual void Enter() { }

	public virtual void Execute() { }

	public virtual void Exit() { }

	public virtual float get_duration() { }

	public List<IPlayable> get_playables() { }

	public List<T> GetPlayables() { }

	public virtual void Pause() { }

	public virtual void Resume() { }

}

