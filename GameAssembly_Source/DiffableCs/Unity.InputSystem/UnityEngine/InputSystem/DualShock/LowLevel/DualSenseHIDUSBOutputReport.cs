namespace UnityEngine.InputSystem.DualShock.LowLevel;

internal struct DualSenseHIDUSBOutputReport : IInputDeviceCommandInfo
{
	internal const int kSize = 56; //Field offset: 0x0
	public InputDeviceCommand baseCommand; //Field offset: 0x0
	public byte reportId; //Field offset: 0x8
	public DualSenseHIDOutputReportPayload payload; //Field offset: 0x9

	public static FourCC Type
	{
		 get { } //Length: 53
	}

	public override FourCC typeStatic
	{
		 get { } //Length: 53
	}

	public static DualSenseHIDUSBOutputReport Create(DualSenseHIDOutputReportPayload payload) { }

	public static FourCC get_Type() { }

	public override FourCC get_typeStatic() { }

}

