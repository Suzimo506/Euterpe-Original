namespace System.Diagnostics.Tracing;

internal sealed class TimeSpanTypeInfo : TraceLoggingTypeInfo<TimeSpan>
{

	public TimeSpanTypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref TimeSpan value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

