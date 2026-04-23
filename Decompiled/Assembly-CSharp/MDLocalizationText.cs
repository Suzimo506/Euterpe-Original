using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200009B")]
public class MDLocalizationText : MonoBehaviour
{
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400044E")]
	public string localizationKey;

	[Token(Token = "0x400044F")]
	[FieldOffset(Offset = "0x20")]
	private Text m_TextComponent;

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0x8C0F20", Offset = "0x8BF720", Length = "0x1EA")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public MDLocalizationText()
	{
	}
}
