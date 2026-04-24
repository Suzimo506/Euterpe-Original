namespace System.Diagnostics.Tracing;

internal sealed class GuidTypeInfo : TraceLoggingTypeInfo<Guid>
{

	public GuidTypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref Guid value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

