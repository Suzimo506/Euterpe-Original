namespace System.Diagnostics.Tracing;

internal sealed class UInt64ArrayTypeInfo : TraceLoggingTypeInfo<UInt64[]>
{

	public UInt64ArrayTypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref UInt64[] value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

