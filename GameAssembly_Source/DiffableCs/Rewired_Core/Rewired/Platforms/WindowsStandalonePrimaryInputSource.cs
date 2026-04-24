namespace Rewired.Platforms;

[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
public enum WindowsStandalonePrimaryInputSource
{
	RawInput = 0,
	DirectInput = 1,
	XInput = 2,
	SDL2 = 10,
	Unity = 100,
}

