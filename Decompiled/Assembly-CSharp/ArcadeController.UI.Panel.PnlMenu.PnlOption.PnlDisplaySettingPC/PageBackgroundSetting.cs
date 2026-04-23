using Cpp2ILInjected;
using UnityEngine;

namespace ArcadeController.UI.Panel.PnlMenu.PnlOption.PnlDisplaySettingPC;

[Token(Token = "0x2000555")]
public class PageBackgroundSetting : PageAbstractHandler
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001F9D")]
	[SerializeField]
	private GameObject m_BtnPrevious;

	[SerializeField]
	[Token(Token = "0x4001F9E")]
	[FieldOffset(Offset = "0x68")]
	private GameObject m_BtnNext;

	[Token(Token = "0x600377B")]
	[Address(RVA = "0x599CB0", Offset = "0x5984B0", Length = "0x12")]
	public PageBackgroundSetting()
	{
	}
}
