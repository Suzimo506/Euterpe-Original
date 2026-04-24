namespace ProtoBuf;

public abstract class Extensible : IExtensible
{
	private IExtension extensionObject; //Field offset: 0x10

	protected Extensible() { }

	public static void AppendValue(IExtensible instance, int tag, TValue value) { }

	public static void AppendValue(IExtensible instance, int tag, DataFormat format, TValue value) { }

	public static void AppendValue(TypeModel model, IExtensible instance, int tag, DataFormat format, object value) { }

	protected override IExtension GetExtensionObject(bool createIfMissing) { }

	public static IExtension GetExtensionObject(ref IExtension extensionObject, bool createIfMissing) { }

	public static TValue GetValue(IExtensible instance, int tag) { }

	public static TValue GetValue(IExtensible instance, int tag, DataFormat format) { }

	public static IEnumerable<TValue> GetValues(IExtensible instance, int tag) { }

	public static IEnumerable<TValue> GetValues(IExtensible instance, int tag, DataFormat format) { }

	public static IEnumerable GetValues(TypeModel model, Type type, IExtensible instance, int tag, DataFormat format) { }

	private override IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing) { }

	public static bool TryGetValue(IExtensible instance, int tag, out TValue value) { }

	public static bool TryGetValue(IExtensible instance, int tag, DataFormat format, out TValue value) { }

	public static bool TryGetValue(IExtensible instance, int tag, DataFormat format, bool allowDefinedTag, out TValue value) { }

	public static bool TryGetValue(TypeModel model, Type type, IExtensible instance, int tag, DataFormat format, bool allowDefinedTag, out object value) { }

}

