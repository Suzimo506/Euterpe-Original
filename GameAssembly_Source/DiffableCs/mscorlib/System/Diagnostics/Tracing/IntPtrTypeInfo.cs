namespace System.Diagnostics.Tracing;

internal sealed class IntPtrTypeInfo : TraceLoggingTypeInfo<IntPtr>
{

	public IntPtrTypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref IntPtr value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

