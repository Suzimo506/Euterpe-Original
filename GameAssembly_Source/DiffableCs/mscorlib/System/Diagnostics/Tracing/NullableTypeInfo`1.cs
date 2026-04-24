namespace System.Diagnostics.Tracing;

internal sealed class NullableTypeInfo : TraceLoggingTypeInfo<Nullable`1<T>>
{
	private readonly TraceLoggingTypeInfo<T> valueInfo; //Field offset: 0x0

	public virtual void WriteData(TraceLoggingDataCollector collector, ref Nullable<T>& value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

