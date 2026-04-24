namespace PeroTools2.Managers;

[Obsolete]
public abstract class AudioSystem : SerializedMonoBehaviour
{
	private AudioManager m_AudioManager; //Field offset: 0x58
	private bool m_Inited; //Field offset: 0x60

	private AudioManager audioManager
	{
		private get { } //Length: 83
	}

	public AudioSource bgm
	{
		 get { } //Length: 62
	}

	public Pool<AudioSource> pool
	{
		 get { } //Length: 62
	}

	protected AudioSystem() { }

	private AudioManager get_audioManager() { }

	public AudioSource get_bgm() { }

	public Pool<AudioSource> get_pool() { }

	public void PauseSfx() { }

	public NativeSource PlayAndroidOneShot(string audioName, float volume = 1, Action callback = null) { }

	public void PlayBGM(string audioName, float fadeTime = 0, float volumeFrom = 0, Ease ease = 1, bool forceReplay = false) { }

	public void PlayBGM(AudioClip clip, float fadeTime = 0, float volumeFrom = 0, Ease ease = 1, bool forceReplay = false) { }

	public AudioSource PlayLoop(AudioClip clip) { }

	public AudioSource PlayLoop(string audioName) { }

	public AudioSource PlayOneShot(string audioName, float volume = 1, Action callback = null) { }

	public AudioSource PlayOneShot(AudioClip clip, float volume = 1, Action callback = null) { }

	public AudioClip[] Preload(IList<String> assetNames, bool isAndroid = false) { }

	public AudioClip Preload(string assetName, bool isAndroid = false) { }

	public void ResumeSfx() { }

	public void StopBGM() { }

	public void StopSound() { }

	public void Unload(IList<String> unloadUids) { }

	public void Unload() { }

}

