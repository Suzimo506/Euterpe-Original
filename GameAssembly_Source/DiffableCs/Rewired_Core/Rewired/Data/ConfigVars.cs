namespace Rewired.Data;

[CustomClassObfuscation]
public sealed class ConfigVars : IConfigVars_Internal
{
	[CustomObfuscation]
	public enum AllPlatformVar
	{
		DisableKeyboard = 0,
		IgnoreInputWhenAppNotInFocus = 1,
		DisableMouse = 2,
	}

	internal sealed class EditorVars
	{
		public bool exportConsts_useParentClass; //Field offset: 0x10
		public string exportConsts_parentClassName; //Field offset: 0x18
		public bool exportConsts_useNamespace; //Field offset: 0x20
		public string exportConsts_namespace; //Field offset: 0x28
		public bool exportConsts_actions; //Field offset: 0x30
		public string exportConsts_actionsClassName; //Field offset: 0x38
		public bool exportConsts_actionsIncludeActionCategory; //Field offset: 0x40
		public bool exportConsts_actionsCreateClassesForActionCategories; //Field offset: 0x41
		public bool exportConsts_mapCategories; //Field offset: 0x42
		public string exportConsts_mapCategoriesClassName; //Field offset: 0x48
		public bool exportConsts_layouts; //Field offset: 0x50
		public string exportConsts_layoutsClassName; //Field offset: 0x58
		public bool exportConsts_players; //Field offset: 0x60
		public string exportConsts_playersClassName; //Field offset: 0x68
		public bool exportConsts_inputBehaviors; //Field offset: 0x70
		public string exportConsts_inputBehaviorsClassName; //Field offset: 0x78
		public bool exportConsts_customControllers; //Field offset: 0x80
		public string exportConsts_customControllersClassName; //Field offset: 0x88
		public string exportConsts_customControllersAxesClassName; //Field offset: 0x90
		public string exportConsts_customControllersButtonsClassName; //Field offset: 0x98
		public bool exportConsts_layoutManagerRuleSets; //Field offset: 0xA0
		public string exportConsts_layoutManagerRuleSetsClassName; //Field offset: 0xA8
		public bool exportConsts_mapEnablerRuleSets; //Field offset: 0xB0
		public string exportConsts_mapEnablerRuleSetsClassName; //Field offset: 0xB8
		public bool exportConsts_allCapsConstantNames; //Field offset: 0xC0

		public EditorVars() { }

	}

