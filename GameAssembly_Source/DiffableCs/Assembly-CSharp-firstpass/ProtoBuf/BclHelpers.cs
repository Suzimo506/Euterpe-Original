namespace ProtoBuf;

public static class BclHelpers
{
	[Flags]
	internal enum NetObjectOptions
	{
		None = 0,
		AsReference = 1,
		DynamicType = 2,
		UseConstructor = 4,
		LateSet = 8,
	}

	private const int FieldTimeSpanScale = 2; //Field offset: 0x64D30
	internal static readonly DateTime EpochOrigin; //Field offset: 0x64D60
	private const int FieldDecimalHigh = 2; //Field offset: 0x64D60
	private const int FieldDecimalSignScale = 3; //Field offset: 0x64D9C
	private const int FieldGuidHigh = 2; //Field offset: 0x64DA0
	private const int FieldExistingObjectKey = 1; //Field offset: 0x64DDE
	private const int FieldExistingTypeKey = 3; //Field offset: 0x64DE0
	private const int FieldNewTypeKey = 4; //Field offset: 0x64E7C
	private const int FieldObject = 10; //Field offset: 0x64E80
	private const int FieldDecimalLow = 1; //Field offset: 0x2C927B4
	private const int FieldGuidLow = 1; //Field offset: 0x2C927B4
	private const int FieldNewObjectKey = 2; //Field offset: 0x2C927B4
	private const int FieldTimeSpanValue = 1; //Field offset: 0x2C927BC
	private const int FieldTypeName = 8; //Field offset: 0x2C927BC

	private static BclHelpers() { }

	public static object GetUninitializedObject(Type type) { }

	public static DateTime ReadDateTime(ProtoReader source) { }

	public static decimal ReadDecimal(ProtoReader reader) { }

	public static Guid ReadGuid(ProtoReader source) { }

	public static object ReadNetObject(object value, ProtoReader source, int key, Type type, NetObjectOptions options) { }

	public static TimeSpan ReadTimeSpan(ProtoReader source) { }

	private static long ReadTimeSpanTicks(ProtoReader source) { }

	public static void WriteDateTime(DateTime value, ProtoWriter dest) { }

	public static void WriteDecimal(decimal value, ProtoWriter writer) { }

	public static void WriteGuid(Guid value, ProtoWriter dest) { }

	public static void WriteNetObject(object value, ProtoWriter dest, int key, NetObjectOptions options) { }

	public static void WriteTimeSpan(TimeSpan timeSpan, ProtoWriter dest) { }

}

