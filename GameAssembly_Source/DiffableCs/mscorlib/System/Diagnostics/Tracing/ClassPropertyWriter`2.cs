namespace System.Diagnostics.Tracing;

internal class ClassPropertyWriter : PropertyAccessor<ContainerType>
{
	private sealed class Getter : MulticastDelegate
	{

		public Getter(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ContainerType container, AsyncCallback callback, object object) { }

		public override ValueType EndInvoke(IAsyncResult result) { }

		public override ValueType Invoke(ContainerType container) { }

	}

	private readonly TraceLoggingTypeInfo<ValueType> valueTypeInfo; //Field offset: 0x0
	private readonly Getter<ContainerType, ValueType> getter; //Field offset: 0x0

	public ClassPropertyWriter`2(PropertyAnalysis property) { }

	public virtual object GetData(ContainerType container) { }

	public virtual void Write(TraceLoggingDataCollector collector, ref ContainerType container) { }

}

