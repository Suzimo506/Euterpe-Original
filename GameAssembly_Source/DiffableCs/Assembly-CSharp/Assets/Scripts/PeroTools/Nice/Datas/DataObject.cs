namespace Assets.Scripts.PeroTools.Nice.Datas;

[CreateAssetMenu]
[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class DataObject : SerializedScriptableObject, IData
{
	[SerializeField]
	protected Dictionary<String, IVariable> m_Fields; //Field offset: 0x58

	public override Dictionary<String, IVariable> fields
	{
		 get { } //Length: 5
	}

	public override IVariable Item
	{
		 get { } //Length: 8
		 set { } //Length: 119
	}

	public DataObject() { }

	public override Dictionary<String, IVariable> get_fields() { }

	public override IVariable get_Item(string uid) { }

	public override void set_Item(string uid, IVariable value) { }

}

