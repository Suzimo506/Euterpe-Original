using System.Collections.Generic;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.ReplaceTools;

[Token(Token = "0x200059E")]
public class ReplaceMeshProText : AbstractReplace
{
	[Token(Token = "0x2000B9B")]
	public class ReplaceMeshProPart
	{
		[Token(Token = "0x4003ABE")]
		[FieldOffset(Offset = "0x10")]
		public bool replaceColor;

		[Token(Token = "0x4003ABF")]
		[FieldOffset(Offset = "0x14")]
		public Color newColor;

		[Token(Token = "0x4003AC0")]
		[FieldOffset(Offset = "0x24")]
		public Color outlineColor;

		[Token(Token = "0x6005EE3")]
		[Address(RVA = "0x658C80", Offset = "0x657480", Length = "0x96")]
		public void Replace(TextMeshPro textMeshPro)
		{
		}

		[Token(Token = "0x6005EE4")]
		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		public ReplaceMeshProPart()
		{
		}
	}

	[Token(Token = "0x40020EF")]
	[FieldOffset(Offset = "0x10")]
	public TextMeshPro meshPro;

	[Token(Token = "0x40020F0")]
	[FieldOffset(Offset = "0x18")]
	public List<ReplaceMeshProPart> parts;

	[Address(RVA = "0x658D20", Offset = "0x657520", Length = "0xEA")]
	[Token(Token = "0x60038DE")]
	public override void Replace(int index)
	{
	}

	[Token(Token = "0x60038DF")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public ReplaceMeshProText()
	{
	}
}
