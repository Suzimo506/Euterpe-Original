using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace ArcadeController.UI.Panel.PnlBattle;

[Token(Token = "0x200055A")]
public class PageBattle : PageAbstractHandler
{
	[Token(Token = "0x4001FA4")]
	[SerializeField]
	[FieldOffset(Offset = "0x60")]
	private List<Button> m_BtnPauses;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001FA5")]
	[SerializeField]
	private Button m_BtnTutoral;

	[Token(Token = "0x6003780")]
	[Address(RVA = "0x599CB0", Offset = "0x5984B0", Length = "0x12")]
	public PageBattle()
	{
	}
}
