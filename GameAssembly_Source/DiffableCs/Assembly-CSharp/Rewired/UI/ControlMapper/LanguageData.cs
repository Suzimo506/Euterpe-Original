namespace Rewired.UI.ControlMapper;

public class LanguageData : LanguageDataBase
{
	internal class CustomEntry
	{
		public string key; //Field offset: 0x10
		public string value; //Field offset: 0x18

		public CustomEntry() { }

		public CustomEntry(string key, string value) { }

		public static Dictionary<String, String> ToDictionary(CustomEntry[] array) { }

	}

	internal class ModifierKeys
	{
		public string control; //Field offset: 0x10
		public string alt; //Field offset: 0x18
		public string shift; //Field offset: 0x20
		public string command; //Field offset: 0x28
		public string separator; //Field offset: 0x30

		public ModifierKeys() { }

	}

	[SerializeField]
	private string _yes; //Field offset: 0x18
	[SerializeField]
	private string _no; //Field offset: 0x20
	[SerializeField]
	private string _add; //Field offset: 0x28
	[SerializeField]
	private string _replace; //Field offset: 0x30
	[SerializeField]
	private string _remove; //Field offset: 0x38
	[SerializeField]
	private string _swap; //Field offset: 0x40
	[SerializeField]
	private string _cancel; //Field offset: 0x48
	[SerializeField]
	private string _none; //Field offset: 0x50
	[SerializeField]
	private string _okay; //Field offset: 0x58
	[SerializeField]
	private string _done; //Field offset: 0x60
	[SerializeField]
	private string _default; //Field offset: 0x68
	[SerializeField]
	private string _assignControllerWindowTitle; //Field offset: 0x70
	[SerializeField]
	private string _assignControllerWindowMessage; //Field offset: 0x78
	[SerializeField]
	private string _controllerAssignmentConflictWindowTitle; //Field offset: 0x80
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string _controllerAssignmentConflictWindowMessage; //Field offset: 0x88
	[SerializeField]
	private string _elementAssignmentPrePollingWindowMessage; //Field offset: 0x90
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string _joystickElementAssignmentPollingWindowMessage; //Field offset: 0x98
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string _joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly; //Field offset: 0xA0
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string _keyboardElementAssignmentPollingWindowMessage; //Field offset: 0xA8
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string _mouseElementAssignmentPollingWindowMessage; //Field offset: 0xB0
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string _mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly; //Field offset: 0xB8
	[SerializeField]
	private string _elementAssignmentConflictWindowMessage; //Field offset: 0xC0
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string _elementAlreadyInUseBlocked; //Field offset: 0xC8
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string _elementAlreadyInUseCanReplace; //Field offset: 0xD0
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string _elementAlreadyInUseCanReplace_conflictAllowed; //Field offset: 0xD8
	[SerializeField]
	private string _mouseAssignmentConflictWindowTitle; //Field offset: 0xE0
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string _mouseAssignmentConflictWindowMessage; //Field offset: 0xE8
	[SerializeField]
	private string _calibrateControllerWindowTitle; //Field offset: 0xF0
	[SerializeField]
	private string _calibrateAxisStep1WindowTitle; //Field offset: 0xF8
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string _calibrateAxisStep1WindowMessage; //Field offset: 0x100
	[SerializeField]
	private string _calibrateAxisStep2WindowTitle; //Field offset: 0x108
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string _calibrateAxisStep2WindowMessage; //Field offset: 0x110
	[SerializeField]
	private string _inputBehaviorSettingsWindowTitle; //Field offset: 0x118
	[SerializeField]
	private string _restoreDefaultsWindowTitle; //Field offset: 0x120
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string _restoreDefaultsWindowMessage_onePlayer; //Field offset: 0x128
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string _restoreDefaultsWindowMessage_multiPlayer; //Field offset: 0x130
	[SerializeField]
	private string _actionColumnLabel; //Field offset: 0x138
	[SerializeField]
	private string _keyboardColumnLabel; //Field offset: 0x140
	[SerializeField]
	private string _mouseColumnLabel; //Field offset: 0x148
	[SerializeField]
	private string _controllerColumnLabel; //Field offset: 0x150
	[SerializeField]
	private string _removeControllerButtonLabel; //Field offset: 0x158
	[SerializeField]
	private string _calibrateControllerButtonLabel; //Field offset: 0x160
	[SerializeField]
	private string _assignControllerButtonLabel; //Field offset: 0x168
	[SerializeField]
	private string _inputBehaviorSettingsButtonLabel; //Field offset: 0x170
	[SerializeField]
	private string _doneButtonLabel; //Field offset: 0x178
	[SerializeField]
	private string _restoreDefaultsButtonLabel; //Field offset: 0x180
	[SerializeField]
	private string _playersGroupLabel; //Field offset: 0x188
	[SerializeField]
	private string _controllerSettingsGroupLabel; //Field offset: 0x190
	[SerializeField]
	private string _assignedControllersGroupLabel; //Field offset: 0x198
	[SerializeField]
	private string _settingsGroupLabel; //Field offset: 0x1A0
	[SerializeField]
	private string _mapCategoriesGroupLabel; //Field offset: 0x1A8
	[SerializeField]
	private string _calibrateWindow_deadZoneSliderLabel; //Field offset: 0x1B0
	[SerializeField]
	private string _calibrateWindow_zeroSliderLabel; //Field offset: 0x1B8
	[SerializeField]
	private string _calibrateWindow_sensitivitySliderLabel; //Field offset: 0x1C0
	[SerializeField]
	private string _calibrateWindow_invertToggleLabel; //Field offset: 0x1C8
	[SerializeField]
	private string _calibrateWindow_calibrateButtonLabel; //Field offset: 0x1D0
	[SerializeField]
	private ModifierKeys _modifierKeys; //Field offset: 0x1D8
	[SerializeField]
	private CustomEntry[] _customEntries; //Field offset: 0x1E0
	private bool _initialized; //Field offset: 0x1E8
	private Dictionary<String, String> customDict; //Field offset: 0x1F0