	private static class FUzaRgYhkgOWaAaWfhtLJfjRhwVC
	{
		public const string QQCXpMaaOYduhiEWtonzULRqXSQM = "updateLoop"; //Field offset: 0x0
		public const string WPvAbJXUkUTHexPxZGmUHRdLgkSn = "autoAssignJoysticks"; //Field offset: 0x0
		public const string WBwWZEDFzLpzxvUKuLfigxWfLNLL = "assignJoysticksToPlayingPlayersOnly"; //Field offset: 0x0
		public const string bbQZnwUmAnvuKuWamyEGUsPXaFZg = "distributeJoysticksEvenly"; //Field offset: 0x0
		public const string gYwPCiKrSRPEAyQKagKzHAMwuVKrA = "reassignJoystickToPreviousOwnerOnReconnect"; //Field offset: 0x0
		public const string AXNjYDaOgYurpCCxrRJqerXJDvss = "defaultJoystickAxis2DDeadZoneType"; //Field offset: 0x0
		public const string DQyzxsYqZVqLnMPkTnuweiBfzugh = "defaultJoystickAxis2DSensitivityType"; //Field offset: 0x0
		public const string jCSGAvGOlxNCNefFxNYZsGquOwRJA = "defaultAxisSensitivityType"; //Field offset: 0x0
		public const string KWPIjbyNnlLIBXwBccCSBbhwMZpU = "force4WayHats"; //Field offset: 0x0
		public const string AlicFHgDdIZqDXhnoeZXQqadHODbA = "maxJoysticksPerPlayer"; //Field offset: 0x0
		public const string AdaDOfNXFWDugfLbJvQBbbUGZminA = "throttleCalibrationMode"; //Field offset: 0x0
		public const string WJSMsQmGvewTpyRgodNXPYxNWfgC = "deferControllerConnectedEventsOnStart"; //Field offset: 0x0
		public const string qJdLgxmYaPrRjXlzxjSjTwNLpoaK = "logLevel"; //Field offset: 0x0
		public const string bVQHtCoDrUFafOtcNSaVulycjULN = "disableKeyboard"; //Field offset: 0x0
		public const string xEkbctkMQguqRRiChBVuHLoAUgqm = "disableMouse"; //Field offset: 0x0
		public const string vtxgMihTpzcVnkElACjgfkKqsHBWA = "ignoreInputWhenAppNotInFocus"; //Field offset: 0x0
		public const string ySYqvMecEzNcCCCYPMxIPUQQUkDD = "useEnhancedDeviceSupport"; //Field offset: 0x0
		public const string knDzIHheGUXfNNuxpkbDaMrDlelT = "useNativeMouse"; //Field offset: 0x0
		public const string LsfDeHBXmRETSvCnicIRYoBSIgUZ = "useNativeKeyboard"; //Field offset: 0x0
		public const string GfZrHXfHhoKZZnpMZkFYrKycSZek = "activateActionButtonsOnNegativeValue"; //Field offset: 0x0
		public const string BvFehEkibPXzTGmnHLWLvXhCerJv = "joystickRefreshRate"; //Field offset: 0x0
		public const string xPmHQVFyjWkAgtkPnPjnzqfhLdiR = "allowInputInEditorSceneView"; //Field offset: 0x0
		public const string LLGQngeAIncESxbFBIDElUwFbqUe = "logToScreen"; //Field offset: 0x0
		public const string TGdZeOucnBdwYmqEKrADXjtXeyrI = "alwaysUseUnityInput"; //Field offset: 0x0
		public const string gheBSXPJrehiTgPUhMzILhhMIALo = "windowsStandalonePrimaryInputSource"; //Field offset: 0x0
		public const string xxuuQpDPgkVkNSOhnvlzPgRlyUkS = "osx_primaryInputSource"; //Field offset: 0x0
		public const string aFpbQLeisAjzOUiKoDoYkXfcPpPV = "linux_primaryInputSource"; //Field offset: 0x0
		public const string HKsNYvdpuUbajwaFTlgefrckFeGL = "windowsUWP_primaryInputSource"; //Field offset: 0x0
		public const string GflFPLhpknBISvxlyOwXLWpEBchPA = "xboxOne_primaryInputSource"; //Field offset: 0x0
		public const string xmZpmJGqrkqhJYuTxCTXzbdKhNLkA = "gameCoreXboxOne_primaryInputSource"; //Field offset: 0x0
		public const string RtatjSRnSJAfRbXaIfKVCMNdFReF = "gameCoreScarlett_primaryInputSource"; //Field offset: 0x0
		public const string memJHTlaWccAoLpkKbHjIcDmlHKEA = "runInEditMode"; //Field offset: 0x0
		public const string oFYaxFSWpziVoWcODuuDCnRKBjBM = "ps4_primaryInputSource"; //Field offset: 0x0
		public const string tZlCZzAxElhvjlLMFVqUAoFshvNAb = "webGL_primaryInputSource"; //Field offset: 0x0
		public const string zuzvYfppyKQubSEoXOANDRsUSmVs = "stadia_primaryInputSource"; //Field offset: 0x0
		public const string BhVeHjEZgCPVumNdsanbpfXcxcosA = "useXInput"; //Field offset: 0x0
		public const string mjbnufsRhwigcckwlaYOKIWysrDiA = "windowsStandalone_useSteamRawInputControllerWorkaround"; //Field offset: 0x0
		public const string TChoHkzuyXFzpRNtwLFqRVheURAJ = "osxStandalone_useEnhancedDeviceSupport"; //Field offset: 0x0
		public const string bWaAWfdsRSaxGDjeCcCqZZxTCHLTb = "android_supportUnknownGamepads"; //Field offset: 0x0
		public const string ZpUDCxeWiLOYAOYQYGAfeUsFjHkWA = "ps4_assignJoysticksByPS4JoyId"; //Field offset: 0x0
		public const string pUmeKPEAKrsfAjnBqPEAbCgCSDVuB = "useSteamControllerSupport"; //Field offset: 0x0
		public const string mcGnERUmQuErdBGUVmefgXIekSayA = "ps5_primaryInputSource"; //Field offset: 0x0
		public const string jVnztsgzstggCOTPsUziOBuwPQky = "assignJoysticksBySystemId"; //Field offset: 0x0

	}

