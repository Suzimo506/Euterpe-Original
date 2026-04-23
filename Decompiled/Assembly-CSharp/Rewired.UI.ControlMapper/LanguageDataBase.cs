using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.UI.ControlMapper;

[Serializable]
[Token(Token = "0x2000203")]
public abstract class LanguageDataBase : ScriptableObject
{
	[Token(Token = "0x170003CA")]
	public abstract string yes
	{
		[Token(Token = "0x60012F6")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003CB")]
	public abstract string no
	{
		[Token(Token = "0x60012F7")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003CC")]
	public abstract string add
	{
		[Token(Token = "0x60012F8")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003CD")]
	public abstract string replace
	{
		[Token(Token = "0x60012F9")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003CE")]
	public abstract string remove
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x60012FA")]
		get;
	}

	[Token(Token = "0x170003CF")]
	public abstract string swap
	{
		[Token(Token = "0x60012FB")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003D0")]
	public abstract string cancel
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x60012FC")]
		get;
	}

	[Token(Token = "0x170003D1")]
	public abstract string none
	{
		[Token(Token = "0x60012FD")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003D2")]
	public abstract string okay
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x60012FE")]
		get;
	}

	[Token(Token = "0x170003D3")]
	public abstract string done
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x60012FF")]
		get;
	}

	[Token(Token = "0x170003D4")]
	public abstract string default_
	{
		[Token(Token = "0x6001300")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003D5")]
	public abstract string assignControllerWindowTitle
	{
		[Token(Token = "0x6001301")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003D6")]
	public abstract string assignControllerWindowMessage
	{
		[Token(Token = "0x6001302")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003D7")]
	public abstract string controllerAssignmentConflictWindowTitle
	{
		[Token(Token = "0x6001303")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003D8")]
	public abstract string elementAssignmentPrePollingWindowMessage
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6001304")]
		get;
	}

	[Token(Token = "0x170003D9")]
	public abstract string elementAssignmentConflictWindowMessage
	{
		[Token(Token = "0x6001305")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003DA")]
	public abstract string mouseAssignmentConflictWindowTitle
	{
		[Token(Token = "0x6001306")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003DB")]
	public abstract string calibrateControllerWindowTitle
	{
		[Token(Token = "0x6001307")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003DC")]
	public abstract string calibrateAxisStep1WindowTitle
	{
		[Token(Token = "0x6001308")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003DD")]
	public abstract string calibrateAxisStep2WindowTitle
	{
		[Token(Token = "0x6001309")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003DE")]
	public abstract string inputBehaviorSettingsWindowTitle
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x600130A")]
		get;
	}

	[Token(Token = "0x170003DF")]
	public abstract string restoreDefaultsWindowTitle
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x600130B")]
		get;
	}

	[Token(Token = "0x170003E0")]
	public abstract string actionColumnLabel
	{
		[Token(Token = "0x600130C")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003E1")]
	public abstract string keyboardColumnLabel
	{
		[Token(Token = "0x600130D")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003E2")]
	public abstract string mouseColumnLabel
	{
		[Token(Token = "0x600130E")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003E3")]
	public abstract string controllerColumnLabel
	{
		[Token(Token = "0x600130F")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003E4")]
	public abstract string removeControllerButtonLabel
	{
		[Token(Token = "0x6001310")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003E5")]
	public abstract string calibrateControllerButtonLabel
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6001311")]
		get;
	}

	[Token(Token = "0x170003E6")]
	public abstract string assignControllerButtonLabel
	{
		[Token(Token = "0x6001312")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003E7")]
	public abstract string inputBehaviorSettingsButtonLabel
	{
		[Token(Token = "0x6001313")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003E8")]
	public abstract string doneButtonLabel
	{
		[Token(Token = "0x6001314")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003E9")]
	public abstract string restoreDefaultsButtonLabel
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6001315")]
		get;
	}

	[Token(Token = "0x170003EA")]
	public abstract string controllerSettingsGroupLabel
	{
		[Token(Token = "0x6001316")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003EB")]
	public abstract string playersGroupLabel
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6001317")]
		get;
	}

	[Token(Token = "0x170003EC")]
	public abstract string assignedControllersGroupLabel
	{
		[Token(Token = "0x6001318")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003ED")]
	public abstract string settingsGroupLabel
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6001319")]
		get;
	}

	[Token(Token = "0x170003EE")]
	public abstract string mapCategoriesGroupLabel
	{
		[Token(Token = "0x600131A")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003EF")]
	public abstract string restoreDefaultsWindowMessage
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x600131B")]
		get;
	}

	[Token(Token = "0x170003F0")]
	public abstract string calibrateWindow_deadZoneSliderLabel
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x600131C")]
		get;
	}

	[Token(Token = "0x170003F1")]
	public abstract string calibrateWindow_zeroSliderLabel
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x600131D")]
		get;
	}

	[Token(Token = "0x170003F2")]
	public abstract string calibrateWindow_sensitivitySliderLabel
	{
		[Token(Token = "0x600131E")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003F3")]
	public abstract string calibrateWindow_invertToggleLabel
	{
		[Token(Token = "0x600131F")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170003F4")]
	public abstract string calibrateWindow_calibrateButtonLabel
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6001320")]
		get;
	}

	[Token(Token = "0x60012F3")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract void Initialize();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x60012F4")]
	public abstract string GetCustomEntry(string key);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x60012F5")]
	public abstract bool ContainsCustomEntryKey(string key);

	[Token(Token = "0x6001321")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract string GetControllerAssignmentConflictWindowMessage(string joystickName, string otherPlayerName, string currentPlayerName);

	[Token(Token = "0x6001322")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract string GetJoystickElementAssignmentPollingWindowMessage(string actionName);

	[Token(Token = "0x6001323")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract string GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName);

	[Token(Token = "0x6001324")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract string GetKeyboardElementAssignmentPollingWindowMessage(string actionName);

	[Token(Token = "0x6001325")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract string GetMouseElementAssignmentPollingWindowMessage(string actionName);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6001326")]
	public abstract string GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName);

	[Token(Token = "0x6001327")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract string GetElementAlreadyInUseBlocked(string elementName);

	[Token(Token = "0x6001328")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract string GetElementAlreadyInUseCanReplace(string elementName, bool allowConflicts);

	[Token(Token = "0x6001329")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract string GetMouseAssignmentConflictWindowMessage(string otherPlayerName, string thisPlayerName);

	[Token(Token = "0x600132A")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract string GetCalibrateAxisStep1WindowMessage(string axisName);

	[Token(Token = "0x600132B")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract string GetCalibrateAxisStep2WindowMessage(string axisName);

	[Token(Token = "0x600132C")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract string GetPlayerName(int playerId);

	[Token(Token = "0x600132D")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract string GetControllerName(Controller controller);

	[Token(Token = "0x600132E")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract string GetElementIdentifierName(ActionElementMap actionElementMap);

	[Token(Token = "0x600132F")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract string GetElementIdentifierName(Controller controller, int elementIdentifierId, AxisRange axisRange);

	[Token(Token = "0x6001330")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract string GetElementIdentifierName(KeyCode keyCode, ModifierKeyFlags modifierKeyFlags);

	[Token(Token = "0x6001331")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract string GetActionName(int actionId);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6001332")]
	public abstract string GetActionName(int actionId, AxisRange axisRange);

	[Token(Token = "0x6001333")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract string GetMapCategoryName(int id);

	[Token(Token = "0x6001334")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract string GetActionCategoryName(int id);

	[Token(Token = "0x6001335")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract string GetLayoutName(ControllerType controllerType, int id);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6001336")]
	public abstract string ModifierKeyFlagsToString(ModifierKeyFlags flags);

	[Token(Token = "0x6001337")]
	[Address(RVA = "0x5C16E0", Offset = "0x5BFEE0", Length = "0x7")]
	protected LanguageDataBase()
	{
	}
}
