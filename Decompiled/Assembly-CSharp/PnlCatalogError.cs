using Cpp2ILInjected;
using PeroTools2.UI;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200011C")]
public class PnlCatalogError : MonoBehaviour
{
	[Token(Token = "0x40006E0")]
	[FieldOffset(Offset = "0x18")]
	public Popup m_Popup;

	[Token(Token = "0x40006E1")]
	[FieldOffset(Offset = "0x20")]
	public Button BtnRetryCatalog;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006E2")]
	public Button BtnCancel;

	[Token(Token = "0x600082E")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlCatalogError()
	{
	}
}
