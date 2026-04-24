namespace ProtoBuf;

public static class Serializer
{
	internal static class GlobalOptions
	{

		[Obsolete]
		public static bool InferTagFromName
		{
			 get { } //Length: 159
			 set { } //Length: 169
		}

		public static bool get_InferTagFromName() { }

		public static void set_InferTagFromName(bool value) { }

	}

	internal static class NonGeneric
	{

		public static bool CanSerialize(Type type) { }

		public static object DeepClone(object instance) { }

		public static object Deserialize(Type type, Stream source) { }

		public static object Merge(Stream source, object instance) { }

		public static void Serialize(Stream dest, object instance) { }

		public static void SerializeWithLengthPrefix(Stream destination, object instance, PrefixStyle style, int fieldNumber) { }

		public static bool TryDeserializeWithLengthPrefix(Stream source, PrefixStyle style, TypeResolver resolver, out object value) { }

	}

	internal sealed class TypeResolver : MulticastDelegate
	{

		public TypeResolver(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int fieldNumber, AsyncCallback callback, object object) { }

		public override Type EndInvoke(IAsyncResult result) { }

		public override Type Invoke(int fieldNumber) { }

	}

	private const string ProtoBinaryField = "proto"; //Field offset: 0x0
	public const int ListItemTag = 1; //Field offset: 0x0

	public static TTo ChangeType(TFrom instance) { }

	public static T DeepClone(T instance) { }

	public static T Deserialize(Stream source) { }

	public static IEnumerable<T> DeserializeItems(Stream source, PrefixStyle style, int fieldNumber) { }

	public static T DeserializeWithLengthPrefix(Stream source, PrefixStyle style) { }

	public static T DeserializeWithLengthPrefix(Stream source, PrefixStyle style, int fieldNumber) { }

	public static void FlushPool() { }

	public static string GetProto() { }

	public static T Merge(Stream source, T instance) { }

	public static T MergeWithLengthPrefix(Stream source, T instance, PrefixStyle style) { }

	public static void PrepareSerializer() { }

	public static void Serialize(Stream destination, T instance) { }

	public static void SerializeWithLengthPrefix(Stream destination, T instance, PrefixStyle style) { }

	public static void SerializeWithLengthPrefix(Stream destination, T instance, PrefixStyle style, int fieldNumber) { }

	public static bool TryReadLengthPrefix(Stream source, PrefixStyle style, out int length) { }

	public static bool TryReadLengthPrefix(Byte[] buffer, int index, int count, PrefixStyle style, out int length) { }

}

