namespace Rewired;

public sealed class ActionElementMap
{
	private static int uidCounter; //Field offset: 0x0
	private static StringBuilder s_toStringSB; //Field offset: 0x8
	[CustomObfuscation]
	[SerializeField]
	internal int _actionCategoryId; //Field offset: 0x10
	[CustomObfuscation]
	[SerializeField]
	internal int _actionId; //Field offset: 0x14
	[CustomObfuscation]
	[SerializeField]
	internal ControllerElementType _elementType; //Field offset: 0x18
	[CustomObfuscation]
	[SerializeField]
	internal int _elementIdentifierId; //Field offset: 0x1C
	[CustomObfuscation]
	[SerializeField]
	internal AxisRange _axisRange; //Field offset: 0x20
	[CustomObfuscation]
	[SerializeField]
	internal bool _invert; //Field offset: 0x24
	[CustomObfuscation]
	[SerializeField]
	internal Pole _axisContribution; //Field offset: 0x28
	[CustomObfuscation]
	[SerializeField]
	internal KeyboardKeyCode _keyboardKeyCode; //Field offset: 0x2C
	[CustomObfuscation]
	[SerializeField]
	internal ModifierKey _modifierKey1; //Field offset: 0x30
	[CustomObfuscation]
	[SerializeField]
	internal ModifierKey _modifierKey2; //Field offset: 0x34
	[CustomObfuscation]
	[SerializeField]
	internal ModifierKey _modifierKey3; //Field offset: 0x38
	internal ControllerMap tYUpDMeWBZjAgbKDWeqfeUhnBWHab; //Field offset: 0x40
	internal bool dDPTnfkiUGCQQHgOhJldFBaHbwjJc; //Field offset: 0x48
	private string GlxrwuWbKhFfKJYBqXQPNOOCWpQv; //Field offset: 0x50
	internal string PzACKxkheaSFCwizJTQknoyKkrVq; //Field offset: 0x58
	internal int MIMUCUzDduObIOVPNrzGBAOgnNnp; //Field offset: 0x60
	internal readonly int VRGdUnHvlIjMTGkmFTGjpOzpSSDOA; //Field offset: 0x64
	private string spsyTCfjzMukUnwVpUceulfGAmcj; //Field offset: 0x68
	private ModifierKeyFlags qrygjdUqZfdvWzWwfbciZpNbxKTv; //Field offset: 0x70

	public string actionDescriptiveName
	{
		 get { } //Length: 5
	}

	public int actionId
	{
		 get { } //Length: 4
		 set { } //Length: 49
	}

	private bool afChpJQSGzWhZQJhBaoayBkJUPFK
	{
		private get { } //Length: 37
	}

	public Pole axisContribution
	{
		 get { } //Length: 4
		 set { } //Length: 52
	}

	public AxisRange axisRange
	{
		 get { } //Length: 4
		 set { } //Length: 126
	}

	public AxisType axisType
	{
		 get { } //Length: 18
	}

	public ControllerMap controllerMap
	{
		 get { } //Length: 5
	}

	public int elementIdentifierId
	{
		 get { } //Length: 4
		 set { } //Length: 331
	}

	public string elementIdentifierName
	{
		 get { } //Length: 54
	}

	public int elementIndex
	{
		 get { } //Length: 4
	}

	public internal ControllerElementType elementType
	{
		 get { } //Length: 4
		internal set { } //Length: 4
	}

	public bool enabled
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool hasModifiers
	{
		 get { } //Length: 30
	}

	public int id
	{
		 get { } //Length: 4
	}

	public bool invert
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public KeyboardKeyCode keyboardKeyCode
	{
		 get { } //Length: 4
		 set { } //Length: 129
	}

	public KeyCode keyCode
	{
		 get { } //Length: 10
		 set { } //Length: 140
	}

	public ModifierKey modifierKey1
	{
		 get { } //Length: 4
		 set { } //Length: 139
	}

	public ModifierKey modifierKey2
	{
		 get { } //Length: 4
		 set { } //Length: 139
	}

	public ModifierKey modifierKey3
	{
		 get { } //Length: 4
		 set { } //Length: 139
	}

	public ModifierKeyFlags modifierKeyFlags
	{
		 get { } //Length: 72
	}

	private static int QFMswyeDNNSaDovDpVDnrImwBHkP
	{
		private get { } //Length: 75
	}

	public ActionElementMap(ActionElementMap unnamed_param_0) { }

	public ActionElementMap(int unnamed_param_0, ControllerElementType unnamed_param_1, int unnamed_param_2, Pole unnamed_param_3, AxisRange unnamed_param_4, bool unnamed_param_5) { }

