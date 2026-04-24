namespace System.Diagnostics.Tracing;

internal class FieldMetadata
{
	private readonly string name; //Field offset: 0x10
	private readonly int nameSize; //Field offset: 0x18
	private readonly EventFieldTags tags; //Field offset: 0x1C
	private readonly Byte[] custom; //Field offset: 0x20
	private readonly ushort fixedCount; //Field offset: 0x28
	private byte inType; //Field offset: 0x2A
	private byte outType; //Field offset: 0x2B

	public FieldMetadata(string name, TraceLoggingDataType type, EventFieldTags tags, bool variableCount) { }

	private FieldMetadata(string name, TraceLoggingDataType dataType, EventFieldTags tags, byte countFlags, ushort fixedCount = 0, Byte[] custom = null) { }

	public void Encode(ref int pos, Byte[] metadata) { }

	public void IncrementStructFieldCount() { }

}

