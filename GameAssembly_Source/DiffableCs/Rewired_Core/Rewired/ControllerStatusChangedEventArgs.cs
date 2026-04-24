namespace Rewired;

public sealed class ControllerStatusChangedEventArgs : EventArgs
{
	private string izBjhSznEaRawMUCFuEAZRGeBHDi; //Field offset: 0x10
	private int RyqgXxdmIROdTFIJICAlfUllSulgB; //Field offset: 0x18
	private ControllerType LAyMyaKwGyfxCtglXtLagEzDLvge; //Field offset: 0x1C

	public Controller controller
	{
		 get { } //Length: 221
	}

	public int controllerId
	{
		 get { } //Length: 4
	}

	public ControllerType controllerType
	{
		 get { } //Length: 4
	}

	public string name
	{
		 get { } //Length: 5
	}

	public ControllerStatusChangedEventArgs(string unnamed_param_0, int unnamed_param_1, ControllerType unnamed_param_2) { }

	public Controller get_controller() { }

	public int get_controllerId() { }

	public ControllerType get_controllerType() { }

	public string get_name() { }

}

