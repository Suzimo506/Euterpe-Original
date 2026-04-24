namespace Rewired.Utils;

public static class UnityTools
{
	internal enum UnityVersion
	{
		UNITY_2_6 = 0,
		UNITY_2_6_1 = 1,
		UNITY_3_0 = 2,
		UNITY_3_0_0 = 3,
		UNITY_3_1 = 4,
		UNITY_3_2 = 5,
		UNITY_3_3 = 6,
		UNITY_3_4 = 7,
		UNITY_3_5 = 8,
		UNITY_3_5_2 = 9,
		UNITY_3_5_7 = 10,
		UNITY_3_MAX = 11,
		UNITY_4_0 = 12,
		UNITY_4_0_1 = 13,
		UNITY_4_1 = 14,
		UNITY_4_2 = 15,
		UNITY_4_3 = 16,
		UNITY_4_4 = 17,
		UNITY_4_5 = 18,
		UNITY_4_6 = 19,
		UNITY_4_6_3p1 = 20,
		UNITY_4_6_3p1Plus = 21,
		UNITY_4_7 = 22,
		UNITY_4_8 = 23,
		UNITY_4_9 = 24,
		UNITY_4_MAX = 25,
		UNITY_5_0 = 26,
		UNITY_5_0_0p1 = 27,
		UNITY_5_0_0p1Plus = 28,
		UNITY_5_0_1 = 29,
		UNITY_5_0_2 = 30,
		UNITY_5_1 = 31,
		UNITY_5_2 = 32,
		UNITY_5_3 = 33,
		UNITY_5_4 = 34,
		UNITY_5_5 = 35,
		UNITY_5_6 = 36,
		UNITY_5_7 = 37,
		UNITY_5_8 = 38,
		UNITY_5_9 = 39,
		UNITY_5_MAX = 40,
		UNITY_2017_0 = 41,
		UNITY_2017_1 = 42,
		UNITY_2017_2 = 43,
		UNITY_2017_3 = 44,
		UNITY_2017_4 = 45,
		UNITY_2017_5 = 46,
		UNITY_2017_6 = 47,
		UNITY_2017_7 = 48,
		UNITY_2017_8 = 49,
		UNITY_2017_9 = 50,
		UNITY_2017_MAX = 51,
		UNITY_2018_0 = 52,
		UNITY_2018_1 = 53,
		UNITY_2018_2 = 54,
		UNITY_2018_3 = 55,
		UNITY_2018_4 = 56,
		UNITY_2018_5 = 57,
		UNITY_2018_6 = 58,
		UNITY_2018_7 = 59,
		UNITY_2018_8 = 60,
		UNITY_2018_9 = 61,
		UNITY_2018_MAX = 62,
		UNITY_2019_0 = 63,
		UNITY_2019_1 = 64,
		UNITY_2019_2 = 65,
		UNITY_2019_3 = 66,
		UNITY_2019_4 = 67,
		UNITY_2019_5 = 68,
		UNITY_2019_6 = 69,
		UNITY_2019_7 = 70,
		UNITY_2019_8 = 71,
		UNITY_2019_9 = 72,
		UNITY_2019_MAX = 73,
		UNITY_2020_0 = 74,
		UNITY_2020_1 = 75,
		UNITY_2020_2 = 76,
		UNITY_2020_3 = 77,
		UNITY_2020_4 = 78,
		UNITY_2020_5 = 79,
		UNITY_2020_6 = 80,
		UNITY_2020_7 = 81,
		UNITY_2020_8 = 82,
		UNITY_2020_9 = 83,
		UNITY_2020_MAX = 84,
		UNITY_2021_0 = 85,
		UNITY_2021_1 = 86,
		UNITY_2021_2 = 87,
		UNITY_2021_3 = 88,
		UNITY_2021_4 = 89,
		UNITY_2021_5 = 90,
		UNITY_2021_6 = 91,
		UNITY_2021_7 = 92,
		UNITY_2021_8 = 93,
		UNITY_2021_9 = 94,
		UNITY_2021_MAX = 95,
		UNITY_2022_0 = 96,
		UNITY_2022_1 = 97,
		UNITY_2022_2 = 98,
		UNITY_2022_3 = 99,
		UNITY_2022_4 = 100,
		UNITY_2022_5 = 101,
		UNITY_2022_6 = 102,
		UNITY_2022_7 = 103,
		UNITY_2022_8 = 104,
		UNITY_2022_9 = 105,
		UNITY_2022_MAX = 106,
		UNITY_2023_0 = 107,
		UNITY_2023_1 = 108,
		UNITY_2023_2 = 109,
		UNITY_2023_3 = 110,
		UNITY_2023_4 = 111,
		UNITY_2023_5 = 112,
		UNITY_2023_6 = 113,
		UNITY_2023_7 = 114,
		UNITY_2023_8 = 115,
		UNITY_2023_9 = 116,
		UNITY_2023_MAX = 117,
		UNITY_2024_0 = 118,
		UNITY_2024_1 = 119,
		UNITY_2024_2 = 120,
		UNITY_2024_3 = 121,
		UNITY_2024_4 = 122,
		UNITY_2024_5 = 123,
		UNITY_2024_6 = 124,
		UNITY_2024_7 = 125,
		UNITY_2024_8 = 126,
		UNITY_2024_9 = 127,
		UNITY_2024_MAX = 128,
		UNITY_2025_0 = 129,
		UNITY_2025_1 = 130,
		UNITY_2025_2 = 131,
		UNITY_2025_3 = 132,
		UNITY_2025_4 = 133,
		UNITY_2025_5 = 134,
		UNITY_2025_6 = 135,
		UNITY_2025_7 = 136,
		UNITY_2025_8 = 137,
		UNITY_2025_9 = 138,
		UNITY_2025_MAX = 139,
		Unknown = 1000,
	}

