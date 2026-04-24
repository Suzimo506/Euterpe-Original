namespace Assets.Scripts.Database;

public class DBConfig
{
	private Dictionary<String, BaseDBConfigObject> m_ConfigDic; //Field offset: 0x10
	private List<BaseDataObject> m_MaskObject; //Field offset: 0x18

	public DBConfig() { }

	public void AddDBConfigObject(string name, BaseDBConfigObject obj) { }

	public void AddMaskObject(BaseDataObject maskObj) { }

	public void ClearAllMask() { }

	public void FindAllObject(List<KeyValuePair`2<String, T>> buffer) { }

	public bool GetDBConfigObject(string name, out BaseDBConfigObject obj) { }

	public bool RemoveDBConfigObject(string name) { }

	public void RemoveMaskObject(BaseDataObject maskObj) { }

}

