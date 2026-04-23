using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace ArcadeController.UI.Panel.PnlMenu.PnlOption;

[Token(Token = "0x2000551")]
public class PageOffsetOption : PageAbstractHandler
{
	[SerializeField]
	[Token(Token = "0x4001F99")]
	[FieldOffset(Offset = "0x60")]
	private Toggle m_Toggle;

	[SerializeField]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001F9A")]
	private GameObject m_BtnPrevious;

	[Token(Token = "0x4001F9B")]
	[SerializeField]
	[FieldOffset(Offset = "0x70")]
	private GameObject m_BtnNext;

	[Token(Token = "0x6003777")]
	[Address(RVA = "0x599CB0", Offset = "0x5984B0", Length = "0x12")]
	public PageOffsetOption()
	{
	}
}
