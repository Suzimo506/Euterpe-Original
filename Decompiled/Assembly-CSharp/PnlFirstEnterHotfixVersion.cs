using Cpp2ILInjected;
using PeroTools2.UI;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200011E")]
public class PnlFirstEnterHotfixVersion : MonoBehaviour
{
	[Token(Token = "0x40006E6")]
	[FieldOffset(Offset = "0x18")]
	public Popup m_Popup;

	[Token(Token = "0x40006E7")]
	[FieldOffset(Offset = "0x20")]
	public Button BtnDownloadIAPAsset;

	[Token(Token = "0x40006E8")]
	[FieldOffset(Offset = "0x28")]
	public Button BtnSkipDownload;

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000835")]
	public PnlFirstEnterHotfixVersion()
	{
	}
}
