namespace Sirenix.Serialization;

public class JsonDataWriter : BaseDataWriter
{
	private static readonly UInt32[] ByteToHexCharLookup; //Field offset: 0x0
	private static readonly string NEW_LINE; //Field offset: 0x8
	private bool justStarted; //Field offset: 0x30
	private bool forceNoSeparatorNextLine; //Field offset: 0x31
	private Dictionary<Type, Delegate> primitiveTypeWriters; //Field offset: 0x38
	private Dictionary<Type, Int32> seenTypes; //Field offset: 0x40
	private Byte[] buffer; //Field offset: 0x48
	private int bufferIndex; //Field offset: 0x50
	public bool FormatAsReadable; //Field offset: 0x54
	public bool EnableTypeOptimization; //Field offset: 0x55

	private static JsonDataWriter() { }

	public JsonDataWriter() { }

	public JsonDataWriter(Stream stream, SerializationContext context, bool formatAsReadable = true) { }

	public virtual void BeginArrayNode(long length) { }

	public virtual void BeginReferenceNode(string name, Type type, int id) { }

	public virtual void BeginStructNode(string name, Type type) { }

	private void Buffer_WriteString_WithEscape(string str) { }

	private static UInt32[] CreateByteToHexLookup() { }

	public virtual void Dispose() { }

	public virtual void EndArrayNode() { }

	public virtual void EndNode(string name) { }

	private void EnsureBufferSpace(int space) { }

	public virtual void FlushToStream() { }

	public virtual string GetDataDump() { }

	public void MarkJustStarted() { }

	public virtual void PrepareNewSerializationSession() { }

	private void StartNewLine(bool noSeparator = false) { }

	public virtual void WriteBoolean(string name, bool value) { }

	public virtual void WriteByte(string name, byte value) { }

	public virtual void WriteChar(string name, char value) { }

	public virtual void WriteDecimal(string name, decimal value) { }

	public virtual void WriteDouble(string name, double value) { }

	private void WriteEntry(string name, string contents, char surroundContentsWith) { }

	private void WriteEntry(string name, string contents) { }

	public virtual void WriteExternalReference(string name, int index) { }

	public virtual void WriteExternalReference(string name, string id) { }

	public virtual void WriteExternalReference(string name, Guid guid) { }

	public virtual void WriteGuid(string name, Guid value) { }

	public virtual void WriteInt16(string name, short value) { }

	public virtual void WriteInt32(string name, int value) { }

	public virtual void WriteInt64(string name, long value) { }

	public virtual void WriteInternalReference(string name, int id) { }

	public virtual void WriteNull(string name) { }

	public virtual void WritePrimitiveArray(T[] array) { }

	public virtual void WriteSByte(string name, sbyte value) { }

	public virtual void WriteSingle(string name, float value) { }

	public virtual void WriteString(string name, string value) { }

	private void WriteTypeEntry(Type type) { }

	public virtual void WriteUInt16(string name, ushort value) { }

	public virtual void WriteUInt32(string name, uint value) { }

	public virtual void WriteUInt64(string name, ulong value) { }

}

