namespace Rewired;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Browsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[CustomClassObfuscation]
[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ExecuteInEditMode]
public abstract class InputManager_Base : MonoBehaviour
{
	private enum zuKYsqPxvQptfmqhMzzKXRlPhzvj
	{
		Initialization = 0,
		Update = 1,
		Destroy = 2,
	}

	[CustomObfuscation]
	[SerializeField]
	private bool _dontDestroyOnLoad; //Field offset: 0x18
	[CustomObfuscation]
	[SerializeField]
	private UserData _userData; //Field offset: 0x20
	[CustomObfuscation]
	[SerializeField]
	private ControllerDataFiles _controllerDataFiles; //Field offset: 0x28
	protected bool isCompiling; //Field offset: 0x30
	private bool ktHyYOotuGgbxPLLXVwLTXVPmjyu; //Field offset: 0x31
	private bool kiPfNeCLGGlPgtVfeLvLQMWUudCoA; //Field offset: 0x32
	protected EditorPlatform editorPlatform; //Field offset: 0x34
	protected Platform platform; //Field offset: 0x38
	protected WebplayerPlatform webplayerPlatform; //Field offset: 0x3C
	protected bool isEditor; //Field offset: 0x40
	protected bool _detectedPlatformInEditor; //Field offset: 0x41
	[CustomObfuscation]
	protected ScriptingBackend scriptingBackend; //Field offset: 0x44
	[CustomObfuscation]
	protected ScriptingAPILevel scriptingAPILevel; //Field offset: 0x48
	private bool rJhlnMQADcIwmNcaKgPtJcBRIQdWA; //Field offset: 0x4C
	private bool IQfbVrehZXZhnJvwtVTNhsdhGRbbA; //Field offset: 0x4D

	public ControllerDataFiles dataFiles
	{
		 get { } //Length: 5
		 set { } //Length: 212
	}

	internal bool isRunningInEditMode
	{
		internal get { } //Length: 321
	}

	public bool runInEditMode
	{
		 get { } //Length: 36
		 set { } //Length: 326
	}

	public internal UserData userData
	{
		 get { } //Length: 5
		internal set { } //Length: 12
	}

	protected InputManager_Base() { }

	private bool AKuqdwEIoBqEjVHSYKKffFcsUBjG() { }

	[CustomObfuscation]
	private void Awake() { }

	protected abstract void CheckRecompile() { }

	private void cnKeHmkQcxuiGFzzSHmDurQFUSeaA() { }

	private string CXEFXiHGVzunAYrAmeDXHSlTFSPq() { }

	protected abstract void DetectPlatform() { }

	internal void DontDestroyOnLoad() { }

	internal void DoUpdate(UpdateLoopType updateLoopType, UpdateLoopSetting updateLoopSettingBit) { }

	private Byte[] EEcDNSdGPAoRBqUWLKKRFOrPBpMG() { }

	[CustomObfuscation]
	private void FixedUpdate() { }

	[CompilerGenerated]
	private bool fLSIXesCgRpDKZDOUVJUkLgIsKXB(Assembly unnamed_param_0) { }

	public ControllerDataFiles get_dataFiles() { }

	internal bool get_isRunningInEditMode() { }

	public bool get_runInEditMode() { }

	public UserData get_userData() { }

	[CustomObfuscation]
	internal EditorPlatform GetEditorPlatform() { }

	protected abstract IExternalTools GetExternalTools() { }

	[CustomObfuscation]
	internal void GetSupportedEditModeControllerTypes(out bool keyboardSupported, out bool mouseSupported, out bool joystickSupported) { }

	private object GSoGHaRfBJkmDetrGbVpiLzOBgDgA(ConfigVars unnamed_param_0) { }

	private bool hsIMVxgptLTMidISCZPuQZeMSESA() { }

	[CustomObfuscation]
	internal bool IsEditModeSupported() { }

	private void jDObHFiaRlajLrxuLKdjlfyfgylZ(List<TextAsset> unnamed_param_0, List<String> unnamed_param_1) { }

	private List<Assembly> juXnTTzNbgAJEFzlCVYWvmYuazhgA() { }

	[CustomObfuscation]
	private void LateUpdate() { }

	private string LmxihfgGzSbfXkwcmVbfkOamKNxbb() { }

	private bool mtZpHEtomgQRYejregexhFtcOKSg() { }

	[CustomObfuscation]
	private void OnApplicationFocus(bool isFocused) { }

	protected abstract void OnDeinitialized() { }

	[CustomObfuscation]
	private void OnDestroy() { }

	[CustomObfuscation]
	private void OnDisable() { }

	[CustomObfuscation]
	private void OnEnable() { }

	internal void OnGUIUpdate() { }

	protected abstract void OnInitialized() { }

	protected void OnSceneLoaded() { }

	protected void RecompileEnd() { }

	protected void RecompileStart() { }

	[CustomObfuscation]
	internal void ResetAll() { }

	public void set_dataFiles(ControllerDataFiles value) { }

	public void set_runInEditMode(bool value) { }

	internal void set_userData(UserData value) { }

	[CustomObfuscation]
	private void Start() { }

	internal void TryStartRunInEditMode() { }

	internal void TryStopRunInEditMode() { }

	[CustomObfuscation]
	private void Update() { }

	private void vPzyiQOoPAahJlEBrGKSxSgsvaMb(zuKYsqPxvQptfmqhMzzKXRlPhzvj unnamed_param_0, string unnamed_param_1, Exception unnamed_param_2) { }

	private List<Assembly> WKtivovzeWUmpSsqebwaqySOJdRC() { }

}

