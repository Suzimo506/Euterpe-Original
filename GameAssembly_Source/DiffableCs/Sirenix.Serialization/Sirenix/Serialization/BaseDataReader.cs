namespace Sirenix.Serialization;

public abstract class BaseDataReader : BaseDataReaderWriter, IDataReader, IDisposable
{
	private DeserializationContext context; //Field offset: 0x20
	private Stream stream; //Field offset: 0x28

	public override DeserializationContext Context
	{
		 get { } //Length: 354
		 set { } //Length: 12
	}

	public override int CurrentNodeDepth
	{
		 get { } //Length: 4
	}

	public override int CurrentNodeId
	{
		 get { } //Length: 37
	}

	public override string CurrentNodeName
	{
		 get { } //Length: 28
	}

	public override Stream Stream
	{
		 get { } //Length: 5
		 set { } //Length: 193
	}

	protected BaseDataReader(Stream stream, DeserializationContext context) { }

	public abstract void Dispose() { }

	public abstract bool EnterArray(out long length) { }

	public abstract bool EnterNode(out Type type) { }

	public abstract bool ExitArray() { }

	public abstract bool ExitNode() { }

	public override DeserializationContext get_Context() { }

	public override int get_CurrentNodeDepth() { }

	public override int get_CurrentNodeId() { }

	public override string get_CurrentNodeName() { }

	public override Stream get_Stream() { }

	public abstract string GetDataDump() { }

	protected abstract EntryType PeekEntry() { }

	public abstract EntryType PeekEntry(out string name) { }

	public override void PrepareNewSerializationSession() { }

	public abstract bool ReadBoolean(out bool value) { }

	public abstract bool ReadByte(out byte value) { }

	public abstract bool ReadChar(out char value) { }

	public abstract bool ReadDecimal(out decimal value) { }

	public abstract bool ReadDouble(out double value) { }

	public abstract bool ReadExternalReference(out Guid guid) { }

	public abstract bool ReadExternalReference(out string id) { }

	public abstract bool ReadExternalReference(out int index) { }

	public abstract bool ReadGuid(out Guid value) { }

	public abstract bool ReadInt16(out short value) { }

	public abstract bool ReadInt32(out int value) { }

	public abstract bool ReadInt64(out long value) { }

	public abstract bool ReadInternalReference(out int id) { }

	public abstract bool ReadNull() { }

	public abstract bool ReadPrimitiveArray(out T[] array) { }

	public abstract bool ReadSByte(out sbyte value) { }

	public abstract bool ReadSingle(out float value) { }

	public abstract bool ReadString(out string value) { }

	protected abstract EntryType ReadToNextEntry() { }

	public abstract bool ReadUInt16(out ushort value) { }

	public abstract bool ReadUInt32(out uint value) { }

	public abstract bool ReadUInt64(out ulong value) { }

	public override void set_Context(DeserializationContext value) { }

	public override void set_Stream(Stream value) { }

	public override void SkipEntry() { }

}

