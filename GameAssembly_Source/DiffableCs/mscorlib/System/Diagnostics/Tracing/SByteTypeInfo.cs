namespace System.Diagnostics.Tracing;

internal sealed class SByteTypeInfo : TraceLoggingTypeInfo<SByte>
{

	public SByteTypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref sbyte value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

