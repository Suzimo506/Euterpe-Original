using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace ArcadeController.UI.Panel.PnlMenu.PnlOption.PnlDisplaySettingPC;

[Token(Token = "0x2000556")]
public class PageDisplaySettingPC : PageAbstractHandler
{
	[SerializeField]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001F9F")]
	private Button m_BtnOk;

	[Address(RVA = "0x599CB0", Offset = "0x5984B0", Length = "0x12")]
	[Token(Token = "0x600377C")]
	public PageDisplaySettingPC()
	{
	}
}
