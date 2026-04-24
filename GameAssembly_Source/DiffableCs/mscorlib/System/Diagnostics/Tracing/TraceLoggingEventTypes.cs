namespace System.Diagnostics.Tracing;

internal class TraceLoggingEventTypes
{
	internal readonly TraceLoggingTypeInfo[] typeInfos; //Field offset: 0x10
	internal readonly string name; //Field offset: 0x18
	internal readonly EventTags tags; //Field offset: 0x20
	internal readonly byte level; //Field offset: 0x24
	internal readonly byte opcode; //Field offset: 0x25
	internal readonly EventKeywords keywords; //Field offset: 0x28
	internal readonly Byte[] typeMetadata; //Field offset: 0x30
	internal readonly int scratchSize; //Field offset: 0x38
	internal readonly int dataCount; //Field offset: 0x3C
	internal readonly int pinCount; //Field offset: 0x40
	private ConcurrentSet<KeyValuePair`2<String, EventTags>, NameInfo> nameInfos; //Field offset: 0x48

	internal string Name
	{
		internal get { } //Length: 5
	}

	internal EventTags Tags
	{
		internal get { } //Length: 4
	}

	internal TraceLoggingEventTypes(string name, EventTags tags, Type[] types) { }

	internal TraceLoggingEventTypes(string name, EventTags tags, ParameterInfo[] paramInfos) { }

	private TraceLoggingEventTypes(EventTags tags, string defaultName, TraceLoggingTypeInfo[] typeInfos) { }

	internal string get_Name() { }

	internal EventTags get_Tags() { }

	internal NameInfo GetNameInfo(string name, EventTags tags) { }

	private TraceLoggingTypeInfo[] MakeArray(ParameterInfo[] paramInfos) { }

	private static TraceLoggingTypeInfo[] MakeArray(Type[] types) { }

}

