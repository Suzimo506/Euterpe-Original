using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace ArcadeController.UI.Panel.PnlPreparation;

[Token(Token = "0x2000545")]
public class PagePreparation : PageAbstractHandler
{
	[SerializeField]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001F84")]
	private Button m_BtnSwitchL;

	[SerializeField]
	[Token(Token = "0x4001F85")]
	[FieldOffset(Offset = "0x68")]
	private Button m_BtnSwitchR;

	[Address(RVA = "0x599CB0", Offset = "0x5984B0", Length = "0x12")]
	[Token(Token = "0x600376B")]
	public PagePreparation()
	{
	}
}
