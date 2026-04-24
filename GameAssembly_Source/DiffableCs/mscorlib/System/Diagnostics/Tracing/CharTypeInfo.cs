namespace System.Diagnostics.Tracing;

internal sealed class CharTypeInfo : TraceLoggingTypeInfo<Char>
{

	public CharTypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref char value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