	[CustomClassObfuscation]
	[CustomObfuscation]
	public class UnityVersionClass
	{
		internal enum LLOpJEJyOLbzIpqxGBerCKwrzHHG
		{
			Normal = 0,
			Beta = 1,
			Patch = 2,
		}

		public readonly int major; //Field offset: 0x10
		public readonly int minor; //Field offset: 0x14
		public readonly int maintenance; //Field offset: 0x18
		public readonly LLOpJEJyOLbzIpqxGBerCKwrzHHG type; //Field offset: 0x1C
		public readonly int build; //Field offset: 0x20

		public UnityVersionClass(string unnamed_param_0) { }

		public static int Comparison(UnityVersionClass a, UnityVersionClass b) { }

		public virtual bool Equals(object obj) { }

		public virtual int GetHashCode() { }

		public static bool IsValidVersionString(string versionString) { }

		public static bool op_Equality(UnityVersionClass a, UnityVersionClass b) { }

		public static bool op_GreaterThan(UnityVersionClass a, UnityVersionClass b) { }

		public static bool op_GreaterThanOrEqual(UnityVersionClass a, UnityVersionClass b) { }

		public static bool op_Inequality(UnityVersionClass a, UnityVersionClass b) { }

		public static bool op_LessThan(UnityVersionClass a, UnityVersionClass b) { }

		public static bool op_LessThanOrEqual(UnityVersionClass a, UnityVersionClass b) { }

		private string THgmYokUahfHEXIQfcjpfqgflFjyA(LLOpJEJyOLbzIpqxGBerCKwrzHHG unnamed_param_0) { }

		public virtual string ToString() { }

		private static int wSfFGOaIQJqgopGFQPTSFpHfgTYbA(LLOpJEJyOLbzIpqxGBerCKwrzHHG unnamed_param_0) { }

	}

