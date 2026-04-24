using Cpp2ILInjected;
using PeroTools2.UI;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Panels.PnlHotfix;

[Token(Token = "0x20001CD")]
public class PnlHotfix : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x58860", Offset = "0x57C60")]
	[Token(Token = "0x4000B72")]
	public Button BtnMask;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B73")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x58CA0", Offset = "0x580A0")]
	public Button ImgNewVersionCheck;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B74")]
	public Popup pnlNewVersionTip;

	[Attribute(Name = "HeaderAttribute", RVA = "0x58DE0", Offset = "0x581E0")]
	[Token(Token = "0x4000B75")]
	[FieldOffset(Offset = "0x30")]
	public Popup pnlCatalogUpdateErrorDisplay;

	[Token(Token = "0x4000B76")]
	[FieldOffset(Offset = "0x38")]
	public Popup pnlMandatoryUpdateErrorDisplay;

	[Token(Token = "0x4000B77")]
	[FieldOffset(Offset = "0x40")]
	public PnlHotfixErrorDisplay pnlErrorDisplay;

	[Token(Token = "0x4000B78")]
	[FieldOffset(Offset = "0x48")]
	public Popup popFirstEnterHotfixVersion;

	[Token(Token = "0x4000B79")]
	[FieldOffset(Offset = "0x50")]
	public PnlAutoDownloadAsk popAutoDownloadAsk;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B7A")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x58E60", Offset = "0x58260")]
	public Popup pnlDownloadingPopup;

	[Token(Token = "0x4000B7B")]
	[FieldOffset(Offset = "0x60")]
	public PnlDownloading pnlDownloading;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000B7C")]
	public Popup pnlDownloadSuccess;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000B7D")]
	public PnlDownloadSizeCheck pnlDownloadSizeCheck;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000B7E")]
	private int m_HotfixProgress;

	[Token(Token = "0x4000B7F")]
	[FieldOffset(Offset = "0x80")]
	private WaitForEndOfFrame m_WaitForEndOfFrame;

	[Token(Token = "0x4000B80")]
	[FieldOffset(Offset = "0x88")]
	private string localDownloadInfo;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000B81")]
	private string[] assetkeys;

	[Token(Token = "0x6000D05")]
	[Address(RVA = "0x50CCC0", Offset = "0x50B4C0", Length = "0x67")]
	public PnlHotfix()
	{
	}
}
