namespace E7.Native;

public class NativeAudioAnalyzer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public float avg; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal float <StdDev>b__0(long d) { }

	}

	[CompilerGenerated]
	private sealed class <AnalyzeRoutine>d__16 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public NativeAudioAnalyzer <>4__this; //Field offset: 0x20
		private int <i>5__2; //Field offset: 0x28

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
		public <AnalyzeRoutine>d__16(int <>1__state) { }

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

	private const float secondsOfPlay = 1; //Field offset: 0x0
	private const int framesOfPlay = 60; //Field offset: 0x0
	private static NativeAudioPointer silence; //Field offset: 0x0
	private NativeAudioAnalyzerResult analysisResult; //Field offset: 0x18
	public List<Int64> allTicks; //Field offset: 0x20
	private IEnumerator analyzeRoutine; //Field offset: 0x28
	private Stopwatch sw; //Field offset: 0x30

	public NativeAudioAnalyzerResult AnalysisResult
	{
		 get { } //Length: 5
	}

	public bool Analyzed
	{
		 get { } //Length: 9
	}

	public NativeAudioAnalyzer() { }

	public void Analyze() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator AnalyzeRoutine() { }

	public void Finish() { }

	public NativeAudioAnalyzerResult get_AnalysisResult() { }

	public bool get_Analyzed() { }

	private static float StdDev(IEnumerable<Int64> values) { }

	private float TicksToMs(long ticks) { }

	private float TicksToMs(double ticks) { }

}

