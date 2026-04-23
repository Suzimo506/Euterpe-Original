using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Rewired.Components;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI;

[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6E210", Offset = "0x6D610")]
[Token(Token = "0x20001F5")]
public sealed class RewiredStandaloneInputModule : RewiredPointerInputModule
{
	[Serializable]
	[Token(Token = "0x2000A78")]
	public class PlayerSetting
	{
		[Token(Token = "0x4003717")]
		[FieldOffset(Offset = "0x10")]
		public int playerId;

		[Token(Token = "0x4003718")]
		[FieldOffset(Offset = "0x18")]
		public List<Rewired.Components.PlayerMouse> playerMice;

		[Address(RVA = "0x89B6F0", Offset = "0x899EF0", Length = "0x69")]
		[Token(Token = "0x60059F7")]
		public PlayerSetting()
		{
		}

		[Address(RVA = "0x89B760", Offset = "0x899F60", Length = "0x1AB")]
		[Token(Token = "0x60059F8")]
		private PlayerSetting(PlayerSetting other)
		{
		}

		[Address(RVA = "0x89B690", Offset = "0x899E90", Length = "0x53")]
		[Token(Token = "0x60059F9")]
		public PlayerSetting Clone()
		{
			return null;
		}
	}

	[Token(Token = "0x4000DA2")]
	private const string DEFAULT_ACTION_MOVE_HORIZONTAL = "UIHorizontal";

	[Token(Token = "0x4000DA3")]
	private const string DEFAULT_ACTION_MOVE_VERTICAL = "UIVertical";

	[Token(Token = "0x4000DA4")]
	private const string DEFAULT_ACTION_SUBMIT = "UISubmit";

	[Token(Token = "0x4000DA5")]
	private const string DEFAULT_ACTION_CANCEL = "UICancel";

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E330", Offset = "0x6D730")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000DA6")]
	private InputManager_Base rewiredInputManager;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E600", Offset = "0x6DA00")]
	[Token(Token = "0x4000DA7")]
	[FieldOffset(Offset = "0x78")]
	private bool useAllRewiredGamePlayers;

	[SerializeField]
	[FieldOffset(Offset = "0x79")]
	[Token(Token = "0x4000DA8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E830", Offset = "0x6DC30")]
	private bool useRewiredSystemPlayer;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000DA9")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA90", Offset = "0x6DE90")]
	[SerializeField]
	private int[] rewiredPlayerIds;

	[Token(Token = "0x4000DAA")]
	[SerializeField]
	[FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC40", Offset = "0x6E040")]
	private bool usePlayingPlayersOnly;

	[SerializeField]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000DAB")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE10", Offset = "0x6E210")]
	private List<Rewired.Components.PlayerMouse> playerMice;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0D0", Offset = "0x6E4D0")]
	[Token(Token = "0x4000DAC")]
	[SerializeField]
	[FieldOffset(Offset = "0x98")]
	private bool moveOneElementPerAxisPress;

	[FieldOffset(Offset = "0x99")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3C0", Offset = "0x6E7C0")]
	[Token(Token = "0x4000DAD")]
	private bool setActionsById;

	[FieldOffset(Offset = "0x9C")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F590", Offset = "0x6E990")]
	[Token(Token = "0x4000DAE")]
	private int horizontalActionId;

	[SerializeField]
	[Token(Token = "0x4000DAF")]
	[FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F690", Offset = "0x6EA90")]
	private int verticalActionId;

	[SerializeField]
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000DB0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F890", Offset = "0x6EC90")]
	private int submitActionId;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x70FE0", Offset = "0x703E0")]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000DB1")]
	private int cancelActionId;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000DB2")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x71110", Offset = "0x70510")]
	[SerializeField]
	private string m_HorizontalAxis;

	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000DB3")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x712D0", Offset = "0x706D0")]
	[SerializeField]
	private string m_VerticalAxis;

	[Token(Token = "0x4000DB4")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x71530", Offset = "0x70930")]
	private string m_SubmitButton;

	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	[Token(Token = "0x4000DB5")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x71640", Offset = "0x70A40")]
	private string m_CancelButton;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x71870", Offset = "0x70C70")]
	[Token(Token = "0x4000DB6")]
	[SerializeField]
	[FieldOffset(Offset = "0xD0")]
	private float m_InputActionsPerSecond;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x71950", Offset = "0x70D50")]
	[Token(Token = "0x4000DB7")]
	[FieldOffset(Offset = "0xD4")]
	private float m_RepeatDelay;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x71B90", Offset = "0x70F90")]
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000DB8")]
	private bool m_allowMouseInput;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x71D70", Offset = "0x71170")]
	[FieldOffset(Offset = "0xD9")]
	[Token(Token = "0x4000DB9")]
	private bool m_allowMouseInputIfTouchSupported;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x71FB0", Offset = "0x713B0")]
	[Token(Token = "0x4000DBA")]
	[FieldOffset(Offset = "0xDA")]
	private bool m_allowTouchInput;

	[FieldOffset(Offset = "0xDB")]
	[Token(Token = "0x4000DBB")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x72200", Offset = "0x71600")]
	[SerializeField]
	private bool m_deselectIfBackgroundClicked;

	[FieldOffset(Offset = "0xDC")]
	[SerializeField]
	[Token(Token = "0x4000DBC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x72400", Offset = "0x71800")]
	private bool m_deselectBeforeSelecting;

	[SerializeField]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x72680", Offset = "0x71A80")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x72680", Offset = "0x71A80")]
	[Token(Token = "0x4000DBD")]
	[FieldOffset(Offset = "0xDD")]
	private bool m_ForceModuleActive;

	[NonSerialized]
	[Token(Token = "0x4000DBE")]
	[FieldOffset(Offset = "0xE0")]
	private int[] playerIds;

	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000DBF")]
	private bool recompiling;

	[NonSerialized]
	[FieldOffset(Offset = "0xE9")]
	[Token(Token = "0x4000DC0")]
	private bool isTouchSupported;

	[NonSerialized]
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000DC1")]
	private double m_PrevActionTime;

	[NonSerialized]
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000DC2")]
	private Vector2 m_LastMoveVector;

	[NonSerialized]
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000DC3")]
	private int m_ConsecutiveMoveCount;

	[NonSerialized]
	[Token(Token = "0x4000DC4")]
	[FieldOffset(Offset = "0x104")]
	private bool m_HasFocus;

	[Token(Token = "0x17000322")]
	public InputManager_Base RewiredInputManager
	{
		[Address(RVA = "0x462D00", Offset = "0x461500", Length = "0x5")]
		[Token(Token = "0x6001073")]
		get
		{
			return null;
		}
		[Address(RVA = "0x422030", Offset = "0x420830", Length = "0xC")]
		[Token(Token = "0x6001074")]
		set
		{
		}
	}

	[Token(Token = "0x17000323")]
	public bool UseAllRewiredGamePlayers
	{
		[Token(Token = "0x6001075")]
		[Address(RVA = "0x8A0EA0", Offset = "0x89F6A0", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001076")]
		[Address(RVA = "0x8A1520", Offset = "0x89FD20", Length = "0x13")]
		set
		{
		}
	}

	[Token(Token = "0x17000324")]
	public bool UseRewiredSystemPlayer
	{
		[Address(RVA = "0x8A0EB0", Offset = "0x89F6B0", Length = "0x5")]
		[Token(Token = "0x6001077")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x8A1540", Offset = "0x89FD40", Length = "0x13")]
		[Token(Token = "0x6001078")]
		set
		{
		}
	}

	[Token(Token = "0x17000325")]
	public int[] RewiredPlayerIds
	{
		[Token(Token = "0x6001079")]
		[Address(RVA = "0x8A0E10", Offset = "0x89F610", Length = "0x79")]
		get
		{
			return null;
		}
		[Token(Token = "0x600107A")]
		[Address(RVA = "0x8A12F0", Offset = "0x89FAF0", Length = "0xAF")]
		set
		{
		}
	}

	[Token(Token = "0x17000326")]
	public bool UsePlayingPlayersOnly
	{
		[Token(Token = "0x600107B")]
		[Address(RVA = "0x44E3B0", Offset = "0x44CBB0", Length = "0x8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600107C")]
		[Address(RVA = "0x44E420", Offset = "0x44CC20", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x17000327")]
	public List<Rewired.Components.PlayerMouse> PlayerMice
	{
		[Address(RVA = "0x8A0DB0", Offset = "0x89F5B0", Length = "0x5E")]
		[Token(Token = "0x600107D")]
		get
		{
			return null;
		}
		[Token(Token = "0x600107E")]
		[Address(RVA = "0x8A1250", Offset = "0x89FA50", Length = "0x9F")]
		set
		{
		}
	}

	[Token(Token = "0x17000328")]
	public bool MoveOneElementPerAxisPress
	{
		[Address(RVA = "0x432400", Offset = "0x430C00", Length = "0x8")]
		[Token(Token = "0x600107F")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001080")]
		[Address(RVA = "0x89A130", Offset = "0x898930", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x17000329")]
	public bool allowMouseInput
	{
		[Address(RVA = "0x749390", Offset = "0x747B90", Length = "0x8")]
		[Token(Token = "0x6001081")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x7496C0", Offset = "0x747EC0", Length = "0x7")]
		[Token(Token = "0x6001082")]
		set
		{
		}
	}

	[Token(Token = "0x1700032A")]
	public bool allowMouseInputIfTouchSupported
	{
		[Address(RVA = "0x8A0EE0", Offset = "0x89F6E0", Length = "0x8")]
		[Token(Token = "0x6001083")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001084")]
		[Address(RVA = "0x8A16D0", Offset = "0x89FED0", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x1700032B")]
	public bool allowTouchInput
	{
		[Address(RVA = "0x8A0EF0", Offset = "0x89F6F0", Length = "0x8")]
		[Token(Token = "0x6001085")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x8A16E0", Offset = "0x89FEE0", Length = "0x7")]
		[Token(Token = "0x6001086")]
		set
		{
		}
	}

	[Token(Token = "0x1700032C")]
	public bool deselectIfBackgroundClicked
	{
		[Token(Token = "0x6001087")]
		[Address(RVA = "0x8A0F10", Offset = "0x89F710", Length = "0x8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001088")]
		[Address(RVA = "0x8A1820", Offset = "0x8A0020", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x1700032D")]
	private bool deselectBeforeSelecting
	{
		[Address(RVA = "0x8A0F00", Offset = "0x89F700", Length = "0x8")]
		[Token(Token = "0x6001089")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600108A")]
		[Address(RVA = "0x8A1810", Offset = "0x8A0010", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x1700032E")]
	public bool SetActionsById
	{
		[Token(Token = "0x600108B")]
		[Address(RVA = "0x8997C0", Offset = "0x897FC0", Length = "0x8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600108C")]
		[Address(RVA = "0x8A13A0", Offset = "0x89FBA0", Length = "0x16")]
		set
		{
		}
	}

	[Token(Token = "0x1700032F")]
	public int HorizontalActionId
	{
		[Address(RVA = "0x8A0DA0", Offset = "0x89F5A0", Length = "0x7")]
		[Token(Token = "0x600108D")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x8A10F0", Offset = "0x89F8F0", Length = "0x159")]
		[Token(Token = "0x600108E")]
		set
		{
		}
	}

	[Token(Token = "0x17000330")]
	public int VerticalActionId
	{
		[Address(RVA = "0x8A0EC0", Offset = "0x89F6C0", Length = "0x7")]
		[Token(Token = "0x600108F")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001090")]
		[Address(RVA = "0x8A1560", Offset = "0x89FD60", Length = "0x159")]
		set
		{
		}
	}

	[Token(Token = "0x17000331")]
	public int SubmitActionId
	{
		[Token(Token = "0x6001091")]
		[Address(RVA = "0x8A0E90", Offset = "0x89F690", Length = "0x7")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001092")]
		[Address(RVA = "0x8A13C0", Offset = "0x89FBC0", Length = "0x159")]
		set
		{
		}
	}

	[Token(Token = "0x17000332")]
	public int CancelActionId
	{
		[Token(Token = "0x6001093")]
		[Address(RVA = "0x8A0D90", Offset = "0x89F590", Length = "0x7")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x8A0F90", Offset = "0x89F790", Length = "0x159")]
		[Token(Token = "0x6001094")]
		set
		{
		}
	}

	[Token(Token = "0x17000333")]
	protected override bool isMouseSupported
	{
		[Address(RVA = "0x8A0F30", Offset = "0x89F730", Length = "0x43")]
		[Token(Token = "0x6001095")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000334")]
	private bool isTouchAllowed
	{
		[Address(RVA = "0x8A0EF0", Offset = "0x89F6F0", Length = "0x8")]
		[Token(Token = "0x6001096")]
		get
		{
			return default(bool);
		}
	}

	[Obsolete]
	[Token(Token = "0x17000335")]
	public bool allowActivationOnMobileDevice
	{
		[Address(RVA = "0x8A0ED0", Offset = "0x89F6D0", Length = "0x8")]
		[Token(Token = "0x6001097")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x8A16C0", Offset = "0x89FEC0", Length = "0x7")]
		[Token(Token = "0x6001098")]
		set
		{
		}
	}

	[Token(Token = "0x17000336")]
	public bool forceModuleActive
	{
		[Token(Token = "0x6001099")]
		[Address(RVA = "0x8A0ED0", Offset = "0x89F6D0", Length = "0x8")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x8A16C0", Offset = "0x89FEC0", Length = "0x7")]
		[Token(Token = "0x600109A")]
		set
		{
		}
	}

	[Token(Token = "0x17000337")]
	public float inputActionsPerSecond
	{
		[Address(RVA = "0x8A0F20", Offset = "0x89F720", Length = "0x9")]
		[Token(Token = "0x600109B")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600109C")]
		[Address(RVA = "0x8A1950", Offset = "0x8A0150", Length = "0x9")]
		set
		{
		}
	}

	[Token(Token = "0x17000338")]
	public float repeatDelay
	{
		[Address(RVA = "0x8A0F80", Offset = "0x89F780", Length = "0x9")]
		[Token(Token = "0x600109D")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600109E")]
		[Address(RVA = "0x8A1960", Offset = "0x8A0160", Length = "0x9")]
		set
		{
		}
	}

	[Token(Token = "0x17000339")]
	public string horizontalAxis
	{
		[Token(Token = "0x600109F")]
		[Address(RVA = "0x49A8E0", Offset = "0x4990E0", Length = "0x8")]
		get
		{
			return null;
		}
		[Address(RVA = "0x8A1830", Offset = "0x8A0030", Length = "0x11E")]
		[Token(Token = "0x60010A0")]
		set
		{
		}
	}

	[Token(Token = "0x1700033A")]
	public string verticalAxis
	{
		[Token(Token = "0x60010A1")]
		[Address(RVA = "0x49A890", Offset = "0x499090", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60010A2")]
		[Address(RVA = "0x8A1A90", Offset = "0x8A0290", Length = "0x11E")]
		set
		{
		}
	}

	[Token(Token = "0x1700033B")]
	public string submitButton
	{
		[Address(RVA = "0x49A8D0", Offset = "0x4990D0", Length = "0x8")]
		[Token(Token = "0x60010A3")]
		get
		{
			return null;
		}
		[Address(RVA = "0x8A1970", Offset = "0x8A0170", Length = "0x11E")]
		[Token(Token = "0x60010A4")]
		set
		{
		}
	}

	[Token(Token = "0x1700033C")]
	public string cancelButton
	{
		[Token(Token = "0x60010A5")]
		[Address(RVA = "0x460220", Offset = "0x45EA20", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60010A6")]
		[Address(RVA = "0x8A16F0", Offset = "0x89FEF0", Length = "0x11E")]
		set
		{
		}
	}

	[Token(Token = "0x60010A7")]
	[Address(RVA = "0x8A0C70", Offset = "0x89F470", Length = "0x11F")]
	private RewiredStandaloneInputModule()
	{
	}

	[Address(RVA = "0x89C4E0", Offset = "0x89ACE0", Length = "0x118")]
	[Token(Token = "0x60010A8")]
	protected override void Awake()
	{
	}

	[Address(RVA = "0x8A0B00", Offset = "0x89F300", Length = "0x16C")]
	[Token(Token = "0x60010A9")]
	public override void UpdateModule()
	{
	}

	[Address(RVA = "0x526C70", Offset = "0x525470", Length = "0x3")]
	[Token(Token = "0x60010AA")]
	public override bool IsModuleSupported()
	{
		return default(bool);
	}

	[Address(RVA = "0x8A0400", Offset = "0x89EC00", Length = "0x627")]
	[Token(Token = "0x60010AB")]
	public override bool ShouldActivateModule()
	{
		return default(bool);
	}

	[Address(RVA = "0x89C400", Offset = "0x89AC00", Length = "0xDE")]
	[Token(Token = "0x60010AC")]
	public override void ActivateModule()
	{
	}

	[Address(RVA = "0x89C8D0", Offset = "0x89B0D0", Length = "0x1F")]
	[Token(Token = "0x60010AD")]
	public override void DeactivateModule()
	{
	}

	[Token(Token = "0x60010AE")]
	[Address(RVA = "0x89EEB0", Offset = "0x89D6B0", Length = "0x29C")]
	public override void Process()
	{
	}

	[Token(Token = "0x60010AF")]
	[Address(RVA = "0x89E3C0", Offset = "0x89CBC0", Length = "0x308")]
	private bool ProcessTouchEvents()
	{
		return default(bool);
	}

	[Token(Token = "0x60010B0")]
	[Address(RVA = "0x89E6D0", Offset = "0x89CED0", Length = "0x7DA")]
	private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
	{
	}

	[Token(Token = "0x60010B1")]
	[Address(RVA = "0x89F580", Offset = "0x89DD80", Length = "0x24C")]
	private bool SendSubmitEventToSelectedObject()
	{
		return default(bool);
	}

	[Address(RVA = "0x89CD40", Offset = "0x89B540", Length = "0x3C0")]
	[Token(Token = "0x60010B2")]
	private Vector2 GetRawMoveVector()
	{
		return default(Vector2);
	}

	[Address(RVA = "0x89F150", Offset = "0x89D950", Length = "0x428")]
	[Token(Token = "0x60010B3")]
	private bool SendMoveEventToSelectedObject()
	{
		return default(bool);
	}

	[Address(RVA = "0x89C600", Offset = "0x89AE00", Length = "0x1B4")]
	[Token(Token = "0x60010B4")]
	private void CheckButtonOrKeyMovement(out bool downHorizontal, out bool downVertical)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref downHorizontal) = null;
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref downVertical) = null;
	}

	[Address(RVA = "0x89DC00", Offset = "0x89C400", Length = "0x18E")]
	[Token(Token = "0x60010B5")]
	private void ProcessMouseEvents()
	{
	}

	[Address(RVA = "0x89D810", Offset = "0x89C010", Length = "0x3EE")]
	[Token(Token = "0x60010B6")]
	private void ProcessMouseEvent(int playerId, int pointerIndex)
	{
	}

	[Address(RVA = "0x89F7D0", Offset = "0x89DFD0", Length = "0x155")]
	[Token(Token = "0x60010B7")]
	private bool SendUpdateEventToSelectedObject()
	{
		return default(bool);
	}

	[Address(RVA = "0x89DD90", Offset = "0x89C590", Length = "0x626")]
	[Token(Token = "0x60010B8")]
	private void ProcessMousePress(MouseButtonEventData data)
	{
	}

	[Address(RVA = "0x89D110", Offset = "0x89B910", Length = "0x1E6")]
	[Token(Token = "0x60010B9")]
	private void HandleMouseTouchDeselectionOnSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
	{
	}

	[Token(Token = "0x60010BA")]
	[Address(RVA = "0x89D6C0", Offset = "0x89BEC0", Length = "0x7")]
	private void OnApplicationFocus(bool hasFocus)
	{
	}

	[Token(Token = "0x60010BB")]
	[Address(RVA = "0x8A0A30", Offset = "0x89F230", Length = "0xCE")]
	private bool ShouldIgnoreEventsOnNoFocus()
	{
		return default(bool);
	}

	[Token(Token = "0x60010BC")]
	[Address(RVA = "0x89D6D0", Offset = "0x89BED0", Length = "0xE4")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60010BD")]
	[Address(RVA = "0x89D4C0", Offset = "0x89BCC0", Length = "0x1F6")]
	protected override bool IsDefaultPlayer(int playerId)
	{
		return default(bool);
	}

	[Address(RVA = "0x89D300", Offset = "0x89BB00", Length = "0x1C0")]
	[Token(Token = "0x60010BE")]
	private void InitializeRewired()
	{
	}

	[Token(Token = "0x60010BF")]
	[Address(RVA = "0x89FE00", Offset = "0x89E600", Length = "0x5FD")]
	private void SetupRewiredVars()
	{
	}

	[Address(RVA = "0x89FC90", Offset = "0x89E490", Length = "0x167")]
	[Token(Token = "0x60010C0")]
	private void SetUpRewiredPlayerMice()
	{
	}

	[Address(RVA = "0x89F930", Offset = "0x89E130", Length = "0x35B")]
	[Token(Token = "0x60010C1")]
	private void SetUpRewiredActions()
	{
	}

	[Address(RVA = "0x89CB00", Offset = "0x89B300", Length = "0x32")]
	[Token(Token = "0x60010C2")]
	private bool GetButton(Player player, int actionId)
	{
		return default(bool);
	}

	[Token(Token = "0x60010C3")]
	[Address(RVA = "0x89CAC0", Offset = "0x89B2C0", Length = "0x32")]
	private bool GetButtonDown(Player player, int actionId)
	{
		return default(bool);
	}

	[Token(Token = "0x60010C4")]
	[Address(RVA = "0x89CD00", Offset = "0x89B500", Length = "0x32")]
	private bool GetNegativeButton(Player player, int actionId)
	{
		return default(bool);
	}

	[Token(Token = "0x60010C5")]
	[Address(RVA = "0x89CCC0", Offset = "0x89B4C0", Length = "0x32")]
	private bool GetNegativeButtonDown(Player player, int actionId)
	{
		return default(bool);
	}

	[Address(RVA = "0x89CA80", Offset = "0x89B280", Length = "0x33")]
	[Token(Token = "0x60010C6")]
	private float GetAxis(Player player, int actionId)
	{
		return default(float);
	}

	[Token(Token = "0x60010C7")]
	[Address(RVA = "0x89C7C0", Offset = "0x89AFC0", Length = "0xC5")]
	private void CheckEditorRecompile()
	{
	}

	[Token(Token = "0x60010C8")]
	[Address(RVA = "0x89D7C0", Offset = "0x89BFC0", Length = "0x3E")]
	private void OnEditorRecompile()
	{
	}

	[Token(Token = "0x60010C9")]
	[Address(RVA = "0x89C890", Offset = "0x89B090", Length = "0x37")]
	private void ClearRewiredVars()
	{
	}

	[Token(Token = "0x60010CA")]
	[Address(RVA = "0x89C8F0", Offset = "0x89B0F0", Length = "0x186")]
	private bool DidAnyMouseMove()
	{
		return default(bool);
	}

	[Address(RVA = "0x89CB40", Offset = "0x89B340", Length = "0x174")]
	[Token(Token = "0x60010CB")]
	private bool GetMouseButtonDownOnAnyMouse(int buttonIndex)
	{
		return default(bool);
	}

	[Address(RVA = "0x89D800", Offset = "0x89C000", Length = "0x7")]
	[Token(Token = "0x60010CC")]
	private void OnRewiredInitialized()
	{
	}

	[Address(RVA = "0x89C890", Offset = "0x89B090", Length = "0x37")]
	[Token(Token = "0x60010CD")]
	private void OnRewiredShutDown()
	{
	}
}
