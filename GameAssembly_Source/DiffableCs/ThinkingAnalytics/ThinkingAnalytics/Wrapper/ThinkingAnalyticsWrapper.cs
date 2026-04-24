namespace ThinkingAnalytics.Wrapper;

public class ThinkingAnalyticsWrapper : IDynamicSuperProperties_PC, IAutoTrackEventCallback_PC
{
	private static IAutoTrackEventCallback mEventCallback; //Field offset: 0x0
	public static MonoBehaviour sMono; //Field offset: 0x8
	private static IDynamicSuperProperties mDynamicSuperProperties; //Field offset: 0x10
	private static IAutoTrackEventCallback mAutoTrackEventCallback; //Field offset: 0x18
	private static Random rnd; //Field offset: 0x20

	private static ThinkingAnalyticsWrapper() { }

	public ThinkingAnalyticsWrapper() { }

	public override Dictionary<String, Object> AutoTrackEventCallback_PC(int type, Dictionary<String, Object> properties) { }

	private static void calibrateTime(long timestamp) { }

	public static void CalibrateTime(long timestamp) { }

	private static void calibrateTimeWithNtp(string ntpServer) { }

	public static void CalibrateTimeWithNtp(string ntpServer) { }

	private static void clearSuperProperty(string appId) { }

	public static void ClearSuperProperty(string appId) { }

	private static string createLightInstance() { }

	public static string CreateLightInstance() { }

	private static void enableAutoTrack(AUTO_TRACK_EVENTS autoTrackEvents, string properties, string appId) { }

	private static void enableAutoTrack(AUTO_TRACK_EVENTS autoTrackEvents, IAutoTrackEventCallback eventCallback, string appId) { }

	public static void EnableAutoTrack(AUTO_TRACK_EVENTS events, Dictionary<String, Object> properties, string appId) { }

	public static void EnableAutoTrack(AUTO_TRACK_EVENTS events, IAutoTrackEventCallback eventCallback, string appId) { }

	private static void enableLog(bool enable) { }

	public static void EnableLog(bool enable) { }

	private static void enableThirdPartySharing(TAThirdPartyShareType shareType) { }

	public static void EnableThirdPartySharing(TAThirdPartyShareType shareType) { }

	private static void enableTracking(bool enabled, string appId) { }

	public static void EnableTracking(bool enabled, string appId) { }

	private static void flush(string appId) { }

	public static void Flush(string appId) { }

	private static string getDeviceId() { }

	public static string GetDeviceId() { }

	private static string getDistinctId(string appId) { }

	public static string GetDistinctId(string appId) { }

	public override Dictionary<String, Object> GetDynamicSuperProperties_PC() { }

	private static string getFinalEventProperties(Dictionary<String, Object> properties) { }

	private static Dictionary<String, Object> getPresetProperties(string appId) { }

	public static Dictionary<String, Object> GetPresetProperties(string appId) { }

	private static Dictionary<String, Object> getSuperProperties(string appId) { }

	public static Dictionary<String, Object> GetSuperProperties(string appId) { }

	private static string getTimeString(DateTime dateTime) { }

	private static void identify(string uniqueId, string appId) { }

	public static void Identify(string uniqueId, string appId) { }

	private static void init(Token token) { }

	private static void login(string accountId, string appId) { }

	public static void Login(string accountId, string appId) { }

	private static void logout(string appId) { }

	public static void Logout(string appId) { }

	private static void optInTracking(string appId) { }

	public static void OptInTracking(string appId) { }

	private static void optOutTracking(string appId) { }

	public static void OptOutTracking(string appId) { }

	private static void optOutTrackingAndDeleteUser(string appId) { }

	public static void OptOutTrackingAndDeleteUser(string appId) { }

	private static string serilize(Dictionary<String, T> data) { }

	private static void setAutoTrackProperties(AUTO_TRACK_EVENTS autoTrackEvents, string properties, string appId) { }

	public static void SetAutoTrackProperties(AUTO_TRACK_EVENTS events, Dictionary<String, Object> properties, string appId) { }

	private static void setDynamicSuperProperties(IDynamicSuperProperties dynamicSuperProperties, string appId) { }

	public static void SetDynamicSuperProperties(IDynamicSuperProperties dynamicSuperProperties, string appId) { }

	private static void setNetworkType(NetworkType networkType) { }

	public static void SetNetworkType(NetworkType networkType) { }

	private static void setSuperProperties(string superProperties, string appId) { }

	public static void SetSuperProperties(Dictionary<String, Object> superProperties, string appId) { }

	private static void setTrackStatus(TA_TRACK_STATUS status, string appId) { }

	public static void SetTrackStatus(TA_TRACK_STATUS status, string appId) { }

	private static void setVersionInfo(string lib_name, string lib_version) { }

	public static void SetVersionInfo(string version) { }

	public static void ShareInstance(Token token, MonoBehaviour mono, bool initRequired = true) { }

	private static void timeEvent(string eventName, string appId) { }

	public static void TimeEvent(string eventName, string appId) { }

	private static void track(ThinkingAnalyticsEvent taEvent, string appId) { }

	private static void track(string eventName, string properties, string appId) { }

	private static void track(string eventName, string properties, DateTime dateTime, string appId) { }

	public static void Track(ThinkingAnalyticsEvent taEvent, string appId) { }

	public static void Track(string eventName, Dictionary<String, Object> properties, DateTime datetime, string appId) { }

	public static void Track(string eventName, Dictionary<String, Object> properties, string appId) { }

	private static void unsetSuperProperty(string superPropertyName, string appId) { }

	public static void UnsetSuperProperty(string superPropertyName, string appId) { }

	private static void userAdd(string properties, DateTime dateTime, string appId) { }

	private static void userAdd(string properties, string appId) { }

	public static void UserAdd(Dictionary<String, Object> properties, string appId) { }

	public static void UserAdd(Dictionary<String, Object> properties, DateTime dateTime, string appId) { }

	private static void userAppend(string properties, string appId) { }

	private static void userAppend(string properties, DateTime dateTime, string appId) { }

	public static void UserAppend(Dictionary<String, Object> properties, string appId) { }

	public static void UserAppend(Dictionary<String, Object> properties, DateTime dateTime, string appId) { }

	private static void userDelete(string appId) { }

	private static void userDelete(DateTime dateTime, string appId) { }

	public static void UserDelete(string appId) { }

	public static void UserDelete(DateTime dateTime, string appId) { }

	private static void userSet(string properties, string appId) { }

	private static void userSet(string properties, DateTime dateTime, string appId) { }

	public static void UserSet(Dictionary<String, Object> properties, string appId) { }

	public static void UserSet(Dictionary<String, Object> properties, DateTime dateTime, string appId) { }

	private static void userSetOnce(string properties, DateTime dateTime, string appId) { }

	private static void userSetOnce(string properties, string appId) { }

	public static void UserSetOnce(Dictionary<String, Object> properties, DateTime dateTime, string appId) { }

	public static void UserSetOnce(Dictionary<String, Object> properties, string appId) { }

	private static void userUniqAppend(string properties, DateTime dateTime, string appId) { }

	private static void userUniqAppend(string properties, string appId) { }

	public static void UserUniqAppend(Dictionary<String, Object> properties, string appId) { }

	public static void UserUniqAppend(Dictionary<String, Object> properties, DateTime dateTime, string appId) { }

	private static void userUnset(List<String> properties, string appId) { }

	private static void userUnset(List<String> properties, DateTime dateTime, string appId) { }

	public static void UserUnset(List<String> properties, string appId) { }

	public static void UserUnset(List<String> properties, DateTime dateTime, string appId) { }

}

