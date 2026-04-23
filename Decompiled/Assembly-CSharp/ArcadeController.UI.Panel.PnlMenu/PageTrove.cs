using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace ArcadeController.UI.Panel.PnlMenu;

[Token(Token = "0x200054D")]
public class PageTrove : PageAbstractHandler
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001F96")]
	[SerializeField]
	private Button m_BtnCherkPC;

	[Token(Token = "0x6003773")]
	[Address(RVA = "0x599CB0", Offset = "0x5984B0", Length = "0x12")]
	public PageTrove()
	{
	}
}
