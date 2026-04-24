namespace System.Diagnostics.Tracing;

internal sealed class EnumInt64TypeInfo : TraceLoggingTypeInfo<EnumType>
{

	public EnumInt64TypeInfo`1() { }

	public virtual object GetData(object value) { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

