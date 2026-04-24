namespace Sirenix.Serialization;

public abstract class MinimalBaseFormatter : IFormatter<T>, IFormatter
{
	protected static readonly bool IsValueType; //Field offset: 0x0

	public override Type SerializedType
	{
		 get { } //Length: 95
	}

	private static MinimalBaseFormatter`1() { }

	protected MinimalBaseFormatter`1() { }

	public override T Deserialize(IDataReader reader) { }

	public override Type get_SerializedType() { }

	protected override T GetUninitializedObject() { }

	protected abstract void Read(ref T value, IDataReader reader) { }

	protected void RegisterReferenceID(T value, IDataReader reader) { }

	public override void Serialize(T value, IDataWriter writer) { }

	private override object Sirenix.Serialization.IFormatter.Deserialize(IDataReader reader) { }

	private override void Sirenix.Serialization.IFormatter.Serialize(object value, IDataWriter writer) { }

	protected abstract void Write(ref T value, IDataWriter writer) { }

}

