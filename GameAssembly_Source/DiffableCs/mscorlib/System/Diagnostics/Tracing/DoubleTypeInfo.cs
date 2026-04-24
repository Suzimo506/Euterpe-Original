namespace System.Diagnostics.Tracing;

internal sealed class DoubleTypeInfo : TraceLoggingTypeInfo<Double>
{

	public DoubleTypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref double value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

