namespace System.Diagnostics.Tracing;

internal sealed class SingleArrayTypeInfo : TraceLoggingTypeInfo<Single[]>
{

	public SingleArrayTypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref Single[] value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

