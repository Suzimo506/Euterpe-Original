namespace Assets.Scripts.PeroTools.Nice.Actions;

public class Sequence : Group
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<IPlayable, Single> <>9__1_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal float <get_duration>b__1_0(IPlayable a) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public int index; //Field offset: 0x10
		public Sequence <>4__this; //Field offset: 0x18
		public IPlayable action; //Field offset: 0x20
		public Action[] callback; //Field offset: 0x28
		public TweenCallback <>9__1; //Field offset: 0x30
		public TweenCallback <>9__2; //Field offset: 0x38

		public <>c__DisplayClass2_0() { }

		internal void <Execute>b__0() { }

		internal void <Execute>b__1() { }

		internal void <Execute>b__2() { }

	}


	public virtual float duration
	{
		 get { } //Length: 243
	}

	public Sequence() { }

	public virtual void Execute() { }

	public virtual float get_duration() { }

}

