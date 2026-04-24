namespace System.Diagnostics.Tracing;

internal sealed class DateTimeOffsetTypeInfo : TraceLoggingTypeInfo<DateTimeOffset>
{

	public DateTimeOffsetTypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref DateTimeOffset value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

