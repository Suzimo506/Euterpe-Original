namespace Assets.Scripts.PeroTools.Commons;

public static class DOTweenUtils
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public Action callFunc; //Field offset: 0x10
		public Sequence seq; //Field offset: 0x18

		public <>c__DisplayClass3_0() { }

		internal void <Delay>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public Func<Boolean> stopFunc; //Field offset: 0x10
		public Action completeFunc; //Field offset: 0x18
		public Sequence seq; //Field offset: 0x20

		public <>c__DisplayClass4_0() { }

		internal void <Update>b__0() { }

	}


	public static Sequence Delay(Action callFunc, float dt) { }

	public static void Kill() { }

	public static void Pause() { }

	public static void Resume() { }

	public static Sequence Update(Action completeFunc, Func<Boolean> stopFunc) { }

}

