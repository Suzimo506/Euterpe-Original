namespace ThinkingSDK.PC.DataModel;

public class ThinkingSDKEventData : ThinkingSDKBaseData
{
	private DateTime mEventTime; //Field offset: 0x48
	private float mDuration; //Field offset: 0x50

	public ThinkingSDKEventData(string eventName) { }

	public ThinkingSDKEventData(ThinkingSDKTimeInter time, string eventName, Dictionary<String, Object> properties) { }

	public virtual string GetDataType() { }

	public void SetDuration(float duration) { }

	public void SetEventTime(DateTime dateTime) { }

	public DateTime Time() { }

	public virtual Dictionary<String, Object> ToDictionary() { }

}

