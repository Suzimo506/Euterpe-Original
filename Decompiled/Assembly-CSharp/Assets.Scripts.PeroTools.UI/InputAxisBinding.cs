using System.Collections.Generic;
using Assets.Scripts.GameCore.Interface;
using Assets.Scripts.PeroTools.Managers;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.UI;

[Token(Token = "0x20005AF")]
public class InputAxisBinding : MonoBehaviour, IInputKeyBinding
{
	[Token(Token = "0x2000BA4")]
	public enum Type
	{
		[Token(Token = "0x4003AD9")]
		Button,
		[Token(Token = "0x4003ADA")]
		Axis
	}

	[Token(Token = "0x4002116")]
	[FieldOffset(Offset = "0x18")]
	private UISelectManage m_UiManage;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002117")]
	public Type type;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002118")]
	public string negative;

	[Token(Token = "0x4002119")]
	[FieldOffset(Offset = "0x30")]
	public string positive;

	[Token(Token = "0x400211A")]
	[FieldOffset(Offset = "0x38")]
	public string axisName;

	[Token(Token = "0x400211B")]
	[FieldOffset(Offset = "0x40")]
	public bool loopToggleGroup;

	[Token(Token = "0x400211C")]
	[FieldOffset(Offset = "0x48")]
	private List<Toggle> m_AllToggles;

	[Token(Token = "0x400211D")]
	[FieldOffset(Offset = "0x50")]
	private ToggleGroup m_ToggleGroup;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400211E")]
	private string m_Guid;

	[Token(Token = "0x400211F")]
	[FieldOffset(Offset = "0x60")]
	private bool m_IsAxisInUse;

	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4002120")]
	private int m_Appen;

	[Token(Token = "0x4002121")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x940D0", Offset = "0x934D0")]
	[FieldOffset(Offset = "0x68")]
	public bool hasInertia;

	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4002122")]
	public float inertia;

	[Token(Token = "0x4002123")]
	[FieldOffset(Offset = "0x70")]
	public float inertiaTime;

	[Token(Token = "0x4002124")]
	[FieldOffset(Offset = "0x74")]
	private int m_InertiaVaule;

	[Token(Token = "0x4002125")]
	[FieldOffset(Offset = "0x78")]
	private Sequence m_Sequence;

	[Token(Token = "0x4002126")]
	[FieldOffset(Offset = "0x80")]
	private UnityGameManager m_UnityGameManager;

	[Token(Token = "0x1700053B")]
	public UISelectManage GetPanelOrder
	{
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		[Token(Token = "0x6003930")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700053C")]
	public bool IsOnCurrentPanel
	{
		[Address(RVA = "0x97D170", Offset = "0x97B970", Length = "0x8F")]
		[Token(Token = "0x6003931")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x97D200", Offset = "0x97BA00", Length = "0x63")]
	[Token(Token = "0x600392E")]
	private bool m_IsHasScrollBar()
	{
		return default(bool);
	}

	[Token(Token = "0x600392F")]
	[Address(RVA = "0x97CFF0", Offset = "0x97B7F0", Length = "0xE8")]
	public void SetPanelOrder(UISelectManage uiManage)
	{
	}

	[Address(RVA = "0x97C6C0", Offset = "0x97AEC0", Length = "0x1BC")]
	[Token(Token = "0x6003932")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003933")]
	[Address(RVA = "0x97CF60", Offset = "0x97B760", Length = "0x83")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x97C880", Offset = "0x97B080", Length = "0x487")]
	[Token(Token = "0x6003934")]
	private void ListenKeyPress(float arg0)
	{
	}

	[Address(RVA = "0x97CD10", Offset = "0x97B510", Length = "0x245")]
	[Token(Token = "0x6003935")]
	public void MoveToggleGroup(ToggleGroup tglGroup, int append)
	{
	}

	[Address(RVA = "0x97D0F0", Offset = "0x97B8F0", Length = "0x77")]
	[Token(Token = "0x6003936")]
	public InputAxisBinding()
	{
	}
}
