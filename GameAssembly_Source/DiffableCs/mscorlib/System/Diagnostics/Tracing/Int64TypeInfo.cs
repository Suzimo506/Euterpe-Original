namespace System.Diagnostics.Tracing;

internal sealed class Int64TypeInfo : TraceLoggingTypeInfo<Int64>
{

	public Int64TypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref long value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

