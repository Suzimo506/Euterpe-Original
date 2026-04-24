namespace System.Diagnostics.Tracing;

internal sealed class UInt64TypeInfo : TraceLoggingTypeInfo<UInt64>
{

	public UInt64TypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref ulong value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

