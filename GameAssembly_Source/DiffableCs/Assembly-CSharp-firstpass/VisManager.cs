//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class VisManager : MonoBehaviour
{
	internal enum Channel
	{
		Left = 0,
		Right = 1,
		Average = 2,
		Min = 3,
		Max = 4,
	}

	internal static class Defaults
	{
		public const Channel channel = 0; //Field offset: 0x0
		public const WindowSize windowSize = 1024; //Field offset: 0x0
		public const FFTWindow windowType = 2; //Field offset: 0x0
		public const bool useAudioListener = False; //Field offset: 0x0
		public const bool displaySpectrumDebug = False; //Field offset: 0x0
		public const bool displayDataGroupDebug = False; //Field offset: 0x0
		public const bool displayControllerDebug = False; //Field offset: 0x0
		public const int debugSpectrumBarWidth = 1; //Field offset: 0x0
		public const int debugSpectrumBarHeight = 80; //Field offset: 0x0
		public const int debugRawAudioBarHeight = 40; //Field offset: 0x0
		public const int debugDataGroupBarWidth = 4; //Field offset: 0x0
		public const int debugDataGroupBarHeight = 40; //Field offset: 0x0
		public const int debugControllerBarWidth = 150; //Field offset: 0x0
		public const int debugControllerBarHeight = 6; //Field offset: 0x0
		public const int debugSeparation = 5; //Field offset: 0x0

	}

	internal enum WindowSize
	{
		_64 = 64,
		_128 = 128,
		_256 = 256,
		_512 = 512,
		_1024 = 1024,
		_2048 = 2048,
		_4096 = 4096,
		_8192 = 8192,
	}

	public Channel channel; //Field offset: 0x18
	public WindowSize windowSize; //Field offset: 0x1C
	public FFTWindow windowType; //Field offset: 0x20
	public AudioSource audioSource; //Field offset: 0x28
	public bool displaySpectrumDebug; //Field offset: 0x30
	public bool displayDataGroupDebug; //Field offset: 0x31
	public bool displayControllerDebug; //Field offset: 0x32
	public int debugSpectrumBarWidth; //Field offset: 0x34
	public int debugSpectrumBarHeight; //Field offset: 0x38
	public int debugRawAudioBarHeight; //Field offset: 0x3C
	public int debugDataGroupBarWidth; //Field offset: 0x40
	public int debugDataGroupBarHeight; //Field offset: 0x44
	public int debugControllerBarWidth; //Field offset: 0x48
	public int debugControllerBarHeight; //Field offset: 0x4C
	public int debugSeparation; //Field offset: 0x50
	public Texture debugTexture; //Field offset: 0x58
	private Single[] m_afSpectrumData; //Field offset: 0x60
	private Single[] m_afRawAudioData; //Field offset: 0x68
	private Single[] m_afAuxiliaryData; //Field offset: 0x70
	private List<VisDataGroup> m_oDataGroups; //Field offset: 0x78
	private List<VisBaseController> m_oControllers; //Field offset: 0x80
	private float m_fMaxDebugValue; //Field offset: 0x88
	private int m_nFrequencyRange; //Field offset: 0x8C
	private float m_fFrequencyResolution; //Field offset: 0x90
	private bool m_bUseAudioListener; //Field offset: 0x94

	public ReadOnlyCollection<VisBaseController> Controllers
	{
		 get { } //Length: 151
	}

	public ReadOnlyCollection<VisDataGroup> DataGroups
	{
		 get { } //Length: 139
	}

	public float FrequencyResolution
	{
		 get { } //Length: 9
	}

	public VisManager() { }

	public void AddController(VisBaseController controller) { }

	public void AddDataGroup(VisDataGroup dataGroup) { }

	public void CalculateFrequencyResolution() { }

	public void ClearControllers() { }

	public void ClearDataGroups() { }

	public string EnsureUniqueControllerName(string name) { }

	public string EnsureUniqueDataGroupName(string name) { }

	public ReadOnlyCollection<VisBaseController> get_Controllers() { }

	public ReadOnlyCollection<VisDataGroup> get_DataGroups() { }

	public float get_FrequencyResolution() { }

	public VisBaseController GetControllerByName(string controllerName) { }

	public VisDataGroup GetDataGroupByName(string dataGroupName) { }

	private Color GetDebugColor(int freqIndex, VisDataSource dataSource) { }

	public Single[] GetRawAudioData() { }

	public Single[] GetSpectrumData() { }

	private void OnGUI() { }

	public void RemoveController(VisBaseController controller) { }

	public void RemoveDataGroup(VisDataGroup dataGroup) { }

	public void Reset() { }

	public static bool RestoreVisManagerTarget(IVisManagerTarget target) { }

	public void SetAudioSource(AudioSource _audioSource) { }

	public void Start() { }

	public virtual string ToString() { }

	private void Update() { }

}

