namespace System.Diagnostics.Tracing;

internal sealed class ArrayTypeInfo : TraceLoggingTypeInfo<ElementType[]>
{
	private readonly TraceLoggingTypeInfo<ElementType> elementInfo; //Field offset: 0x0

	public virtual void WriteData(TraceLoggingDataCollector collector, ref ElementType[] value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

