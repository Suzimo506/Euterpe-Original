namespace Rewired.Data;

[CustomClassObfuscation]
[Preserve]
public sealed class ControllerMapLayoutManager_Rule_Editor : IDeepCloneable
{
	[Serialize]
	[SerializeField]
	private string _tag; //Field offset: 0x10
	[Serialize]
	[SerializeField]
	private List<Int32> _categoryIds; //Field offset: 0x18
	[Serialize]
	[SerializeField]
	private int _layoutId; //Field offset: 0x20
	[Serialize]
	[SerializeField]
	private ControllerSetSelector_Editor _controllerSetSelector; //Field offset: 0x28

	public List<Int32> categoryIds
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public ControllerSetSelector_Editor controllerSetSelector
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public int layoutId
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public string tag
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public ControllerMapLayoutManager_Rule_Editor() { }

	public ControllerMapLayoutManager_Rule_Editor(ControllerMapLayoutManager_Rule_Editor unnamed_param_0) { }

	public List<Int32> get_categoryIds() { }

	public ControllerSetSelector_Editor get_controllerSetSelector() { }

	public int get_layoutId() { }

	public string get_tag() { }

	private override object Rewired.Utils.Interfaces.IDeepCloneable.DeepClone() { }

	public void set_categoryIds(List<Int32> value) { }

	public void set_controllerSetSelector(ControllerSetSelector_Editor value) { }

	public void set_layoutId(int value) { }

	public void set_tag(string value) { }

	internal Rule ToRuntime() { }

}

