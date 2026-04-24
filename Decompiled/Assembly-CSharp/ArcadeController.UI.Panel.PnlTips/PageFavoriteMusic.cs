using Assets.Scripts.PeroTools.UI;
using Cpp2ILInjected;
using UnityEngine;

namespace ArcadeController.UI.Panel.PnlTips;

[Token(Token = "0x2000540")]
public class PageFavoriteMusic : PageAbstractHandler
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001F7B")]
	[SerializeField]
	private LongPressButton m_BtnLeft;

	[SerializeField]
	[Token(Token = "0x4001F7C")]
	[FieldOffset(Offset = "0x68")]
	private LongPressButton m_BtnRight;

	[Address(RVA = "0x599CB0", Offset = "0x5984B0", Length = "0x12")]
	[Token(Token = "0x6003766")]
	public PageFavoriteMusic()
	{
	}
}
