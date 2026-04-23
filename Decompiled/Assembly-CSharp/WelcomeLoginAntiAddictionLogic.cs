using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200013B")]
public class WelcomeLoginAntiAddictionLogic : MonoBehaviour
{
	[Token(Token = "0x40007C3")]
	[FieldOffset(Offset = "0x18")]
	public Button[] btns;

	[Token(Token = "0x60008F0")]
	[Address(RVA = "0xD32690", Offset = "0xD30E90", Length = "0x7")]
	private void Start()
	{
	}

	[Address(RVA = "0xD32690", Offset = "0xD30E90", Length = "0x7")]
	[Token(Token = "0x60008F1")]
	public void LoginDetection()
	{
	}

	[Address(RVA = "0xD326A0", Offset = "0xD30EA0", Length = "0xC4")]
	[Token(Token = "0x60008F2")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60008F3")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public WelcomeLoginAntiAddictionLogic()
	{
	}
}
