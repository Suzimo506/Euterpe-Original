using Cpp2ILInjected;
using PeroTools2.UI;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Panels.PnlHotfix;

[Token(Token = "0x20001CB")]
public class PnlAutoDownloadAsk : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4000B67")]
	[FieldOffset(Offset = "0x18")]
	private Popup m_Popup;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B68")]
	[SerializeField]
	private Text m_TxtAutoDownloadAskTips;

	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000B69")]
	private Button m_BtnYes;

	[SerializeField]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B6A")]
	private int m_LimitDownloadSize;

	[Token(Token = "0x6000D03")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlAutoDownloadAsk()
	{
	}
}
