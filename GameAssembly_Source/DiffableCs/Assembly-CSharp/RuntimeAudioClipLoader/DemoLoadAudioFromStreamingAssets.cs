namespace RuntimeAudioClipLoader;

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class DemoLoadAudioFromStreamingAssets : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <DownloadClipFromUrl>d__8 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public string url; //Field offset: 0x20
		public DemoLoadAudioFromStreamingAssets <>4__this; //Field offset: 0x28
		private WWW <www>5__2; //Field offset: 0x30

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
		public <DownloadClipFromUrl>d__8(int <>1__state) { }

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

	public bool loadInBackground; //Field offset: 0x18
	public bool doStream; //Field offset: 0x19
	public string urlToLoad; //Field offset: 0x20
	private AudioSource audioSource; //Field offset: 0x28

	private string sourceFolder
	{
		private get { } //Length: 96
	}

	public DemoLoadAudioFromStreamingAssets() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator DownloadClipFromUrl(string url) { }

	private string get_sourceFolder() { }

	private void OnGUI() { }

	private void Start() { }

}

