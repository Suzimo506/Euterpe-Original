using Cpp2ILInjected;
using UnityEngine;

namespace UI.Controls;

[Token(Token = "0x20001D0")]
public class BtnBind : MonoBehaviour
{
	[Address(RVA = "0x5093A0", Offset = "0x507BA0", Length = "0xAD")]
	[Token(Token = "0x6000D11")]
	private void Start()
	{
	}

	[Token(Token = "0x6000D12")]
	[Address(RVA = "0x509520", Offset = "0x507D20", Length = "0x112")]
	private void UpdateState()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000D13")]
	public BtnBind()
	{
	}
}
