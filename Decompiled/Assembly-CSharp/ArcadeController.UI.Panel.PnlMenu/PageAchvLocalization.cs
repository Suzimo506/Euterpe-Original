using Cpp2ILInjected;
using UnityEngine;

namespace ArcadeController.UI.Panel.PnlMenu;

[Token(Token = "0x2000547")]
public class PageAchvLocalization : PageAbstractHandler
{
	[SerializeField]
	[Token(Token = "0x4001F86")]
	[FieldOffset(Offset = "0x60")]
	private UISelectManage m_UISelectManage;

	[Address(RVA = "0x599CB0", Offset = "0x5984B0", Length = "0x12")]
	[Token(Token = "0x600376D")]
	public PageAchvLocalization()
	{
	}
}
