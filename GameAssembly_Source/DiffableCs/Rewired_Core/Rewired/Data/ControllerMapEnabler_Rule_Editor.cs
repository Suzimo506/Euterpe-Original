namespace Rewired.Data;

[CustomClassObfuscation]
[Preserve]
public sealed class ControllerMapEnabler_Rule_Editor : IDeepCloneable
{
	[Serialize]
	[SerializeField]
	private string _tag; //Field offset: 0x10
	[Serialize]
	[SerializeField]
	private bool _enable; //Field offset: 0x18
	[Serialize]
	[SerializeField]
	private List<Int32> _categoryIds; //Field offset: 0x20
	[Serialize]
	[SerializeField]
	private List<Int32> _layoutIds; //Field offset: 0x28
	[Serialize]
	[SerializeField]
	private ControllerSetSelector_Editor _controllerSetSelector; //Field offset: 0x30

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

	public bool enable
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public List<Int32> layoutIds
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public string tag
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public ControllerMapEnabler_Rule_Editor() { }

	public ControllerMapEnabler_Rule_Editor(ControllerMapEnabler_Rule_Editor unnamed_param_0) { }

	public List<Int32> get_categoryIds() { }

	public ControllerSetSelector_Editor get_controllerSetSelector() { }

	public bool get_enable() { }

	public List<Int32> get_layoutIds() { }

	public string get_tag() { }

	private override object Rewired.Utils.Interfaces.IDeepCloneable.DeepClone() { }

	public void set_categoryIds(List<Int32> value) { }

	public void set_controllerSetSelector(ControllerSetSelector_Editor value) { }

	public void set_enable(bool value) { }

	public void set_layoutIds(List<Int32> value) { }

	public void set_tag(string value) { }

	internal Rule ToRuntime() { }

}

