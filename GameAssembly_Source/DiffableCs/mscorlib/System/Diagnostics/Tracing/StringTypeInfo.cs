namespace System.Diagnostics.Tracing;

internal sealed class StringTypeInfo : TraceLoggingTypeInfo<String>
{

	public StringTypeInfo() { }

	public virtual object GetData(object value) { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref string value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

