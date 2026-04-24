namespace System.Diagnostics.Tracing;

internal sealed class DateTimeTypeInfo : TraceLoggingTypeInfo<DateTime>
{

	public DateTimeTypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref DateTime value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

