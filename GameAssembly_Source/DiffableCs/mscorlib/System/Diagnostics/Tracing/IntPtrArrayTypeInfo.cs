namespace System.Diagnostics.Tracing;

internal sealed class IntPtrArrayTypeInfo : TraceLoggingTypeInfo<IntPtr[]>
{

	public IntPtrArrayTypeInfo() { }

	public virtual void WriteData(TraceLoggingDataCollector collector, ref IntPtr[] value) { }

	public virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

}

