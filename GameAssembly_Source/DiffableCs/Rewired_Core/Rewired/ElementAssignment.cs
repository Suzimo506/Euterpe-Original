namespace Rewired;

public struct ElementAssignment
{
	public ElementAssignmentType type; //Field offset: 0x0
	public int elementMapId; //Field offset: 0x4
	public int elementIdentifierId; //Field offset: 0x8
	public AxisRange axisRange; //Field offset: 0xC
	public KeyCode keyboardKey; //Field offset: 0x10
	public ModifierKeyFlags modifierKeyFlags; //Field offset: 0x14
	public int actionId; //Field offset: 0x18
	public Pole axisContribution; //Field offset: 0x1C
	public bool invert; //Field offset: 0x20

	public ElementAssignment(ElementAssignmentType unnamed_param_0, int unnamed_param_1, AxisRange unnamed_param_2, KeyCode unnamed_param_3, ModifierKeyFlags unnamed_param_4, int unnamed_param_5, Pole unnamed_param_6, bool unnamed_param_7, int unnamed_param_8) { }

	public ElementAssignment(ControllerType unnamed_param_0, ControllerElementType unnamed_param_1, int unnamed_param_2, AxisRange unnamed_param_3, KeyCode unnamed_param_4, ModifierKeyFlags unnamed_param_5, int unnamed_param_6, Pole unnamed_param_7, bool unnamed_param_8, int unnamed_param_9) { }

	public ElementAssignment(ElementAssignmentType unnamed_param_0, int unnamed_param_1, AxisRange unnamed_param_2, KeyCode unnamed_param_3, ModifierKeyFlags unnamed_param_4, int unnamed_param_5, Pole unnamed_param_6, bool unnamed_param_7) { }

	public ElementAssignment(ControllerType unnamed_param_0, ControllerElementType unnamed_param_1, int unnamed_param_2, AxisRange unnamed_param_3, KeyCode unnamed_param_4, ModifierKeyFlags unnamed_param_5, int unnamed_param_6, Pole unnamed_param_7, bool unnamed_param_8) { }

	public ElementAssignment(int unnamed_param_0, int unnamed_param_1, bool unnamed_param_2) { }

	public ElementAssignment(int unnamed_param_0, int unnamed_param_1, bool unnamed_param_2, int unnamed_param_3) { }

	public ElementAssignment(int unnamed_param_0, AxisRange unnamed_param_1, int unnamed_param_2, Pole unnamed_param_3) { }

	public ElementAssignment(int unnamed_param_0, AxisRange unnamed_param_1, int unnamed_param_2, Pole unnamed_param_3, int unnamed_param_4) { }

	public ElementAssignment(int unnamed_param_0, int unnamed_param_1, Pole unnamed_param_2) { }

	public ElementAssignment(int unnamed_param_0, int unnamed_param_1, Pole unnamed_param_2, int unnamed_param_3) { }

	public ElementAssignment(KeyCode unnamed_param_0, ModifierKeyFlags unnamed_param_1, int unnamed_param_2, Pole unnamed_param_3) { }

	public ElementAssignment(KeyCode unnamed_param_0, ModifierKeyFlags unnamed_param_1, int unnamed_param_2, Pole unnamed_param_3, int unnamed_param_4) { }

	public static ElementAssignment ButtonAssignment(int elementIdentifierId, int actionId, Pole axisContribution, int elementMapId) { }

	public static ElementAssignment ButtonAssignment(int elementIdentifierId, int actionId, Pole axisContribution) { }

	public static ElementAssignment CompleteAssignment(ControllerType controllerType, ControllerElementType elementType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert) { }

	public static ElementAssignment CompleteAssignment(ElementAssignmentType elementAssignmentType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert, int elementMapId) { }

	public static ElementAssignment CompleteAssignment(ControllerType controllerType, ControllerElementType elementType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert, int elementMapId) { }

	public static ElementAssignment CompleteAssignment(ElementAssignmentType elementAssignmentType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert) { }

	public static ElementAssignment FullAxisAssignment(int elementIdentifierId, int actionId, bool invert) { }

	public static ElementAssignment FullAxisAssignment(int elementIdentifierId, int actionId, bool invert, int elementMapId) { }

	public static ElementAssignment KeyboardKeyAssignment(KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, int elementMapId) { }

	public static ElementAssignment KeyboardKeyAssignment(KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution) { }

	public static ElementAssignment SplitAxisAssignment(int elementIdentifierId, AxisRange axisRange, int actionId, Pole axisContribution) { }

	public static ElementAssignment SplitAxisAssignment(int elementIdentifierId, AxisRange axisRange, int actionId, Pole axisContribution, int elementMapId) { }

	public ElementAssignmentConflictCheck ToElementAssignmentConflictCheck() { }

}

