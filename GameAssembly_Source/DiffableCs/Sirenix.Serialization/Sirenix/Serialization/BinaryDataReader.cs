namespace Sirenix.Serialization;

public class BinaryDataReader : BaseDataReader
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x681F0

		private static <>c() { }

		public <>c() { }

		internal char <.cctor>b__64_0(Byte[] b, int i) { }

		internal byte <.cctor>b__64_1(Byte[] b, int i) { }

		internal sbyte <.cctor>b__64_2(Byte[] b, int i) { }

		internal bool <.cctor>b__64_3(Byte[] b, int i) { }

	}

	private struct Struct256Bit
	{
		public decimal d1; //Field offset: 0x0
		public decimal d2; //Field offset: 0x10

	}

	private static readonly Dictionary<Type, Delegate> PrimitiveFromByteMethods; //Field offset: 0x0
	private Byte[] internalBufferBackup; //Field offset: 0x30
	private Byte[] buffer; //Field offset: 0x38
	private int bufferIndex; //Field offset: 0x40
	private int bufferEnd; //Field offset: 0x44
	private Nullable<EntryType> peekedEntryType; //Field offset: 0x48
	private BinaryEntryType peekedBinaryEntryType; //Field offset: 0x4A
	private string peekedEntryName; //Field offset: 0x50
	private Dictionary<Int32, Type> types; //Field offset: 0x58

	private static BinaryDataReader() { }

	public BinaryDataReader() { }

	public BinaryDataReader(Stream stream, DeserializationContext context) { }

	public virtual void Dispose() { }

	public virtual bool EnterArray(out long length) { }

	public virtual bool EnterNode(out Type type) { }

	public virtual bool ExitArray() { }

	public virtual bool ExitNode() { }

	public virtual string GetDataDump() { }

	private bool HasBufferData(int amount) { }

	private void MarkEntryContentConsumed() { }

	protected virtual EntryType PeekEntry() { }

	public virtual EntryType PeekEntry(out string name) { }

	public virtual void PrepareNewSerializationSession() { }

	public virtual bool ReadBoolean(out bool value) { }

	public virtual bool ReadByte(out byte value) { }

	public virtual bool ReadChar(out char value) { }

	public virtual bool ReadDecimal(out decimal value) { }

	public virtual bool ReadDouble(out double value) { }

	private void ReadEntireStreamToBuffer() { }

	public virtual bool ReadExternalReference(out string id) { }

	public virtual bool ReadExternalReference(out Guid guid) { }

	public virtual bool ReadExternalReference(out int index) { }

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

	private string ReadStringValue() { }

	protected virtual EntryType ReadToNextEntry() { }

	private Type ReadTypeEntry() { }

	public virtual bool ReadUInt16(out ushort value) { }

	public virtual bool ReadUInt32(out uint value) { }

	public virtual bool ReadUInt64(out ulong value) { }

	private bool SkipBuffer(int amount) { }

	private void SkipPeekedEntryContent() { }

	private void SkipStringValue() { }

	private bool UNSAFE_Read_1_Byte(out byte value) { }

	private bool UNSAFE_Read_1_SByte(out sbyte value) { }

	private bool UNSAFE_Read_16_Decimal(out decimal value) { }

	private bool UNSAFE_Read_16_Guid(out Guid value) { }

	private bool UNSAFE_Read_2_Char(out char value) { }

	private bool UNSAFE_Read_2_Int16(out short value) { }

	private bool UNSAFE_Read_2_UInt16(out ushort value) { }

	private bool UNSAFE_Read_4_Float32(out float value) { }

	private bool UNSAFE_Read_4_Int32(out int value) { }

	private bool UNSAFE_Read_4_UInt32(out uint value) { }

	private bool UNSAFE_Read_8_Float64(out double value) { }

	private bool UNSAFE_Read_8_Int64(out long value) { }

	private bool UNSAFE_Read_8_UInt64(out ulong value) { }

}

