namespace System.Diagnostics.Tracing;

internal abstract class TraceLoggingTypeInfo : TraceLoggingTypeInfo
{
	private static TraceLoggingTypeInfo<DataType> instance; //Field offset: 0x0

	public static TraceLoggingTypeInfo<DataType> Instance
	{
		 get { } //Length: 167
	}

	protected TraceLoggingTypeInfo`1() { }

	protected TraceLoggingTypeInfo`1(string name, EventLevel level, EventOpcode opcode, EventKeywords keywords, EventTags tags) { }

	public static TraceLoggingTypeInfo<DataType> get_Instance() { }

	internal static TraceLoggingTypeInfo<DataType> GetInstance(List<Type> recursionCheck) { }

	private static TraceLoggingTypeInfo<DataType> InitInstance() { }

	public abstract void WriteData(TraceLoggingDataCollector collector, ref DataType value) { }

	public virtual void WriteObjectData(TraceLoggingDataCollector collector, object value) { }

}

