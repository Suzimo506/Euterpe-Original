using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlAccount;

[Token(Token = "0x2000909")]
public class PnlDlcInfo : BaseMessageBox
{
	[SerializeField]
	[Token(Token = "0x400308A")]
	[FieldOffset(Offset = "0xF0")]
	private Transform m_DlcInfo;

	[SerializeField]
	[Token(Token = "0x400308B")]
	[FieldOffset(Offset = "0xF8")]
	private Transform m_InfoPos;

	[Token(Token = "0x400308C")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private Transform m_DlcPos;

	[SerializeField]
	[Token(Token = "0x400308D")]
	[FieldOffset(Offset = "0x108")]
	private Button m_ReLogin;

	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x400308E")]
	private bool isUnlockAll;

	[Token(Token = "0x600521A")]
	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	public PnlDlcInfo()
	{
	}
}
