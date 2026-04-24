namespace ThinkingSDK.PC.Main;

public class ThinkingPCSDK
{
	private static readonly Dictionary<String, ThinkingSDKInstance> Instances; //Field offset: 0x0
	private static string CurrentAppid; //Field offset: 0x8

	private static ThinkingPCSDK() { }

	public static void CalibrateTime(long timestamp) { }

	public static void CalibrateTimeWithNtp(string ntpServer) { }

	public static void ClearSuperProperties(string appId = "") { }

	public static string CreateLightInstance() { }

	public static string DistinctId(string appId = "") { }

	public static void EnableAutoTrack(AUTO_TRACK_EVENTS events, Dictionary<String, Object> properties, string appId = "") { }

	public static void EnableAutoTrack(AUTO_TRACK_EVENTS events, IAutoTrackEventCallback_PC eventCallback, string appId = "") { }

	public static void EnableLog(bool isEnable) { }

	public static void EnableTracking(bool isEnable, string appId = "") { }

	public static void Flush(string appId = "") { }

	public static void FlushImmediately(string appId = "") { }

	public static string GetDeviceId() { }

	private static ThinkingSDKInstance GetInstance(string appId) { }

	public static void Identifiy(string distinctID, string appId = "") { }

	public static ThinkingSDKInstance Init(string appId, string server, ThinkingSDKConfig config = null, MonoBehaviour mono = null) { }

	public static void Login(string accountID, string appId = "") { }

	public static void Logout(string appId = "") { }

	public static void OptTracking(bool optTracking, string appId = "") { }

	public static void OptTrackingAndDeleteUser(string appId = "") { }

	public static Dictionary<String, Object> PresetProperties(string appId = "") { }

	public static void SetAutoTrackProperties(AUTO_TRACK_EVENTS events, Dictionary<String, Object> properties, string appId = "") { }

	public static void SetDynamicSuperProperties(IDynamicSuperProperties_PC dynamicSuperProperties, string appId = "") { }

	public static void SetLibName(string name) { }

	public static void SetLibVersion(string versionCode) { }

	public static void SetSuperProperties(Dictionary<String, Object> superProperties, string appId = "") { }

	public static void SetTrackStatus(TA_TRACK_STATUS status, string appId = "") { }

	public static Dictionary<String, Object> SuperProperties(string appId = "") { }

	public static void TimeEvent(string eventName, string appId = "") { }

	public static string TimeString(DateTime dateTime, string appId = "") { }

	public static void Track(ThinkingSDKEventData analyticsEvent, string appId = "") { }

	public static void Track(string eventName, Dictionary<String, Object> properties, DateTime date, string appId = "") { }

	public static void Track(string eventName, Dictionary<String, Object> properties, string appId = "") { }

	public static void UnsetSuperProperty(string propertyKey, string appId = "") { }

	public static void UserAdd(Dictionary<String, Object> properties, string appId = "") { }

	public static void UserAdd(Dictionary<String, Object> properties, DateTime dateTime, string appId = "") { }

	public static void UserAppend(Dictionary<String, Object> properties, string appId = "") { }

	public static void UserAppend(Dictionary<String, Object> properties, DateTime dateTime, string appId = "") { }

	public static void UserDelete(DateTime dateTime, string appId = "") { }

	public static void UserDelete(string appId = "") { }

	public static void UserSet(Dictionary<String, Object> properties, string appId = "") { }

	public static void UserSet(Dictionary<String, Object> properties, DateTime dateTime, string appId = "") { }

	public static void UserSetOnce(Dictionary<String, Object> properties, DateTime dateTime, string appId = "") { }

	public static void UserSetOnce(Dictionary<String, Object> properties, string appId = "") { }

	public static void UserUniqAppend(Dictionary<String, Object> properties, string appId = "") { }

	public static void UserUniqAppend(Dictionary<String, Object> properties, DateTime dateTime, string appId = "") { }

	public static void UserUnset(List<String> propertyKeys, string appId = "") { }

	public static void UserUnset(List<String> propertyKeys, DateTime dateTime, string appId = "") { }

}

