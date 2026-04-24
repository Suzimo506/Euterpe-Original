using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace ArcadeController.UI.Panel.PnlHome;

[Token(Token = "0x2000559")]
public class PageHome : PageAbstractHandler
{
	[SerializeField]
	[Token(Token = "0x4001FA3")]
	[FieldOffset(Offset = "0x60")]
	private Button m_BtnTouch;

	[Address(RVA = "0x599CB0", Offset = "0x5984B0", Length = "0x12")]
	[Token(Token = "0x600377F")]
	public PageHome()
	{
	}
}
