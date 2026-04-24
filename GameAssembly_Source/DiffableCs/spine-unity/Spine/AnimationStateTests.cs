namespace Spine;

public class AnimationStateTests
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public int counter; //Field offset: 0x10

		public <>c__DisplayClass14_0() { }

		internal void <.ctor>b__12(TrackEntry trackEntry) { }

		internal void <.ctor>b__13(TrackEntry trackEntry) { }

		internal void <.ctor>b__14(TrackEntry trackEntry) { }

		internal void <.ctor>b__15(TrackEntry trackEntry) { }

		internal void <.ctor>b__16(TrackEntry trackEntry) { }

		internal void <.ctor>b__17(TrackEntry trackEntry, Event ev) { }

	}

	internal sealed class FailDelegate : MulticastDelegate
	{

		public FailDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string message, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string message) { }

	}

	internal sealed class LogDelegate : MulticastDelegate
	{

		public LogDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string message, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string message) { }

	}

	private class LoggingAnimationStateListener
	{
		private AnimationStateTests tests; //Field offset: 0x10

		public LoggingAnimationStateListener(AnimationStateTests tests) { }

		private void Add(Result result) { }

		public void Complete(TrackEntry entry) { }

		public void Dispose(TrackEntry entry) { }

		public void End(TrackEntry entry) { }

		public void Event(TrackEntry entry, Event ev) { }

		public void Interrupt(TrackEntry entry) { }

		public void RegisterAtAnimationState(AnimationState state) { }

		public void Start(TrackEntry entry) { }

		public void UnregisterFromAnimationState(AnimationState state) { }

	}

	private class NullAttachmentLoader : AttachmentLoader
	{

		public NullAttachmentLoader() { }

		public override BoundingBoxAttachment NewBoundingBoxAttachment(Skin skin, string name) { }

		public override ClippingAttachment NewClippingAttachment(Skin skin, string name) { }

		public override MeshAttachment NewMeshAttachment(Skin skin, string name, string path) { }

		public override PathAttachment NewPathAttachment(Skin skin, string name) { }

		public override PointAttachment NewPointAttachment(Skin skin, string name) { }

		public override RegionAttachment NewRegionAttachment(Skin skin, string name, string path) { }

	}

	private class Result
	{
		public string name; //Field offset: 0x10
		public int animationIndex; //Field offset: 0x18
		public float trackTime; //Field offset: 0x1C
		public float totalTime; //Field offset: 0x20
		public bool note; //Field offset: 0x24

		public Result() { }

		public virtual bool Equals(object obj) { }

		public virtual int GetHashCode() { }

		public virtual string ToString() { }

	}

	private class TestListener
	{
		internal sealed class FrameDelegate : MulticastDelegate
		{

			public FrameDelegate(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(float time, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(float time) { }

		}

		[CompilerGenerated]
		private FrameDelegate frame; //Field offset: 0x10

		public event FrameDelegate frame
		{
			[CompilerGenerated]
			 add { } //Length: 158
			[CompilerGenerated]
			 remove { } //Length: 158
		}

		public TestListener(FrameDelegate frame) { }

		[CompilerGenerated]
		public void add_frame(FrameDelegate value) { }

		public void Frame(float time) { }

		[CompilerGenerated]
		public void remove_frame(FrameDelegate value) { }

	}

	private static readonly float FLOAT_ROUNDING_ERROR; //Field offset: 0x0
	[CompilerGenerated]
	private static LogDelegate logImplementation; //Field offset: 0x8
	[CompilerGenerated]
	private static FailDelegate failImplementation; //Field offset: 0x10
	private readonly SkeletonJson json; //Field offset: 0x10
	private LoggingAnimationStateListener stateListener; //Field offset: 0x18
	private readonly SkeletonData skeletonData; //Field offset: 0x20
	private readonly List<Result> actual; //Field offset: 0x28
	private readonly List<Result> expected; //Field offset: 0x30
	private AnimationStateData stateData; //Field offset: 0x38
	private AnimationState state; //Field offset: 0x40
	private float time; //Field offset: 0x48
	private bool fail; //Field offset: 0x4C
	private int test; //Field offset: 0x50

	public static event FailDelegate failImplementation
	{
		[CompilerGenerated]
		 add { } //Length: 254
		[CompilerGenerated]
		 remove { } //Length: 254
	}

	public static event LogDelegate logImplementation
	{
		[CompilerGenerated]
		 add { } //Length: 254
		[CompilerGenerated]
		 remove { } //Length: 254
	}

	private static AnimationStateTests() { }

	private AnimationStateTests(string testJsonFilePath) { }

	[CompilerGenerated]
	private void <.ctor>b__14_0(float time) { }

	[CompilerGenerated]
	private void <.ctor>b__14_1(float time) { }

	[CompilerGenerated]
	private void <.ctor>b__14_10(float time) { }

	[CompilerGenerated]
	private void <.ctor>b__14_11(float time) { }

	[CompilerGenerated]
	private void <.ctor>b__14_2(float time) { }

	[CompilerGenerated]
	private void <.ctor>b__14_3(float time) { }

	[CompilerGenerated]
	private void <.ctor>b__14_4(TrackEntry trackEntry) { }

	[CompilerGenerated]
	private void <.ctor>b__14_5(TrackEntry trackEntry) { }

	[CompilerGenerated]
	private void <.ctor>b__14_6(TrackEntry trackEntry) { }

	[CompilerGenerated]
	private void <.ctor>b__14_7(TrackEntry trackEntry) { }

	[CompilerGenerated]
	private void <.ctor>b__14_8(TrackEntry trackEntry) { }

	[CompilerGenerated]
	private void <.ctor>b__14_9(TrackEntry trackEntry, Event ev) { }

	private Result Actual(string name, TrackEntry entry) { }

	[CompilerGenerated]
	public static void add_failImplementation(FailDelegate value) { }

	[CompilerGenerated]
	public static void add_logImplementation(LogDelegate value) { }

	private Result Expect(int animationIndex, string name, float trackTime, float totalTime) { }

	private static void FailTestRun(string message) { }

	private static bool IsEqual(float a, float b) { }

	private static void Log(string message) { }

	public static void Main(string testJsonFilePath) { }

	private Result Note(string message) { }

	[CompilerGenerated]
	public static void remove_failImplementation(FailDelegate value) { }

	[CompilerGenerated]
	public static void remove_logImplementation(LogDelegate value) { }

	private static float Round(float value, int decimals) { }

	private static string RoundTime(float value) { }

	private void Run(float incr, float endTime, TestListener listener) { }

	private void Setup(string description, Result[] expectedArray) { }

}

