namespace System.Diagnostics.Tracing;

internal sealed class Int32ArrayTypeInfo : TraceLoggingTypeInfo<Int32[]>
{

	public Int32ArrayTypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref Int32[] value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

