namespace PeroTools2.Datas;

public class DataRef
{
	[SerializeField]
	private string m_Uid; //Field offset: 0x10

	public DataRef(string str = "") { }

	public T Get() { }

	public bool TryGet(out T value) { }

}

