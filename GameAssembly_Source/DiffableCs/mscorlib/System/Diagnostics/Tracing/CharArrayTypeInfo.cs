namespace System.Diagnostics.Tracing;

internal sealed class CharArrayTypeInfo : TraceLoggingTypeInfo<Char[]>
{

	public CharArrayTypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref Char[] value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

