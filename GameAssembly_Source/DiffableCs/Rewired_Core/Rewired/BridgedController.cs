namespace Rewired;

[CustomClassObfuscation]
[CustomObfuscation]
internal class BridgedController : BridgedControllerHWInfo
{
	public IInputManagerJoystickPublic sourceJoystick; //Field offset: 0xB8
	public HardwareControllerMap_Game gameHardwareMap; //Field offset: 0xC0
	public Guid controllerTypeGuid; //Field offset: 0xC8
	public Extension controllerExtension; //Field offset: 0xD8
	public string instanceName; //Field offset: 0xE0
	public string productName; //Field offset: 0xE8
	public bool isXInputDevice; //Field offset: 0xF0
	public int axisCount; //Field offset: 0xF4
	public int buttonCount; //Field offset: 0xF8
	public Boolean[] isButtonPressureSensitive; //Field offset: 0x100
	public UnknownControllerHat[] unknownControllerHats; //Field offset: 0x108
	public CustomInputSource customInputSource; //Field offset: 0x110

	public bool isUnknownController
	{
		 get { } //Length: 138
	}

	public BridgedController() { }

	public bool get_isUnknownController() { }

}

