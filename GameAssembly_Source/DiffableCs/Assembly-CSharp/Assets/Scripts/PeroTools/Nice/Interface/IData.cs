namespace Assets.Scripts.PeroTools.Nice.Interface;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public interface IData
{

	public Dictionary<String, IVariable> fields
	{
		 get { } //Length: 0
	}

	public IVariable Item
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Dictionary<String, IVariable> get_fields() { }

	public IVariable get_Item(string uid) { }

	public void set_Item(string uid, IVariable value) { }

}

