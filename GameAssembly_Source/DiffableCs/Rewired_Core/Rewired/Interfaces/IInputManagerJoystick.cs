namespace Rewired.Interfaces;

[CustomClassObfuscation]
[CustomObfuscation]
internal interface IInputManagerJoystick : IInputManagerJoystickPublic
{

	public void FillData(ControllerDataUpdater dataUpdater) { }

	public BridgedController ToBridgedController() { }

	public ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs() { }

	public void Update() { }

}

