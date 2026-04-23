using Assets.Scripts.UI.Panels.Bulletin.AnnounceModule;
using Cpp2ILInjected;
using UnityEngine;

namespace ArcadeController.UI.Panel.PnlMenu;

[Token(Token = "0x2000548")]
public class PageAnnounce : PageAbstractHandler
{
	[Token(Token = "0x4001F87")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private PnlAnnounceScrollListView m_PnlAnnounceScrollListView;

	[Address(RVA = "0x599CB0", Offset = "0x5984B0", Length = "0x12")]
	[Token(Token = "0x600376E")]
	public PageAnnounce()
	{
	}
}
