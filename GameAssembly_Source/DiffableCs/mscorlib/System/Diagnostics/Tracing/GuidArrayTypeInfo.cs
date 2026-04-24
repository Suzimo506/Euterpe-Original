namespace System.Diagnostics.Tracing;

internal sealed class GuidArrayTypeInfo : TraceLoggingTypeInfo<Guid[]>
{

	public GuidArrayTypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref Guid[] value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

