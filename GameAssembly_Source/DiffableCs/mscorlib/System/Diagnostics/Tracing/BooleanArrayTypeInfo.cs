namespace System.Diagnostics.Tracing;

internal sealed class BooleanArrayTypeInfo : TraceLoggingTypeInfo<Boolean[]>
{

	public BooleanArrayTypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref Boolean[] value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

