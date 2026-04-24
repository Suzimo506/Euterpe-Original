namespace System.Diagnostics.Tracing;

internal abstract class TraceLoggingTypeInfo
{
	private readonly string name; //Field offset: 0x10
	private readonly EventKeywords keywords; //Field offset: 0x18
	private readonly EventLevel level; //Field offset: 0x20
	private readonly EventOpcode opcode; //Field offset: 0x24
	private readonly EventTags tags; //Field offset: 0x28
	private readonly Type dataType; //Field offset: 0x30

	internal Type DataType
	{
		internal get { } //Length: 5
	}

	public EventKeywords Keywords
	{
		 get { } //Length: 5
	}

	public EventLevel Level
	{
		 get { } //Length: 4
	}

	public string Name
	{
		 get { } //Length: 5
	}

	public EventOpcode Opcode
	{
		 get { } //Length: 4
	}

	public EventTags Tags
	{
		 get { } //Length: 4
	}

	internal TraceLoggingTypeInfo(Type dataType) { }

	internal TraceLoggingTypeInfo(Type dataType, string name, EventLevel level, EventOpcode opcode, EventKeywords keywords, EventTags tags) { }

	internal Type get_DataType() { }

	public EventKeywords get_Keywords() { }

	public EventLevel get_Level() { }

	public string get_Name() { }

	public EventOpcode get_Opcode() { }

	public EventTags get_Tags() { }

	public override object GetData(object value) { }

	public abstract void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	public abstract void WriteObjectData(TraceLoggingDataCollector collector, object value) { }

}

