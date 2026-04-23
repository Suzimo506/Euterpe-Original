using System.Collections.Generic;
using Assets.Scripts.GameCore.Interface;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.UI;

[Token(Token = "0x20005B0")]
public class InputKeyBinding : MonoBehaviour, IInputKeyBinding
{
	[Token(Token = "0x2000BA6")]
	public enum Type
	{
		[Token(Token = "0x4003ADD")]
		Button,
		[Token(Token = "0x4003ADE")]
		AxisPositive,
		[Token(Token = "0x4003ADF")]
		AxisNegative
	}

	[Token(Token = "0x4002127")]
	[FieldOffset(Offset = "0x18")]
	private UISelectManage m_UiManage;

	[Token(Token = "0x4002128")]
	[FieldOffset(Offset = "0x20")]
	public Type btnType;

	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x942E0", Offset = "0x936E0")]
	[Token(Token = "0x4002129")]
	public string buttonName;

	[Token(Token = "0x400212A")]
	[FieldOffset(Offset = "0x30")]
	public string axisName;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400212B")]
	public float axisSpeed;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400212C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x943E0", Offset = "0x937E0")]
	public InputKeyBinding excludeButton;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400212D")]
	private ReuseScorllRect m_ReuseScorllRect;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400212E")]
	private Scrollbar m_Scrollbar;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400212F")]
	private Slider m_Slider;

	[Token(Token = "0x4002130")]
	[FieldOffset(Offset = "0x60")]
	public bool checkOtherActivePnl;

	[Token(Token = "0x4002131")]
	[FieldOffset(Offset = "0x61")]
	public bool onlyKeyboard;

	[Token(Token = "0x4002132")]
	[FieldOffset(Offset = "0x62")]
	public bool ignorePnlCheck;

	[FieldOffset(Offset = "0x63")]
	[Token(Token = "0x4002133")]
	private bool m_IsAxisInUse;

	[Token(Token = "0x4002134")]
	private static List<InputKeyBinding> m_InputKeyBindings;

	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4002135")]
	private bool m_AixsLongPress;

	[FieldOffset(Offset = "0x65")]
	[Token(Token = "0x4002136")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x94500", Offset = "0x93900")]
	public bool disableSimpleKey;

	[Token(Token = "0x4002137")]
	[FieldOffset(Offset = "0x66")]
	public bool IsPressUpInvok;

	[Token(Token = "0x4002138")]
	[FieldOffset(Offset = "0x67")]
	public bool IsNeedMouseUpInvokEvent;

	[Token(Token = "0x4002139")]
	[FieldOffset(Offset = "0x68")]
	private bool m_IsPress;

	[Token(Token = "0x400213A")]
	private static bool s_ThisKeyInvoke;

	[Token(Token = "0x1700053D")]
	public UISelectManage GetPanelOrder
	{
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		[Token(Token = "0x600393D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700053E")]
	public bool IsOnCurrentPanel
	{
		[Token(Token = "0x600393E")]
		[Address(RVA = "0x97E470", Offset = "0x97CC70", Length = "0x27")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700053F")]
	public bool isBlockAllKey
	{
		[Address(RVA = "0x97E4A0", Offset = "0x97CCA0", Length = "0xB7")]
		[Token(Token = "0x600393F")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x97D310", Offset = "0x97BB10", Length = "0x86")]
	[Token(Token = "0x6003938")]
	private bool IsGetExcludeButtonDown()
	{
		return default(bool);
	}

	[Address(RVA = "0x97D3A0", Offset = "0x97BBA0", Length = "0x58")]
	[Token(Token = "0x6003939")]
	private bool IsReuseScorllRect()
	{
		return default(bool);
	}

	[Address(RVA = "0x97D400", Offset = "0x97BC00", Length = "0x58")]
	[Token(Token = "0x600393A")]
	private bool IsScrollBar()
	{
		return default(bool);
	}

	[Token(Token = "0x600393B")]
	[Address(RVA = "0x97D300", Offset = "0x97BB00", Length = "0x8")]
	private bool ExceptButton()
	{
		return default(bool);
	}

	[Token(Token = "0x600393C")]
	[Address(RVA = "0x97DAA0", Offset = "0x97C2A0", Length = "0xE8")]
	public void SetPanelOrder(UISelectManage uiManage)
	{
	}

	[Token(Token = "0x6003940")]
	[Address(RVA = "0x97D4D0", Offset = "0x97BCD0", Length = "0x31A")]
	private void PressDown()
	{
	}

	[Address(RVA = "0x97D7F0", Offset = "0x97BFF0", Length = "0x2A6")]
	[Token(Token = "0x6003941")]
	private void PressUp()
	{
	}

	[Token(Token = "0x6003942")]
	[Address(RVA = "0x97D4A0", Offset = "0x97BCA0", Length = "0x2E")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x97D270", Offset = "0x97BA70", Length = "0x83")]
	[Token(Token = "0x6003943")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003944")]
	[Address(RVA = "0x97DB90", Offset = "0x97C390", Length = "0x8C9")]
	private void Update()
	{
	}

	[Token(Token = "0x6003945")]
	[Address(RVA = "0x97D460", Offset = "0x97BC60", Length = "0x36")]
	private void LateUpdate()
	{
	}

	[Address(RVA = "0x97E460", Offset = "0x97CC60", Length = "0xE")]
	[Token(Token = "0x6003946")]
	public InputKeyBinding()
	{
	}
}
