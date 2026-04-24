namespace Rewired.Interfaces;

[CustomClassObfuscation]
[CustomObfuscation]
internal interface IControllerAssigner
{

	public bool enabled
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public void AssignController(ControllerType controllerType, Controller controller) { }

	public bool CanHandleAssignment(ControllerType controllerType, Controller controller) { }

	public bool get_enabled() { }

	public void set_enabled(bool value) { }

}

