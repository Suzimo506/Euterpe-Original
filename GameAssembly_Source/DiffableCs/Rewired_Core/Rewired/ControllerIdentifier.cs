namespace Rewired;

public struct ControllerIdentifier
{
	private int RyqgXxdmIROdTFIJICAlfUllSulgB; //Field offset: 0x0
	private ControllerType LAyMyaKwGyfxCtglXtLagEzDLvge; //Field offset: 0x4
	private Guid uDhhjuSkmWglwDEGlGDXxQSpcPfXA; //Field offset: 0x8
	private string mtlXIJeXMrSHONeOjtpICqmvuvJe; //Field offset: 0x18
	private Guid zMQrjJHLSKAdKULhaCeyZgdoURgn; //Field offset: 0x20

	public static ControllerIdentifier Blank
	{
		 get { } //Length: 24
	}

	public int controllerId
	{
		 get { } //Length: 3
		 set { } //Length: 3
	}

	public ControllerType controllerType
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public Guid deviceInstanceGuid
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public string hardwareIdentifier
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public Guid hardwareTypeGuid
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	internal ControllerIdentifier(Controller unnamed_param_0) { }

	public static ControllerIdentifier get_Blank() { }

	public int get_controllerId() { }

	public ControllerType get_controllerType() { }

	public Guid get_deviceInstanceGuid() { }

	public string get_hardwareIdentifier() { }

	public Guid get_hardwareTypeGuid() { }

	public void set_controllerId(int value) { }

	public void set_controllerType(ControllerType value) { }

	public void set_deviceInstanceGuid(Guid value) { }

	public void set_hardwareIdentifier(string value) { }

	public void set_hardwareTypeGuid(Guid value) { }

}

