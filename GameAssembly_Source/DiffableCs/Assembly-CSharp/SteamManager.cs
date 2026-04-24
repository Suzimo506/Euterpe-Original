//Type is in global namespace

[DisallowMultipleComponent]
public class SteamManager : SingletonMonoBehaviour<SteamManager>
{
	protected static bool s_EverInitialized; //Field offset: 0x0
	protected bool m_bInitialized; //Field offset: 0x18
	protected SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook; //Field offset: 0x20
	private bool m_DoSomething1; //Field offset: 0x28
	private bool m_DoSomething3; //Field offset: 0x29

	public bool dlcVerify
	{
		 get { } //Length: 12
	}

	public static bool Initialized
	{
		 get { } //Length: 62
	}

	private static SteamManager() { }

	public SteamManager() { }

	protected override void Awake() { }

	public void DLCVerify() { }

	private bool DoSomething1() { }

	public bool get_dlcVerify() { }

	public static bool get_Initialized() { }

	[RuntimeInitializeOnLoadMethod]
	private static void InitOnPlayMode() { }

	public void JumpToStore() { }

	protected override void OnDestroy() { }

	protected override void OnEnable() { }

	[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText) { }

	private void SuffixInit() { }

	protected override void Update() { }

}

