using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.UI.ControlMapper;

[Serializable]
[Token(Token = "0x2000202")]
public class LanguageData : LanguageDataBase
{
	[Serializable]
	[Token(Token = "0x2000A9A")]
	protected class CustomEntry
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40037CD")]
		public string key;

		[Token(Token = "0x40037CE")]
		[FieldOffset(Offset = "0x18")]
		public string value;

		[Token(Token = "0x6005B2E")]
		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		public CustomEntry()
		{
		}

		[Address(RVA = "0x746990", Offset = "0x745190", Length = "0x4C")]
		[Token(Token = "0x6005B2F")]
		public CustomEntry(string key, string value)
		{
		}

		[Address(RVA = "0xDBDB70", Offset = "0xDBC370", Length = "0x223")]
		[Token(Token = "0x6005B30")]
		public static Dictionary<string, string> ToDictionary(CustomEntry[] array)
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000A9B")]
	protected class ModifierKeys
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40037CF")]
		public string control;

		[Token(Token = "0x40037D0")]
		[FieldOffset(Offset = "0x18")]
		public string alt;

		[Token(Token = "0x40037D1")]
		[FieldOffset(Offset = "0x20")]
		public string shift;

		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40037D2")]
		public string command;

		[Token(Token = "0x40037D3")]
		[FieldOffset(Offset = "0x30")]
		public string separator;

		[Token(Token = "0x6005B31")]
		[Address(RVA = "0xDC8A70", Offset = "0xDC7270", Length = "0x92")]
		public ModifierKeys()
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x4000E87")]
	[FieldOffset(Offset = "0x18")]
	private string _yes;

	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E88")]
	private string _no;

	[SerializeField]
	[Token(Token = "0x4000E89")]
	[FieldOffset(Offset = "0x28")]
	private string _add;

	[SerializeField]
	[Token(Token = "0x4000E8A")]
	[FieldOffset(Offset = "0x30")]
	private string _replace;

	[SerializeField]
	[Token(Token = "0x4000E8B")]
	[FieldOffset(Offset = "0x38")]
	private string _remove;

	[SerializeField]
	[Token(Token = "0x4000E8C")]
	[FieldOffset(Offset = "0x40")]
	private string _swap;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000E8D")]
	[SerializeField]
	private string _cancel;

	[SerializeField]
	[Token(Token = "0x4000E8E")]
	[FieldOffset(Offset = "0x50")]
	private string _none;

