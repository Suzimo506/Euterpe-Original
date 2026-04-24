namespace Rewired.UI.ControlMapper;

public abstract class LanguageDataBase : ScriptableObject
{

	public abstract string actionColumnLabel
	{
		 get { } //Length: 0
	}

	public abstract string add
	{
		 get { } //Length: 0
	}

	public abstract string assignControllerButtonLabel
	{
		 get { } //Length: 0
	}

	public abstract string assignControllerWindowMessage
	{
		 get { } //Length: 0
	}

	public abstract string assignControllerWindowTitle
	{
		 get { } //Length: 0
	}

	public abstract string assignedControllersGroupLabel
	{
		 get { } //Length: 0
	}

	public abstract string calibrateAxisStep1WindowTitle
	{
		 get { } //Length: 0
	}

	public abstract string calibrateAxisStep2WindowTitle
	{
		 get { } //Length: 0
	}

	public abstract string calibrateControllerButtonLabel
	{
		 get { } //Length: 0
	}

	public abstract string calibrateControllerWindowTitle
	{
		 get { } //Length: 0
	}

	public abstract string calibrateWindow_calibrateButtonLabel
	{
		 get { } //Length: 0
	}

	public abstract string calibrateWindow_deadZoneSliderLabel
	{
		 get { } //Length: 0
	}

	public abstract string calibrateWindow_invertToggleLabel
	{
		 get { } //Length: 0
	}

	public abstract string calibrateWindow_sensitivitySliderLabel
	{
		 get { } //Length: 0
	}

	public abstract string calibrateWindow_zeroSliderLabel
	{
		 get { } //Length: 0
	}

	public abstract string cancel
	{
		 get { } //Length: 0
	}

	public abstract string controllerAssignmentConflictWindowTitle
	{
		 get { } //Length: 0
	}

	public abstract string controllerColumnLabel
	{
		 get { } //Length: 0
	}

	public abstract string controllerSettingsGroupLabel
	{
		 get { } //Length: 0
	}

	public abstract string default_
	{
		 get { } //Length: 0
	}

	public abstract string done
	{
		 get { } //Length: 0
	}

	public abstract string doneButtonLabel
	{
		 get { } //Length: 0
	}

	public abstract string elementAssignmentConflictWindowMessage
	{
		 get { } //Length: 0
	}

	public abstract string elementAssignmentPrePollingWindowMessage
	{
		 get { } //Length: 0
	}

	public abstract string inputBehaviorSettingsButtonLabel
	{
		 get { } //Length: 0
	}

	public abstract string inputBehaviorSettingsWindowTitle
	{
		 get { } //Length: 0
	}

	public abstract string keyboardColumnLabel
	{
		 get { } //Length: 0
	}

	public abstract string mapCategoriesGroupLabel
	{
		 get { } //Length: 0
	}

	public abstract string mouseAssignmentConflictWindowTitle
	{
		 get { } //Length: 0
	}

	public abstract string mouseColumnLabel
	{
		 get { } //Length: 0
	}

	public abstract string no
	{
		 get { } //Length: 0
	}

	public abstract string none
	{
		 get { } //Length: 0
	}

	public abstract string okay
	{
		 get { } //Length: 0
	}

	public abstract string playersGroupLabel
	{
		 get { } //Length: 0
	}

	public abstract string remove
	{
		 get { } //Length: 0
	}

	public abstract string removeControllerButtonLabel
	{
		 get { } //Length: 0
	}

	public abstract string replace
	{
		 get { } //Length: 0
	}

	public abstract string restoreDefaultsButtonLabel
	{
		 get { } //Length: 0
	}

	public abstract string restoreDefaultsWindowMessage
	{
		 get { } //Length: 0
	}

	public abstract string restoreDefaultsWindowTitle
	{
		 get { } //Length: 0
	}

	public abstract string settingsGroupLabel
	{
		 get { } //Length: 0
	}

	public abstract string swap
	{
		 get { } //Length: 0
	}

	public abstract string yes
	{
		 get { } //Length: 0
	}

	protected LanguageDataBase() { }

	public abstract bool ContainsCustomEntryKey(string key) { }

	public abstract string get_actionColumnLabel() { }

	public abstract string get_add() { }

