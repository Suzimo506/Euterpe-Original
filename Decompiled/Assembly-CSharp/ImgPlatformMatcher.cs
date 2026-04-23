using System.Collections.Generic;
using Cpp2ILInjected;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000183")]
public class ImgPlatformMatcher : SerializedMonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4000982")]
	[FieldOffset(Offset = "0x58")]
	private Image m_Img;

	[Token(Token = "0x4000983")]
	[SerializeField]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<string, Dictionary<string, Sprite>> m_PlatformLanguageToSpriteMapping;

	[Token(Token = "0x6000B09")]
	[Address(RVA = "0x5C6FE0", Offset = "0x5C57E0", Length = "0xC8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000B0A")]
	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	public ImgPlatformMatcher()
	{
	}
}
