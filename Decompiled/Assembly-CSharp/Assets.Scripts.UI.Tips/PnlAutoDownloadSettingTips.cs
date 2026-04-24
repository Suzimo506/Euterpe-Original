using Assets.Scripts.UI.Panels;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Tips;

[Token(Token = "0x2000880")]
public class PnlAutoDownloadSettingTips : BaseMessageBox
{
	[SerializeField]
	[Token(Token = "0x4002C68")]
	[FieldOffset(Offset = "0xF0")]
	private PnlMenu m_PnlMenu;

	[Token(Token = "0x6004D84")]
	[Address(RVA = "0x5F96A0", Offset = "0x5F7EA0", Length = "0x51")]
	public PnlAutoDownloadSettingTips()
	{
	}
}
