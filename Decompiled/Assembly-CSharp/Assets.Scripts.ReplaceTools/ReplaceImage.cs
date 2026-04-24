using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.ReplaceTools;

[Token(Token = "0x200059D")]
public class ReplaceImage : AbstractReplace
{
	[Token(Token = "0x2000B9A")]
	public class ReplaceRawImagePart
	{
		[Token(Token = "0x4003ABB")]
		[FieldOffset(Offset = "0x10")]
		public Sprite newSprite;

		[Token(Token = "0x4003ABC")]
		[FieldOffset(Offset = "0x18")]
		public bool replaceColor;

		[Token(Token = "0x4003ABD")]
		[FieldOffset(Offset = "0x1C")]
		public Color newColor;

		[Address(RVA = "0x659270", Offset = "0x657A70", Length = "0xB5")]
		[Token(Token = "0x6005EE1")]
		public void Replace(Image image)
		{
		}

		[Token(Token = "0x6005EE2")]
		[Address(RVA = "0x6589E0", Offset = "0x6571E0", Length = "0x2B")]
		public ReplaceRawImagePart()
		{
		}
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40020ED")]
	public Image image;

	[Token(Token = "0x40020EE")]
	[FieldOffset(Offset = "0x18")]
	public List<ReplaceRawImagePart> parts;

	[Token(Token = "0x60038DC")]
	[Address(RVA = "0x658B40", Offset = "0x657340", Length = "0x133")]
	public override void Replace(int index)
	{
	}

	[Token(Token = "0x60038DD")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public ReplaceImage()
	{
	}
}
