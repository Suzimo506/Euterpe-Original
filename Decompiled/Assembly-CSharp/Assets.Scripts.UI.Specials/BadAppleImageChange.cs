using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Specials;

[Token(Token = "0x200086B")]
public class BadAppleImageChange : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002BFF")]
	[SerializeField]
	private SpriteRenderer m_SpriteRender;

	[SerializeField]
	[Token(Token = "0x4002C00")]
	[FieldOffset(Offset = "0x20")]
	private Sprite m_BadAppleSprite;

	[Token(Token = "0x6004CF9")]
	[Address(RVA = "0x60A750", Offset = "0x608F50", Length = "0xCA")]
	private void Start()
	{
	}

	[Token(Token = "0x6004CFA")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public BadAppleImageChange()
	{
	}
}
