using Cpp2ILInjected;
using UnityEngine;

namespace ArcadeController.UI.Panel.PnlTips;

[Token(Token = "0x2000543")]
public class PageTutorialSelect : PageAbstractHandler
{
	[Token(Token = "0x4001F7E")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GameObject m_BtnLevelTutorial;

	[SerializeField]
	[Token(Token = "0x4001F7F")]
	[FieldOffset(Offset = "0x68")]
	private GameObject m_BtnFunctionDescription;

	[Token(Token = "0x6003769")]
	[Address(RVA = "0x599CB0", Offset = "0x5984B0", Length = "0x12")]
	public PageTutorialSelect()
	{
	}
}
