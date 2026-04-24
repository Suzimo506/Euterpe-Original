namespace System.Diagnostics.Tracing;

internal sealed class DoubleArrayTypeInfo : TraceLoggingTypeInfo<Double[]>
{

	public DoubleArrayTypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref Double[] value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

