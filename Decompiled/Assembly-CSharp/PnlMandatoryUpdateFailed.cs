using Cpp2ILInjected;
using PeroTools2.UI;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000120")]
public class PnlMandatoryUpdateFailed : MonoBehaviour
{
	[Token(Token = "0x40006ED")]
	[FieldOffset(Offset = "0x18")]
	public Popup m_Popup;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006EE")]
	public Button BtnRetryCatalog;

	[Token(Token = "0x40006EF")]
	[FieldOffset(Offset = "0x28")]
	public Button BtnCancel;

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600083E")]
	public PnlMandatoryUpdateFailed()
	{
	}
}
