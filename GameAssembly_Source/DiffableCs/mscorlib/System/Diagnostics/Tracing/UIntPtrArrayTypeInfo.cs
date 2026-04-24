namespace System.Diagnostics.Tracing;

internal sealed class UIntPtrArrayTypeInfo : TraceLoggingTypeInfo<UIntPtr[]>
{

	public UIntPtrArrayTypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref UIntPtr[] value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