	private const UnityVersion uHTGWfUmhelYHryANtpVjBzKgwtm = 26; //Field offset: 0x0
	private static UnityVersionClass VcBMbqAWprTAsNXezTcybIbNgLTCA; //Field offset: 0x0
	private static UnityVersion nRibjIBLkTdVEIZHSqXYHgndOIuf; //Field offset: 0x8
	private static string PTSnGIRSSOjhRRCuKgNkfURpIktqA; //Field offset: 0x10
	private static Platform MBqjDOgyHVSNWhzxskEfbEZGShWI; //Field offset: 0x18
	private static EditorPlatform zrUeTGKXDanRYngjElNdJDGAdTYIA; //Field offset: 0x1C
	private static bool FlVYmywTrCQuLcLOmdAdEKbbsRMBA; //Field offset: 0x20
	private static bool hjEORYlwRkCQFDcLQMEZzkobBEql; //Field offset: 0x21
	private static bool gMNLTZyRhIeEfAINvADSjfPtBDWHA; //Field offset: 0x22
	private static WebplayerPlatform XpBsBVeTsuLLEJTRyRugRSxcoyOk; //Field offset: 0x24
	private static bool soghpMWeAJGgdcGfhsjEZretFWaG; //Field offset: 0x28
	private static bool fRYJCFYeRieDtfEiNshRgpmKTgRQ; //Field offset: 0x29
	private static bool xqmnvWmvuPMWKiiIChOuxJhjBzdy; //Field offset: 0x2A
	private static bool dzAYTLhyNoSNxVEZSbJKefsowagRA; //Field offset: 0x2B
	private static bool iqyhhFNqNFfwmwsXTAowIvISDFdgb; //Field offset: 0x2C
	private static bool HjIxteYCBpcxWdYFQZkVWIPKGNSh; //Field offset: 0x2D
	private static string fevHbQIZrLlIBAGTfDPCjuuYLHjYA; //Field offset: 0x30
	private static ScriptingBackend rCHCajGPpulzFegqbbNKSGVLAzfCA; //Field offset: 0x38
	private static ScriptingAPILevel WcIJjoqcBQnxbQYUypKFrpSnAOIj; //Field offset: 0x3C
	private static bool oroYlPDfutSXpIiQakRUUViVyoAJ; //Field offset: 0x40
	private static IExternalTools JMzBkBDdhjQYBBkThlojQOjCMOMpA; //Field offset: 0x48
	[CompilerGenerated]
	private static IAndroidFallbackPlatformHelper BAFiRUbPPZOPlBGjGwtrKaTjbYnjc; //Field offset: 0x50
	private static bool oVcTpaxNAcGoMVonVuWneaDTHWGu; //Field offset: 0x58

	internal static IAndroidFallbackPlatformHelper BveGZfXptcSHOeUPEnWpFRNiBkCk
	{
		[CompilerGenerated]
		internal get { } //Length: 87
		[CompilerGenerated]
		internal set { } //Length: 103
	}

	public static EditorPlatform editorPlatform
	{
		 get { } //Length: 198
	}

	[CustomObfuscation]
	internal static bool editorPlatformMatchesBuildPlatform
	{
		internal get { } //Length: 414
	}

	[CustomObfuscation]
	internal static Platform effectivePlatform
	{
		internal get { } //Length: 325
	}

	public static IExternalTools externalTools
	{
		 get { } //Length: 199
	}

	public static bool isAndroidPlatform
	{
		 get { } //Length: 343
	}

	public static bool isDebugBuild
	{
		 get { } //Length: 199
	}

	public static bool isEditor
	{
		 get { } //Length: 199
	}

	[CustomObfuscation]
	internal static bool isInitialized
	{
		internal get { } //Length: 87
	}

	public static bool isIOSPlatform
	{
		 get { } //Length: 249
	}

	public static bool isPlaying
	{
		 get { } //Length: 87
	}

	public static bool isStandalonePlatform
	{
		 get { } //Length: 296
	}

	public static bool isSupportedVersion3
	{
		 get { } //Length: 199
	}

	public static bool isSupportedVersion4
	{
		 get { } //Length: 199
	}

	private static bool ktHyYOotuGgbxPLLXVwLTXVPmjyu
	{
		private get { } //Length: 72
	}

	public static bool logToDebugLog
	{
		 get { } //Length: 471
	}

	public static Platform platform
	{
		 get { } //Length: 198
	}

	[CustomObfuscation]
	internal static ScriptingAPILevel scriptingAPILevel
	{
		internal get { } //Length: 86
	}

	[CustomObfuscation]
	internal static ScriptingBackend scriptingBackend
	{
		internal get { } //Length: 86
	}

	public static bool supports2DColliders
	{
		 get { } //Length: 202
	}

	public static bool supportsNestedPrefabs
	{
		 get { } //Length: 202
	}

