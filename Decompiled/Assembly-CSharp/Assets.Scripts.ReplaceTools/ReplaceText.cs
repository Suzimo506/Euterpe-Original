using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.ReplaceTools;

[Token(Token = "0x20005A5")]
public class ReplaceText : AbstractReplace
{
	[Token(Token = "0x2000BA0")]
	public class ReplaceTextPart
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003ACE")]
		public Color newColor;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003ACF")]
		public bool replaceOutline;

		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4003AD0")]
		public Color outlineColor;

		[Address(RVA = "0x659B00", Offset = "0x658300", Length = "0xC7")]
		[Token(Token = "0x6005EEE")]
		public void Replace(Text text)
		{
		}

		[Address(RVA = "0x659BD0", Offset = "0x6583D0", Length = "0x2B")]
		[Token(Token = "0x6005EEF")]
		public ReplaceTextPart()
		{
		}
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002101")]
	public Text text;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002102")]
	public List<ReplaceTextPart> parts;

	[Token(Token = "0x60038EA")]
	[Address(RVA = "0x659C00", Offset = "0x658400", Length = "0x14F")]
	public override void Replace(int index)
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60038EB")]
	public ReplaceText()
	{
	}
}