	public ActionElementMap(int unnamed_param_0, ControllerElementType unnamed_param_1, Pole unnamed_param_2, KeyboardKeyCode unnamed_param_3, ModifierKey unnamed_param_4, ModifierKey unnamed_param_5, ModifierKey unnamed_param_6) { }

	public ActionElementMap(int unnamed_param_0, ControllerElementType unnamed_param_1, int unnamed_param_2, Pole unnamed_param_3, AxisRange unnamed_param_4) { }

	public ActionElementMap() { }

	public ActionElementMap(int unnamed_param_0, ControllerElementType unnamed_param_1, int unnamed_param_2) { }

	private bool aAWybTNmDnBhudbnogTWktsiXRaRA(KeyboardKeyCode unnamed_param_0, ModifierKeyFlags unnamed_param_1) { }

	internal SerializedObject AqisXDDvDCPKwOpTfFxwWvniiRXz() { }

	private bool AXxlLMGOLLkNTTFBJwaCgmGMKLtx(int unnamed_param_0, AxisRange unnamed_param_1) { }

	internal void bBPMtmGuSfSJmZxBxGjnMufsajeR(SerializedObject unnamed_param_0) { }

	public bool CheckForAssignmentConflict(ActionElementMap elementMap) { }

	public bool CheckForAssignmentConflict(ElementAssignment elementAssignment) { }

	internal void DljxfXPhHTdURSoLTICmagppJygeA(ControllerElementType unnamed_param_0) { }

	private void eVGYmYTzJPqORDcpyZeuEnOmVrSC(ControllerType unnamed_param_0, HardwareControllerMap_Game unnamed_param_1, bool unnamed_param_2) { }

	private void eVGYmYTzJPqORDcpyZeuEnOmVrSC(bool unnamed_param_0) { }

	internal void eVGYmYTzJPqORDcpyZeuEnOmVrSC(ControllerMap unnamed_param_0) { }

	public string get_actionDescriptiveName() { }

	public int get_actionId() { }

	public Pole get_axisContribution() { }

	public AxisRange get_axisRange() { }

	public AxisType get_axisType() { }

	public ControllerMap get_controllerMap() { }

	public int get_elementIdentifierId() { }

	public string get_elementIdentifierName() { }

	public int get_elementIndex() { }

	public ControllerElementType get_elementType() { }

	public bool get_enabled() { }

	public bool get_hasModifiers() { }

	public int get_id() { }

	public bool get_invert() { }

	public KeyboardKeyCode get_keyboardKeyCode() { }

	public KeyCode get_keyCode() { }

	public ModifierKey get_modifierKey1() { }

	public ModifierKey get_modifierKey2() { }

	public ModifierKey get_modifierKey3() { }

	public ModifierKeyFlags get_modifierKeyFlags() { }

	private static int geUaeFRVmbhCkLCNhFLXwRcRgNqs() { }

	private void HHVjBBVBQmrXuiJTsjbkPFmfPVxV() { }

	public bool IsTarget(IControllerElementTarget elementTarget) { }

	public bool IsTarget(ControllerElementTarget elementTarget) { }

	internal void KkGkppCNvzdCEwxhITKcgVZosrXj(ControllerMap unnamed_param_0, HardwareControllerMap_Game unnamed_param_1) { }

	private bool KpfyyhxRlbaBfUAkLrQwNpqYhwgG() { }

	private string KrQqYVkNxKMmdEFGRfvvEyDzwaUv() { }

	private void LrACBRFiFYZFktFTnEJcRYngpInk() { }

	public void set_actionId(int value) { }

	public void set_axisContribution(Pole value) { }

	public void set_axisRange(AxisRange value) { }

	public void set_elementIdentifierId(int value) { }

	public void set_enabled(bool value) { }

	public void set_invert(bool value) { }

	public void set_keyboardKeyCode(KeyboardKeyCode value) { }

	public void set_keyCode(KeyCode value) { }

	public void set_modifierKey1(ModifierKey value) { }

	public void set_modifierKey2(ModifierKey value) { }

	public void set_modifierKey3(ModifierKey value) { }

	public bool ShowInField(AxisRange fieldActionRange) { }

	internal void TIWlPgfaGufdFBhysiChIRXnJxnP() { }

	public virtual string ToString() { }

	private void uLnvJEEBCraHkIMejqSfvCrvoyh() { }

	internal static void UvGcWThpZhrcZBXEbjILmjHwXDtIA(ActionElementMap unnamed_param_0, ActionElementMap unnamed_param_1) { }

	private void VvHTQCvzvTlCXgCngmoXmRrVPWXU() { }

	private bool WjKfGHNYUbazpUvmYLaJwFyfNmCB(ElementAssignmentType unnamed_param_0) { }

	internal static bool XiBqQjhlXaglmNqrfBOMZDxCCAXEA(ActionElementMap unnamed_param_0) { }

}

