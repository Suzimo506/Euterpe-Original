namespace ThinkingSDK.PC.Main;

public class LightThinkingSDKInstance : ThinkingSDKInstance
{

	public LightThinkingSDKInstance(string appId, string server, ThinkingSDKConfig config, MonoBehaviour mono = null) { }

	public virtual string AccountID() { }

	public virtual void ClearSuperProperties() { }

	public virtual string DistinctId() { }

	public virtual void EnableAutoTrack(AUTO_TRACK_EVENTS events, Dictionary<String, Object> properties) { }

	public virtual void Flush() { }

	public virtual void Identifiy(string distinctID) { }

	public virtual void Login(string accountID) { }

	public virtual void Logout() { }

	public virtual void SetAutoTrackProperties(AUTO_TRACK_EVENTS events, Dictionary<String, Object> properties) { }

	public virtual void SetSuperProperties(Dictionary<String, Object> superProperties) { }

	public virtual Dictionary<String, Object> SuperProperties() { }

	public virtual void UnsetSuperProperty(string propertyKey) { }

}

