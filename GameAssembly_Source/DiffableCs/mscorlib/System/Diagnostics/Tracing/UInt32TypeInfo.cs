namespace System.Diagnostics.Tracing;

internal sealed class UInt32TypeInfo : TraceLoggingTypeInfo<UInt32>
{

	public UInt32TypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref uint value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

