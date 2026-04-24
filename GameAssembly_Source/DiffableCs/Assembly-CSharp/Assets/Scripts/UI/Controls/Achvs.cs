namespace Assets.Scripts.UI.Controls;

public class Achvs : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <UpdateActivateAchv>d__11 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Achvs <>4__this; //Field offset: 0x20

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
		public <UpdateActivateAchv>d__11(int <>1__state) { }

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

	public GameObject achvBox; //Field offset: 0x18
	private List<String> m_Achievements; //Field offset: 0x20
	private List<Int32> m_DoneIndex; //Field offset: 0x28
	private List<GameObject> m_GameObjects; //Field offset: 0x30
	private Dictionary<String, Int32> m_IndexCount; //Field offset: 0x38
	private int m_CurrentActivateAchv; //Field offset: 0x40
	public AchvSelect achvSelect; //Field offset: 0x48
	private int m_SeealbeAchvCount; //Field offset: 0x50
	private string m_CurrentLanguage; //Field offset: 0x58

	public Achvs() { }

	private void Awake() { }

	private bool IsHideAchv(int AchvIndex) { }

	private void OnEnable() { }

	private void SetAchv(int AchvIndex) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator UpdateActivateAchv() { }

	private void UpdateRectTransformHeight() { }

}