	private class OlVknyjKsOjLmmUzibvugogpEQFA
	{
		public Func<Platform, Object> LpYOjGepTjwEENJnjHxqISkMUBOL; //Field offset: 0x10
		public Action<Platform, Object> PBxxvIUQplKLpnHzqhNnJyOUIuKS; //Field offset: 0x18

		public OlVknyjKsOjLmmUzibvugogpEQFA(Func<Platform, Object> unnamed_param_0, Action<Platform, Object> unnamed_param_1) { }

	}

	internal class PlatformVars
	{
		public bool disableKeyboard; //Field offset: 0x10
		public bool disableMouse; //Field offset: 0x11
		public bool ignoreInputWhenAppNotInFocus; //Field offset: 0x12

		public PlatformVars() { }

	}

	internal class PlatformVars_GameCoreScarlett : PlatformVars
	{
		public bool assignJoysticksByUserId; //Field offset: 0x18

		public PlatformVars_GameCoreScarlett() { }

	}

	internal class PlatformVars_GameCoreXboxOne : PlatformVars
	{
		public bool assignJoysticksByUserId; //Field offset: 0x18

		public PlatformVars_GameCoreXboxOne() { }

	}

	internal class PlatformVars_OSXStandalone : PlatformVars
	{
		public bool useAppleGameController; //Field offset: 0x18
		public bool assignJoysticksByUserId; //Field offset: 0x19

		public PlatformVars_OSXStandalone() { }

	}

	internal class PlatformVars_PS5 : PlatformVars
	{
		public bool assignJoysticksByPS5JoyId; //Field offset: 0x18

		public PlatformVars_PS5() { }

	}

	internal class PlatformVars_Stadia : PlatformVars
	{
		public bool useNativeKeyboard; //Field offset: 0x18
		public bool useNativeMouse; //Field offset: 0x19

		public PlatformVars_Stadia() { }

	}

	internal class PlatformVars_WindowsStandalone : PlatformVars
	{
		public bool useNativeKeyboard; //Field offset: 0x18
		public int joystickRefreshRate; //Field offset: 0x1C

		public PlatformVars_WindowsStandalone() { }

	}

	internal class PlatformVars_WindowsUWP : PlatformVars
	{
		public bool useGamepadAPI; //Field offset: 0x18
		public bool useHIDAPI; //Field offset: 0x19

		public PlatformVars_WindowsUWP() { }

	}

	private class TiQCVQksUtLNdEmpydAeeyzyHduA
	{
		public Func<PlatformVars> LpYOjGepTjwEENJnjHxqISkMUBOL; //Field offset: 0x10
		public string hcWQJjwQqNpEAreeCIqVRPYtVIHq; //Field offset: 0x18

		public TiQCVQksUtLNdEmpydAeeyzyHduA(Func<PlatformVars> unnamed_param_0, string unnamed_param_1) { }

	}

