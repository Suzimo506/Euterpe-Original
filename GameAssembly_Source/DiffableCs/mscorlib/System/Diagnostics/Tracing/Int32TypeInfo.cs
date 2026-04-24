namespace System.Diagnostics.Tracing;

internal sealed class Int32TypeInfo : TraceLoggingTypeInfo<Int32>
{

	public Int32TypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref int value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