	public static bool supportsSortingLayers
	{
		 get { } //Length: 202
	}

	public static bool supportsStadia
	{
		 get { } //Length: 202
	}

	public static bool supportsTouchControls
	{
		 get { } //Length: 202
	}

	public static bool supportsUnityUI
	{
		 get { } //Length: 202
	}

	public static bool supportsUnityUIGraphicRaycastTarget
	{
		 get { } //Length: 202
	}

	public static bool supportsWindowsAppStore
	{
		 get { } //Length: 249
	}

	public static bool supportsWindowsUWP
	{
		 get { } //Length: 202
	}

	public static bool supportsWindowsUWP_IL2CPP
	{
		 get { } //Length: 202
	}

	public static bool supportsXboxOne
	{
		 get { } //Length: 202
	}

	public static UnityVersion unityVersion
	{
		 get { } //Length: 201
	}

	[CustomObfuscation]
	internal static UnityVersionClass unityVersionObj
	{
		internal get { } //Length: 198
	}

	public static string unityVersionString
	{
		 get { } //Length: 214
	}

	public static WebplayerPlatform webplayerPlatform
	{
		 get { } //Length: 198
	}

	public static bool windowsJoystickNamesReturnsEmptyStringsIfJoystickNull
	{
		 get { } //Length: 199
	}

	public static bool windowsStandalone_supportsRawInputForwarding
	{
		 get { } //Length: 199
	}

	private static UnityTools() { }

	private static void BhNPKHymPMMvxOxLunEXJmVEyfUT() { }

	private static UnityVersion bmyvhPDNxaqmEFaXdgDgBZvAxpfR(string unnamed_param_0) { }

	internal static void cnKeHmkQcxuiGFzzSHmDurQFUSeaA(Platform unnamed_param_0, EditorPlatform unnamed_param_1, bool unnamed_param_2, WebplayerPlatform unnamed_param_3, ScriptingBackend unnamed_param_4, ScriptingAPILevel unnamed_param_5, IExternalTools unnamed_param_6) { }

	public static AnimationCurve Copy(AnimationCurve orig) { }

	public static void DebugDrawCross(Vector3 position, float length, Color color, float duration) { }

	public static void DebugDrawCross(Vector3 position, float length, Color color) { }

	public static WebplayerPlatform DetermineWebplayerPlatformType(Platform platform, EditorPlatform editorPlatform) { }

	[CompilerGenerated]
	internal static void DwqAXKqjcKsxbvDSZiUMrocIasaz(IAndroidFallbackPlatformHelper unnamed_param_0) { }

	private static Type EKImwQSBnuOWDVVgElCXIgFAFEHu(wGtjUNAQFhrxRtWNLGFYJnqfKVie unnamed_param_0) { }

	public static GameObject FindGameObjectInChildren(Transform transform, string name) { }

	public static GameObject FindGameObjectInChildren(GameObject gameObject, string name) { }

	public static Transform FindTransformInChildren(Transform transform, string name) { }

	public static Transform FindTransformInChildren(GameObject gameObject, string name) { }

	public static void ForEachComponent(Component component, Action<T> delegate) { }

	public static void ForEachComponent(Transform transform, Action<T> delegate, bool includeChildren) { }

	public static void ForEachComponent(Transform transform, Action<T> delegate) { }

	public static void ForEachComponent(Component component, Action<T> delegate, bool includeChildren) { }

	public static void ForEachComponent(GameObject gameObject, Action<T> delegate, bool includeChildren) { }

	public static void ForEachComponent(GameObject gameObject, Action<T> delegate) { }

	public static void ForEachComponentInChildren(Transform transform, Action<T> delegate) { }

	public static void ForEachComponentInChildren(GameObject gameObject, Action<T> delegate) { }

	public static void ForEachComponentInChildren(Component component, Action<T> delegate) { }

	private static UnityVersion gAvSMJADWQpRMTGJTvoFqKapPwrj(int unnamed_param_0) { }

	public static EditorPlatform get_editorPlatform() { }

	internal static bool get_editorPlatformMatchesBuildPlatform() { }

	internal static Platform get_effectivePlatform() { }

	public static IExternalTools get_externalTools() { }

	public static bool get_isAndroidPlatform() { }

