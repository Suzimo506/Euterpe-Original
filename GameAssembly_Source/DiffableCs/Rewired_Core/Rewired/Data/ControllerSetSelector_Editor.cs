namespace Rewired.Data;

[Preserve]
public sealed class ControllerSetSelector_Editor : IDeepCloneable
{
	[Serialize]
	[SerializeField]
	private Type _type; //Field offset: 0x10
	[Serialize]
	[SerializeField]
	private ControllerType _controllerType; //Field offset: 0x14
	[Serialize]
	[SerializeField]
	private string _hardwareTypeGuidString; //Field offset: 0x18
	[Serialize]
	[SerializeField]
	private string _hardwareIdentifier; //Field offset: 0x20
	[Serialize]
	[SerializeField]
	private string _controllerTemplateTypeGuidString; //Field offset: 0x28
	[Serialize]
	[SerializeField]
	private string _deviceInstanceGuidString; //Field offset: 0x30
	[Serialize]
	[SerializeField]
	private int _customControllerSourceId; //Field offset: 0x38
	[Serialize]
	[SerializeField]
	private int _controllerId; //Field offset: 0x3C

	public int controllerId
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public Guid controllerTemplateTypeGuid
	{
		 get { } //Length: 113
		 set { } //Length: 43
	}

	public string controllerTemplateTypeGuidString
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public ControllerType controllerType
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public int customControllerSourceId
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public Guid deviceInstanceGuid
	{
		 get { } //Length: 113
		 set { } //Length: 43
	}

	public string deviceInstanceGuidString
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public string hardwareIdentifier
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public Guid hardwareTypeGuid
	{
		 get { } //Length: 113
		 set { } //Length: 43
	}

	public string hardwareTypeGuidString
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public Type type
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	internal ControllerSetSelector_Editor(Type unnamed_param_0) { }

	public ControllerSetSelector_Editor() { }

	public ControllerSetSelector_Editor(ControllerSetSelector_Editor unnamed_param_0) { }

	internal ControllerSetSelector FRwVMquVlCIQJwvicwXxVwgEJPCT() { }

	public int get_controllerId() { }

	public Guid get_controllerTemplateTypeGuid() { }

	public string get_controllerTemplateTypeGuidString() { }

	public ControllerType get_controllerType() { }

	public int get_customControllerSourceId() { }

	public Guid get_deviceInstanceGuid() { }

	public string get_deviceInstanceGuidString() { }

	public string get_hardwareIdentifier() { }

	public Guid get_hardwareTypeGuid() { }

	public string get_hardwareTypeGuidString() { }

	public Type get_type() { }

	private override object Rewired.Utils.Interfaces.IDeepCloneable.DeepClone() { }

	public void set_controllerId(int value) { }

	public void set_controllerTemplateTypeGuid(Guid value) { }

	public void set_controllerTemplateTypeGuidString(string value) { }

	public void set_controllerType(ControllerType value) { }

	public void set_customControllerSourceId(int value) { }

	public void set_deviceInstanceGuid(Guid value) { }

	public void set_deviceInstanceGuidString(string value) { }

	public void set_hardwareIdentifier(string value) { }

	public void set_hardwareTypeGuid(Guid value) { }

	public void set_hardwareTypeGuidString(string value) { }

	public void set_type(Type value) { }

}

