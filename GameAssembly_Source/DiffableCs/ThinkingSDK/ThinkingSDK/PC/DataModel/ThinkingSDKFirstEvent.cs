namespace ThinkingSDK.PC.DataModel;

public class ThinkingSDKFirstEvent : ThinkingSDKEventData
{
	private string mFirstCheckId; //Field offset: 0x58

	public ThinkingSDKFirstEvent(string eventName) { }

	public string FirstCheckId() { }

	public void SetFirstCheckId(string firstCheckId) { }

	public virtual Dictionary<String, Object> ToDictionary() { }

}

