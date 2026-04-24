namespace Rewired;

public abstract class ControllerMapSaveData
{
	protected Controller _controller; //Field offset: 0x10
	protected ControllerMap _map; //Field offset: 0x18
	internal readonly int VetpcoloufDUIHFBDUgRuDriUEsF; //Field offset: 0x20

	public int categoryId
	{
		 get { } //Length: 174
	}

	public Controller controller
	{
		 get { } //Length: 155
	}

	public string controllerHardwareIdentifier
	{
		 get { } //Length: 186
	}

	public ControllerType controllerType
	{
		 get { } //Length: 171
	}

	public int layoutId
	{
		 get { } //Length: 174
	}

	public ControllerMap map
	{
		 get { } //Length: 155
	}

	public Type mapType
	{
		 get { } //Length: 171
	}

	public string mapTypeString
	{
		 get { } //Length: 186
	}

	internal ControllerMapSaveData(Controller unnamed_param_0, ControllerMap unnamed_param_1) { }

	public int get_categoryId() { }

	public Controller get_controller() { }

	public string get_controllerHardwareIdentifier() { }

	public ControllerType get_controllerType() { }

	public int get_layoutId() { }

	public ControllerMap get_map() { }

	public Type get_mapType() { }

	public string get_mapTypeString() { }

	public T GetMap() { }

	internal static  iubCQMAjMIuecaDNoukJTrSXGONC(Controller unnamed_param_0, ControllerMap unnamed_param_1) { }

	internal static ControllerMapSaveData iubCQMAjMIuecaDNoukJTrSXGONC(Controller unnamed_param_0, ControllerMap unnamed_param_1) { }

}

