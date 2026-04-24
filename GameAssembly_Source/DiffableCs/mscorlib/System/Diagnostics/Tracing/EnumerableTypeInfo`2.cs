namespace System.Diagnostics.Tracing;

internal sealed class EnumerableTypeInfo : TraceLoggingTypeInfo<IterableType>
{
	private readonly TraceLoggingTypeInfo<ElementType> elementInfo; //Field offset: 0x0

	public virtual void WriteData(TraceLoggingDataCollector collector, ref IterableType value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

