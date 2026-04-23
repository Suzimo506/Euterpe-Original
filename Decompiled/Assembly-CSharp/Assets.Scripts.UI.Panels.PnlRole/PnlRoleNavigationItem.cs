using Assets.Scripts.UI.Redot.RoleSelectRedot;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlRole;

[Token(Token = "0x2000964")]
public class PnlRoleNavigationItem : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4003362")]
	[SerializeField]
	private Image m_ImgInUse;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4003363")]
	[SerializeField]
	private Image m_ImgRandom;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4003364")]
	[SerializeField]
	private Image m_ImgRole;

	[SerializeField]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4003365")]
	private LongSongNameController m_TxtRoleNameController;

	[Token(Token = "0x4003366")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject m_SpecialObj;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4003367")]
	[SerializeField]
	private GameObject m_LockedObj;

	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4003368")]
	private GameObject m_ImgTryOutObj;

	[Token(Token = "0x4003369")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Color m_SelectedColor;

	[SerializeField]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400336A")]
	private Color m_DeselectedColor;

	[SerializeField]
	[Token(Token = "0x400336B")]
	[FieldOffset(Offset = "0x70")]
	private RolePreviewRedot m_Redot;

	[Token(Token = "0x6005598")]
	[Address(RVA = "0x63B040", Offset = "0x639840", Length = "0x193")]
	public void ShowByNavigationInfo(PnlRoleNavigationView.NavigationInfo navigationInfo)
	{
	}

	[Token(Token = "0x6005599")]
	[Address(RVA = "0x63AEB0", Offset = "0x6396B0", Length = "0xB4")]
	public void InitItemRedot(PnlRoleNavigationView.NavigationInfo navigationInfo)
	{
	}

	[Token(Token = "0x600559A")]
	[Address(RVA = "0x63AF70", Offset = "0x639770", Length = "0xCB")]
	public void RefreshItemRedotData(PnlRoleNavigationView.NavigationInfo navigationInfo)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600559B")]
	public PnlRoleNavigationItem()
	{
	}
}
