namespace RuntimeAudioClipLoader;

public class Manager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public CustomAudioFileReader reader; //Field offset: 0x10

		public <>c__DisplayClass12_0() { }

		internal void <Load>b__0(Single[] target) { }

		internal void <Load>b__1(int target) { }

	}

	private class AudioInstance
	{
		public AudioClip audioClip; //Field offset: 0x10
		public CustomAudioFileReader reader; //Field offset: 0x18
		public Single[] dataToSet; //Field offset: 0x20
		public int samplesCount; //Field offset: 0x28
		public Stream streamToDisposeOnceDone; //Field offset: 0x30

		public int channels
		{
			 get { } //Length: 48
		}

		public int sampleRate
		{
			 get { } //Length: 47
		}

		public AudioInstance() { }

		public int get_channels() { }

		public int get_sampleRate() { }

		public static AudioClip op_Implicit(AudioInstance ai) { }

	}

	private static readonly String[] supportedFormats; //Field offset: 0x0
	private static Dictionary<String, AudioClip> cache; //Field offset: 0x8
	private static Queue<AudioInstance> deferredLoadQueue; //Field offset: 0x10
	private static Queue<AudioInstance> deferredSetDataQueue; //Field offset: 0x18
	private static Queue<AudioInstance> deferredSetFail; //Field offset: 0x20
	private static Thread deferredLoaderThread; //Field offset: 0x28
	private static GameObject managerInstance; //Field offset: 0x30
	private static Dictionary<AudioClip, AudioClipLoadType> audioClipLoadType; //Field offset: 0x38
	private static Dictionary<AudioClip, AudioDataLoadState> audioLoadState; //Field offset: 0x40

	private static Manager() { }

	public Manager() { }

	public static void ClearCache() { }

	private static void DeferredLoaderMain() { }

	private static void EnsureInstanceExists() { }

	public static AudioDataLoadState GetAudioClipLoadState(AudioClip audioClip) { }

	public static AudioClipLoadType GetAudioClipLoadType(AudioClip audioClip) { }

	public static AudioFormat GetAudioFormat(string filePath) { }

	private static string GetExtension(string filePath) { }

	public static bool IsSupportedFormat(string filePath) { }

	public static AudioClip Load(string filePath, bool doStream = false, bool loadInBackground = true, bool useCache = true) { }

	public static AudioClip Load(Stream dataStream, AudioFormat audioFormat, string unityAudioClipName, bool doStream = false, bool loadInBackground = true, bool diposeDataStreamIfNotNeeded = true) { }

	private static void RunDeferredLoaderThread() { }

	public static void SetAudioClipLoadState(AudioClip audioClip, AudioDataLoadState newLoadState) { }

	public static void SetAudioClipLoadType(AudioClip audioClip, AudioClipLoadType newLoadType) { }

	private void Update() { }

}

