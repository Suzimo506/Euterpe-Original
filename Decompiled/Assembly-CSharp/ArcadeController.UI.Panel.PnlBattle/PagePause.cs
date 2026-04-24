using Cpp2ILInjected;
using UnityEngine;

namespace ArcadeController.UI.Panel.PnlBattle;

[Token(Token = "0x200055B")]
public class PagePause : PageAbstractHandler
{
	[SerializeField]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001FA6")]
	private GameObject m_BtnMenu;

	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4001FA7")]
	private GameObject m_BtnRestart;

	[SerializeField]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001FA8")]
	private GameObject m_BtnResume;

	[Address(RVA = "0x599CB0", Offset = "0x5984B0", Length = "0x12")]
	[Token(Token = "0x6003781")]
	public PagePause()
	{
	}
}
