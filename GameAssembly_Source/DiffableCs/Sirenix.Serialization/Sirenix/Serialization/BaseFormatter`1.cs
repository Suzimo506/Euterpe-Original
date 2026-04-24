namespace Sirenix.Serialization;

public abstract class BaseFormatter : IFormatter<T>, IFormatter
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public MethodInfo info; //Field offset: 0x0

		public <>c__DisplayClass11_0() { }

		internal void <CreateCallback>b__0(ref T value, StreamingContext context) { }

		internal void <CreateCallback>b__1(ref T value, StreamingContext context) { }

	}

	internal sealed class SerializationCallback : MulticastDelegate
	{

		public SerializationCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref T value, StreamingContext context, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref T value, IAsyncResult result) { }

		public override void Invoke(ref T value, StreamingContext context) { }

	}

	protected static readonly SerializationCallback<T>[] OnSerializingCallbacks; //Field offset: 0x0
	protected static readonly SerializationCallback<T>[] OnSerializedCallbacks; //Field offset: 0x0
	protected static readonly SerializationCallback<T>[] OnDeserializingCallbacks; //Field offset: 0x0
	protected static readonly SerializationCallback<T>[] OnDeserializedCallbacks; //Field offset: 0x0
	protected static readonly bool IsValueType; //Field offset: 0x0
	protected static readonly bool ImplementsISerializationCallbackReceiver; //Field offset: 0x0
	protected static readonly bool ImplementsIDeserializationCallback; //Field offset: 0x0
	protected static readonly bool ImplementsIObjectReference; //Field offset: 0x0

	public override Type SerializedType
	{
		 get { } //Length: 95
	}

	private static BaseFormatter`1() { }

	protected BaseFormatter`1() { }

	private static SerializationCallback<T> CreateCallback(MethodInfo info) { }

	public override T Deserialize(IDataReader reader) { }

	protected abstract void DeserializeImplementation(ref T value, IDataReader reader) { }

	public override Type get_SerializedType() { }

	private static SerializationCallback<T>[] GetCallbacks(MethodInfo[] methods, Type callbackAttribute, ref List<SerializationCallback<T>>& list) { }

	protected override T GetUninitializedObject() { }

	[Obsolete]
	protected void InvokeOnDeserializingCallbacks(T value, DeserializationContext context) { }

	protected void InvokeOnDeserializingCallbacks(ref T value, DeserializationContext context) { }

	protected void RegisterReferenceID(T value, IDataReader reader) { }

	public override void Serialize(T value, IDataWriter writer) { }

	protected abstract void SerializeImplementation(ref T value, IDataWriter writer) { }

	private override object Sirenix.Serialization.IFormatter.Deserialize(IDataReader reader) { }

	private override void Sirenix.Serialization.IFormatter.Serialize(object value, IDataWriter writer) { }

}

