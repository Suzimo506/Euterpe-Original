namespace ThinkingAnalytics;

public class ThinkingAnalyticsEvent
{
	internal enum Type
	{
		FIRST = 0,
		UPDATABLE = 1,
		OVERWRITABLE = 2,
	}

	[CompilerGenerated]
	private Nullable<Type> <EventType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <EventName>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Dictionary<String, Object> <Properties>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private DateTime <EventTime>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <ExtraId>k__BackingField; //Field offset: 0x30

	public string EventName
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public DateTime EventTime
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Nullable<Type> EventType
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public string ExtraId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public Dictionary<String, Object> Properties
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ThinkingAnalyticsEvent(string eventName, Dictionary<String, Object> properties) { }

	[CompilerGenerated]
	public string get_EventName() { }

	[CompilerGenerated]
	public DateTime get_EventTime() { }

	[CompilerGenerated]
	public Nullable<Type> get_EventType() { }

	[CompilerGenerated]
	public string get_ExtraId() { }

	[CompilerGenerated]
	public Dictionary<String, Object> get_Properties() { }

	[CompilerGenerated]
	public void set_EventTime(DateTime value) { }

	[CompilerGenerated]
	public void set_EventType(Nullable<Type> value) { }

	[CompilerGenerated]
	public void set_ExtraId(string value) { }

}

