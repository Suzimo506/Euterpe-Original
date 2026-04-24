using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.ReplaceTools;

[Token(Token = "0x20005A4")]
public class ReplaceSprite : AbstractReplace
{
	[Token(Token = "0x2000B9F")]
	public class ReplaceSpritePart
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003ACB")]
		public Sprite newSprite;

		[Token(Token = "0x4003ACC")]
		[FieldOffset(Offset = "0x18")]
		public bool replaceColor;

		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4003ACD")]
		public Color newColor;

		[Address(RVA = "0x659920", Offset = "0x658120", Length = "0xAD")]
		[Token(Token = "0x6005EEC")]
		public void Replace(SpriteRenderer sprite)
		{
		}

		[Token(Token = "0x6005EED")]
		[Address(RVA = "0x6589E0", Offset = "0x6571E0", Length = "0x2B")]
		public ReplaceSpritePart()
		{
		}
	}

	[Token(Token = "0x40020FF")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer sprite;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002100")]
	public List<ReplaceSpritePart> parts;

	[Token(Token = "0x60038E8")]
	[Address(RVA = "0x6599D0", Offset = "0x6581D0", Length = "0x12B")]
	public override void Replace(int index)
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60038E9")]
	public ReplaceSprite()
	{
	}
}
