using Assets.Scripts.UI.Panels.PnlRole;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace ArcadeController.UI.Panel.PnlMenu;

[Token(Token = "0x200054B")]
public class PageRole : PageAbstractHandler
{
	[Token(Token = "0x4001F8D")]
	[SerializeField]
	[FieldOffset(Offset = "0x60")]
	private PnlRoleFancyPanelDirectionControl m_PnlRoleFancyPanelDirectionControl;

	[SerializeField]
	[Token(Token = "0x4001F8E")]
	[FieldOffset(Offset = "0x68")]
	private PnlRoleMainShowControl m_PnlRoleMainShowControl;

	[SerializeField]
	[Token(Token = "0x4001F8F")]
	[FieldOffset(Offset = "0x70")]
	private PnlRoleSkinContainer m_PnlRoleSkinContainer;

	[Token(Token = "0x4001F90")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Transform m_PnlRoleSkinItemParent;

	[Token(Token = "0x4001F91")]
	[SerializeField]
	[FieldOffset(Offset = "0x80")]
	private Button m_BtnPrevious;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001F92")]
	[SerializeField]
	private Button m_BtnNext;

	[SerializeField]
	[Token(Token = "0x4001F93")]
	[FieldOffset(Offset = "0x90")]
	private Button m_BtnExorcistSound;

	[Token(Token = "0x4001F94")]
	[SerializeField]
	[FieldOffset(Offset = "0x98")]
	private GameObject m_IsImgSelect;

	[Token(Token = "0x6003771")]
	[Address(RVA = "0x599CB0", Offset = "0x5984B0", Length = "0x12")]
	public PageRole()
	{
	}
}
