using Assets.Scripts.UI.Panels.PnlRole;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000133")]
public class PnlRoleTopControl : PnlRoleSelectedItem
{
	[SerializeField]
	[Token(Token = "0x4000789")]
	[FieldOffset(Offset = "0x80")]
	private UISelectManage m_PnlRoleUISelectManage;

	[SerializeField]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400078A")]
	private PnlRoleSelectedItem m_DefaultSelectedItem;

	[Token(Token = "0x400078B")]
	[FieldOffset(Offset = "0x90")]
	private PnlRoleSelectedItem m_CurSelectedItem;

	[Token(Token = "0x60008AB")]
	[Address(RVA = "0x561E00", Offset = "0x560600", Length = "0x42")]
	private void Awake()
	{
	}

	[Token(Token = "0x60008AC")]
	[Address(RVA = "0x561FA0", Offset = "0x5607A0", Length = "0x56")]
	private void Update()
	{
	}

	[Token(Token = "0x60008AD")]
	[Address(RVA = "0x561E50", Offset = "0x560650", Length = "0x14D")]
	public override void SetCurrentChildToParent(PnlRoleSelectedItem item)
	{
	}

	[Token(Token = "0x60008AE")]
	[Address(RVA = "0x561DF0", Offset = "0x5605F0", Length = "0x7")]
	public PnlRoleTopControl()
	{
	}
}
