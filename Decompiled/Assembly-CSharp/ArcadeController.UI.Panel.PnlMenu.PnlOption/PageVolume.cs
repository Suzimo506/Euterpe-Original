using Cpp2ILInjected;
using UnityEngine;

namespace ArcadeController.UI.Panel.PnlMenu.PnlOption;

[Token(Token = "0x2000554")]
public class PageVolume : PageAbstractHandler
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001F9C")]
	[SerializeField]
	private UISelectManage m_UISelectManageChild;

	[Token(Token = "0x600377A")]
	[Address(RVA = "0x599CB0", Offset = "0x5984B0", Length = "0x12")]
	public PageVolume()
	{
	}
}
