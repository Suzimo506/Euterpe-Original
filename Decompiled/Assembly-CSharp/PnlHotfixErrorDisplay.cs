using Cpp2ILInjected;
using PeroTools2.UI;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200011F")]
public class PnlHotfixErrorDisplay : MonoBehaviour
{
	[Token(Token = "0x40006E9")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Popup m_Popup;

	[Token(Token = "0x40006EA")]
	[FieldOffset(Offset = "0x20")]
	public Text TxtMainError;

	[Token(Token = "0x40006EB")]
	[FieldOffset(Offset = "0x28")]
	public Text TxtExtraTip;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40006EC")]
	public Button BtnSkip;

	[Address(RVA = "0x79FD40", Offset = "0x79E540", Length = "0x89")]
	[Token(Token = "0x6000836")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000837")]
	[Address(RVA = "0x79FE00", Offset = "0x79E600", Length = "0x29")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000838")]
	[Address(RVA = "0x79FE30", Offset = "0x79E630", Length = "0x5C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000839")]
	[Address(RVA = "0x79FD40", Offset = "0x79E540", Length = "0x89")]
	private void RegitserButtonEvent()
	{
	}

	[Address(RVA = "0x79FE00", Offset = "0x79E600", Length = "0x29")]
	[Token(Token = "0x600083A")]
	private void UnregitserButtonEvent()
	{
	}

	[Address(RVA = "0x79FE90", Offset = "0x79E690", Length = "0x2D")]
	[Token(Token = "0x600083B")]
	public void Show()
	{
	}

	[Token(Token = "0x600083C")]
	[Address(RVA = "0x79FDD0", Offset = "0x79E5D0", Length = "0x23")]
	private void OnClickSkip()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600083D")]
	public PnlHotfixErrorDisplay()
	{
	}
}
