namespace Rewired.Data;

[CustomClassObfuscation]
[Preserve]
public sealed class ControllerMapLayoutManager_RuleSet_Editor
{
	[Serialize]
	[SerializeField]
	private int _id; //Field offset: 0x10
	[Serialize]
	[SerializeField]
	private string _name; //Field offset: 0x18
	[Serialize]
	[SerializeField]
	private string _tag; //Field offset: 0x20
	[Serialize]
	[SerializeField]
	private List<ControllerMapLayoutManager_Rule_Editor> _rules; //Field offset: 0x28

	public int id
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public string name
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public List<ControllerMapLayoutManager_Rule_Editor> rules
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public string tag
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public ControllerMapLayoutManager_RuleSet_Editor() { }

	public ControllerMapLayoutManager_RuleSet_Editor(ControllerMapLayoutManager_RuleSet_Editor unnamed_param_0) { }

	internal ControllerMapLayoutManager_RuleSet_Editor Clone() { }

	public int get_id() { }

	public string get_name() { }

	public List<ControllerMapLayoutManager_Rule_Editor> get_rules() { }

	public string get_tag() { }

	public void set_id(int value) { }

	public void set_name(string value) { }

	public void set_rules(List<ControllerMapLayoutManager_Rule_Editor> value) { }

	public void set_tag(string value) { }

	internal RuleSet ToRuntime() { }

}

