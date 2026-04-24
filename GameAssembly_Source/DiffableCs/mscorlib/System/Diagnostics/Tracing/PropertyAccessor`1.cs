namespace System.Diagnostics.Tracing;

internal abstract class PropertyAccessor
{

	protected PropertyAccessor`1() { }

	public static PropertyAccessor<ContainerType> Create(PropertyAnalysis property) { }

	public abstract object GetData(ContainerType value) { }

	public abstract void Write(TraceLoggingDataCollector collector, ref ContainerType value) { }

}

