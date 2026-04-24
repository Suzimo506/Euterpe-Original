namespace System.Diagnostics.Tracing;

internal sealed class ByteTypeInfo : TraceLoggingTypeInfo<Byte>
{

	public ByteTypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref byte value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

