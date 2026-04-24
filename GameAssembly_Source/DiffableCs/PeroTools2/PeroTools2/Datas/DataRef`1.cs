namespace PeroTools2.Datas;

public class DataRef
{
	[SerializeField]
	private string m_Uid; //Field offset: 0x0
	private T m_Data; //Field offset: 0x0

	public DataRef`1(string str = "") { }

	public T Get() { }

	public void Init() { }

	public bool TryGet(out T value) { }

}

