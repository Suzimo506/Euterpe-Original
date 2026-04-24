namespace Rewired;

[CustomClassObfuscation]
[CustomObfuscation]
internal class UpdateControllerInfoEventArgs : EventArgs
{
	public readonly IInputManagerJoystickPublic sourceJoystick; //Field offset: 0x10

	public UpdateControllerInfoEventArgs(IInputManagerJoystickPublic unnamed_param_0) { }

}

