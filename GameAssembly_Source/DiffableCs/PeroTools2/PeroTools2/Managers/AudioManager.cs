namespace PeroTools2.Managers;

[Obsolete]
internal class AudioManager : SingletonMonoBehaviourInternal<AudioManager>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public float volume; //Field offset: 0x10
		public AudioManager <>4__this; //Field offset: 0x18

		public <>c__DisplayClass28_0() { }

		internal void <PlayBGM>b__0() { }

	}

	internal struct AndroidPlayCallback
	{
		public float time; //Field offset: 0x0
		public float length; //Field offset: 0x4
		public Action callback; //Field offset: 0x8

	}

	[CompilerGenerated]
	private Pool<AudioSource> <pool>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private AudioSource <bgm>k__BackingField; //Field offset: 0x60
	private Tweener m_BGMTweener; //Field offset: 0x68
	private Dictionary<Int32, Action> m_Callbacks; //Field offset: 0x70
	private List<AndroidPlayCallback> m_AndroidPlayCallbacks; //Field offset: 0x78
	private Dictionary<String, NativeAudioPointer> m_AndroidAudios; //Field offset: 0x80

	public private AudioSource bgm
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private Pool<AudioSource> pool
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public AudioManager() { }

	[CompilerGenerated]
	private void <Init>b__13_0(AudioSource audioClip) { }

	[CompilerGenerated]
	public AudioSource get_bgm() { }

	[CompilerGenerated]
	public Pool<AudioSource> get_pool() { }

	private void Init() { }

	private void OnActiveSceneChanged(Scene scene1, Scene scene2) { }

	public void PauseSfx() { }

	public NativeSource PlayAndroidOneShot(string audioName, float volume = 1, Action callback = null) { }

	public void PlayBGM(AudioClip clip, float fadeTime = 0, float volumeFrom = 0, Ease ease = 1, bool forceReplay = false) { }

	public void PlayBGM(string audioName, float fadeTime = 0, float volumeFrom = 0, Ease ease = 1, bool forceReplay = false) { }

	public AudioSource PlayLoop(string audioName) { }

	public AudioSource PlayLoop(AudioClip clip) { }

	public AudioSource PlayOneShot(AudioClip clip, float volume = 1, Action callback = null) { }

	public AudioSource PlayOneShot(string audioName, float volume = 1, Action callback = null) { }

	public AudioClip[] Preload(IList<String> assetNames, bool isAndroid) { }

	public AudioClip Preload(string assetName, bool isAndroid = false) { }

	public void ResumeSfx() { }

	[CompilerGenerated]
	private void set_bgm(AudioSource value) { }

	[CompilerGenerated]
	private void set_pool(Pool<AudioSource> value) { }

	public void StopBGM() { }

	public void StopSound() { }

	public void Unload(IList<String> unloadUids) { }

	public void Unload() { }

	private void Update() { }

}

