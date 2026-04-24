using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000195")]
public class SpecialsText : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009F3")]
	public Font specialFont;

	[Token(Token = "0x40009F4")]
	[FieldOffset(Offset = "0x20")]
	public Font simpleFont;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009F5")]
	private Text m_Text;

	[Token(Token = "0x6000B73")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void Awake()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6000B74")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000B75")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public SpecialsText()
	{
	}
}