	public UpdateLoopSetting updateLoop; //Field offset: 0x10
	public bool alwaysUseUnityInput; //Field offset: 0x14
	public WindowsStandalonePrimaryInputSource windowsStandalonePrimaryInputSource; //Field offset: 0x18
	public OSXStandalonePrimaryInputSource osx_primaryInputSource; //Field offset: 0x1C
	public LinuxStandalonePrimaryInputSource linux_primaryInputSource; //Field offset: 0x20
	public WindowsUWPPrimaryInputSource windowsUWP_primaryInputSource; //Field offset: 0x24
	public XboxOnePrimaryInputSource xboxOne_primaryInputSource; //Field offset: 0x28
	public GameCoreXboxOnePrimaryInputSource gameCoreXboxOne_primaryInputSource; //Field offset: 0x2C
	public GameCoreScarlettPrimaryInputSource gameCoreScarlett_primaryInputSource; //Field offset: 0x30
	public PS4PrimaryInputSource ps4_primaryInputSource; //Field offset: 0x34
	public PS5PrimaryInputSource ps5_primaryInputSource; //Field offset: 0x38
	public WebGLPrimaryInputSource webGL_primaryInputSource; //Field offset: 0x3C
	public StadiaPrimaryInputSource stadia_primaryInputSource; //Field offset: 0x40
	public bool useXInput; //Field offset: 0x44
	public bool useNativeMouse; //Field offset: 0x45
	public bool useEnhancedDeviceSupport; //Field offset: 0x46
	public bool windowsStandalone_useSteamRawInputControllerWorkaround; //Field offset: 0x47
	public bool osxStandalone_useEnhancedDeviceSupport; //Field offset: 0x48
	public bool android_supportUnknownGamepads; //Field offset: 0x49
	public bool ps4_assignJoysticksByPS4JoyId; //Field offset: 0x4A
	public bool useSteamControllerSupport; //Field offset: 0x4B
	public bool logToScreen; //Field offset: 0x4C
	public bool runInEditMode; //Field offset: 0x4D
	public bool allowInputInEditorSceneView; //Field offset: 0x4E
	public PlatformVars_WindowsStandalone platformVars_windowsStandalone; //Field offset: 0x50
	public PlatformVars platformVars_linuxStandalone; //Field offset: 0x58
	public PlatformVars_OSXStandalone platformVars_osxStandalone; //Field offset: 0x60
	public PlatformVars_WindowsUWP platformVars_windowsUWP; //Field offset: 0x68
	public PlatformVars platformVars_iOS; //Field offset: 0x70
	public PlatformVars platformVars_tvOS; //Field offset: 0x78
	public PlatformVars platformVars_android; //Field offset: 0x80
	public PlatformVars platformVars_ps4; //Field offset: 0x88
	public PlatformVars_PS5 platformVars_ps5; //Field offset: 0x90
	public PlatformVars platformVars_psVita; //Field offset: 0x98
	public PlatformVars platformVars_xboxOne; //Field offset: 0xA0
	public PlatformVars_GameCoreXboxOne platformVars_gameCoreXboxOne; //Field offset: 0xA8
	public PlatformVars_GameCoreScarlett platformVars_gameCoreScarlett; //Field offset: 0xB0
	public PlatformVars platformVars_switch; //Field offset: 0xB8
	public PlatformVars platformVars_webGL; //Field offset: 0xC0
	public PlatformVars_Stadia platformVars_stadia; //Field offset: 0xC8
	private PlatformVars platformVars_unknown; //Field offset: 0xD0
	public int maxJoysticksPerPlayer; //Field offset: 0xD8
	public bool autoAssignJoysticks; //Field offset: 0xDC
	public bool assignJoysticksToPlayingPlayersOnly; //Field offset: 0xDD
	public bool distributeJoysticksEvenly; //Field offset: 0xDE
	public bool reassignJoystickToPreviousOwnerOnReconnect; //Field offset: 0xDF
	public DeadZone2DType defaultJoystickAxis2DDeadZoneType; //Field offset: 0xE0
	public AxisSensitivity2DType defaultJoystickAxis2DSensitivityType; //Field offset: 0xE4
	public AxisSensitivityType defaultAxisSensitivityType; //Field offset: 0xE8
	public bool force4WayHats; //Field offset: 0xEC
	public ThrottleCalibrationMode throttleCalibrationMode; //Field offset: 0xF0
	public bool activateActionButtonsOnNegativeValue; //Field offset: 0xF4
	public bool deferControllerConnectedEventsOnStart; //Field offset: 0xF5
	public LogLevelFlags logLevel; //Field offset: 0xF8
	public EditorVars editorSettings; //Field offset: 0x100
	private Dictionary<Int32, TiQCVQksUtLNdEmpydAeeyzyHduA> __platformVarsDict; //Field offset: 0x108
	private Dictionary<Int32, OlVknyjKsOjLmmUzibvugogpEQFA> __getSetPlatformVariableDict; //Field offset: 0x110
	private KeyedGetSetValueStore<String> __configVarsValues; //Field offset: 0x118
	private Dictionary<String, Object> __valueDelegates; //Field offset: 0x120

