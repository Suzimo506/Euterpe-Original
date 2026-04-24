namespace ZenFulcrum.EmbeddedBrowser;

public class PromiseTimer : IPromiseTimer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public float seconds; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal bool <WaitFor>b__0(TimeData t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public Func<TimeData, Boolean> predicate; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal bool <WaitWhile>b__0(TimeData t) { }

	}

	private float curTime; //Field offset: 0x10
	private List<PredicateWait> waiting; //Field offset: 0x18

	public PromiseTimer() { }

	public override void Update(float deltaTime) { }

	public override IPromise WaitFor(float seconds) { }

	public override IPromise WaitUntil(Func<TimeData, Boolean> predicate) { }

	public override IPromise WaitWhile(Func<TimeData, Boolean> predicate) { }

}

