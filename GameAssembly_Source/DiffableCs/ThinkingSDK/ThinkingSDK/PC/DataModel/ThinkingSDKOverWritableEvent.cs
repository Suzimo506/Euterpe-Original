namespace ThinkingSDK.PC.DataModel;

public class ThinkingSDKOverWritableEvent : ThinkingSDKEventData
{
	private string mEventID; //Field offset: 0x58

	public ThinkingSDKOverWritableEvent(string eventName, string eventID) { }

	public virtual string GetDataType() { }

	public virtual Dictionary<String, Object> ToDictionary() { }

}

