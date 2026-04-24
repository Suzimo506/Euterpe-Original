namespace ZenFulcrum.EmbeddedBrowser;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class JSONNode
{
	internal enum NodeType
	{
		Invalid = 0,
		String = 1,
		Number = 2,
		Object = 3,
		Array = 4,
		Bool = 5,
		Null = 6,
	}

	public static readonly JSONNode InvalidNode; //Field offset: 0x0
	public static readonly JSONNode NullNode; //Field offset: 0x8
	public NodeType _type; //Field offset: 0x10
	private string _stringValue; //Field offset: 0x18
	private double _numberValue; //Field offset: 0x20
	private Dictionary<String, JSONNode> _objectValue; //Field offset: 0x28
	private List<JSONNode> _arrayValue; //Field offset: 0x30
	private bool _boolValue; //Field offset: 0x38

	public string AsJSON
	{
		 get { } //Length: 259
	}

	public int Count
	{
		 get { } //Length: 106
	}

	public bool IsNull
	{
		 get { } //Length: 8
	}

	public bool IsValid
	{
		 get { } //Length: 8
	}

	public JSONNode Item
	{
		 get { } //Length: 173
		 set { } //Length: 191
	}

	public JSONNode Item
	{
		 get { } //Length: 162
		 set { } //Length: 269
	}

	public NodeType Type
	{
		 get { } //Length: 4
	}

	public object Value
	{
		 get { } //Length: 296
	}

	private static JSONNode() { }

	public JSONNode(NodeType type = 6) { }

	public JSONNode(string value) { }

	public JSONNode(double value) { }

	public JSONNode(Dictionary<String, JSONNode> value) { }

	public JSONNode(List<JSONNode> value) { }

	public JSONNode(bool value) { }

	public void Add(JSONNode item) { }

	public JSONNode Check() { }

	public string get_AsJSON() { }

	public int get_Count() { }

	public bool get_IsNull() { }

	public bool get_IsValid() { }

	public JSONNode get_Item(string k) { }

	public JSONNode get_Item(int idx) { }

	public NodeType get_Type() { }

	public object get_Value() { }

	public static JSONNode op_Implicit(bool v) { }

	public static bool op_Implicit(JSONNode n) { }

	public static List<JSONNode> op_Implicit(JSONNode n) { }

	public static JSONNode op_Implicit(float v) { }

	public static JSONNode op_Implicit(double v) { }

	public static double op_Implicit(JSONNode n) { }

	public static float op_Implicit(JSONNode n) { }

	public static JSONNode op_Implicit(int v) { }

	public static int op_Implicit(JSONNode n) { }

	public static JSONNode op_Implicit(string v) { }

	public static string op_Implicit(JSONNode n) { }

	public static Dictionary<String, JSONNode> op_Implicit(JSONNode n) { }

	public static JSONNode Parse(string json) { }

	public void set_Item(string k, JSONNode value) { }

	public void set_Item(int idx, JSONNode value) { }

}