	public static bool get_isDebugBuild() { }

	public static bool get_isEditor() { }

	internal static bool get_isInitialized() { }

	public static bool get_isIOSPlatform() { }

	public static bool get_isPlaying() { }

	public static bool get_isStandalonePlatform() { }

	public static bool get_isSupportedVersion3() { }

	public static bool get_isSupportedVersion4() { }

	public static bool get_logToDebugLog() { }

	public static Platform get_platform() { }

	internal static ScriptingAPILevel get_scriptingAPILevel() { }

	internal static ScriptingBackend get_scriptingBackend() { }

	public static bool get_supports2DColliders() { }

	public static bool get_supportsNestedPrefabs() { }

	public static bool get_supportsSortingLayers() { }

	public static bool get_supportsStadia() { }

	public static bool get_supportsTouchControls() { }

	public static bool get_supportsUnityUI() { }

	public static bool get_supportsUnityUIGraphicRaycastTarget() { }

	public static bool get_supportsWindowsAppStore() { }

	public static bool get_supportsWindowsUWP() { }

	public static bool get_supportsWindowsUWP_IL2CPP() { }

	public static bool get_supportsXboxOne() { }

	public static UnityVersion get_unityVersion() { }

	internal static UnityVersionClass get_unityVersionObj() { }

	public static string get_unityVersionString() { }

	public static WebplayerPlatform get_webplayerPlatform() { }

	public static bool get_windowsJoystickNamesReturnsEmptyStringsIfJoystickNull() { }

	public static bool get_windowsStandalone_supportsRawInputForwarding() { }

	public static T GetComponent(Transform transform) { }

	public static Component GetComponent(GameObject gameObject, Type type) { }

	public static Component GetComponent(Component component, Type type) { }

	public static Component GetComponent(GameObject gameObject, Type type, bool includeInactive) { }

	public static Component GetComponent(Transform transform, Type type) { }

	public static Component GetComponent(Transform transform, Type type, bool includeInactive) { }

	public static T GetComponent(GameObject gameObject, bool includeInactive) { }

	public static T GetComponent(Component component, bool includeInactive) { }

	public static T GetComponent(Transform transform, bool includeInactive) { }

	public static T GetComponent(GameObject gameObject) { }

	public static T GetComponent(Component component) { }

	public static Component GetComponent(Component component, Type type, bool includeInactive) { }

	public static Component GetComponentInChildren(GameObject gameObject, Type type, bool includeInactive) { }

	public static Component GetComponentInChildren(Component component, Type type, bool includeInactive) { }

	public static Component GetComponentInChildren(Transform transform, Type type) { }

	public static Component GetComponentInChildren(Transform transform, Type type, bool includeInactive) { }

	public static Component GetComponentInChildren(GameObject gameObject, Type type) { }

	public static T GetComponentInChildren(GameObject gameObject) { }

	public static T GetComponentInChildren(Component component) { }

	public static T GetComponentInChildren(Transform transform) { }

	public static Component GetComponentInChildren(Component component, Type type) { }

	public static T GetComponentInChildren(GameObject gameObject, bool includeInactive) { }

	public static T GetComponentInChildren(Transform transform, bool includeInactive) { }

	public static T GetComponentInChildren(Component component, bool includeInactive) { }

	public static T GetComponentInParents(GameObject gameObject) { }

	public static T GetComponentInParents(Component component) { }

	public static T GetComponentInParents(Transform transform) { }

	public static T GetComponentInSelfOrChildren(Component component) { }

	public static T GetComponentInSelfOrChildren(Transform transform) { }

	public static T GetComponentInSelfOrChildren(GameObject gameObject) { }

	public static T GetComponentInSelfOrParents(Component component) { }

	public static T GetComponentInSelfOrParents(GameObject gameObject) { }

	public static T GetComponentInSelfOrParents(Transform transform) { }

	public static int GetComponents(Component component, List<T> results, bool append) { }

	public static int GetComponents(GameObject gameObject, Type type, List<Component> results, bool append) { }

	public static int GetComponents(Component component, Type type, List<Component> results, bool append) { }

	public static int GetComponents(Transform transform, Type type, List<Component> results, bool append) { }

