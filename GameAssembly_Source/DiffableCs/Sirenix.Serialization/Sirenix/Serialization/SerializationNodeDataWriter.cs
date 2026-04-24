namespace Sirenix.Serialization;

public class SerializationNodeDataWriter : BaseDataWriter
{
	private List<SerializationNode> nodes; //Field offset: 0x30
	private Dictionary<Type, Delegate> primitiveTypeWriters; //Field offset: 0x38

	public List<SerializationNode> Nodes
	{
		 get { } //Length: 111
		 set { } //Length: 113
	}

	public virtual Stream Stream
	{
		 get { } //Length: 81
		 set { } //Length: 81
	}

	public SerializationNodeDataWriter(SerializationContext context) { }

	public virtual void BeginArrayNode(long length) { }

	public virtual void BeginReferenceNode(string name, Type type, int id) { }

	public virtual void BeginStructNode(string name, Type type) { }

	public virtual void Dispose() { }

	public virtual void EndArrayNode() { }

	public virtual void EndNode(string name) { }

	public virtual void FlushToStream() { }

	public List<SerializationNode> get_Nodes() { }

	public virtual Stream get_Stream() { }

	public virtual string GetDataDump() { }

	public virtual void PrepareNewSerializationSession() { }

	public void set_Nodes(List<SerializationNode> value) { }

	public virtual void set_Stream(Stream value) { }

	public virtual void WriteBoolean(string name, bool value) { }

	public virtual void WriteByte(string name, byte value) { }

	public virtual void WriteChar(string name, char value) { }

	public virtual void WriteDecimal(string name, decimal value) { }

	public virtual void WriteDouble(string name, double value) { }

	public virtual void WriteExternalReference(string name, string id) { }

	public virtual void WriteExternalReference(string name, int index) { }

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

	public virtual void WriteUInt16(string name, ushort value) { }

	public virtual void WriteUInt32(string name, uint value) { }

	public virtual void WriteUInt64(string name, ulong value) { }

}

