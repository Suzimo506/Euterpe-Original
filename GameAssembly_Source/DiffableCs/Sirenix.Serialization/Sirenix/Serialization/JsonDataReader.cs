namespace Sirenix.Serialization;

public class JsonDataReader : BaseDataReader
{
	private JsonTextReader reader; //Field offset: 0x30
	private Nullable<EntryType> peekedEntryType; //Field offset: 0x38
	private string peekedEntryName; //Field offset: 0x40
	private string peekedEntryContent; //Field offset: 0x48
	private Dictionary<Int32, Type> seenTypes; //Field offset: 0x50
	private readonly Dictionary<Type, Delegate> primitiveArrayReaders; //Field offset: 0x58

	public virtual Stream Stream
	{
		 get { } //Length: 5
		 set { } //Length: 465
	}

	public JsonDataReader() { }

	public JsonDataReader(Stream stream, DeserializationContext context) { }

	[CompilerGenerated]
	private char <.ctor>b__7_0() { }

	[CompilerGenerated]
	private sbyte <.ctor>b__7_1() { }

	[CompilerGenerated]
	private bool <.ctor>b__7_10() { }

	[CompilerGenerated]
	private float <.ctor>b__7_11() { }

	[CompilerGenerated]
	private double <.ctor>b__7_12() { }

	[CompilerGenerated]
	private Guid <.ctor>b__7_13() { }

	[CompilerGenerated]
	private short <.ctor>b__7_2() { }

	[CompilerGenerated]
	private int <.ctor>b__7_3() { }

	[CompilerGenerated]
	private long <.ctor>b__7_4() { }

	[CompilerGenerated]
	private byte <.ctor>b__7_5() { }

	[CompilerGenerated]
	private ushort <.ctor>b__7_6() { }

	[CompilerGenerated]
	private uint <.ctor>b__7_7() { }

	[CompilerGenerated]
	private ulong <.ctor>b__7_8() { }

	[CompilerGenerated]
	private decimal <.ctor>b__7_9() { }

	public virtual void Dispose() { }

	public virtual bool EnterArray(out long length) { }

	public virtual bool EnterNode(out Type type) { }

	public virtual bool ExitArray() { }

	public virtual bool ExitNode() { }

	public virtual Stream get_Stream() { }

	public virtual string GetDataDump() { }

	private void MarkEntryConsumed() { }

	public virtual EntryType PeekEntry(out string name) { }

	protected virtual EntryType PeekEntry() { }

	public virtual void PrepareNewSerializationSession() { }

	private bool ReadAnyIntReference(out int value) { }

	public virtual bool ReadBoolean(out bool value) { }

	public virtual bool ReadByte(out byte value) { }

	public virtual bool ReadChar(out char value) { }

	public virtual bool ReadDecimal(out decimal value) { }

	public virtual bool ReadDouble(out double value) { }

	public virtual bool ReadExternalReference(out int index) { }

	public virtual bool ReadExternalReference(out Guid guid) { }

	public virtual bool ReadExternalReference(out string id) { }

	public virtual bool ReadGuid(out Guid value) { }

	public virtual bool ReadInt16(out short value) { }

	public virtual bool ReadInt32(out int value) { }

	public virtual bool ReadInt64(out long value) { }

	public virtual bool ReadInternalReference(out int id) { }

	public virtual bool ReadNull() { }

	public virtual bool ReadPrimitiveArray(out T[] array) { }

	public virtual bool ReadSByte(out sbyte value) { }

	public virtual bool ReadSingle(out float value) { }

	public virtual bool ReadString(out string value) { }

	protected virtual EntryType ReadToNextEntry() { }

	public virtual bool ReadUInt16(out ushort value) { }

	public virtual bool ReadUInt32(out uint value) { }

	public virtual bool ReadUInt64(out ulong value) { }

	public virtual void set_Stream(Stream value) { }

}

