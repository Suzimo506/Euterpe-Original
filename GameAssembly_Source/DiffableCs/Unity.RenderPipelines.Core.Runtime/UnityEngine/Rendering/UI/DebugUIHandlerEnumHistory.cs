namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerEnumHistory : DebugUIHandlerEnumField
{
	[CompilerGenerated]
	private sealed class <RefreshAfterSanitization>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public DebugUIHandlerEnumHistory <>4__this; //Field offset: 0x20

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
		public <RefreshAfterSanitization>d__4(int <>1__state) { }

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

	private const float xDecal = 60; //Field offset: 0x0
	private Text[] historyValues; //Field offset: 0x70

	public DebugUIHandlerEnumHistory() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator RefreshAfterSanitization() { }

	internal virtual void SetWidget(Widget widget) { }

	protected virtual void UpdateValueLabel() { }

}

