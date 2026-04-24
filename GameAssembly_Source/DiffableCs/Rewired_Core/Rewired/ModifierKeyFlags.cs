namespace Rewired;

[Flags]
public enum ModifierKeyFlags
{
	None = 0,
	LeftControl = 1,
	RightControl = 2,
	LeftAlt = 4,
	RightAlt = 8,
	LeftShift = 16,
	RightShift = 32,
	LeftCommand = 64,
	RightCommand = 128,
}

