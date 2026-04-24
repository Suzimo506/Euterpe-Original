using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000122")]
public class PnlOption_DownloadManage : BaseMessageBox
{
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40006F0")]
	public Button m_BtnDownloadAllIapAsset;

	[Token(Token = "0x40006F1")]
	[FieldOffset(Offset = "0xF8")]
	public Button m_BtnClearAllAssetCache;

	[Token(Token = "0x40006F2")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private Toggle m_TglAutoDownload;

	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	[Token(Token = "0x6000840")]
	public PnlOption_DownloadManage()
	{
	}
}
