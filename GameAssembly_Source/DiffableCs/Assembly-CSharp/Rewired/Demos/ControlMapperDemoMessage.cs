namespace Rewired.Demos;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ControlMapperDemoMessage : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <SelectDefaultDeferred>d__7 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ControlMapperDemoMessage <>4__this; //Field offset: 0x20

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
		public <SelectDefaultDeferred>d__7(int <>1__state) { }

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

	public ControlMapper controlMapper; //Field offset: 0x18
	public Selectable defaultSelectable; //Field offset: 0x20

	public ControlMapperDemoMessage() { }

	private void Awake() { }

	private void OnControlMapperClosed() { }

	private void OnControlMapperOpened() { }

	private void SelectDefault() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator SelectDefaultDeferred() { }

	private void Start() { }

}

