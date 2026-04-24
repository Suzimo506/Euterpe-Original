using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000009")]
public class XDSDKHandler : MonoBehaviour
{
	[Token(Token = "0x600001A")]
	[Address(RVA = "0xD33E30", Offset = "0xD32630", Length = "0xAC")]
	private void OnLoginSuccess(string sid)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600001B")]
	public XDSDKHandler()
	{
	}
}
