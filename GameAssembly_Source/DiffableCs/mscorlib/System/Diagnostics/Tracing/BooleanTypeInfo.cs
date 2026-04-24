namespace System.Diagnostics.Tracing;

internal sealed class BooleanTypeInfo : TraceLoggingTypeInfo<Boolean>
{

	public BooleanTypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref bool value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

