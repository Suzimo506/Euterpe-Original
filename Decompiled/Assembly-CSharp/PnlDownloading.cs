using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200011D")]
public class PnlDownloading : MonoBehaviour
{
	[Token(Token = "0x40006E3")]
	[FieldOffset(Offset = "0x18")]
	public Slider sldDownloadProgress;

	[Token(Token = "0x40006E4")]
	[FieldOffset(Offset = "0x20")]
	public Text txtDownloadInfo;

	[Token(Token = "0x40006E5")]
	[FieldOffset(Offset = "0x28")]
	public Text txtDownloadProgress;

	[Token(Token = "0x600082F")]
	[Address(RVA = "0x4FEF60", Offset = "0x4FD760", Length = "0x19B")]
	public void Set(string info, string progress, float slider)
	{
	}

	[Address(RVA = "0x4FEEB0", Offset = "0x4FD6B0", Length = "0xA6")]
	[Token(Token = "0x6000830")]
	public void SetSliderProgress(float progress)
	{
	}

	[Address(RVA = "0x4FEE10", Offset = "0x4FD610", Length = "0x94")]
	[Token(Token = "0x6000831")]
	public void SetInfo(string downloadInfo)
	{
	}

	[Token(Token = "0x6000832")]
	[Address(RVA = "0x4FED70", Offset = "0x4FD570", Length = "0x94")]
	public void SetDownloadProgress(string info)
	{
	}

	[Token(Token = "0x6000833")]
	[Address(RVA = "0x4FECC0", Offset = "0x4FD4C0", Length = "0xA1")]
	public void ResetPanel()
	{
	}

	[Token(Token = "0x6000834")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlDownloading()
	{
	}
}
