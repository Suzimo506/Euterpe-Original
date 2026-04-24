namespace Rewired;

public sealed class JoystickMapSaveData : ControllerMapSaveData
{

	public Joystick joystick
	{
		 get { } //Length: 231
	}

	public Guid joystickHardwareTypeGuid
	{
		 get { } //Length: 428
	}

	public JoystickMap joystickMap
	{
		 get { } //Length: 176
	}

	internal JoystickMapSaveData(Joystick unnamed_param_0, JoystickMap unnamed_param_1) { }

	public Joystick get_joystick() { }

	public Guid get_joystickHardwareTypeGuid() { }

	public JoystickMap get_joystickMap() { }

}

