namespace System.Diagnostics.Tracing;

internal sealed class UIntPtrTypeInfo : TraceLoggingTypeInfo<UIntPtr>
{

	public UIntPtrTypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref UIntPtr value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

