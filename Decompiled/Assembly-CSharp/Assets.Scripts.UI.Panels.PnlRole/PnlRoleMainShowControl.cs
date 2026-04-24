using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlRole;

[Token(Token = "0x2000962")]
public class PnlRoleMainShowControl : PnlRoleSelectedItem
{
	[SerializeField]
	[Token(Token = "0x400335A")]
	[FieldOffset(Offset = "0x80")]
	private List<PnlRoleSelectedItem> m_SelectedChildList;

	[SerializeField]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400335B")]
	private List<PnlRoleSelectedItem> m_ExtraAllTimeSelectedItemList;

	[Token(Token = "0x400335C")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Button m_BtnNavigation;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400335D")]
	private Dictionary<PnlRoleSelectedItem, int> m_ChildToIndexMapping;

	[Token(Token = "0x400335E")]
	[FieldOffset(Offset = "0xA0")]
	private int m_CurIndex;

	[Address(RVA = "0x639F20", Offset = "0x638720", Length = "0x2E7")]
	[Token(Token = "0x600558A")]
	private void Awake()
	{
	}

	[Token(Token = "0x600558B")]
	[Address(RVA = "0x63A570", Offset = "0x638D70", Length = "0x6C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600558C")]
	[Address(RVA = "0x63AB40", Offset = "0x639340", Length = "0x13D")]
	private void TurnUp()
	{
	}

	[Token(Token = "0x600558D")]
	[Address(RVA = "0x63A9C0", Offset = "0x6391C0", Length = "0x179")]
	private void TurnDown()
	{
	}

	[Address(RVA = "0x63A7B0", Offset = "0x638FB0", Length = "0x201")]
	[Token(Token = "0x600558E")]
	private void TurnByAxis(float value)
	{
	}

	[Token(Token = "0x600558F")]
	[Address(RVA = "0x63A340", Offset = "0x638B40", Length = "0x149")]
	private bool CheckSelectedValid()
	{
		return default(bool);
	}

	[Address(RVA = "0x63A210", Offset = "0x638A10", Length = "0xFD")]
	[Token(Token = "0x6005590")]
	public override void ButtonActionInvoke()
	{
	}

	[Address(RVA = "0x63A6B0", Offset = "0x638EB0", Length = "0xFB")]
	[Token(Token = "0x6005591")]
	public override void SetCurrentChildToParent(PnlRoleSelectedItem item)
	{
	}

	[Address(RVA = "0x63A5E0", Offset = "0x638DE0", Length = "0xC7")]
	[Token(Token = "0x6005592")]
	public override void OnSelected()
	{
	}

	[Address(RVA = "0x63A490", Offset = "0x638C90", Length = "0xD1")]
	[Token(Token = "0x6005593")]
	public override void OnDeselected()
	{
	}

	[Token(Token = "0x6005594")]
	[Address(RVA = "0x63A310", Offset = "0x638B10", Length = "0x2A")]
	private void ChangeNavigation(bool value)
	{
	}

	[Token(Token = "0x6005595")]
	[Address(RVA = "0x63AC80", Offset = "0x639480", Length = "0x6C")]
	public PnlRoleMainShowControl()
	{
	}
}
