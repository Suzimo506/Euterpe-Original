namespace PeroTools2.Commons.Overlay;

public class Overlay : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <<Unblock>g__Unblock|12_0>d : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Overlay <>4__this; //Field offset: 0x20

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
		public <<Unblock>g__Unblock|12_0>d(int <>1__state) { }

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

	private static Overlay s_Instance; //Field offset: 0x0
	private const string prefab_name = "OverlayCanvas"; //Field offset: 0x0
	[SerializeField]
	private GameObject m_PnlBlock; //Field offset: 0x18
	[SerializeField]
	private GameObject m_PnlText; //Field offset: 0x20
	[SerializeField]
	private Text m_TxtShow; //Field offset: 0x28
	private DOTweenAnimation[] m_BlockAnimations; //Field offset: 0x30
	private EventSystem m_EventSystem; //Field offset: 0x38
	private Coroutine m_Coroutine; //Field offset: 0x40
	private bool m_IsBlocking; //Field offset: 0x48

	public static Overlay instance
	{
		 get { } //Length: 608
	}

	public Overlay() { }

	[CompilerGenerated]
	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator <Unblock>g__Unblock|12_0() { }

	public void Block() { }

	public static Overlay get_instance() { }

	private void Init() { }

	private void OnDestroy() { }

	private void OnSceneChanged(Scene arg0, Scene arg1) { }

	public void ShowText(string text) { }

	public void Unblock() { }

}

