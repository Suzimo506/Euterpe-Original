namespace Assets.Scripts.PeroTools.Managers;

public class AudioManager : Singleton<AudioManager>, IPause
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass39_0
	{
		public float volume; //Field offset: 0x10
		public AudioManager <>4__this; //Field offset: 0x18

		public <>c__DisplayClass39_0() { }

		internal void <PlayBGM>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <PlayOverCallback>d__21 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AudioSource audioSource; //Field offset: 0x20
		public Action callback; //Field offset: 0x28

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
		public <PlayOverCallback>d__21(int <>1__state) { }

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
	private FastPool <pool>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private AudioSource <bgm>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private GameObject <gameObject>k__BackingField; //Field offset: 0x20
	private Tweener m_BGMTweener; //Field offset: 0x28
	private Dictionary<String, AudioClip> m_SfxBuffer; //Field offset: 0x30
	private Dictionary<String, NativeAudioPointer> m_AndroidSfxBuffer; //Field offset: 0x38

	public private AudioSource bgm
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public float bgmVolume
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public private GameObject gameObject
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public override bool IsGlobal
	{
		 get { } //Length: 3
	}

	public private FastPool pool
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public AudioManager() { }

	[CompilerGenerated]
	private void <Init>b__15_0(Scene scene1, Scene scene2) { }

	[CompilerGenerated]
	public AudioSource get_bgm() { }

	public float get_bgmVolume() { }

	[CompilerGenerated]
	public GameObject get_gameObject() { }

	public override bool get_IsGlobal() { }

	[CompilerGenerated]
	public FastPool get_pool() { }

	private void Init() { }

	private void OptimizeForVivo(ref int dspBuffer) { }

	public override void Pause(bool pauseCorountine) { }

	public void PauseSfx() { }

	public NativeSource PlayAndroidOneShot(string name, float volume = 1, int index = -1, Action callback = null) { }

	public void PlayBGM(string name, float fadeTime = 0, float volumeFrom = 0, Ease ease = 1, bool forceReplay = false, bool mute = false) { }

	public void PlayBGM(AudioClip clip, float fadeTime = 0, float volumeFrom = 0, Ease ease = 1, bool forceReplay = false) { }

	public void PlayButtonClickedSfx(ClickSfxType sfxType) { }

	public AudioSource PlayLoop(AudioClip clip, float volume = 1) { }

	public AudioSource PlayLoop(string name, float volume = 1) { }

	public void PlayOneShot(AudioSource audioSource, AudioClip clip, float volume = 1) { }

	public AudioSource PlayOneShot(string name, float volume = 1, Action callback = null) { }

	public void PlayOneShot(AudioSource audioSource, string name, float volume = 1) { }

	public AudioSource PlayOneShot(AudioClip clip, float volume = 1, Action callback = null) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator PlayOverCallback(AudioSource audioSource, Action callback) { }

	public void Preload(IList<String> preloadAudioNames, bool isAndroidPreload) { }

	public bool Preload(string assetName, string audioName, bool isAndroidPreload = false) { }

	public bool Preload(string assetName, bool isAndroidPreload = false) { }

	public void PreloadBattleSfx(IList<String> preloadSfx, IList<String> normalSfx, bool isAndroidPreload) { }

	public void Release() { }

	public void Resume(bool isExit, bool includeSfx, Action bgmResumeCallback) { }

	public override void Resume() { }

	public void ResumeSfx() { }

	[CompilerGenerated]
	private void set_bgm(AudioSource value) { }

	public void set_bgmVolume(float value) { }

	[CompilerGenerated]
	private void set_gameObject(GameObject value) { }

	[CompilerGenerated]
	private void set_pool(FastPool value) { }

	public void SetBGMMute(bool mute) { }

	public void StopBGM() { }

	public void StopSound() { }

}

