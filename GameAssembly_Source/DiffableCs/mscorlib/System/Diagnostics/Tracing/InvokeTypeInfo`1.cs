namespace System.Diagnostics.Tracing;

internal sealed class InvokeTypeInfo : TraceLoggingTypeInfo<ContainerType>
{
	private readonly PropertyAnalysis[] properties; //Field offset: 0x0
	private readonly PropertyAccessor<ContainerType>[] accessors; //Field offset: 0x0

	public InvokeTypeInfo`1(TypeAnalysis typeAnalysis) { }

	public virtual object GetData(object value) { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref ContainerType value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	public virtual void WriteObjectData(TraceLoggingDataCollector collector, object valueObj) { }

}

