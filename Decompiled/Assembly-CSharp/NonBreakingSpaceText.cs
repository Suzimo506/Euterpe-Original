using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200018A")]
[Attribute(Name = "RequireComponent", RVA = "0x3D430", Offset = "0x3C830")]
public class NonBreakingSpaceText : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009A7")]
	private Text txt;

	[Token(Token = "0x40009A8")]
	private const string NonBreakingSpace = "\ufffd";

	[Token(Token = "0x6000B29")]
	[Address(RVA = "0x86BC80", Offset = "0x86A480", Length = "0x147")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000B2A")]
	[Address(RVA = "0x86BDD0", Offset = "0x86A5D0", Length = "0xBD")]
	private void OnTextChange()
	{
	}

	[Token(Token = "0x6000B2B")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public NonBreakingSpaceText()
	{
	}
}
