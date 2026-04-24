namespace System.Diagnostics.Tracing;

internal sealed class UInt32ArrayTypeInfo : TraceLoggingTypeInfo<UInt32[]>
{

	public UInt32ArrayTypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref UInt32[] value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

