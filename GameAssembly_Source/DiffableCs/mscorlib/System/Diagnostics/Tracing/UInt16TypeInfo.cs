namespace System.Diagnostics.Tracing;

internal sealed class UInt16TypeInfo : TraceLoggingTypeInfo<UInt16>
{

	public UInt16TypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref ushort value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

