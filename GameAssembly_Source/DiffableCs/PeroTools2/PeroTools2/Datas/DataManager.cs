namespace PeroTools2.Datas;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class DataManager : Singleton<DataManager>
{
	private const char split_char = '\u2F'; //Field offset: 0x0
	private Dictionary<String, DataObject> m_DataObjects; //Field offset: 0x10

	public DataObject Item
	{
		 get { } //Length: 186
		 set { } //Length: 213
	}

	public DataManager() { }

	public DataObject get_Item(string uid) { }

	internal IVariable GetVariable(string uid) { }

	private void Init() { }

	private void Load() { }

	[Obsolete]
	public void LoadFromBytes(Byte[] bytes) { }

	public void LoadFromJson(string json) { }

	internal IVariable RegVariable(string id) { }

	public void Save() { }

	public void set_Item(string uid, DataObject value) { }

	internal void SetVariable(string uid, IVariable variable) { }

	[Obsolete]
	public Byte[] ToBytes() { }

	public string ToJson() { }

	internal bool TryRegVariable(string id, out IVariable variable) { }

}

