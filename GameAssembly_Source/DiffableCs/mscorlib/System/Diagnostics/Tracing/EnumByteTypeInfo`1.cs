namespace System.Diagnostics.Tracing;

internal sealed class EnumByteTypeInfo : TraceLoggingTypeInfo<EnumType>
{

	public EnumByteTypeInfo`1() { }

	public virtual object GetData(object value) { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

