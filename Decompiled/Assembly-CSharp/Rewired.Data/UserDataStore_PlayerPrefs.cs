using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Data;

[Token(Token = "0x20001EF")]
public class UserDataStore_PlayerPrefs : UserDataStore
{
	[Token(Token = "0x2000A6E")]
	private class ControllerAssignmentSaveInfo
	{
		[Token(Token = "0x2000DFA")]
		public class PlayerInfo
		{
			[Token(Token = "0x4004135")]
			[FieldOffset(Offset = "0x10")]
			public int id;

			[Token(Token = "0x4004136")]
			[FieldOffset(Offset = "0x14")]
			public bool hasKeyboard;

			[Token(Token = "0x4004137")]
			[FieldOffset(Offset = "0x15")]
			public bool hasMouse;

			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4004138")]
			public JoystickInfo[] joysticks;

			[Token(Token = "0x17000B3E")]
			public int joystickCount
			{
				[Token(Token = "0x60066B2")]
				[Address(RVA = "0x55FD90", Offset = "0x55E590", Length = "0xE")]
				get
				{
					return default(int);
				}
			}

			[Address(RVA = "0x55FD20", Offset = "0x55E520", Length = "0x62")]
			[Token(Token = "0x60066B3")]
			public int IndexOfJoystick(int joystickId)
			{
				return default(int);
			}

			[Address(RVA = "0x55FCB0", Offset = "0x55E4B0", Length = "0x67")]
			[Token(Token = "0x60066B4")]
			public bool ContainsJoystick(int joystickId)
			{
				return default(bool);
			}

			[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
			[Token(Token = "0x60066B5")]
			public PlayerInfo()
			{
			}
		}

		[Token(Token = "0x2000DFB")]
		public class JoystickInfo
		{
			[Token(Token = "0x4004139")]
			[FieldOffset(Offset = "0x10")]
			public Guid instanceGuid;

			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x400413A")]
			public string hardwareIdentifier;

			[Token(Token = "0x400413B")]
			[FieldOffset(Offset = "0x28")]
			public int id;

			[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
			[Token(Token = "0x60066B6")]
			public JoystickInfo()
			{
			}
		}

		[Token(Token = "0x4003706")]
		[FieldOffset(Offset = "0x10")]
		public PlayerInfo[] players;

		[Token(Token = "0x1700098B")]
		public int playerCount
		{
			[Token(Token = "0x60059C8")]
			[Address(RVA = "0x55FC00", Offset = "0x55E400", Length = "0xE")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60059C9")]
		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		public ControllerAssignmentSaveInfo()
		{
		}

		[Token(Token = "0x60059CA")]
		[Address(RVA = "0x55FAF0", Offset = "0x55E2F0", Length = "0x10C")]
		public ControllerAssignmentSaveInfo(int playerCount)
		{
		}

		[Token(Token = "0x60059CB")]
		[Address(RVA = "0x55FA80", Offset = "0x55E280", Length = "0x62")]
		public int IndexOfPlayer(int playerId)
		{
			return default(int);
		}

		[Token(Token = "0x60059CC")]
		[Address(RVA = "0x55FA10", Offset = "0x55E210", Length = "0x67")]
		public bool ContainsPlayer(int playerId)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000A6F")]
	private class JoystickAssignmentHistoryInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003707")]
		public readonly Joystick joystick;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003708")]
		public readonly int oldJoystickId;

		[Token(Token = "0x60059CD")]
		[Address(RVA = "0x55FC10", Offset = "0x55E410", Length = "0x94")]
		public JoystickAssignmentHistoryInfo(Joystick joystick, int oldJoystickId)
		{
		}
	}

	[Token(Token = "0x4000D76")]
	private const string thisScriptName = "UserDataStore_PlayerPrefs";

	[Token(Token = "0x4000D77")]
	private const string logPrefix = "Rewired: ";

	[Token(Token = "0x4000D78")]
	private const string editorLoadedMessage = "\n***IMPORTANT:*** Changes made to the Rewired Input Manager configuration after the last time XML data was saved WILL NOT be used because the loaded old saved data has overwritten these values. If you change something in the Rewired Input Manager such as a Joystick Map or Input Behavior settings, you will not see these changes reflected in the current configuration. Clear PlayerPrefs using the inspector option on the UserDataStore_PlayerPrefs component.";

	[Token(Token = "0x4000D79")]
	private const string playerPrefsKeySuffix_controllerAssignments = "ControllerAssignments";

	[Token(Token = "0x4000D7A")]
	private const int controllerMapPPKeyVersion_original = 0;

	[Token(Token = "0x4000D7B")]
	private const int controllerMapPPKeyVersion_includeDuplicateJoystickIndex = 1;

	[Token(Token = "0x4000D7C")]
	private const int controllerMapPPKeyVersion_supportDisconnectedControllers = 2;

	[Token(Token = "0x4000D7D")]
	private const int controllerMapPPKeyVersion_includeFormatVersion = 2;

	[Token(Token = "0x4000D7E")]
	private const int controllerMapPPKeyVersion = 2;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x66BD0", Offset = "0x65FD0")]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D7F")]
	[SerializeField]
	private bool isEnabled;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67180", Offset = "0x66580")]
	[SerializeField]
	[Token(Token = "0x4000D80")]
	[FieldOffset(Offset = "0x19")]
	private bool loadDataOnStart;

