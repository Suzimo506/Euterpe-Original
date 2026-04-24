namespace Rewired;

[CustomClassObfuscation]
[CustomObfuscation]
internal class ControllerDataUpdater
{
	public readonly InputSource source; //Field offset: 0x10
	public readonly int axisCount; //Field offset: 0x14
	public readonly int buttonCount; //Field offset: 0x18
	public readonly Single[] axisValues; //Field offset: 0x20
	public readonly Boolean[] buttonValues; //Field offset: 0x28
	public readonly Single[] buttonPressureValues; //Field offset: 0x30
	public readonly Boolean[] axisHasBeenPressedOSXLinux; //Field offset: 0x38
	private readonly UnknownControllerHat[] gvyEgWfHbiYQMjGLCepVhLJvXoNx; //Field offset: 0x40
	public bool hasReceivedInput; //Field offset: 0x48

	public ControllerDataUpdater(InputSource unnamed_param_0, int unnamed_param_1, int unnamed_param_2, UnknownControllerHat[] unnamed_param_3) { }

	public void ClearData() { }

	public HatButtons GetUnknownHatButtons(int buttonIndex) { }

	public bool IsUnknownHatCardinal(int buttonIndex) { }

}

