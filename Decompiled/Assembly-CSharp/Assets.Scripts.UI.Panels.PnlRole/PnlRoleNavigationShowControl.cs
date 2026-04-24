using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlRole;

[Token(Token = "0x2000965")]
public class PnlRoleNavigationShowControl : PnlRoleSelectedItem
{
	[SerializeField]
	[Token(Token = "0x400336C")]
	[FieldOffset(Offset = "0x80")]
	private List<PnlRoleSelectedItem> m_SelectedChildList;

	[SerializeField]
	[Token(Token = "0x400336D")]
	[FieldOffset(Offset = "0x88")]
	private Button m_BtnBack;

	[Address(RVA = "0x63B1E0", Offset = "0x6399E0", Length = "0xD6")]
	[Token(Token = "0x600559C")]
	private void Awake()
	{
	}

	[Address(RVA = "0x63A310", Offset = "0x638B10", Length = "0x2A")]
	[Token(Token = "0x600559D")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x63B2C0", Offset = "0x639AC0", Length = "0xB8")]
	[Token(Token = "0x600559E")]
	public override void ButtonActionInvoke()
	{
	}

	[Token(Token = "0x600559F")]
	[Address(RVA = "0x63B3D0", Offset = "0x639BD0", Length = "0x50")]
	public override void OnSelected()
	{
	}

	[Address(RVA = "0x63B380", Offset = "0x639B80", Length = "0x4A")]
	[Token(Token = "0x60055A0")]
	private void CloseNavigation()
	{
	}

	[Address(RVA = "0x561DF0", Offset = "0x5605F0", Length = "0x7")]
	[Token(Token = "0x60055A1")]
	public PnlRoleNavigationShowControl()
	{
	}
}
