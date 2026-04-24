namespace Rewired;

[CustomClassObfuscation]
[CustomObfuscation]
internal class HardwareJoystickMap_InputManager
{
	public string controllerName; //Field offset: 0x10
	public readonly HardwareControllerMapIdentifier hardwareMapIdentifier; //Field offset: 0x18
	public readonly Platform map; //Field offset: 0x38
	public readonly int buttonCount; //Field offset: 0x40
	public readonly int axisCount; //Field offset: 0x44
	public readonly ControllerElementIdentifier[] elementIdentifiers; //Field offset: 0x48
	public readonly CompoundElement[] compoundElements; //Field offset: 0x50
	public bool useSystemName; //Field offset: 0x58
	public readonly bool isUnknownController; //Field offset: 0x59
	public readonly JoystickType[] joystickTypes; //Field offset: 0x60

	public HardwareJoystickMap_InputManager(HardwareControllerMapIdentifier unnamed_param_0, JoystickType[] unnamed_param_1, Platform unnamed_param_2, string unnamed_param_3, int unnamed_param_4, int unnamed_param_5, int unnamed_param_6, CompoundElement[] unnamed_param_7) { }

	public String[] GetAxisNames() { }

	public String[] GetEffectiveButtonNames() { }

	public HardwareControllerMap_Game ToGameHardwareControllerMap() { }

}

