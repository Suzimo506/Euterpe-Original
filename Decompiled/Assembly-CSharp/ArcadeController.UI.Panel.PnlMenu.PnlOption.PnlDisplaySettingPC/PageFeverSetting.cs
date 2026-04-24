using Assets.Scripts.PeroTools.UI;
using Cpp2ILInjected;
using UnityEngine;

namespace ArcadeController.UI.Panel.PnlMenu.PnlOption.PnlDisplaySettingPC;

[Token(Token = "0x2000557")]
public class PageFeverSetting : PageAbstractHandler
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001FA0")]
	[SerializeField]
	private LongPressButton m_BtnPrevious;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001FA1")]
	[SerializeField]
	private LongPressButton m_BtnNext;

	[Token(Token = "0x600377D")]
	[Address(RVA = "0x599CB0", Offset = "0x5984B0", Length = "0x12")]
	public PageFeverSetting()
	{
	}
}
