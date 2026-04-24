namespace Assets.Scripts.GameCore.Managers;

public class MainManager : SingletonMonoBehaviour<MainManager>
{
	[CompilerGenerated]
	private sealed class <<InitCheckAdult>g__CheckAdult|13_0>d : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <<InitCheckAdult>g__CheckAdult|13_0>d(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Boolean> <>9__13_1; //Field offset: 0x8
		public static Action<DownloadHandler> <>9__13_2; //Field offset: 0x10
		public static Func<SkeletonAnimator, Boolean> <>9__33_0; //Field offset: 0x18
		public static Func<SkeletonAnimator, GameObject> <>9__33_1; //Field offset: 0x20
		public static Func<GameObject, Boolean> <>9__33_2; //Field offset: 0x28
		public static Action<GameObject> <>9__33_4; //Field offset: 0x30
		public static Action<GameObject> <>9__33_6; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal bool <AnimatorsInit>b__33_0(SkeletonAnimator a) { }

		internal GameObject <AnimatorsInit>b__33_1(SkeletonAnimator a) { }

		internal bool <AnimatorsInit>b__33_2(GameObject g) { }

		internal void <AnimatorsInit>b__33_4(GameObject g) { }

		internal void <AnimatorsInit>b__33_6(GameObject g) { }

		internal bool <InitCheckAdult>b__13_1() { }

		internal void <InitCheckAdult>b__13_2(DownloadHandler handler) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public int i; //Field offset: 0x10

		public <>c__DisplayClass23_0() { }

		internal bool <InitLoading>b__0(IData t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public MainManager <>4__this; //Field offset: 0x10
		public int tickSecond; //Field offset: 0x18
		public float time; //Field offset: 0x1C

		public <>c__DisplayClass30_0() { }

		internal void <InitTimer>b__0(DateTime dt) { }

		internal void <InitTimer>b__1(float tick) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public List<GameObject> gameObjects; //Field offset: 0x10

		public <>c__DisplayClass33_0() { }

		internal void <AnimatorsInit>b__3(SkeletonAnimator a) { }

		internal void <AnimatorsInit>b__5() { }

	}

	[HideInInspector]
	public DateTime dateTime; //Field offset: 0x18
	[CompilerGenerated]
	private bool <isFirstOpen>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Action<DateTime> onTimeChanged; //Field offset: 0x28
	public Discord discord; //Field offset: 0x30

	public event Action<DateTime> onTimeChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public private bool isFirstOpen
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public MainManager() { }

	[CompilerGenerated]
	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal static IEnumerator <InitCheckAdult>g__CheckAdult|13_0() { }

	[CompilerGenerated]
	private void <InitController>b__22_0(ControllerStatusChangedEventArgs arg) { }

	[CompilerGenerated]
	private void <InitController>b__22_1(ControllerStatusChangedEventArgs arg) { }

	[CompilerGenerated]
	private void <OnApplicationPause>b__34_0(DateTime dt) { }

	[CompilerGenerated]
	public void add_onTimeChanged(Action<DateTime> value) { }

	private void AnimatorsInit() { }

	[CompilerGenerated]
	public bool get_isFirstOpen() { }

	private void Init() { }

	private void InitAccountSystem() { }

	private void InitAnchor() { }

	private void InitChannel() { }

	private void InitCheckAdult() { }

	public void InitController(bool firstTime = true) { }

	private void InitDevices() { }

	private void InitGraphic() { }

	private void InitHexie() { }

	private void InitIAP(bool first) { }

	private void InitLanguage() { }

	public void InitLoading(string key = "LoadingNull") { }

	private void InitMouse() { }

	private void InitPlatforms() { }

	private void InitRegion() { }

	private void InitReview() { }

	private void InitServerTime() { }

	private void InitStageInfo() { }

	private void InitTimer() { }

	private void InitUI() { }

	private void InitWeekFree() { }

	private void OnApplicationPause(bool pauseStatus) { }

	private void OnSceneChange(Scene _, Scene scene) { }

	[CompilerGenerated]
	public void remove_onTimeChanged(Action<DateTime> value) { }

	private void ResetButtonInvokeFlag(float _) { }

	public void ScreenAdapte() { }

	[CompilerGenerated]
	private void set_isFirstOpen(bool value) { }

}

