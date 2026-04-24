namespace Assets.Scripts.PeroTools.Nice.Variables;

public class Text : IVariable, IValue
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

	public int index
	{
		 get { } //Length: 57
		 set { } //Length: 111
	}

	public string key
	{
		 get { } //Length: 57
		 set { } //Length: 87
	}

	public string name
	{
		 get { } //Length: 57
		 set { } //Length: 87
	}

	public override object result
	{
		 get { } //Length: 1027
		 set { } //Length: 3
	}

	public Text() { }

	public int get_index() { }

	public string get_key() { }

	public string get_name() { }

	public override object get_result() { }

	public void set_index(int value) { }

	public void set_key(string value) { }

	public void set_name(string value) { }

	public override void set_result(object value) { }

}

