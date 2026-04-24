namespace ThinkingSDK.PC.DataModel;

public class ThinkingSDKUpdateEvent : ThinkingSDKEventData
{
	private string mEventID; //Field offset: 0x58

	public ThinkingSDKUpdateEvent(string eventName, string eventID) { }

	public virtual string GetDataType() { }

	public virtual Dictionary<String, Object> ToDictionary() { }

}

