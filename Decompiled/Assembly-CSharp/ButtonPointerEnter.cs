using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000DC")]
public class ButtonPointerEnter : MonoBehaviour
{
	[Token(Token = "0x4000585")]
	[FieldOffset(Offset = "0x18")]
	private bool m_IsPointerHover;

	[Token(Token = "0x6000655")]
	[Address(RVA = "0x462200", Offset = "0x460A00", Length = "0xE0")]
	public void PointerEnter()
	{
	}

	[Address(RVA = "0x4622F0", Offset = "0x460AF0", Length = "0x5")]
	[Token(Token = "0x6000656")]
	public void PointerExit()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000657")]
	public ButtonPointerEnter()
	{
	}
}
