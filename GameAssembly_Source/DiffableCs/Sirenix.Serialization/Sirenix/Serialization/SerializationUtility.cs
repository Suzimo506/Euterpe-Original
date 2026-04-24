namespace Sirenix.Serialization;

public static class SerializationUtility
{

	public static object CreateCopy(object obj) { }

	public static IDataReader CreateReader(Stream stream, DeserializationContext context, DataFormat format) { }

	public static IDataWriter CreateWriter(Stream stream, SerializationContext context, DataFormat format) { }

	public static T DeserializeValue(Byte[] bytes, DataFormat format, DeserializationContext context = null) { }

	public static T DeserializeValue(Stream stream, DataFormat format, List<Object> referencedUnityObjects, DeserializationContext context = null) { }

	public static T DeserializeValue(Stream stream, DataFormat format, DeserializationContext context = null) { }

	public static T DeserializeValue(IDataReader reader, List<Object> referencedUnityObjects) { }

	public static T DeserializeValue(IDataReader reader) { }

	public static T DeserializeValue(Byte[] bytes, DataFormat format, List<Object> referencedUnityObjects, DeserializationContext context = null) { }

	public static object DeserializeValueWeak(Byte[] bytes, DataFormat format, List<Object> referencedUnityObjects) { }

	public static object DeserializeValueWeak(Byte[] bytes, DataFormat format, DeserializationContext context = null) { }

	public static object DeserializeValueWeak(Stream stream, DataFormat format, List<Object> referencedUnityObjects, DeserializationContext context = null) { }

	public static object DeserializeValueWeak(Stream stream, DataFormat format, DeserializationContext context = null) { }

	public static object DeserializeValueWeak(IDataReader reader, List<Object> referencedUnityObjects) { }

	public static object DeserializeValueWeak(IDataReader reader) { }

	private static IDataReader GetCachedReader(out IDisposable cache, DataFormat format, Stream stream, DeserializationContext context) { }

	private static IDataWriter GetCachedWriter(out IDisposable cache, DataFormat format, Stream stream, SerializationContext context) { }

	public static Byte[] SerializeValue(T value, DataFormat format, out List<Object>& unityObjects, SerializationContext context = null) { }

	public static void SerializeValue(T value, Stream stream, DataFormat format, out List<Object>& unityObjects, SerializationContext context = null) { }

	public static void SerializeValue(T value, Stream stream, DataFormat format, SerializationContext context = null) { }

	public static void SerializeValue(T value, IDataWriter writer, out List<Object>& unityObjects) { }

	public static void SerializeValue(T value, IDataWriter writer) { }

	public static Byte[] SerializeValue(T value, DataFormat format, SerializationContext context = null) { }

	public static Byte[] SerializeValueWeak(object value, DataFormat format, SerializationContext context = null) { }

	public static void SerializeValueWeak(object value, Stream stream, DataFormat format, out List<Object>& unityObjects, SerializationContext context = null) { }

	public static void SerializeValueWeak(object value, Stream stream, DataFormat format, SerializationContext context = null) { }

	public static void SerializeValueWeak(object value, IDataWriter writer, out List<Object>& unityObjects) { }

	public static void SerializeValueWeak(object value, IDataWriter writer) { }

	public static Byte[] SerializeValueWeak(object value, DataFormat format, out List<Object>& unityObjects) { }

}

