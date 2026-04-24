namespace Sirenix.Serialization;

public abstract class BaseDataWriter : BaseDataReaderWriter, IDataWriter, IDisposable
{
	private SerializationContext context; //Field offset: 0x20
	private Stream stream; //Field offset: 0x28

	public override SerializationContext Context
	{
		 get { } //Length: 106
		 set { } //Length: 12
	}

	public override Stream Stream
	{
		 get { } //Length: 5
		 set { } //Length: 193
	}

	protected BaseDataWriter(Stream stream, SerializationContext context) { }

	public abstract void BeginArrayNode(long length) { }

	public abstract void BeginReferenceNode(string name, Type type, int id) { }

	public abstract void BeginStructNode(string name, Type type) { }

	public abstract void Dispose() { }

	public abstract void EndArrayNode() { }

	public abstract void EndNode(string name) { }

	public override void FlushToStream() { }

	public override SerializationContext get_Context() { }

	public override Stream get_Stream() { }

	public abstract string GetDataDump() { }

	public override void PrepareNewSerializationSession() { }

	public override void set_Context(SerializationContext value) { }

	public override void set_Stream(Stream value) { }

	public abstract void WriteBoolean(string name, bool value) { }

	public abstract void WriteByte(string name, byte value) { }

	public abstract void WriteChar(string name, char value) { }

	public abstract void WriteDecimal(string name, decimal value) { }

	public abstract void WriteDouble(string name, double value) { }

	public abstract void WriteExternalReference(string name, int index) { }

	public abstract void WriteExternalReference(string name, Guid guid) { }

	public abstract void WriteExternalReference(string name, string id) { }

	public abstract void WriteGuid(string name, Guid value) { }

	public abstract void WriteInt16(string name, short value) { }

	public abstract void WriteInt32(string name, int value) { }

	public abstract void WriteInt64(string name, long value) { }

	public abstract void WriteInternalReference(string name, int id) { }

	public abstract void WriteNull(string name) { }

	public abstract void WritePrimitiveArray(T[] array) { }

	public abstract void WriteSByte(string name, sbyte value) { }

	public abstract void WriteSingle(string name, float value) { }

	public abstract void WriteString(string name, string value) { }

	public abstract void WriteUInt16(string name, ushort value) { }

	public abstract void WriteUInt32(string name, uint value) { }

	public abstract void WriteUInt64(string name, ulong value) { }

}

