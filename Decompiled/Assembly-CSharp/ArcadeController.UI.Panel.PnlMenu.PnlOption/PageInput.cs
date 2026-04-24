using Cpp2ILInjected;
using UnityEngine;

namespace ArcadeController.UI.Panel.PnlMenu.PnlOption;

[Token(Token = "0x200054F")]
public class PageInput : PageAbstractHandler
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001F98")]
	[SerializeField]
	private UISelectManage m_UISelectManage;

	[Token(Token = "0x6003775")]
	[Address(RVA = "0x599CB0", Offset = "0x5984B0", Length = "0x12")]
	public PageInput()
	{
	}
}