	public abstract string get_assignControllerButtonLabel() { }

	public abstract string get_assignControllerWindowMessage() { }

	public abstract string get_assignControllerWindowTitle() { }

	public abstract string get_assignedControllersGroupLabel() { }

	public abstract string get_calibrateAxisStep1WindowTitle() { }

	public abstract string get_calibrateAxisStep2WindowTitle() { }

	public abstract string get_calibrateControllerButtonLabel() { }

	public abstract string get_calibrateControllerWindowTitle() { }

	public abstract string get_calibrateWindow_calibrateButtonLabel() { }

	public abstract string get_calibrateWindow_deadZoneSliderLabel() { }

	public abstract string get_calibrateWindow_invertToggleLabel() { }

	public abstract string get_calibrateWindow_sensitivitySliderLabel() { }

	public abstract string get_calibrateWindow_zeroSliderLabel() { }

	public abstract string get_cancel() { }

	public abstract string get_controllerAssignmentConflictWindowTitle() { }

	public abstract string get_controllerColumnLabel() { }

	public abstract string get_controllerSettingsGroupLabel() { }

	public abstract string get_default_() { }

	public abstract string get_done() { }

	public abstract string get_doneButtonLabel() { }

	public abstract string get_elementAssignmentConflictWindowMessage() { }

	public abstract string get_elementAssignmentPrePollingWindowMessage() { }

	public abstract string get_inputBehaviorSettingsButtonLabel() { }

	public abstract string get_inputBehaviorSettingsWindowTitle() { }

	public abstract string get_keyboardColumnLabel() { }

	public abstract string get_mapCategoriesGroupLabel() { }

	public abstract string get_mouseAssignmentConflictWindowTitle() { }

	public abstract string get_mouseColumnLabel() { }

	public abstract string get_no() { }

	public abstract string get_none() { }

	public abstract string get_okay() { }

	public abstract string get_playersGroupLabel() { }

	public abstract string get_remove() { }

	public abstract string get_removeControllerButtonLabel() { }

	public abstract string get_replace() { }

	public abstract string get_restoreDefaultsButtonLabel() { }

	public abstract string get_restoreDefaultsWindowMessage() { }

	public abstract string get_restoreDefaultsWindowTitle() { }

	public abstract string get_settingsGroupLabel() { }

	public abstract string get_swap() { }

	public abstract string get_yes() { }

	public abstract string GetActionCategoryName(int id) { }

	public abstract string GetActionName(int actionId, AxisRange axisRange) { }

	public abstract string GetActionName(int actionId) { }

	public abstract string GetCalibrateAxisStep1WindowMessage(string axisName) { }

	public abstract string GetCalibrateAxisStep2WindowMessage(string axisName) { }

	public abstract string GetControllerAssignmentConflictWindowMessage(string joystickName, string otherPlayerName, string currentPlayerName) { }

	public abstract string GetControllerName(Controller controller) { }

	public abstract string GetCustomEntry(string key) { }

	public abstract string GetElementAlreadyInUseBlocked(string elementName) { }

	public abstract string GetElementAlreadyInUseCanReplace(string elementName, bool allowConflicts) { }

	public abstract string GetElementIdentifierName(KeyCode keyCode, ModifierKeyFlags modifierKeyFlags) { }

	public abstract string GetElementIdentifierName(ActionElementMap actionElementMap) { }

	public abstract string GetElementIdentifierName(Controller controller, int elementIdentifierId, AxisRange axisRange) { }

	public abstract string GetJoystickElementAssignmentPollingWindowMessage(string actionName) { }

	public abstract string GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName) { }

	public abstract string GetKeyboardElementAssignmentPollingWindowMessage(string actionName) { }

	public abstract string GetLayoutName(ControllerType controllerType, int id) { }

	public abstract string GetMapCategoryName(int id) { }

	public abstract string GetMouseAssignmentConflictWindowMessage(string otherPlayerName, string thisPlayerName) { }

	public abstract string GetMouseElementAssignmentPollingWindowMessage(string actionName) { }

	public abstract string GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName) { }

	public abstract string GetPlayerName(int playerId) { }

	public abstract void Initialize() { }

	public abstract string ModifierKeyFlagsToString(ModifierKeyFlags flags) { }

}

