namespace ThinkingAnalytics;

[DisallowMultipleComponent]
public class ThinkingAnalyticsAPI : MonoBehaviour
{
	internal enum NetworkType
	{
		DEFAULT = 1,
		WIFI = 2,
		ALL = 3,
	}

	internal enum TAMode
	{
		NORMAL = 0,
		DEBUG = 1,
		DEBUG_ONLY = 2,
	}

	internal enum TATimeZone
	{
		Local = 0,
		UTC = 1,
		Asia_Shanghai = 2,
		Asia_Tokyo = 3,
		America_Los_Angeles = 4,
		America_New_York = 5,
		Other = 100,
	}

	internal struct Token
	{
		public string appid; //Field offset: 0x0
		public string serverUrl; //Field offset: 0x8
		public TAMode mode; //Field offset: 0x10
		public TATimeZone timeZone; //Field offset: 0x14
		public string timeZoneId; //Field offset: 0x18
		public bool enableEncrypt; //Field offset: 0x20
		public int encryptVersion; //Field offset: 0x24
		public string encryptPublicKey; //Field offset: 0x28
		public SSLPinningMode pinningMode; //Field offset: 0x30
		public bool allowInvalidCertificates; //Field offset: 0x34
		public bool validatesDomainName; //Field offset: 0x35

		public Token(string appId, string serverUrl, TAMode mode = 0, TATimeZone timeZone = 0, string timeZoneId = null) { }

		public string getTimeZoneId() { }

	}

	private static ThinkingAnalyticsAPI sThinkingAnalyticsAPI; //Field offset: 0x0
	private static bool tracking_enabled; //Field offset: 0x8
	private static List<Dictionary`2<String, Object>> eventCaches; //Field offset: 0x10
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool startManually; //Field offset: 0x18
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool enableLog; //Field offset: 0x19
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public NetworkType networkType; //Field offset: 0x1C
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[HideInInspector]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Token[] tokens; //Field offset: 0x20

	private static ThinkingAnalyticsAPI() { }

	public ThinkingAnalyticsAPI() { }

	private void Awake() { }

	public static void CalibrateTime(long timestamp) { }

	public static void CalibrateTimeWithNtp(string ntpServer) { }

	public static void ClearSuperProperties(string appId = "") { }

	public static string CreateLightInstance(string appId = "") { }

	public static void EnableAutoTrack(AUTO_TRACK_EVENTS events, Dictionary<String, Object> properties = null, string appId = "") { }

	public static void EnableAutoTrack(AUTO_TRACK_EVENTS events, IAutoTrackEventCallback eventCallback, string appId = "") { }

	public static void EnableLog(bool enable, string appId = "") { }

	public static void EnableThirdPartySharing(TAThirdPartyShareType shareType) { }

	[Obsolete]
	public static void EnableTracking(bool enabled, string appId = "") { }

	public static void Flush(string appId = "") { }

	private static void FlushEventCaches() { }

	public static string GetDeviceId() { }

	public static string GetDistinctId(string appId = "") { }

	public static TDPresetProperties GetPresetProperties(string appId = "") { }

	public static Dictionary<String, Object> GetSuperProperties(string appId = "") { }

	public static void Identify(string firstId, string appId = "") { }

	public static void Login(string account, string appId = "") { }

	public static void Logout(string appId = "") { }

	public static void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	public static void OnSceneUnloaded(Scene scene) { }

	[Obsolete]
	public static void OptInTracking(string appId = "") { }

	[Obsolete]
	public static void OptOutTracking(string appId = "") { }

	[Obsolete]
	public static void OptOutTrackingAndDeleteUser(string appId = "") { }

	public static void SetAutoTrackProperties(AUTO_TRACK_EVENTS events, Dictionary<String, Object> properties, string appId = "") { }

	public static void SetDynamicSuperProperties(IDynamicSuperProperties dynamicSuperProperties, string appId = "") { }

	public static void SetNetworkType(NetworkType networkType, string appId = "") { }

	public static void SetSuperProperties(Dictionary<String, Object> superProperties, string appId = "") { }

	public static void SetTrackStatus(TA_TRACK_STATUS status, string appId = "") { }

	private void Start() { }

	public static void StartThinkingAnalytics(Token token) { }

	public static void StartThinkingAnalytics(string appId, string serverUrl) { }

	public static void StartThinkingAnalytics(Token[] tokens = null) { }

	public static void TimeEvent(string eventName, string appId = "") { }

	public static void Track(string eventName, Dictionary<String, Object> properties, string appId = "") { }

	public static void Track(string eventName, string appId = "") { }

	public static void Track(ThinkingAnalyticsEvent analyticsEvent, string appId = "") { }

	public static void Track(string eventName, Dictionary<String, Object> properties, DateTime date, string appId = "") { }

	public static void UnsetSuperProperty(string property, string appId = "") { }

	public static void UserAdd(Dictionary<String, Object> properties, string appId = "") { }

	public static void UserAdd(string property, object value, string appId = "") { }

	public static void UserAdd(Dictionary<String, Object> properties, DateTime dateTime, string appId = "") { }

	public static void UserAppend(Dictionary<String, Object> properties, DateTime dateTime, string appId = "") { }

	public static void UserAppend(Dictionary<String, Object> properties, string appId = "") { }

	public static void UserDelete(string appId = "") { }

	public static void UserDelete(DateTime dateTime, string appId = "") { }

	public static void UserSet(Dictionary<String, Object> properties, DateTime dateTime, string appId = "") { }

	public static void UserSet(Dictionary<String, Object> properties, string appId = "") { }

	public static void UserSetOnce(Dictionary<String, Object> properties, string appId = "") { }

	public static void UserSetOnce(Dictionary<String, Object> properties, DateTime dateTime, string appId = "") { }

	public static void UserUniqAppend(Dictionary<String, Object> properties, DateTime dateTime, string appId = "") { }

	public static void UserUniqAppend(Dictionary<String, Object> properties, string appId = "") { }

	public static void UserUnset(List<String> properties, DateTime dateTime, string appId = "") { }

	public static void UserUnset(List<String> properties, string appId = "") { }

	public static void UserUnset(string property, string appId = "") { }

}