	private Dictionary<Int32, OlVknyjKsOjLmmUzibvugogpEQFA> getSetPlatformVariableDict
	{
		private get { } //Length: 636
	}

	private Dictionary<Int32, TiQCVQksUtLNdEmpydAeeyzyHduA> platformVarsDict
	{
		private get { } //Length: 2290
	}

	private override KeyedGetSetValueStore<String> Rewired.Data.IConfigVars_Internal.values
	{
		private get { } //Length: 142
	}

	private Dictionary<String, Object> valueDelegates
	{
		private get { } //Length: 6238
	}

	[Preserve]
	public ConfigVars() { }

	[CompilerGenerated]
	private object <get_getSetPlatformVariableDict>b__60_0(Platform p) { }

	[CompilerGenerated]
	private void <get_getSetPlatformVariableDict>b__60_1(Platform platform, object value) { }

	[CompilerGenerated]
	private object <get_getSetPlatformVariableDict>b__60_2(Platform p) { }

	[CompilerGenerated]
	private void <get_getSetPlatformVariableDict>b__60_3(Platform platform, object value) { }

	[CompilerGenerated]
	private object <get_getSetPlatformVariableDict>b__60_4(Platform platform) { }

	[CompilerGenerated]
	private void <get_getSetPlatformVariableDict>b__60_5(Platform platform, object value) { }

	[CompilerGenerated]
	private PlatformVars <get_platformVarsDict>b__57_0() { }

	[CompilerGenerated]
	private PlatformVars <get_platformVarsDict>b__57_1() { }

	[CompilerGenerated]
	private PlatformVars <get_platformVarsDict>b__57_10() { }

	[CompilerGenerated]
	private PlatformVars <get_platformVarsDict>b__57_11() { }

	[CompilerGenerated]
	private PlatformVars <get_platformVarsDict>b__57_12() { }

	[CompilerGenerated]
	private PlatformVars <get_platformVarsDict>b__57_13() { }

	[CompilerGenerated]
	private PlatformVars <get_platformVarsDict>b__57_14() { }

	[CompilerGenerated]
	private PlatformVars <get_platformVarsDict>b__57_15() { }

	[CompilerGenerated]
	private PlatformVars <get_platformVarsDict>b__57_16() { }

	[CompilerGenerated]
	private PlatformVars <get_platformVarsDict>b__57_2() { }

	[CompilerGenerated]
	private PlatformVars <get_platformVarsDict>b__57_3() { }

	[CompilerGenerated]
	private PlatformVars <get_platformVarsDict>b__57_4() { }

	[CompilerGenerated]
	private PlatformVars <get_platformVarsDict>b__57_5() { }

	[CompilerGenerated]
	private PlatformVars <get_platformVarsDict>b__57_6() { }

	[CompilerGenerated]
	private PlatformVars <get_platformVarsDict>b__57_7() { }

	[CompilerGenerated]
	private PlatformVars <get_platformVarsDict>b__57_8() { }

	[CompilerGenerated]
	private PlatformVars <get_platformVarsDict>b__57_9() { }

	[CompilerGenerated]
	private UpdateLoopSetting <get_valueDelegates>b__96_0() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_1(UpdateLoopSetting x) { }

	[CompilerGenerated]
	private WindowsUWPPrimaryInputSource <get_valueDelegates>b__96_10() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_11(WindowsUWPPrimaryInputSource x) { }

	[CompilerGenerated]
	private XboxOnePrimaryInputSource <get_valueDelegates>b__96_12() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_13(XboxOnePrimaryInputSource x) { }

