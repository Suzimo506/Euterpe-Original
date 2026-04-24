//Type is in global namespace

public class SaveImage : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <SaveImages>d__5 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Texture2D texture; //Field offset: 0x20
		public SaveImage <>4__this; //Field offset: 0x28

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
		public <SaveImages>d__5(int <>1__state) { }

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

	[SerializeField]
	private GameObject m_SampleImg; //Field offset: 0x18
	[SerializeField]
	private GameObject m_43Img; //Field offset: 0x20
	[SerializeField]
	private GameObject m_VerySpecialImg; //Field offset: 0x28

	public SaveImage() { }

	private void Awake() { }

	private Texture2D DeCompress(Texture2D source) { }

	private AndroidJavaObject GetAndroidJavaObject() { }

	public void OnCilck(Image images) { }

	private void OnClickDownload() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator SaveImages(Texture2D texture) { }

	private void savePngAndUpdate(string fileName) { }

}