	public virtual string actionColumnLabel
	{
		 get { } //Length: 8
	}

	public virtual string add
	{
		 get { } //Length: 5
	}

	public virtual string assignControllerButtonLabel
	{
		 get { } //Length: 8
	}

	public virtual string assignControllerWindowMessage
	{
		 get { } //Length: 5
	}

	public virtual string assignControllerWindowTitle
	{
		 get { } //Length: 5
	}

	public virtual string assignedControllersGroupLabel
	{
		 get { } //Length: 8
	}

	public virtual string calibrateAxisStep1WindowTitle
	{
		 get { } //Length: 8
	}

	public virtual string calibrateAxisStep2WindowTitle
	{
		 get { } //Length: 8
	}

	public virtual string calibrateControllerButtonLabel
	{
		 get { } //Length: 8
	}

	public virtual string calibrateControllerWindowTitle
	{
		 get { } //Length: 8
	}

	public virtual string calibrateWindow_calibrateButtonLabel
	{
		 get { } //Length: 8
	}

	public virtual string calibrateWindow_deadZoneSliderLabel
	{
		 get { } //Length: 8
	}

	public virtual string calibrateWindow_invertToggleLabel
	{
		 get { } //Length: 8
	}

	public virtual string calibrateWindow_sensitivitySliderLabel
	{
		 get { } //Length: 8
	}

	public virtual string calibrateWindow_zeroSliderLabel
	{
		 get { } //Length: 8
	}

	public virtual string cancel
	{
		 get { } //Length: 5
	}

	public virtual string controllerAssignmentConflictWindowTitle
	{
		 get { } //Length: 8
	}

	public virtual string controllerColumnLabel
	{
		 get { } //Length: 8
	}

	public virtual string controllerSettingsGroupLabel
	{
		 get { } //Length: 8
	}

	public virtual string default_
	{
		 get { } //Length: 5
	}

	public virtual string done
	{
		 get { } //Length: 5
	}

	public virtual string doneButtonLabel
	{
		 get { } //Length: 8
	}

	public virtual string elementAssignmentConflictWindowMessage
	{
		 get { } //Length: 8
	}

	public virtual string elementAssignmentPrePollingWindowMessage
	{
		 get { } //Length: 8
	}

	public virtual string inputBehaviorSettingsButtonLabel
	{
		 get { } //Length: 8
	}

	public virtual string inputBehaviorSettingsWindowTitle
	{
		 get { } //Length: 8
	}

	public virtual string keyboardColumnLabel
	{
		 get { } //Length: 8
	}

	public virtual string mapCategoriesGroupLabel
	{
		 get { } //Length: 8
	}

	public virtual string mouseAssignmentConflictWindowTitle
	{
		 get { } //Length: 8
	}

	public virtual string mouseColumnLabel
	{
		 get { } //Length: 8
	}

	public virtual string no
	{
		 get { } //Length: 5
	}

	public virtual string none
	{
		 get { } //Length: 5
	}

	public virtual string okay
	{
		 get { } //Length: 5
	}

	public virtual string playersGroupLabel
	{
		 get { } //Length: 8
	}

	public virtual string remove
	{
		 get { } //Length: 5
	}

	public virtual string removeControllerButtonLabel
	{
		 get { } //Length: 8
	}

	public virtual string replace
	{
		 get { } //Length: 5
	}

	public virtual string restoreDefaultsButtonLabel
	{
		 get { } //Length: 8
	}

	public virtual string restoreDefaultsWindowMessage
	{
		 get { } //Length: 124
	}

