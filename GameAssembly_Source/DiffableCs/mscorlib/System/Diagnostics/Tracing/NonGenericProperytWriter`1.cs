namespace System.Diagnostics.Tracing;

internal class NonGenericProperytWriter : PropertyAccessor<ContainerType>
{
	private readonly TraceLoggingTypeInfo typeInfo; //Field offset: 0x0
	private readonly MethodInfo getterInfo; //Field offset: 0x0

	public NonGenericProperytWriter`1(PropertyAnalysis property) { }

	public virtual object GetData(ContainerType container) { }

	public virtual void Write(TraceLoggingDataCollector collector, ref ContainerType container) { }

}

