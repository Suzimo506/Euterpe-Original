using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200009A")]
public class MDLocalizationFont : MonoBehaviour
{
	[Token(Token = "0x4000448")]
	[FieldOffset(Offset = "0x18")]
	public Font englishFont;

	[Token(Token = "0x4000449")]
	[FieldOffset(Offset = "0x20")]
	public Font chineseSFont;

	[Token(Token = "0x400044A")]
	[FieldOffset(Offset = "0x28")]
	public Font chineseTFont;

	[Token(Token = "0x400044B")]
	[FieldOffset(Offset = "0x30")]
	public Font japaneseFont;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400044C")]
	public Font koreanFont;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400044D")]
	private Text m_TextComponent;

	[Address(RVA = "0x8C0ED0", Offset = "0x8BF6D0", Length = "0x47")]
	[Token(Token = "0x60004D6")]
	private void Start()
	{
	}

	[Address(RVA = "0x8C0B90", Offset = "0x8BF390", Length = "0x335")]
	[Token(Token = "0x60004D7")]
	public void OnEnable()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60004D8")]
	public MDLocalizationFont()
	{
	}
}