	public virtual string restoreDefaultsWindowTitle
	{
		 get { } //Length: 8
	}

	public virtual string settingsGroupLabel
	{
		 get { } //Length: 8
	}

	public virtual string swap
	{
		 get { } //Length: 5
	}

	public virtual string yes
	{
		 get { } //Length: 5
	}

	public LanguageData() { }

	public virtual bool ContainsCustomEntryKey(string key) { }

	public virtual string get_actionColumnLabel() { }

	public virtual string get_add() { }

	public virtual string get_assignControllerButtonLabel() { }

	public virtual string get_assignControllerWindowMessage() { }

	public virtual string get_assignControllerWindowTitle() { }

	public virtual string get_assignedControllersGroupLabel() { }

	public virtual string get_calibrateAxisStep1WindowTitle() { }

	public virtual string get_calibrateAxisStep2WindowTitle() { }

	public virtual string get_calibrateControllerButtonLabel() { }

	public virtual string get_calibrateControllerWindowTitle() { }

	public virtual string get_calibrateWindow_calibrateButtonLabel() { }

	public virtual string get_calibrateWindow_deadZoneSliderLabel() { }

	public virtual string get_calibrateWindow_invertToggleLabel() { }

	public virtual string get_calibrateWindow_sensitivitySliderLabel() { }

	public virtual string get_calibrateWindow_zeroSliderLabel() { }

	public virtual string get_cancel() { }

	public virtual string get_controllerAssignmentConflictWindowTitle() { }

	public virtual string get_controllerColumnLabel() { }

	public virtual string get_controllerSettingsGroupLabel() { }

	public virtual string get_default_() { }

	public virtual string get_done() { }

	public virtual string get_doneButtonLabel() { }

	public virtual string get_elementAssignmentConflictWindowMessage() { }

	public virtual string get_elementAssignmentPrePollingWindowMessage() { }

	public virtual string get_inputBehaviorSettingsButtonLabel() { }

	public virtual string get_inputBehaviorSettingsWindowTitle() { }

	public virtual string get_keyboardColumnLabel() { }

	public virtual string get_mapCategoriesGroupLabel() { }

	public virtual string get_mouseAssignmentConflictWindowTitle() { }

	public virtual string get_mouseColumnLabel() { }

	public virtual string get_no() { }

	public virtual string get_none() { }

	public virtual string get_okay() { }

	public virtual string get_playersGroupLabel() { }

	public virtual string get_remove() { }

	public virtual string get_removeControllerButtonLabel() { }

	public virtual string get_replace() { }

	public virtual string get_restoreDefaultsButtonLabel() { }

	public virtual string get_restoreDefaultsWindowMessage() { }

	public virtual string get_restoreDefaultsWindowTitle() { }

	public virtual string get_settingsGroupLabel() { }

	public virtual string get_swap() { }

	public virtual string get_yes() { }

	public virtual string GetActionCategoryName(int id) { }

	public virtual string GetActionName(int actionId, AxisRange axisRange) { }

	public virtual string GetActionName(int actionId) { }

	public virtual string GetCalibrateAxisStep1WindowMessage(string axisName) { }

	public virtual string GetCalibrateAxisStep2WindowMessage(string axisName) { }

	public virtual string GetControllerAssignmentConflictWindowMessage(string joystickName, string otherPlayerName, string currentPlayerName) { }

	public virtual string GetControllerName(Controller controller) { }

	public virtual string GetCustomEntry(string key) { }

	public virtual string GetElementAlreadyInUseBlocked(string elementName) { }

	public virtual string GetElementAlreadyInUseCanReplace(string elementName, bool allowConflicts) { }

	public virtual string GetElementIdentifierName(KeyCode keyCode, ModifierKeyFlags modifierKeyFlags) { }

	public virtual string GetElementIdentifierName(ActionElementMap actionElementMap) { }

	public virtual string GetElementIdentifierName(Controller controller, int elementIdentifierId, AxisRange axisRange) { }

	public virtual string GetJoystickElementAssignmentPollingWindowMessage(string actionName) { }

	public virtual string GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName) { }

	public virtual string GetKeyboardElementAssignmentPollingWindowMessage(string actionName) { }

	public virtual string GetLayoutName(ControllerType controllerType, int id) { }

	public virtual string GetMapCategoryName(int id) { }

	public virtual string GetMouseAssignmentConflictWindowMessage(string otherPlayerName, string thisPlayerName) { }

	public virtual string GetMouseElementAssignmentPollingWindowMessage(string actionName) { }

	public virtual string GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName) { }

	public virtual string GetPlayerName(int playerId) { }

	public virtual void Initialize() { }

	public virtual string ModifierKeyFlagsToString(ModifierKeyFlags flags) { }

}

