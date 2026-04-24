namespace System.Diagnostics.Tracing;

internal sealed class Int16ArrayTypeInfo : TraceLoggingTypeInfo<Int16[]>
{

	public Int16ArrayTypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref Int16[] value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

