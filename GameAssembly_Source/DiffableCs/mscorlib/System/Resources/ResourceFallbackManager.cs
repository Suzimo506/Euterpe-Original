namespace System.Resources;

internal class ResourceFallbackManager : IEnumerable<CultureInfo>, IEnumerable
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__5 : IEnumerator<CultureInfo>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private CultureInfo <>2__current; //Field offset: 0x18
		public ResourceFallbackManager <>4__this; //Field offset: 0x20
		private CultureInfo <currentCulture>5__1; //Field offset: 0x28
		private bool <reachedNeutralResourcesCulture>5__2; //Field offset: 0x30

		private override CultureInfo System.Collections.Generic.IEnumerator<System.Globalization.CultureInfo>.Current
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
		public <GetEnumerator>d__5(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override CultureInfo System.Collections.Generic.IEnumerator<System.Globalization.CultureInfo>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private CultureInfo m_startingCulture; //Field offset: 0x10
	private CultureInfo m_neutralResourcesCulture; //Field offset: 0x18
	private bool m_useParents; //Field offset: 0x20

	internal ResourceFallbackManager(CultureInfo startingCulture, CultureInfo neutralResourcesCulture, bool useParents) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override IEnumerator<CultureInfo> GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

