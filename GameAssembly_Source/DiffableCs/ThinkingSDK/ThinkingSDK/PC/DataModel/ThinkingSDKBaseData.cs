namespace ThinkingSDK.PC.DataModel;

public abstract class ThinkingSDKBaseData
{
	private string mType; //Field offset: 0x10
	private ThinkingSDKTimeInter mTime; //Field offset: 0x18
	private string mDistinctID; //Field offset: 0x20
	private string mEventName; //Field offset: 0x28
	private string mAccountID; //Field offset: 0x30
	private string mUUID; //Field offset: 0x38
	private Dictionary<String, Object> mProperties; //Field offset: 0x40

	public ThinkingSDKBaseData(ThinkingSDKTimeInter time, string eventName, Dictionary<String, Object> properties) { }

	public ThinkingSDKBaseData(string eventName) { }

	public ThinkingSDKBaseData(ThinkingSDKTimeInter time, string eventName) { }

	public ThinkingSDKBaseData() { }

	public string AccountID() { }

	public string DistinctID() { }

	public string EventName() { }

	public ThinkingSDKTimeInter EventTime() { }

	public override string GetDataType() { }

	public Dictionary<String, Object> Properties() { }

	public void SetAccountID(string accuntID) { }

	public void SetBaseData(string eventName) { }

	public void SetDistinctID(string distinctID) { }

	public void SetEventType(string eventType) { }

	public void SetProperties(Dictionary<String, Object> properties, bool isOverwrite = true) { }

	public void SetTime(ThinkingSDKTimeInter time) { }

	public abstract Dictionary<String, Object> ToDictionary() { }

	public string UUID() { }

}

