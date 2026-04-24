namespace Sirenix.Serialization;

public sealed class CoroutineFormatter : IFormatter<Coroutine>, IFormatter
{

	public override Type SerializedType
	{
		 get { } //Length: 85
	}

	public CoroutineFormatter() { }

	public override Coroutine Deserialize(IDataReader reader) { }

	public override Type get_SerializedType() { }

	public override void Serialize(object value, IDataWriter writer) { }

	public override void Serialize(Coroutine value, IDataWriter writer) { }

	private override object Sirenix.Serialization.IFormatter.Deserialize(IDataReader reader) { }

}

