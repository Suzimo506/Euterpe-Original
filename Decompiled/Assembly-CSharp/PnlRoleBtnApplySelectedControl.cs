using Assets.Scripts.UI.Panels.PnlRole;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000132")]
public class PnlRoleBtnApplySelectedControl : PnlRoleSelectedItem
{
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000787")]
	[SerializeField]
	private GameObject m_SelectedObj;

	[SerializeField]
	[Token(Token = "0x4000788")]
	[FieldOffset(Offset = "0x88")]
	private Button m_BtnApply;

	[Token(Token = "0x60008A4")]
	[Address(RVA = "0x561C10", Offset = "0x560410", Length = "0xD1")]
	private void Awake()
	{
	}

	[Token(Token = "0x60008A5")]
	[Address(RVA = "0x561D60", Offset = "0x560560", Length = "0x30")]
	public override void OnSelected()
	{
	}

	[Token(Token = "0x60008A6")]
	[Address(RVA = "0x561D20", Offset = "0x560520", Length = "0x30")]
	public override void OnDeselected()
	{
	}

	[Token(Token = "0x60008A7")]
	[Address(RVA = "0x561CF0", Offset = "0x5604F0", Length = "0x23")]
	public override bool IsSelectedValid()
	{
		return default(bool);
	}

	[Token(Token = "0x60008A8")]
	[Address(RVA = "0x561DF0", Offset = "0x5605F0", Length = "0x7")]
	public PnlRoleBtnApplySelectedControl()
	{
	}
}
