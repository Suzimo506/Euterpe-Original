namespace PeroTools2.Datas.Variables;

public class JsonText : IVariable
{
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Name; //Field offset: 0x10
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Key; //Field offset: 0x18
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Index; //Field offset: 0x20
	[SerializeField]
	private bool m_IsPro; //Field offset: 0x28
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_CompareKey; //Field offset: 0x30
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_CompareValue; //Field offset: 0x38
	private IValue m_Value; //Field offset: 0x40

	public override event Action<IVariable> onVariableChanged
	{
		 add { } //Length: 87
		 remove { } //Length: 87
	}

	public int index
	{
		 get { } //Length: 57
		 set { } //Length: 92
	}

	public string key
	{
		 get { } //Length: 57
		 set { } //Length: 12
	}

	public string name
	{
		 get { } //Length: 57
		 set { } //Length: 12
	}

	public JsonText() { }

	public override void add_onVariableChanged(Action<IVariable> value) { }

	public int get_index() { }

	public string get_key() { }

	public string get_name() { }

	private object GetResult() { }

	public override T GetValue() { }

	public override void remove_onVariableChanged(Action<IVariable> value) { }

	public void set_index(int value) { }

	public void set_key(string value) { }

	public void set_name(string value) { }

}

