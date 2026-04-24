namespace System.Diagnostics.Tracing;

internal sealed class ByteArrayTypeInfo : TraceLoggingTypeInfo<Byte[]>
{

	public ByteArrayTypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref Byte[] value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

