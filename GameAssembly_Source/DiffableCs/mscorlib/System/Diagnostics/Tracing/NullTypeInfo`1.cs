namespace System.Diagnostics.Tracing;

internal sealed class NullTypeInfo : TraceLoggingTypeInfo<DataType>
{

	public NullTypeInfo`1() { }

	public virtual object GetData(object value) { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref DataType value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

