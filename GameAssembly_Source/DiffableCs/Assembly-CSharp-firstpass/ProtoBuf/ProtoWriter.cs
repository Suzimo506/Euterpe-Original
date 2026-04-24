namespace ProtoBuf;

public sealed class ProtoWriter : IDisposable
{
	private const int RecursionCheckDepth = 25; //Field offset: 0x0
	private static readonly UTF8Encoding encoding; //Field offset: 0x0
	private Stream dest; //Field offset: 0x10
	private TypeModel model; //Field offset: 0x18
	private readonly NetObjectCache netCache; //Field offset: 0x20
	private int fieldNumber; //Field offset: 0x28
	private int flushLock; //Field offset: 0x2C
	private WireType wireType; //Field offset: 0x30
	private int depth; //Field offset: 0x34
	private MutableList recursionStack; //Field offset: 0x38
	private readonly SerializationContext context; //Field offset: 0x40
	private Byte[] ioBuffer; //Field offset: 0x48
	private int ioIndex; //Field offset: 0x50
	private int position; //Field offset: 0x54
	private int packedFieldNumber; //Field offset: 0x58

	public SerializationContext Context
	{
		 get { } //Length: 5
	}

	public TypeModel Model
	{
		 get { } //Length: 5
	}

	internal NetObjectCache NetCache
	{
		internal get { } //Length: 5
	}

	internal WireType WireType
	{
		internal get { } //Length: 4
	}

	private static ProtoWriter() { }

	public ProtoWriter(Stream dest, TypeModel model, SerializationContext context) { }

	public static void AppendExtensionData(IExtensible instance, ProtoWriter writer) { }

	internal void CheckDepthFlushlock() { }

	private void CheckRecursionStackAndPush(object instance) { }

	public void Close() { }

	private static void CopyRawFromStream(Stream source, ProtoWriter writer) { }

	internal static Exception CreateException(ProtoWriter writer) { }

	private static void DemandSpace(int required, ProtoWriter writer) { }

	private void Dispose() { }

	private static void EndSubItem(SubItemToken token, ProtoWriter writer, PrefixStyle style) { }

	public static void EndSubItem(SubItemToken token, ProtoWriter writer) { }

	internal static void Flush(ProtoWriter writer) { }

	public SerializationContext get_Context() { }

	public TypeModel get_Model() { }

	internal NetObjectCache get_NetCache() { }

	internal WireType get_WireType() { }

	internal static int GetPosition(ProtoWriter writer) { }

	internal int GetTypeKey(ref Type type) { }

	private static void IncrementedAndReset(int length, ProtoWriter writer) { }

	private void PopRecursionStack() { }

	internal string SerializeType(Type type) { }

	public static void SetPackedField(int fieldNumber, ProtoWriter writer) { }

	public void SetRootObject(object value) { }

	private static SubItemToken StartSubItem(object instance, ProtoWriter writer, bool allowFixed) { }

	public static SubItemToken StartSubItem(object instance, ProtoWriter writer) { }

	private override void System.IDisposable.Dispose() { }

	public static void ThrowEnumException(ProtoWriter writer, object enumValue) { }

	public static void WriteBoolean(bool value, ProtoWriter writer) { }

	public static void WriteByte(byte value, ProtoWriter writer) { }

	public static void WriteBytes(Byte[] data, ProtoWriter writer) { }

	public static void WriteBytes(Byte[] data, int offset, int length, ProtoWriter writer) { }

	public static void WriteDouble(double value, ProtoWriter writer) { }

	public static void WriteFieldHeader(int fieldNumber, WireType wireType, ProtoWriter writer) { }

	internal static void WriteHeaderCore(int fieldNumber, WireType wireType, ProtoWriter writer) { }

	public static void WriteInt16(short value, ProtoWriter writer) { }

	public static void WriteInt32(int value, ProtoWriter writer) { }

	private static void WriteInt32ToBuffer(int value, Byte[] buffer, int index) { }

	public static void WriteInt64(long value, ProtoWriter writer) { }

	internal static void WriteObject(object value, int key, ProtoWriter writer, PrefixStyle style, int fieldNumber) { }

	public static void WriteObject(object value, int key, ProtoWriter writer) { }

	public static void WriteRecursionSafeObject(object value, int key, ProtoWriter writer) { }

	public static void WriteSByte(sbyte value, ProtoWriter writer) { }

	public static void WriteSingle(float value, ProtoWriter writer) { }

	public static void WriteString(string value, ProtoWriter writer) { }

	public static void WriteType(Type value, ProtoWriter writer) { }

	public static void WriteUInt16(ushort value, ProtoWriter writer) { }

	public static void WriteUInt32(uint value, ProtoWriter writer) { }

	private static void WriteUInt32Variant(uint value, ProtoWriter writer) { }

	public static void WriteUInt64(ulong value, ProtoWriter writer) { }

	private static void WriteUInt64Variant(ulong value, ProtoWriter writer) { }

	internal static ulong Zig(long value) { }

	internal static uint Zig(int value) { }

}