	[FieldOffset(Offset = "0x1A")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689D0", Offset = "0x67DD0")]
	[Token(Token = "0x4000D81")]
	private bool loadJoystickAssignments;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68C60", Offset = "0x68060")]
	[Token(Token = "0x4000D82")]
	[FieldOffset(Offset = "0x1B")]
	[SerializeField]
	private bool loadKeyboardAssignments;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x690C0", Offset = "0x684C0")]
	[Token(Token = "0x4000D83")]
	[FieldOffset(Offset = "0x1C")]
	private bool loadMouseAssignments;

	[SerializeField]
	[Token(Token = "0x4000D84")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x69280", Offset = "0x68680")]
	private string playerPrefsKeyPrefix;

	[NonSerialized]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D85")]
	private bool allowImpreciseJoystickAssignmentMatching;

	[NonSerialized]
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4000D86")]
	private bool deferredJoystickAssignmentLoadPending;

	[NonSerialized]
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x4000D87")]
	private bool wasJoystickEverDetected;

	[NonSerialized]
	[Token(Token = "0x4000D88")]
	[FieldOffset(Offset = "0x30")]
	private List<int> __allActionIds;

	[NonSerialized]
	[Token(Token = "0x4000D89")]
	[FieldOffset(Offset = "0x38")]
	private string __allActionIdsString;

	[Token(Token = "0x1700030B")]
	public bool IsEnabled
	{
		[Address(RVA = "0x470810", Offset = "0x46F010", Length = "0x5")]
		[Token(Token = "0x6000FE9")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000FEA")]
		[Address(RVA = "0x470820", Offset = "0x46F020", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x1700030C")]
	public bool LoadDataOnStart
	{
		[Address(RVA = "0x575490", Offset = "0x573C90", Length = "0x5")]
		[Token(Token = "0x6000FEB")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000FEC")]
		[Address(RVA = "0x575860", Offset = "0x574060", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x1700030D")]
	public bool LoadJoystickAssignments
	{
		[Address(RVA = "0x5754A0", Offset = "0x573CA0", Length = "0x5")]
		[Token(Token = "0x6000FED")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000FEE")]
		[Address(RVA = "0x575870", Offset = "0x574070", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x1700030E")]
	public bool LoadKeyboardAssignments
	{
		[Token(Token = "0x6000FEF")]
		[Address(RVA = "0x5754B0", Offset = "0x573CB0", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000FF0")]
		[Address(RVA = "0x575880", Offset = "0x574080", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x1700030F")]
	public bool LoadMouseAssignments
	{
		[Address(RVA = "0x44A0A0", Offset = "0x4488A0", Length = "0x5")]
		[Token(Token = "0x6000FF1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000FF2")]
		[Address(RVA = "0x48C800", Offset = "0x48B000", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x17000310")]
	public string PlayerPrefsKeyPrefix
	{
		[Token(Token = "0x6000FF3")]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000FF4")]
		[Address(RVA = "0x483E40", Offset = "0x482640", Length = "0xC")]
		set
		{
		}
	}

	[Token(Token = "0x17000311")]
	private string playerPrefsKey_controllerAssignments
	{
		[Address(RVA = "0x575810", Offset = "0x574010", Length = "0x43")]
		[Token(Token = "0x6000FF5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000312")]
	private bool loadControllerAssignments
	{
		[Address(RVA = "0x5757F0", Offset = "0x573FF0", Length = "0x14")]
		[Token(Token = "0x6000FF6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000313")]
	private List<int> allActionIds
	{
		[Address(RVA = "0x5755F0", Offset = "0x573DF0", Length = "0x1FC")]
		[Token(Token = "0x6000FF7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000314")]
	private string allActionIdsString
	{
		[Address(RVA = "0x5754C0", Offset = "0x573CC0", Length = "0x120")]
		[Token(Token = "0x6000FF8")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x575160", Offset = "0x573960", Length = "0x6E")]
	[Token(Token = "0x6000FF9")]
	public override void Save()
	{
	}

	[Address(RVA = "0x573F30", Offset = "0x572730", Length = "0xC0")]
	[Token(Token = "0x6000FFA")]
	public override void SaveControllerData(int playerId, ControllerType controllerType, int controllerId)
	{
	}

	[Token(Token = "0x6000FFB")]
	[Address(RVA = "0x573FF0", Offset = "0x5727F0", Length = "0x9F")]
	public override void SaveControllerData(ControllerType controllerType, int controllerId)
	{
	}

	[Address(RVA = "0x575070", Offset = "0x573870", Length = "0xE0")]
	[Token(Token = "0x6000FFC")]
	public override void SavePlayerData(int playerId)
	{
	}

	[Token(Token = "0x6000FFD")]
	[Address(RVA = "0x5748F0", Offset = "0x5730F0", Length = "0x172")]
	public override void SaveInputBehavior(int playerId, int behaviorId)
	{
	}

	[Token(Token = "0x6000FFE")]
	[Address(RVA = "0x573300", Offset = "0x571B00", Length = "0x6E")]
	public override void Load()
	{
	}

	[Address(RVA = "0x570FA0", Offset = "0x56F7A0", Length = "0xBF")]
	[Token(Token = "0x6000FFF")]
	public override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId)
	{
	}

	[Address(RVA = "0x570F00", Offset = "0x56F700", Length = "0x99")]
	[Token(Token = "0x6001000")]
	public override void LoadControllerData(ControllerType controllerType, int controllerId)
	{
	}

	[Address(RVA = "0x573220", Offset = "0x571A20", Length = "0xD9")]
	[Token(Token = "0x6001001")]
	public override void LoadPlayerData(int playerId)
	{
	}

	[Address(RVA = "0x5717D0", Offset = "0x56FFD0", Length = "0x148")]
	[Token(Token = "0x6001002")]
	public override void LoadInputBehavior(int playerId, int behaviorId)
	{
	}

	[Token(Token = "0x6001003")]
	[Address(RVA = "0x573490", Offset = "0x571C90", Length = "0xA5")]
	protected override void OnInitialize()
	{
	}

	[Address(RVA = "0x573370", Offset = "0x571B70", Length = "0xCA")]
	[Token(Token = "0x6001004")]
	protected override void OnControllerConnected(ControllerStatusChangedEventArgs args)
	{
	}

	[Token(Token = "0x6001005")]
	[Address(RVA = "0x573460", Offset = "0x571C60", Length = "0x2E")]
	protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args)
	{
	}

	[Address(RVA = "0x573440", Offset = "0x571C40", Length = "0x20")]
	[Token(Token = "0x6001006")]
	protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
	{
	}

	[Address(RVA = "0x574410", Offset = "0x572C10", Length = "0x99")]
	[Token(Token = "0x6001007")]
	public override void SaveControllerMap(int playerId, ControllerMap controllerMap)
	{
	}

	[Address(RVA = "0x571060", Offset = "0x56F860", Length = "0xD6")]
	[Token(Token = "0x6001008")]
	public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		return null;
	}

	[Address(RVA = "0x570AB0", Offset = "0x56F2B0", Length = "0x1DA")]
	[Token(Token = "0x6001009")]
	private int LoadAll()
	{
		return default(int);
	}

	[Address(RVA = "0x572F60", Offset = "0x571760", Length = "0x7E")]
	[Token(Token = "0x600100A")]
	private int LoadPlayerDataNow(int playerId)
	{
		return default(int);
	}

	[Address(RVA = "0x572FE0", Offset = "0x5717E0", Length = "0x23E")]
	[Token(Token = "0x600100B")]
	private int LoadPlayerDataNow(Player player)
	{
		return default(int);
	}

	[Address(RVA = "0x570870", Offset = "0x56F070", Length = "0x237")]
	[Token(Token = "0x600100C")]
	private int LoadAllJoystickCalibrationData()
	{
		return default(int);
	}

	[Address(RVA = "0x5728A0", Offset = "0x5710A0", Length = "0x9B")]
	[Token(Token = "0x600100D")]
	private int LoadJoystickCalibrationData(Joystick joystick)
	{
		return default(int);
	}

	[Address(RVA = "0x572940", Offset = "0x571140", Length = "0xFA")]
	[Token(Token = "0x600100E")]
	private int LoadJoystickCalibrationData(int joystickId)
	{
		return default(int);
	}

	[Token(Token = "0x600100F")]
	[Address(RVA = "0x572A40", Offset = "0x571240", Length = "0x221")]
	private int LoadJoystickData(int joystickId)
	{
		return default(int);
	}

	[Token(Token = "0x6001010")]
	[Address(RVA = "0x570E80", Offset = "0x56F680", Length = "0x73")]
	private int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
	{
		return default(int);
	}

	[Address(RVA = "0x570E60", Offset = "0x56F660", Length = "0x15")]
	[Token(Token = "0x6001011")]
	private int LoadControllerDataNow(ControllerType controllerType, int controllerId)
	{
		return default(int);
	}

	[Address(RVA = "0x5712C0", Offset = "0x56FAC0", Length = "0x30C")]
	[Token(Token = "0x6001012")]
	private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId)
	{
		return default(int);
	}

	[Token(Token = "0x6001013")]
	[Address(RVA = "0x571140", Offset = "0x56F940", Length = "0x176")]
	private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		return null;
	}

	[Address(RVA = "0x571920", Offset = "0x570120", Length = "0x21B")]
	[Token(Token = "0x6001014")]
	private int LoadInputBehaviors(int playerId)
	{
		return default(int);
	}

	[Address(RVA = "0x5715D0", Offset = "0x56FDD0", Length = "0xE4")]
	[Token(Token = "0x6001015")]
	private int LoadInputBehaviorNow(int playerId, int behaviorId)
	{
		return default(int);
	}

	[Address(RVA = "0x5716C0", Offset = "0x56FEC0", Length = "0x10D")]
	[Token(Token = "0x6001016")]
	private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior)
	{
		return default(int);
	}

	[Address(RVA = "0x570DC0", Offset = "0x56F5C0", Length = "0x9E")]
	[Token(Token = "0x6001017")]
	private bool LoadControllerAssignmentsNow()
	{
		return default(bool);
	}

	[Token(Token = "0x6001018")]
	[Address(RVA = "0x572C70", Offset = "0x571470", Length = "0x2EB")]
	private bool LoadKeyboardAndMouseAssignmentsNow(ControllerAssignmentSaveInfo data)
	{
		return default(bool);
	}

	[Address(RVA = "0x571BB0", Offset = "0x5703B0", Length = "0xCE0")]
	[Token(Token = "0x6001019")]
	private bool LoadJoystickAssignmentsNow(ControllerAssignmentSaveInfo data)
	{
		return default(bool);
	}

	[Address(RVA = "0x570C90", Offset = "0x56F490", Length = "0x129")]
	[Token(Token = "0x600101A")]
	private ControllerAssignmentSaveInfo LoadControllerAssignmentData()
	{
		return null;
	}

	[Token(Token = "0x600101B")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x694B0", Offset = "0x688B0")]
	[Address(RVA = "0x571B40", Offset = "0x570340", Length = "0x65")]
	private IEnumerator LoadJoystickAssignmentsDeferred()
	{
		return null;
	}

	[Token(Token = "0x600101C")]
	[Address(RVA = "0x5737E0", Offset = "0x571FE0", Length = "0x1D7")]
	private void SaveAll()
	{
	}

	[Token(Token = "0x600101D")]
	[Address(RVA = "0x574FE0", Offset = "0x5737E0", Length = "0x85")]
	private void SavePlayerDataNow(int playerId)
	{
	}

	[Token(Token = "0x600101E")]
	[Address(RVA = "0x574E90", Offset = "0x573690", Length = "0x14C")]
	private void SavePlayerDataNow(Player player)
	{
	}

	[Token(Token = "0x600101F")]
	[Address(RVA = "0x5735E0", Offset = "0x571DE0", Length = "0x1F3")]
	private void SaveAllJoystickCalibrationData()
	{
	}

	[Token(Token = "0x6001020")]
	[Address(RVA = "0x574BB0", Offset = "0x5733B0", Length = "0xC4")]
	private void SaveJoystickCalibrationData(int joystickId)
	{
	}

	[Token(Token = "0x6001021")]
	[Address(RVA = "0x574B30", Offset = "0x573330", Length = "0x70")]
	private void SaveJoystickCalibrationData(Joystick joystick)
	{
	}

	[Address(RVA = "0x574C80", Offset = "0x573480", Length = "0x200")]
	[Token(Token = "0x6001022")]
	private void SaveJoystickData(int joystickId)
	{
	}

	[Token(Token = "0x6001023")]
	[Address(RVA = "0x573ED0", Offset = "0x5726D0", Length = "0x55")]
	private void SaveControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
	{
	}

	[Token(Token = "0x6001024")]
	[Address(RVA = "0x573EA0", Offset = "0x5726A0", Length = "0x21")]
	private void SaveControllerDataNow(ControllerType controllerType, int controllerId)
	{
	}

	[Token(Token = "0x6001025")]
	[Address(RVA = "0x574600", Offset = "0x572E00", Length = "0x185")]
	private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData)
	{
	}

	[Token(Token = "0x6001026")]
	[Address(RVA = "0x5744B0", Offset = "0x572CB0", Length = "0x144")]
	private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId)
	{
	}

	[Token(Token = "0x6001027")]
	[Address(RVA = "0x574090", Offset = "0x572890", Length = "0x37A")]
	private void SaveControllerMap(Player player, ControllerMap controllerMap)
	{
	}

	[Address(RVA = "0x574A70", Offset = "0x573270", Length = "0xBF")]
	[Token(Token = "0x6001028")]
	private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData)
	{
	}

	[Token(Token = "0x6001029")]
	[Address(RVA = "0x5747E0", Offset = "0x572FE0", Length = "0x10A")]
	private void SaveInputBehaviorNow(int playerId, int behaviorId)
	{
	}

	[Token(Token = "0x600102A")]
	[Address(RVA = "0x574790", Offset = "0x572F90", Length = "0x49")]
	private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior)
	{
	}

	[Token(Token = "0x600102B")]
	[Address(RVA = "0x5739C0", Offset = "0x5721C0", Length = "0x4D2")]
	private bool SaveControllerAssignments()
	{
		return default(bool);
	}

	[Address(RVA = "0x56F280", Offset = "0x56DA80", Length = "0xA9")]
	[Token(Token = "0x600102C")]
	private bool ControllerAssignmentSaveDataExists()
	{
		return default(bool);
	}

	[Address(RVA = "0x56F510", Offset = "0x56DD10", Length = "0x62")]
	[Token(Token = "0x600102D")]
	private string GetBasePlayerPrefsKey(Player player)
	{
		return null;
	}

	[Address(RVA = "0x56FDF0", Offset = "0x56E5F0", Length = "0x107")]
	[Token(Token = "0x600102E")]
	private string GetControllerMapPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
	{
		return null;
	}

	[Token(Token = "0x600102F")]
	[Address(RVA = "0x56F580", Offset = "0x56DD80", Length = "0x107")]
	private string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
	{
		return null;
	}

	[Token(Token = "0x6001030")]
	[Address(RVA = "0x56F880", Offset = "0x56E080", Length = "0x566")]
	private static string GetControllerMapPlayerPrefsKeyCommonSuffix(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
	{
		return null;
	}

	[Address(RVA = "0x5706B0", Offset = "0x56EEB0", Length = "0x139")]
	[Token(Token = "0x6001031")]
	private string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick)
	{
		return null;
	}

	[Address(RVA = "0x570550", Offset = "0x56ED50", Length = "0xCA")]
	[Token(Token = "0x6001032")]
	private string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId)
	{
		return null;
	}

	[Token(Token = "0x6001033")]
	[Address(RVA = "0x570050", Offset = "0x56E850", Length = "0xBD")]
	private string GetControllerMapXml(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		return null;
	}

	[Address(RVA = "0x56F690", Offset = "0x56DE90", Length = "0x1E0")]
	[Token(Token = "0x6001034")]
	private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		return null;
	}

	[Address(RVA = "0x5707F0", Offset = "0x56EFF0", Length = "0x7A")]
	[Token(Token = "0x6001035")]
	private string GetJoystickCalibrationMapXml(Joystick joystick)
	{
		return null;
	}

	[Address(RVA = "0x570620", Offset = "0x56EE20", Length = "0x8F")]
	[Token(Token = "0x6001036")]
	private string GetInputBehaviorXml(Player player, int id)
	{
		return null;
	}

	[Token(Token = "0x6001037")]
	[Address(RVA = "0x56EE50", Offset = "0x56D650", Length = "0x421")]
	private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds)
	{
	}

	[Address(RVA = "0x56F330", Offset = "0x56DB30", Length = "0x1D6")]
	[Token(Token = "0x6001038")]
	private Joystick FindJoystickPrecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo)
	{
		return null;
	}

	[Address(RVA = "0x5751D0", Offset = "0x5739D0", Length = "0x25E")]
	[Token(Token = "0x6001039")]
	private bool TryFindJoysticksImprecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Joystick> matches)
	{
		matches = null;
		return default(bool);
	}

	[Address(RVA = "0x570110", Offset = "0x56E910", Length = "0x437")]
	[Token(Token = "0x600103A")]
	private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier)
	{
		return default(int);
	}

	[Token(Token = "0x600103B")]
	[Address(RVA = "0x573540", Offset = "0x571D40", Length = "0x91")]
	private void RefreshLayoutManager(int playerId)
	{
	}

	[Address(RVA = "0x56FF00", Offset = "0x56E700", Length = "0x141")]
	[Token(Token = "0x600103C")]
	private static Type GetControllerMapType(ControllerType controllerType)
	{
		return null;
	}

	[Token(Token = "0x600103D")]
	[Address(RVA = "0x575430", Offset = "0x573C30", Length = "0x55")]
	public UserDataStore_PlayerPrefs()
	{
	}
}
