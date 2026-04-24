namespace System.Diagnostics.Tracing;

internal sealed class Int16TypeInfo : TraceLoggingTypeInfo<Int16>
{

	public Int16TypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref short value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

