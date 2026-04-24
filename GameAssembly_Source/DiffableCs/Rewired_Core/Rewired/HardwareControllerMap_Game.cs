namespace Rewired;

[CustomClassObfuscation]
[CustomObfuscation]
internal class HardwareControllerMap_Game
{
	public readonly string controllerName; //Field offset: 0x10
	public readonly HardwareControllerMapIdentifier hardwareMapIdentifier; //Field offset: 0x18
	public readonly int customControllerSourceId; //Field offset: 0x34
	public readonly ADictionary<Int32, ControllerElementIdentifier> elementIdentifiers; //Field offset: 0x38
	public readonly ControllerElementIdentifier[] elementIdentifiers_cache; //Field offset: 0x40
	public readonly ControllerElementIdentifier[] buttonElementIdentifiers_cache; //Field offset: 0x48
	public readonly ControllerElementIdentifier[] axisElementIdentifiers_cache; //Field offset: 0x50
	public readonly ControllerElementIdentifier[] axis2DElementIdentifiers_cache; //Field offset: 0x58
	public readonly ControllerElementIdentifier[] hatElementIdentifiers_cache; //Field offset: 0x60
	public readonly IList<ControllerElementIdentifier> elementIdentifiers_readOnly; //Field offset: 0x68
	public readonly IList<ControllerElementIdentifier> buttonElementIdentifiers_readOnly; //Field offset: 0x70
	public readonly IList<ControllerElementIdentifier> axisElementIdentifiers_readOnly; //Field offset: 0x78
	public readonly IList<ControllerElementIdentifier> axis2DElementIdentifiers_readOnly; //Field offset: 0x80
	public readonly IList<ControllerElementIdentifier> hatElementIdentifiers_readOnly; //Field offset: 0x88
	public readonly Int32[] buttonElementIdentifierIds; //Field offset: 0x90
	public readonly Int32[] axisElementIdentifierIds; //Field offset: 0x98
	public readonly Int32[] axis2DElementIdentifierIds; //Field offset: 0xA0
	public readonly Int32[] hatElementIdentifierIds; //Field offset: 0xA8
	public readonly int elementIdentifierCount; //Field offset: 0xB0
	public readonly int axisCount; //Field offset: 0xB4
	public readonly int buttonCount; //Field offset: 0xB8
	public readonly int compoundElementCount; //Field offset: 0xBC
	public readonly int axis2DCount; //Field offset: 0xC0
	public readonly int hatCount; //Field offset: 0xC4
	public readonly JoystickType[] joystickTypes; //Field offset: 0xC8
	public readonly AxisCalibrationData[] hwAxisCalibrationData; //Field offset: 0xD0
	public readonly AxisRange[] hwAxisRanges; //Field offset: 0xD8
	public readonly HardwareAxisInfo[] hwAxisInfo; //Field offset: 0xE0
	public readonly HardwareButtonInfo[] hwButtonInfo; //Field offset: 0xE8
	public readonly CompoundElement[] compoundElements; //Field offset: 0xF0

	private HardwareControllerMap_Game(string unnamed_param_0) { }

	public HardwareControllerMap_Game(string unnamed_param_0, int unnamed_param_1, ControllerElementIdentifier[] unnamed_param_2, Int32[] unnamed_param_3, Int32[] unnamed_param_4, AxisCalibrationData[] unnamed_param_5, AxisRange[] unnamed_param_6, HardwareAxisInfo[] unnamed_param_7, HardwareButtonInfo[] unnamed_param_8, CompoundElement[] unnamed_param_9) { }

	public HardwareControllerMap_Game(string unnamed_param_0, HardwareControllerMapIdentifier unnamed_param_1, JoystickType[] unnamed_param_2, ControllerElementIdentifier[] unnamed_param_3, Int32[] unnamed_param_4, Int32[] unnamed_param_5, AxisCalibrationData[] unnamed_param_6, AxisRange[] unnamed_param_7, HardwareAxisInfo[] unnamed_param_8, HardwareButtonInfo[] unnamed_param_9, CompoundElement[] unnamed_param_10) { }

	public HardwareControllerMap_Game(string unnamed_param_0, HardwareControllerMapIdentifier unnamed_param_1, ControllerElementIdentifier[] unnamed_param_2, Int32[] unnamed_param_3, Int32[] unnamed_param_4, AxisCalibrationData[] unnamed_param_5, AxisRange[] unnamed_param_6, HardwareAxisInfo[] unnamed_param_7, HardwareButtonInfo[] unnamed_param_8, CompoundElement[] unnamed_param_9) { }

	private HardwareControllerMap_Game(string unnamed_param_0, ControllerElementIdentifier[] unnamed_param_1, Int32[] unnamed_param_2, Int32[] unnamed_param_3, AxisCalibrationData[] unnamed_param_4, AxisRange[] unnamed_param_5, HardwareAxisInfo[] unnamed_param_6, HardwareButtonInfo[] unnamed_param_7, CompoundElement[] unnamed_param_8) { }

	public CompoundElement GetAxis2DData(int index) { }

	public ControllerElementIdentifier GetAxisElementIdentifierById(int id) { }

	public int GetAxisIndex(int elementIdentifierId) { }

	public int GetAxisIndex(string elementIdentifierName) { }

	public ControllerElementIdentifier GetButtonElementIdentifierById(int id) { }

	public int GetButtonIndex(int elementIdentifierId) { }

	public int GetButtonIndex(string elementIdentifierName) { }

	public ControllerElementIdentifier GetElementIdentifierById(int id) { }

	public string GetElementIdentifierName(int elementIdentifierId) { }

	public string GetElementIdentifierNegativeName(int elementIdentifierId) { }

	public string GetElementIdentifierPositiveName(int elementIdentifierId) { }

	public ControllerElementType GetElementType(int elementIdentifierId) { }

	public CompoundElement GetHatData(int index) { }

	private int nMCNxXBFTmUhUdpjgBCukHDnJervA(ControllerElementIdentifier[] unnamed_param_0, int unnamed_param_1) { }

}