	[Token(Token = "0x4000E8F")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private string _okay;

	[Token(Token = "0x4000E90")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private string _done;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000E91")]
	[SerializeField]
	private string _default;

	[SerializeField]
	[Token(Token = "0x4000E92")]
	[FieldOffset(Offset = "0x70")]
	private string _assignControllerWindowTitle;

	[SerializeField]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000E93")]
	private string _assignControllerWindowMessage;

	[SerializeField]
	[Token(Token = "0x4000E94")]
	[FieldOffset(Offset = "0x80")]
	private string _controllerAssignmentConflictWindowTitle;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2C0", Offset = "0x9B6C0")]
	[Token(Token = "0x4000E95")]
	[FieldOffset(Offset = "0x88")]
	private string _controllerAssignmentConflictWindowMessage;

	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	[Token(Token = "0x4000E96")]
	private string _elementAssignmentPrePollingWindowMessage;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C5F0", Offset = "0x9B9F0")]
	[Token(Token = "0x4000E97")]
	[FieldOffset(Offset = "0x98")]
	private string _joystickElementAssignmentPollingWindowMessage;

	[Token(Token = "0x4000E98")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C780", Offset = "0x9BB80")]
	[SerializeField]
	[FieldOffset(Offset = "0xA0")]
	private string _joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000E99")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C5F0", Offset = "0x9B9F0")]
	[SerializeField]
	private string _keyboardElementAssignmentPollingWindowMessage;

	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C5F0", Offset = "0x9B9F0")]
	[Token(Token = "0x4000E9A")]
	private string _mouseElementAssignmentPollingWindowMessage;

	[SerializeField]
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000E9B")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C780", Offset = "0x9BB80")]
	private string _mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly;

	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	[Token(Token = "0x4000E9C")]
	private string _elementAssignmentConflictWindowMessage;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D1F0", Offset = "0x9C5F0")]
	[Token(Token = "0x4000E9D")]
	[FieldOffset(Offset = "0xC8")]
	private string _elementAlreadyInUseBlocked;

	[Token(Token = "0x4000E9E")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D1F0", Offset = "0x9C5F0")]
	private string _elementAlreadyInUseCanReplace;

	[SerializeField]
	[Token(Token = "0x4000E9F")]
	[FieldOffset(Offset = "0xD8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D1F0", Offset = "0x9C5F0")]
	private string _elementAlreadyInUseCanReplace_conflictAllowed;

	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000EA0")]
	[SerializeField]
	private string _mouseAssignmentConflictWindowTitle;

	[Token(Token = "0x4000EA1")]
	[SerializeField]
	[FieldOffset(Offset = "0xE8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D5B0", Offset = "0x9C9B0")]
	private string _mouseAssignmentConflictWindowMessage;

	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	[Token(Token = "0x4000EA2")]
	private string _calibrateControllerWindowTitle;

	[SerializeField]
	[Token(Token = "0x4000EA3")]
	[FieldOffset(Offset = "0xF8")]
	private string _calibrateAxisStep1WindowTitle;

	[Token(Token = "0x4000EA4")]
	[SerializeField]
	[FieldOffset(Offset = "0x100")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EC70", Offset = "0x9E070")]
	private string _calibrateAxisStep1WindowMessage;

	[Token(Token = "0x4000EA5")]
	[SerializeField]
	[FieldOffset(Offset = "0x108")]
	private string _calibrateAxisStep2WindowTitle;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EC70", Offset = "0x9E070")]
	[SerializeField]
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000EA6")]
	private string _calibrateAxisStep2WindowMessage;

	[SerializeField]
	[Token(Token = "0x4000EA7")]
	[FieldOffset(Offset = "0x118")]
	private string _inputBehaviorSettingsWindowTitle;

	[SerializeField]
	[Token(Token = "0x4000EA8")]
	[FieldOffset(Offset = "0x120")]
	private string _restoreDefaultsWindowTitle;

	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2C0", Offset = "0x9E6C0")]
	[Token(Token = "0x4000EA9")]
	private string _restoreDefaultsWindowMessage_onePlayer;

	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000EAA")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F460", Offset = "0x9E860")]
	[SerializeField]
	private string _restoreDefaultsWindowMessage_multiPlayer;

	[SerializeField]
	[Token(Token = "0x4000EAB")]
	[FieldOffset(Offset = "0x138")]
	private string _actionColumnLabel;

	[SerializeField]
	[Token(Token = "0x4000EAC")]
	[FieldOffset(Offset = "0x140")]
	private string _keyboardColumnLabel;

	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000EAD")]
	[SerializeField]
	private string _mouseColumnLabel;

	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	[Token(Token = "0x4000EAE")]
	private string _controllerColumnLabel;

	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000EAF")]
	[SerializeField]
	private string _removeControllerButtonLabel;

	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000EB0")]
	[SerializeField]
	private string _calibrateControllerButtonLabel;

	[Token(Token = "0x4000EB1")]
	[SerializeField]
	[FieldOffset(Offset = "0x168")]
	private string _assignControllerButtonLabel;

	[SerializeField]
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4000EB2")]
	private string _inputBehaviorSettingsButtonLabel;

	[SerializeField]
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x4000EB3")]
	private string _doneButtonLabel;

	[SerializeField]
	[Token(Token = "0x4000EB4")]
	[FieldOffset(Offset = "0x180")]
	private string _restoreDefaultsButtonLabel;

	[FieldOffset(Offset = "0x188")]
	[SerializeField]
	[Token(Token = "0x4000EB5")]
	private string _playersGroupLabel;

	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000EB6")]
	[SerializeField]
	private string _controllerSettingsGroupLabel;

	[SerializeField]
	[Token(Token = "0x4000EB7")]
	[FieldOffset(Offset = "0x198")]
	private string _assignedControllersGroupLabel;

	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4000EB8")]
	[SerializeField]
	private string _settingsGroupLabel;

	[FieldOffset(Offset = "0x1A8")]
	[SerializeField]
	[Token(Token = "0x4000EB9")]
	private string _mapCategoriesGroupLabel;

	[SerializeField]
	[Token(Token = "0x4000EBA")]
	[FieldOffset(Offset = "0x1B0")]
	private string _calibrateWindow_deadZoneSliderLabel;

	[Token(Token = "0x4000EBB")]
	[SerializeField]
	[FieldOffset(Offset = "0x1B8")]
	private string _calibrateWindow_zeroSliderLabel;

	[Token(Token = "0x4000EBC")]
	[FieldOffset(Offset = "0x1C0")]
	[SerializeField]
	private string _calibrateWindow_sensitivitySliderLabel;

	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000EBD")]
	[SerializeField]
	private string _calibrateWindow_invertToggleLabel;

	[SerializeField]
	[Token(Token = "0x4000EBE")]
	[FieldOffset(Offset = "0x1D0")]
	private string _calibrateWindow_calibrateButtonLabel;

	[SerializeField]
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4000EBF")]
	private ModifierKeys _modifierKeys;

	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000EC0")]
	[SerializeField]
	private CustomEntry[] _customEntries;

	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000EC1")]
	private bool _initialized;

	[Token(Token = "0x4000EC2")]
	[FieldOffset(Offset = "0x1F0")]
	private Dictionary<string, string> customDict;

	[Token(Token = "0x1700039F")]
	public override string yes
	{
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		[Token(Token = "0x60012B1")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003A0")]
	public override string no
	{
		[Token(Token = "0x60012B2")]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003A1")]
	public override string add
	{
		[Token(Token = "0x60012B3")]
		[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003A2")]
	public override string replace
	{
		[Token(Token = "0x60012B4")]
		[Address(RVA = "0x45EEE0", Offset = "0x45D6E0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003A3")]
	public override string remove
	{
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		[Token(Token = "0x60012B5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003A4")]
	public override string swap
	{
		[Token(Token = "0x60012B6")]
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003A5")]
	public override string cancel
	{
		[Token(Token = "0x60012B7")]
		[Address(RVA = "0x46EF30", Offset = "0x46D730", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003A6")]
	public override string none
	{
		[Address(RVA = "0x46EF80", Offset = "0x46D780", Length = "0x5")]
		[Token(Token = "0x60012B8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003A7")]
	public override string okay
	{
		[Token(Token = "0x60012B9")]
		[Address(RVA = "0x429C40", Offset = "0x428440", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003A8")]
	public override string done
	{
		[Token(Token = "0x60012BA")]
		[Address(RVA = "0x4293D0", Offset = "0x427BD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003A9")]
	public override string default_
	{
		[Token(Token = "0x60012BB")]
		[Address(RVA = "0x4293C0", Offset = "0x427BC0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003AA")]
	public override string assignControllerWindowTitle
	{
		[Token(Token = "0x60012BC")]
		[Address(RVA = "0x462D00", Offset = "0x461500", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003AB")]
	public override string assignControllerWindowMessage
	{
		[Address(RVA = "0x5C1440", Offset = "0x5BFC40", Length = "0x5")]
		[Token(Token = "0x60012BD")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003AC")]
	public override string controllerAssignmentConflictWindowTitle
	{
		[Address(RVA = "0x4865C0", Offset = "0x484DC0", Length = "0x8")]
		[Token(Token = "0x60012BE")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003AD")]
	public override string elementAssignmentPrePollingWindowMessage
	{
		[Token(Token = "0x60012BF")]
		[Address(RVA = "0x46D010", Offset = "0x46B810", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003AE")]
	public override string elementAssignmentConflictWindowMessage
	{
		[Token(Token = "0x60012C0")]
		[Address(RVA = "0x49A8D0", Offset = "0x4990D0", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003AF")]
	public override string mouseAssignmentConflictWindowTitle
	{
		[Token(Token = "0x60012C1")]
		[Address(RVA = "0x48E510", Offset = "0x48CD10", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003B0")]
	public override string calibrateControllerWindowTitle
	{
		[Address(RVA = "0x4CFBF0", Offset = "0x4CE3F0", Length = "0x8")]
		[Token(Token = "0x60012C2")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003B1")]
	public override string calibrateAxisStep1WindowTitle
	{
		[Address(RVA = "0x4E8C50", Offset = "0x4E7450", Length = "0x8")]
		[Token(Token = "0x60012C3")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003B2")]
	public override string calibrateAxisStep2WindowTitle
	{
		[Address(RVA = "0xA5DC40", Offset = "0xA5C440", Length = "0x8")]
		[Token(Token = "0x60012C4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003B3")]
	public override string inputBehaviorSettingsWindowTitle
	{
		[Token(Token = "0x60012C5")]
		[Address(RVA = "0x427D10", Offset = "0x426510", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003B4")]
	public override string restoreDefaultsWindowTitle
	{
		[Address(RVA = "0x51FEB0", Offset = "0x51E6B0", Length = "0x8")]
		[Token(Token = "0x60012C6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003B5")]
	public override string actionColumnLabel
	{
		[Token(Token = "0x60012C7")]
		[Address(RVA = "0x6BE720", Offset = "0x6BCF20", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003B6")]
	public override string keyboardColumnLabel
	{
		[Token(Token = "0x60012C8")]
		[Address(RVA = "0xCD8150", Offset = "0xCD6950", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003B7")]
	public override string mouseColumnLabel
	{
		[Address(RVA = "0x561370", Offset = "0x55FB70", Length = "0x8")]
		[Token(Token = "0x60012C9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003B8")]
	public override string controllerColumnLabel
	{
		[Address(RVA = "0xDC7FD0", Offset = "0xDC67D0", Length = "0x8")]
		[Token(Token = "0x60012CA")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003B9")]
	public override string removeControllerButtonLabel
	{
		[Address(RVA = "0x832820", Offset = "0x831020", Length = "0x8")]
		[Token(Token = "0x60012CB")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003BA")]
	public override string calibrateControllerButtonLabel
	{
		[Address(RVA = "0xCE3140", Offset = "0xCE1940", Length = "0x8")]
		[Token(Token = "0x60012CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003BB")]
	public override string assignControllerButtonLabel
	{
		[Address(RVA = "0xCE30D0", Offset = "0xCE18D0", Length = "0x8")]
		[Token(Token = "0x60012CD")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003BC")]
	public override string inputBehaviorSettingsButtonLabel
	{
		[Address(RVA = "0x998050", Offset = "0x996850", Length = "0x8")]
		[Token(Token = "0x60012CE")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003BD")]
	public override string doneButtonLabel
	{
		[Token(Token = "0x60012CF")]
		[Address(RVA = "0xCE3190", Offset = "0xCE1990", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003BE")]
	public override string restoreDefaultsButtonLabel
	{
		[Token(Token = "0x60012D0")]
		[Address(RVA = "0x682270", Offset = "0x680A70", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003BF")]
	public override string controllerSettingsGroupLabel
	{
		[Token(Token = "0x60012D1")]
		[Address(RVA = "0xCE31A0", Offset = "0xCE19A0", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003C0")]
	public override string playersGroupLabel
	{
		[Address(RVA = "0x58FB30", Offset = "0x58E330", Length = "0x8")]
		[Token(Token = "0x60012D2")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003C1")]
	public override string assignedControllersGroupLabel
	{
		[Token(Token = "0x60012D3")]
		[Address(RVA = "0x444FC0", Offset = "0x4437C0", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003C2")]
	public override string settingsGroupLabel
	{
		[Address(RVA = "0x81DA10", Offset = "0x81C210", Length = "0x8")]
		[Token(Token = "0x60012D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003C3")]
	public override string mapCategoriesGroupLabel
	{
		[Token(Token = "0x60012D5")]
		[Address(RVA = "0xCD80E0", Offset = "0xCD68E0", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003C4")]
	public override string restoreDefaultsWindowMessage
	{
		[Token(Token = "0x60012D6")]
		[Address(RVA = "0xDC7FE0", Offset = "0xDC67E0", Length = "0x7C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003C5")]
	public override string calibrateWindow_deadZoneSliderLabel
	{
		[Token(Token = "0x60012D7")]
		[Address(RVA = "0x81DA20", Offset = "0x81C220", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003C6")]
	public override string calibrateWindow_zeroSliderLabel
	{
		[Address(RVA = "0xCD8100", Offset = "0xCD6900", Length = "0x8")]
		[Token(Token = "0x60012D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003C7")]
	public override string calibrateWindow_sensitivitySliderLabel
	{
		[Address(RVA = "0xCD80D0", Offset = "0xCD68D0", Length = "0x8")]
		[Token(Token = "0x60012D9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003C8")]
	public override string calibrateWindow_invertToggleLabel
	{
		[Token(Token = "0x60012DA")]
		[Address(RVA = "0xCD8110", Offset = "0xCD6910", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003C9")]
	public override string calibrateWindow_calibrateButtonLabel
	{
		[Token(Token = "0x60012DB")]
		[Address(RVA = "0x8999F0", Offset = "0x8981F0", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60012AE")]
	[Address(RVA = "0xDC78A0", Offset = "0xDC60A0", Length = "0x3F")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x60012AF")]
	[Address(RVA = "0xDC70F0", Offset = "0xDC58F0", Length = "0x97")]
	public override string GetCustomEntry(string key)
	{
		return null;
	}

	[Token(Token = "0x60012B0")]
	[Address(RVA = "0xDC6C60", Offset = "0xDC5460", Length = "0x70")]
	public override bool ContainsCustomEntryKey(string key)
	{
		return default(bool);
	}

	[Address(RVA = "0xDC7060", Offset = "0xDC5860", Length = "0x15")]
	[Token(Token = "0x60012DC")]
	public override string GetControllerAssignmentConflictWindowMessage(string joystickName, string otherPlayerName, string currentPlayerName)
	{
		return null;
	}

	[Address(RVA = "0xDC7500", Offset = "0xDC5D00", Length = "0xF")]
	[Token(Token = "0x60012DD")]
	public override string GetJoystickElementAssignmentPollingWindowMessage(string actionName)
	{
		return null;
	}

	[Token(Token = "0x60012DE")]
	[Address(RVA = "0xDC74F0", Offset = "0xDC5CF0", Length = "0xF")]
	public override string GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName)
	{
		return null;
	}

	[Address(RVA = "0xDC7510", Offset = "0xDC5D10", Length = "0xF")]
	[Token(Token = "0x60012DF")]
	public override string GetKeyboardElementAssignmentPollingWindowMessage(string actionName)
	{
		return null;
	}

	[Address(RVA = "0xDC77B0", Offset = "0xDC5FB0", Length = "0xF")]
	[Token(Token = "0x60012E0")]
	public override string GetMouseElementAssignmentPollingWindowMessage(string actionName)
	{
		return null;
	}

	[Token(Token = "0x60012E1")]
	[Address(RVA = "0xDC77A0", Offset = "0xDC5FA0", Length = "0xF")]
	public override string GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName)
	{
		return null;
	}

	[Token(Token = "0x60012E2")]
	[Address(RVA = "0xDC7190", Offset = "0xDC5990", Length = "0xF")]
	public override string GetElementAlreadyInUseBlocked(string elementName)
	{
		return null;
	}

	[Token(Token = "0x60012E3")]
	[Address(RVA = "0xDC71A0", Offset = "0xDC59A0", Length = "0x23")]
	public override string GetElementAlreadyInUseCanReplace(string elementName, bool allowConflicts)
	{
		return null;
	}

	[Token(Token = "0x60012E4")]
	[Address(RVA = "0xDC7790", Offset = "0xDC5F90", Length = "0xF")]
	public override string GetMouseAssignmentConflictWindowMessage(string otherPlayerName, string thisPlayerName)
	{
		return null;
	}

	[Token(Token = "0x60012E5")]
	[Address(RVA = "0xDC7040", Offset = "0xDC5840", Length = "0xF")]
	public override string GetCalibrateAxisStep1WindowMessage(string axisName)
	{
		return null;
	}

	[Address(RVA = "0xDC7050", Offset = "0xDC5850", Length = "0xF")]
	[Token(Token = "0x60012E6")]
	public override string GetCalibrateAxisStep2WindowMessage(string axisName)
	{
		return null;
	}

	[Address(RVA = "0xDC77C0", Offset = "0xDC5FC0", Length = "0xD4")]
	[Token(Token = "0x60012E7")]
	public override string GetPlayerName(int playerId)
	{
		return null;
	}

	[Address(RVA = "0xDC7080", Offset = "0xDC5880", Length = "0x68")]
	[Token(Token = "0x60012E8")]
	public override string GetControllerName(Controller controller)
	{
		return null;
	}

	[Token(Token = "0x60012E9")]
	[Address(RVA = "0xDC7290", Offset = "0xDC5A90", Length = "0x10D")]
	public override string GetElementIdentifierName(ActionElementMap actionElementMap)
	{
		return null;
	}

	[Token(Token = "0x60012EA")]
	[Address(RVA = "0xDC73A0", Offset = "0xDC5BA0", Length = "0x140")]
	public override string GetElementIdentifierName(Controller controller, int elementIdentifierId, AxisRange axisRange)
	{
		return null;
	}

	[Token(Token = "0x60012EB")]
	[Address(RVA = "0xDC71D0", Offset = "0xDC59D0", Length = "0xBC")]
	public override string GetElementIdentifierName(KeyCode keyCode, ModifierKeyFlags modifierKeyFlags)
	{
		return null;
	}

	[Address(RVA = "0xDC6F70", Offset = "0xDC5770", Length = "0xCF")]
	[Token(Token = "0x60012EC")]
	public override string GetActionName(int actionId)
	{
		return null;
	}

	[Address(RVA = "0xDC6DB0", Offset = "0xDC55B0", Length = "0x1B5")]
	[Token(Token = "0x60012ED")]
	public override string GetActionName(int actionId, AxisRange axisRange)
	{
		return null;
	}

	[Address(RVA = "0xDC76C0", Offset = "0xDC5EC0", Length = "0xCF")]
	[Token(Token = "0x60012EE")]
	public override string GetMapCategoryName(int id)
	{
		return null;
	}

	[Address(RVA = "0xDC6CE0", Offset = "0xDC54E0", Length = "0xCF")]
	[Token(Token = "0x60012EF")]
	public override string GetActionCategoryName(int id)
	{
		return null;
	}

	[Token(Token = "0x60012F0")]
	[Address(RVA = "0xDC7520", Offset = "0xDC5D20", Length = "0x19E")]
	public override string GetLayoutName(ControllerType controllerType, int id)
	{
		return null;
	}

	[Token(Token = "0x60012F1")]
	[Address(RVA = "0xDC78E0", Offset = "0xDC60E0", Length = "0x20C")]
	public override string ModifierKeyFlagsToString(ModifierKeyFlags flags)
	{
		return null;
	}

	[Token(Token = "0x60012F2")]
	[Address(RVA = "0xDC7AF0", Offset = "0xDC62F0", Length = "0x4DC")]
	public LanguageData()
	{
	}
}
