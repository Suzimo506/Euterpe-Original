namespace System.Diagnostics.Tracing;

internal sealed class DecimalTypeInfo : TraceLoggingTypeInfo<Decimal>
{

	public DecimalTypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref decimal value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

