namespace System.Diagnostics.Tracing;

internal sealed class SingleTypeInfo : TraceLoggingTypeInfo<Single>
{

	public SingleTypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref float value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