	[CompilerGenerated]
	private GameCoreXboxOnePrimaryInputSource <get_valueDelegates>b__96_14() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_15(GameCoreXboxOnePrimaryInputSource x) { }

	[CompilerGenerated]
	private GameCoreScarlettPrimaryInputSource <get_valueDelegates>b__96_16() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_17(GameCoreScarlettPrimaryInputSource x) { }

	[CompilerGenerated]
	private PS4PrimaryInputSource <get_valueDelegates>b__96_18() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_19(PS4PrimaryInputSource x) { }

	[CompilerGenerated]
	private bool <get_valueDelegates>b__96_2() { }

	[CompilerGenerated]
	private PS5PrimaryInputSource <get_valueDelegates>b__96_20() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_21(PS5PrimaryInputSource x) { }

	[CompilerGenerated]
	private WebGLPrimaryInputSource <get_valueDelegates>b__96_22() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_23(WebGLPrimaryInputSource x) { }

	[CompilerGenerated]
	private StadiaPrimaryInputSource <get_valueDelegates>b__96_24() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_25(StadiaPrimaryInputSource x) { }

	[CompilerGenerated]
	private bool <get_valueDelegates>b__96_26() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_27(bool x) { }

	[CompilerGenerated]
	private bool <get_valueDelegates>b__96_28() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_29(bool x) { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_3(bool x) { }

	[CompilerGenerated]
	private bool <get_valueDelegates>b__96_30() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_31(bool x) { }

	[CompilerGenerated]
	private bool <get_valueDelegates>b__96_32() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_33(bool x) { }

	[CompilerGenerated]
	private bool <get_valueDelegates>b__96_34() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_35(bool x) { }

	[CompilerGenerated]
	private bool <get_valueDelegates>b__96_36() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_37(bool x) { }

	[CompilerGenerated]
	private bool <get_valueDelegates>b__96_38() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_39(bool x) { }

	[CompilerGenerated]
	private WindowsStandalonePrimaryInputSource <get_valueDelegates>b__96_4() { }

	[CompilerGenerated]
	private bool <get_valueDelegates>b__96_40() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_41(bool x) { }

	[CompilerGenerated]
	private bool <get_valueDelegates>b__96_42() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_43(bool x) { }

	[CompilerGenerated]
	private int <get_valueDelegates>b__96_44() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_45(int x) { }

	[CompilerGenerated]
	private bool <get_valueDelegates>b__96_46() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_47(bool x) { }

	[CompilerGenerated]
	private bool <get_valueDelegates>b__96_48() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_49(bool x) { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_5(WindowsStandalonePrimaryInputSource x) { }

	[CompilerGenerated]
	private bool <get_valueDelegates>b__96_50() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_51(bool x) { }

	[CompilerGenerated]
	private bool <get_valueDelegates>b__96_52() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_53(bool x) { }

	[CompilerGenerated]
	private DeadZone2DType <get_valueDelegates>b__96_54() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_55(DeadZone2DType x) { }

	[CompilerGenerated]
	private AxisSensitivity2DType <get_valueDelegates>b__96_56() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_57(AxisSensitivity2DType x) { }

	[CompilerGenerated]
	private AxisSensitivityType <get_valueDelegates>b__96_58() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_59(AxisSensitivityType x) { }

	[CompilerGenerated]
	private OSXStandalonePrimaryInputSource <get_valueDelegates>b__96_6() { }

	[CompilerGenerated]
	private bool <get_valueDelegates>b__96_60() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_61(bool x) { }

	[CompilerGenerated]
	private ThrottleCalibrationMode <get_valueDelegates>b__96_62() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_63(ThrottleCalibrationMode x) { }

	[CompilerGenerated]
	private bool <get_valueDelegates>b__96_64() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_65(bool x) { }

	[CompilerGenerated]
	private bool <get_valueDelegates>b__96_66() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_67(bool x) { }

	[CompilerGenerated]
	private LogLevelFlags <get_valueDelegates>b__96_68() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_69(LogLevelFlags x) { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_7(OSXStandalonePrimaryInputSource x) { }

	[CompilerGenerated]
	private bool <get_valueDelegates>b__96_70() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_71(bool x) { }

	[CompilerGenerated]
	private bool <get_valueDelegates>b__96_72() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_73(bool x) { }

	[CompilerGenerated]
	private bool <get_valueDelegates>b__96_74() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_75(bool x) { }

	[CompilerGenerated]
	private bool <get_valueDelegates>b__96_76() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_77(bool x) { }

	[CompilerGenerated]
	private bool <get_valueDelegates>b__96_78() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_79(bool x) { }

	[CompilerGenerated]
	private LinuxStandalonePrimaryInputSource <get_valueDelegates>b__96_8() { }

	[CompilerGenerated]
	private bool <get_valueDelegates>b__96_80() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_81(bool x) { }

	[CompilerGenerated]
	private int <get_valueDelegates>b__96_82() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_83(int x) { }

	[CompilerGenerated]
	private bool <get_valueDelegates>b__96_84() { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_85(bool x) { }

	[CompilerGenerated]
	private void <get_valueDelegates>b__96_9(LinuxStandalonePrimaryInputSource x) { }

	internal bool DoesPlatformUseFallback(Platform platform, WebplayerPlatform webplayerPlatform, bool isEditor) { }

	internal bool DoesPlatformUseSDL2(Platform platform, WebplayerPlatform webplayerPlatform, bool isEditor) { }

	[CustomObfuscation]
	internal T Editor_GetAllSerializedPlatformVar(AllPlatformVar var) { }

	[CustomObfuscation]
	internal void Editor_SetAllSerializedPlatformVar(AllPlatformVar var, object value) { }

	private Dictionary<Int32, OlVknyjKsOjLmmUzibvugogpEQFA> get_getSetPlatformVariableDict() { }

	private Dictionary<Int32, TiQCVQksUtLNdEmpydAeeyzyHduA> get_platformVarsDict() { }

	private Dictionary<String, Object> get_valueDelegates() { }

	private MultiBoolValue GetAllSerializedPlatformVar_multiBool(AllPlatformVar var) { }

	internal string GetDebugConfigSettings() { }

	private T GetOrCreatePlatformVars(ref T var) { }

	internal bool GetPlatformVar_assignJoysticksBySystemId() { }

	internal bool GetPlatformVar_disableKeyboard() { }

	internal bool GetPlatformVar_disableMouse() { }

	internal bool GetPlatformVar_ignoreInputWhenAppNotInFocus() { }

	internal int GetPlatformVar_joystickRefreshRate() { }

	internal bool GetPlatformVar_useAppleGameController() { }

	internal bool GetPlatformVar_useEnhancedDeviceSupport() { }

	internal bool GetPlatformVar_useNativeKeyboard() { }

	internal bool GetPlatformVar_useNativeMouse() { }

	private PlatformVars GetPlatformVars() { }

	[CustomObfuscation]
	internal PlatformVars GetPlatformVars(Platform platform) { }

	[CustomObfuscation]
	internal string GetPlatformVarsRelPath(Platform platform) { }

	internal bool IsEditModeInputSupported(ControllerType controllerType, EditorPlatform editorPlatform) { }

	private override KeyedGetSetValueStore<String> Rewired.Data.IConfigVars_Internal.get_values() { }

	internal bool SetPlatformVar_assignJoysticksBySystemId(bool value) { }

	internal bool SetPlatformVar_disableKeyboard(bool value) { }

	internal bool SetPlatformVar_disableMouse(bool value) { }

	internal bool SetPlatformVar_ignoreInputWhenAppNotInFocus(bool value) { }

	internal bool SetPlatformVar_joystickRefreshRate(int value) { }

	internal bool SetPlatformVar_useAppleGameController(bool value) { }

	internal bool SetPlatformVar_useEnhancedDeviceSupport(bool value) { }

	internal bool SetPlatformVar_useNativeKeyboard(bool value) { }

	internal bool SetPlatformVar_useNativeMouse(bool value) { }

}

