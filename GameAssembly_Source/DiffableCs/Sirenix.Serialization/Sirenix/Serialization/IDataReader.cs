namespace Sirenix.Serialization;

public interface IDataReader : IDisposable
{

	public TwoWaySerializationBinder Binder
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public DeserializationContext Context
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public int CurrentNodeDepth
	{
		 get { } //Length: 0
	}

	public int CurrentNodeId
	{
		 get { } //Length: 0
	}

	public string CurrentNodeName
	{
		 get { } //Length: 0
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

	public bool EnterArray(out long length) { }

	public bool EnterNode(out Type type) { }

	public bool ExitArray() { }

	public bool ExitNode() { }

	public TwoWaySerializationBinder get_Binder() { }

	public DeserializationContext get_Context() { }

	public int get_CurrentNodeDepth() { }

	public int get_CurrentNodeId() { }

	public string get_CurrentNodeName() { }

	public bool get_IsInArrayNode() { }

	public Stream get_Stream() { }

	public string GetDataDump() { }

	public EntryType PeekEntry(out string name) { }

	public void PrepareNewSerializationSession() { }

	public bool ReadBoolean(out bool value) { }

	public bool ReadByte(out byte value) { }

	public bool ReadChar(out char value) { }

	public bool ReadDecimal(out decimal value) { }

	public bool ReadDouble(out double value) { }

	public bool ReadExternalReference(out Guid guid) { }

	public bool ReadExternalReference(out int index) { }

	public bool ReadExternalReference(out string id) { }

	public bool ReadGuid(out Guid value) { }

	public bool ReadInt16(out short value) { }

	public bool ReadInt32(out int value) { }

	public bool ReadInt64(out long value) { }

	public bool ReadInternalReference(out int id) { }

	public bool ReadNull() { }

	public bool ReadPrimitiveArray(out T[] array) { }

	public bool ReadSByte(out sbyte value) { }

	public bool ReadSingle(out float value) { }

	public bool ReadString(out string value) { }

	public bool ReadUInt16(out ushort value) { }

	public bool ReadUInt32(out uint value) { }

	public bool ReadUInt64(out ulong value) { }

	public void set_Binder(TwoWaySerializationBinder value) { }

	public void set_Context(DeserializationContext value) { }

	public void set_Stream(Stream value) { }

	public void SkipEntry() { }

}

