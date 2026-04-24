namespace Sirenix.Serialization;

public interface IDataWriter : IDisposable
{

	public TwoWaySerializationBinder Binder
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public SerializationContext Context
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool IsInArrayNode
	{
		 get { } //Length: 0
	}

	[Obsolete]
	public Stream Stream
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public void BeginArrayNode(long length) { }

	public void BeginReferenceNode(string name, Type type, int id) { }

	public void BeginStructNode(string name, Type type) { }

	public void EndArrayNode() { }

	public void EndNode(string name) { }

	public void FlushToStream() { }

	public TwoWaySerializationBinder get_Binder() { }

	public SerializationContext get_Context() { }

	public bool get_IsInArrayNode() { }

	public Stream get_Stream() { }

	public string GetDataDump() { }

	public void PrepareNewSerializationSession() { }

	public void set_Binder(TwoWaySerializationBinder value) { }

	public void set_Context(SerializationContext value) { }

	public void set_Stream(Stream value) { }

	public void WriteBoolean(string name, bool value) { }

	public void WriteByte(string name, byte value) { }

	public void WriteChar(string name, char value) { }

	public void WriteDecimal(string name, decimal value) { }

	public void WriteDouble(string name, double value) { }

	public void WriteExternalReference(string name, int index) { }

	public void WriteExternalReference(string name, Guid guid) { }

	public void WriteExternalReference(string name, string id) { }

	public void WriteGuid(string name, Guid value) { }

	public void WriteInt16(string name, short value) { }

	public void WriteInt32(string name, int value) { }

	public void WriteInt64(string name, long value) { }

	public void WriteInternalReference(string name, int id) { }

	public void WriteNull(string name) { }

	public void WritePrimitiveArray(T[] array) { }

	public void WriteSByte(string name, sbyte value) { }

	public void WriteSingle(string name, float value) { }

	public void WriteString(string name, string value) { }

	public void WriteUInt16(string name, ushort value) { }

	public void WriteUInt32(string name, uint value) { }

	public void WriteUInt64(string name, ulong value) { }

}

