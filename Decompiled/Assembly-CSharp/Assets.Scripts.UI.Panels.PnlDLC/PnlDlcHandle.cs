using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Attribute(Name = "RequireComponent", RVA = "0x945B0", Offset = "0x939B0")]
[Token(Token = "0x200093F")]
public class PnlDlcHandle : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40031F9")]
	private PnlDlc m_PnlDlc;

	[Token(Token = "0x40031FA")]
	private static PnlDlcHandle m_Instance;

	[Token(Token = "0x170008D4")]
	private static PnlDlcHandle Instance
	{
		[Token(Token = "0x60053F6")]
		[Address(RVA = "0x825C30", Offset = "0x824430", Length = "0x12E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60053F7")]
	[Address(RVA = "0x825900", Offset = "0x824100", Length = "0x13C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60053F8")]
	[Address(RVA = "0x825B80", Offset = "0x824380", Length = "0xAD")]
	private void Initialize()
	{
	}

	[Address(RVA = "0x825A40", Offset = "0x824240", Length = "0x137")]
	[Token(Token = "0x60053F9")]
	public static PnlDlc GetPnlDlc()
	{
		return null;
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60053FA")]
	public PnlDlcHandle()
	{
	}
}
