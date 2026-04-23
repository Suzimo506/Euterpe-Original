using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Commons;

[Token(Token = "0x2000692")]
public static class TextureUtils
{
	[Address(RVA = "0x933EE0", Offset = "0x9326E0", Length = "0xC1")]
	[Token(Token = "0x6003DC3")]
	public static Sprite ToSprite(this Texture2D texture)
	{
		return null;
	}

	[Address(RVA = "0x933E50", Offset = "0x932650", Length = "0x90")]
	[Token(Token = "0x6003DC4")]
	public static void SaveToImage(this Texture2D texture, string path)
	{
	}

	[Token(Token = "0x6003DC5")]
	[Address(RVA = "0x933E20", Offset = "0x932620", Length = "0x23")]
	private static void SaveToImageDecode(this Texture2D texture, string path)
	{
	}

	[Token(Token = "0x6003DC6")]
	[Address(RVA = "0x933C30", Offset = "0x932430", Length = "0x1EC")]
	private static Texture2D DeCompressTexture(Texture2D texture)
	{
		return null;
	}
}