	public static int GetComponents(GameObject gameObject, List<Component> results, bool append) { }

	public static int GetComponents(Component component, List<Component> results, bool append) { }

	public static int GetComponents(Transform transform, List<Component> results, bool append) { }

	public static int GetComponents(GameObject gameObject, bool includeInactive, List<T> results, bool append) { }

	public static int GetComponents(Transform transform, bool includeInactive, List<T> results, bool append) { }

	public static int GetComponents(GameObject gameObject, List<T> results, bool append) { }

	public static int GetComponents(Transform transform, List<T> results, bool append) { }

	public static int GetComponents(Component component, bool includeInactive, List<T> results, bool append) { }

	public static List<Component> GetComponents(Component component, Type type) { }

	public static List<Component> GetComponents(GameObject gameObject, Type type) { }

	public static List<Component> GetComponents(GameObject gameObject, Type type, bool includeInactive) { }

	public static List<Component> GetComponents(Transform transform, Type type) { }

	public static List<T> GetComponents(GameObject gameObject, bool includeInactive) { }

	public static List<T> GetComponents(Component component, bool includeInactive) { }

	public static List<Component> GetComponents(Component component, Type type, bool includeInactive) { }

	public static List<Component> GetComponents(Transform transform, Type type, bool includeInactive) { }

	public static List<T> GetComponents(Transform transform, bool includeInactive) { }

	public static List<T> GetComponents(GameObject gameObject) { }

	public static List<T> GetComponents(Component component) { }

	public static List<T> GetComponents(Transform transform) { }

	public static int GetComponentsInChildren(GameObject gameObject, bool includeInactive, List<T> results, bool append) { }

	public static int GetComponentsInChildren(Component component, bool includeInactive, List<T> results, bool append) { }

	public static int GetComponentsInChildren(Component component, List<Component> results, bool append) { }

	public static int GetComponentsInChildren(GameObject gameObject, List<T> results, bool append) { }

	public static int GetComponentsInChildren(Component component, List<T> results, bool append) { }

	public static int GetComponentsInChildren(Transform transform, List<T> results, bool append) { }

	public static List<T> GetComponentsInChildren(Transform transform, bool includeInactive) { }

	public static int GetComponentsInChildren(Transform transform, List<Component> results, bool append) { }

	public static int GetComponentsInChildren(Transform transform, bool includeInactive, List<T> results, bool append) { }

	public static int GetComponentsInChildren(GameObject gameObject, List<Component> results, bool append) { }

	public static List<T> GetComponentsInChildren(Component component, bool includeInactive) { }

	public static List<Component> GetComponentsInChildren(GameObject gameObject) { }

	public static List<T> GetComponentsInChildren(GameObject gameObject, bool includeInactive) { }

	public static List<Component> GetComponentsInChildren(Transform transform) { }

	public static List<Component> GetComponentsInChildren(Component component) { }

	public static List<T> GetComponentsInChildren(Transform transform) { }

	public static List<T> GetComponentsInChildren(Component component) { }

	public static List<T> GetComponentsInChildren(GameObject gameObject) { }

	public static int GetComponentsInParents(Transform transform, List<Component> results, bool append) { }

	public static int GetComponentsInParents(GameObject gameObject, List<Component> results, bool append) { }

	public static int GetComponentsInParents(Component component, List<Component> results, bool append) { }

	public static int GetComponentsInParents(GameObject gameObject, List<T> results, bool append) { }

	public static int GetComponentsInParents(Component component, List<T> results, bool append) { }

	public static List<T> GetComponentsInParents(Transform transform) { }

	public static List<T> GetComponentsInParents(Component component) { }

	public static List<T> GetComponentsInParents(GameObject gameObject) { }

	public static int GetComponentsInParents(Transform transform, List<T> results, bool append) { }

	public static List<Component> GetComponentsInParents(Component component) { }

	public static List<Component> GetComponentsInParents(GameObject gameObject) { }

	public static List<Component> GetComponentsInParents(Transform transform) { }

	public static int GetComponentsInSelfAndChildren(GameObject gameObject, List<Component> results, bool append) { }

	public static int GetComponentsInSelfAndChildren(Transform transform, List<T> results, bool append) { }

