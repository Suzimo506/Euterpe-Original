namespace ProtoBuf;

public sealed class ProtoReader : IDisposable
{
	[ThreadStatic]
	private static ProtoReader lastReader; //Field offset: 0x80000000
	private static readonly UTF8Encoding encoding; //Field offset: 0x0
	private const int Int32Msb = -2147483648; //Field offset: 0x0
	private const long Int64Msb = -9223372036854775808; //Field offset: 0x0
	internal const int TO_EOF = -1; //Field offset: 0x0
	private static readonly Byte[] EmptyBlob; //Field offset: 0x8
	private Stream source; //Field offset: 0x10
	private Byte[] ioBuffer; //Field offset: 0x18
	private TypeModel model; //Field offset: 0x20
	private int fieldNumber; //Field offset: 0x28
	private int depth; //Field offset: 0x2C
	private int dataRemaining; //Field offset: 0x30
	private int ioIndex; //Field offset: 0x34
	private int position; //Field offset: 0x38
	private int available; //Field offset: 0x3C
	private int blockEnd; //Field offset: 0x40
	private WireType wireType; //Field offset: 0x44
	private bool isFixedLength; //Field offset: 0x48
	private bool internStrings; //Field offset: 0x49
	private NetObjectCache netCache; //Field offset: 0x50
	private uint trapCount; //Field offset: 0x58
	private SerializationContext context; //Field offset: 0x60
	private Dictionary<String, String> stringInterner; //Field offset: 0x68

	public SerializationContext Context
	{
		 get { } //Length: 5
	}

	public int FieldNumber
	{
		 get { } //Length: 4
	}

	public bool InternStrings
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public TypeModel Model
	{
		 get { } //Length: 5
	}

	internal NetObjectCache NetCache
	{
		internal get { } //Length: 5
	}

	public int Position
	{
		 get { } //Length: 4
	}

	public WireType WireType
	{
		 get { } //Length: 4
	}

	private static ProtoReader() { }

	public ProtoReader(Stream source, TypeModel model, SerializationContext context, int length) { }

	public ProtoReader(Stream source, TypeModel model, SerializationContext context) { }

	internal static Exception AddErrorData(Exception exception, ProtoReader source) { }

	public static Byte[] AppendBytes(Byte[] value, ProtoReader reader) { }

	public void AppendExtensionData(IExtensible instance) { }

	private void AppendExtensionField(ProtoWriter writer) { }

	public void Assert(WireType wireType) { }

	internal void CheckFullyConsumed() { }

	internal static ProtoReader Create(Stream source, TypeModel model, SerializationContext context, int len) { }

	private Exception CreateException(string message) { }

	private Exception CreateWireTypeException() { }

	internal Type DeserializeType(string value) { }

	public static int DirectReadBigEndianInt32(Stream source) { }

	public static void DirectReadBytes(Stream source, Byte[] buffer, int offset, int count) { }

	public static Byte[] DirectReadBytes(Stream source, int count) { }

	public static int DirectReadLittleEndianInt32(Stream source) { }

	public static string DirectReadString(Stream source, int length) { }

	public static int DirectReadVarintInt32(Stream source) { }

	public override void Dispose() { }

	public static void EndSubItem(SubItemToken token, ProtoReader reader) { }

	internal void Ensure(int count, bool strict) { }

	private static Exception EoF(ProtoReader source) { }

	public SerializationContext get_Context() { }

	public int get_FieldNumber() { }

	public bool get_InternStrings() { }

	public TypeModel get_Model() { }

	internal NetObjectCache get_NetCache() { }

	public int get_Position() { }

	public WireType get_WireType() { }

	private static ProtoReader GetRecycled() { }

	internal int GetTypeKey(ref Type type) { }

	public static bool HasSubValue(WireType wireType, ProtoReader source) { }

	public void Hint(WireType wireType) { }

	private static void Init(ProtoReader reader, Stream source, TypeModel model, SerializationContext context, int length) { }

	private string Intern(string value) { }

	public static object Merge(ProtoReader parent, object from, object to) { }

	public static void NoteObject(object value, ProtoReader reader) { }

	public bool ReadBoolean() { }

	public byte ReadByte() { }

	private static int ReadByteOrThrow(Stream source) { }

	public double ReadDouble() { }

	public int ReadFieldHeader() { }

	public short ReadInt16() { }

	public int ReadInt32() { }

	public long ReadInt64() { }

	public static int ReadLengthPrefix(Stream source, bool expectHeader, PrefixStyle style, out int fieldNumber) { }

	public static int ReadLengthPrefix(Stream source, bool expectHeader, PrefixStyle style, out int fieldNumber, out int bytesRead) { }

	public static object ReadObject(object value, int key, ProtoReader reader) { }

	public sbyte ReadSByte() { }

	public float ReadSingle() { }

	public string ReadString() { }

	public Type ReadType() { }

	internal static object ReadTypedObject(object value, int key, ProtoReader reader, Type type) { }

	public ushort ReadUInt16() { }

	public uint ReadUInt32() { }

	private uint ReadUInt32Variant(bool trimNegative) { }

	public ulong ReadUInt64() { }

	private ulong ReadUInt64Variant() { }

	internal static void Recycle(ProtoReader reader) { }

	internal static void Seek(Stream source, int count, Byte[] buffer) { }

	public void set_InternStrings(bool value) { }

	internal void SetRootObject(object value) { }

	public void SkipField() { }

	public static SubItemToken StartSubItem(ProtoReader reader) { }

	public void ThrowEnumException(Type type, int value) { }

	internal void TrapNextObject(int newObjectKey) { }

	public bool TryReadFieldHeader(int field) { }

	private static int TryReadUInt32Variant(Stream source, out uint value) { }

	private bool TryReadUInt32Variant(out uint value) { }

	internal int TryReadUInt32VariantWithoutMoving(bool trimNegative, out uint value) { }

	private int TryReadUInt64VariantWithoutMoving(out ulong value) { }

	private static int Zag(uint ziggedValue) { }

	private static long Zag(ulong ziggedValue) { }

}

