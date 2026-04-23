using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.ReplaceTools;

[Token(Token = "0x20005A0")]
public class ReplaceRawImage : AbstractReplace
{
	[Token(Token = "0x2000B9D")]
	public class ReplaceRawImagePart
	{
		[Token(Token = "0x4003AC6")]
		[FieldOffset(Offset = "0x10")]
		public Texture newTexture;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003AC7")]
		public bool replaceColor;

		[Token(Token = "0x4003AC8")]
		[FieldOffset(Offset = "0x1C")]
		public Color newColor;

		[Token(Token = "0x6005EE7")]
		[Address(RVA = "0x6591B0", Offset = "0x6579B0", Length = "0xB5")]
		public void Replace(RawImage image)
		{
		}

		[Address(RVA = "0x6589E0", Offset = "0x6571E0", Length = "0x2B")]
		[Token(Token = "0x6005EE8")]
		public ReplaceRawImagePart()
		{
		}
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40020F3")]
	public RawImage image;

	[Token(Token = "0x40020F4")]
	[FieldOffset(Offset = "0x18")]
	public List<ReplaceRawImagePart> parts;

	[Token(Token = "0x60038E2")]
	[Address(RVA = "0x659330", Offset = "0x657B30", Length = "0x133")]
	public override void Replace(int index)
	{
	}

	[Token(Token = "0x60038E3")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public ReplaceRawImage()
	{
	}
}