	public static int GetComponentsInSelfAndChildren(Component component, List<T> results, bool append) { }

	public static int GetComponentsInSelfAndChildren(GameObject gameObject, List<T> results, bool append) { }

	public static int GetComponentsInSelfAndChildren(Transform transform, List<Component> results, bool append) { }

	public static int GetComponentsInSelfAndChildren(Component component, List<Component> results, bool append) { }

	public static int GetComponentsInSelfAndChildren(Component component, bool includeInactive, List<T> results, bool append) { }

	public static int GetComponentsInSelfAndChildren(GameObject gameObject, bool includeInactive, List<T> results, bool append) { }

	public static List<T> GetComponentsInSelfAndChildren(GameObject gameObject) { }

	public static int GetComponentsInSelfAndChildren(Transform transform, bool includeInactive, List<T> results, bool append) { }

	public static List<T> GetComponentsInSelfAndChildren(Transform transform) { }

	public static List<T> GetComponentsInSelfAndChildren(Component component) { }

	public static List<String> GetCurrentPlatformResourecesDLLPaths() { }

	public static string GetUnityInputAxisName(int unityJoystickIndex, int axisIndex) { }

	public static string GetUnityInputAxisNameByJoystickId(int unityJoystickId, int axisIndex) { }

	public static string GetUnityInputButtonName(int unityJoystickIndex, int buttonIndex) { }

	public static string GetUnityInputButtonNameByJoystickId(int unityJoystickId, int buttonIndex) { }

	public static object Instantiate(object original, Transform parent, bool instantiateInWorldSpace) { }

	public static object Instantiate(object original, Vector3 position, Quaternion rotation, Transform parent, bool instantiateInWorldSpace) { }

	public static T Instantiate(object original, Transform parent, bool instantiateInWorldSpace) { }

	public static T Instantiate(object original, Vector3 position, Quaternion rotation, Transform parent, bool instantiateInWorldSpace) { }

	public static bool IsActiveAndEnabled(Component component) { }

	public static bool IsEnabled(Component component) { }

	public static bool IsNullOrDestroyed(object object) { }

	public static bool IsNullOrDestroyed(T object) { }

	[CustomObfuscation]
	internal static bool IsObjectInScene(T object) { }

	public static bool IsUnityVersionInRange(string minVersionStr, string maxVersionStr) { }

	public static bool IsValidUnityJoystickName(string name) { }

	private static bool iwefIxoGzMssYGBSxwUKsufXSyeK(string unnamed_param_0, out int unnamed_param_1) { }

	internal static ButtonStateFlags LfKvzuAGAWhjlkOqsVnRekbXSJdQ(string unnamed_param_0) { }

	internal static Type LpKdadgElWouRDWywysfGCydoEzo(wGtjUNAQFhrxRtWNLGFYJnqfKVie unnamed_param_0) { }

	internal static ButtonStateFlags MxlwTgrNRHGMvbJcHAlDNcxaCKiCb(KeyCode unnamed_param_0) { }

	[CompilerGenerated]
	internal static IAndroidFallbackPlatformHelper oVAWpjZoZDcbBICbzXRDcZLfUnLT() { }

	private static void SXeNoxJFXQBgtbNNoXkEKCUjAmpYA() { }

	public static Vector3 TransformDirection(Transform from, Transform to, Vector3 direction) { }

	public static Vector3 TransformDirection(Transform from, Transform to) { }

	public static Vector3 TransformPoint(Transform from, Transform to) { }

	public static Vector3 TransformPoint(Transform from, Transform to, Vector3 point) { }

	public static Rect TransformRect(Transform from, Transform to, Rect rect) { }

	public static Vector3 TransformVector(Transform from, Transform to, Vector3 vector) { }

	public static Vector3 TransformVector(Transform from, Transform to) { }

	private static bool uGrIpMOKtQGRwBtSzfaCrFVelftR() { }

	private static  WqhwlIdJPHfIEdimyIqvKqAaZivIA( unnamed_param_0) { }

	private static UnityVersion xribvcZJVVVbyLIVAYmUAABRENxC(int unnamed_param_0) { }

	private static bool zfAtPcWAGcFMhcTSebYMHeOddsWbA() { }

}

