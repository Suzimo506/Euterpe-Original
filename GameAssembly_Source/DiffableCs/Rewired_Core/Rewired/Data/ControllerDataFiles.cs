namespace Rewired.Data;

public sealed class ControllerDataFiles : ScriptableObject
{
	[CustomObfuscation]
	[SerializeField]
	private HardwareJoystickMap defaultHardwareJoystickMap; //Field offset: 0x18
	[CustomObfuscation]
	[SerializeField]
	private HardwareJoystickMap[] hardwareJoystickMaps; //Field offset: 0x20
	[CustomObfuscation]
	[SerializeField]
	private HardwareJoystickTemplateMap[] joystickTemplates; //Field offset: 0x28
	private bool lPESTxgFnNSKIziADAuEEBSbszbsA; //Field offset: 0x30

	public HardwareJoystickMap DefaultHardwareJoystickMap
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public Guid defaultHardwareJoystickMapGuid
	{
		 get { } //Length: 200
	}

	public HardwareJoystickMap[] HardwareJoystickMaps
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public HardwareJoystickTemplateMap[] JoystickTemplates
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public ControllerDataFiles() { }

	private HardwareJoystickMap_InputManager AuFguKEYHutxheezRzbDViqdpxQC(BridgedControllerHWInfo unnamed_param_0, string unnamed_param_1) { }

	public HardwareJoystickMap get_DefaultHardwareJoystickMap() { }

	public Guid get_defaultHardwareJoystickMapGuid() { }

	public HardwareJoystickMap[] get_HardwareJoystickMaps() { }

	public HardwareJoystickTemplateMap[] get_JoystickTemplates() { }

	public IHardwareControllerTemplateMap GetControllerTemplate(Guid guid) { }

	public String[] GetEditorJoystickNames() { }

	public HardwareJoystickMap GetHardwareJoystickMap(Guid guid) { }

	public IHardwareControllerMap GetHardwareJoystickOrTemplateMap(Guid guid) { }

	public Guid[] GetJoystickGuids() { }

	public String[] GetJoystickNames() { }

	public HardwareJoystickTemplateMap GetJoystickTemplate(Guid guid) { }

	public Guid[] GetJoystickTemplateGuids() { }

	public String[] GetJoystickTemplateNames() { }

	internal HardwareJoystickMap_InputManager jzoMNudLKnEMHhYPEfVldlAGByvvA(Guid unnamed_param_0, InputSource unnamed_param_1) { }

	private HardwareJoystickMap_InputManager nIzcsqarUooHEpVhsKxshEDeJdtjb(HardwareJoystickMap unnamed_param_0, BridgedControllerHWInfo unnamed_param_1, bool unnamed_param_2, out InputPlatform unnamed_param_3, out int unnamed_param_4, out Platform unnamed_param_5) { }

	internal HardwareJoystickMap_InputManager PPxJoRenfbVxpqcMIeqiYHyKpnMT(BridgedControllerHWInfo unnamed_param_0) { }

	public void set_DefaultHardwareJoystickMap(HardwareJoystickMap value) { }

	public void set_HardwareJoystickMaps(HardwareJoystickMap[] value) { }

	public void set_JoystickTemplates(HardwareJoystickTemplateMap[] value) { }

	private HardwareJoystickMap_InputManager sVoGTmRmVlIaxqBQYdOvbZHvhfvmA(BridgedControllerHWInfo unnamed_param_0) { }

	private void wUEnjBVCdJsBFCHbVuKaZaGCpLKG() { }

	internal ControllerTemplateElementIdentifier XnLtXDJsuKvIrjExbcRMncPfBggd(Guid unnamed_param_0, int unnamed_param_1) { }

}

