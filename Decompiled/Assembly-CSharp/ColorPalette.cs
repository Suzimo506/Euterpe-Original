using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000060")]
public class ColorPalette : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002DE")]
	public Color color1;

	[Token(Token = "0x40002DF")]
	[FieldOffset(Offset = "0x28")]
	public Color color2;

	[Token(Token = "0x40002E0")]
	[FieldOffset(Offset = "0x38")]
	public Color color3;

	[Token(Token = "0x40002E1")]
	[FieldOffset(Offset = "0x48")]
	public Color color4;

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000303")]
	public ColorPalette()
	{
	}
}
