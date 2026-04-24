namespace System.Diagnostics.Tracing;

internal sealed class KeyValuePairTypeInfo : TraceLoggingTypeInfo<KeyValuePair`2<K, V>>
{
	private readonly TraceLoggingTypeInfo<K> keyInfo; //Field offset: 0x0
	private readonly TraceLoggingTypeInfo<V> valueInfo; //Field offset: 0x0

	public virtual void WriteData(TraceLoggingDataCollector collector, ref KeyValuePair<K, V>& value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

