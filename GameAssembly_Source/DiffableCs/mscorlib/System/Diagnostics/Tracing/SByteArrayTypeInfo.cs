namespace System.Diagnostics.Tracing;

internal sealed class SByteArrayTypeInfo : TraceLoggingTypeInfo<SByte[]>
{

	public SByteArrayTypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref SByte[] value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

