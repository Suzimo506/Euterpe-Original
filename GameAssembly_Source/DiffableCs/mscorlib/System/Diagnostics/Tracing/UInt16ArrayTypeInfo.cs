namespace System.Diagnostics.Tracing;

internal sealed class UInt16ArrayTypeInfo : TraceLoggingTypeInfo<UInt16[]>
{

	public UInt16ArrayTypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref UInt16[] value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

