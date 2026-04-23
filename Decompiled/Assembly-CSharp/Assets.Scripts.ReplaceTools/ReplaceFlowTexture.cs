using System.Collections.Generic;
using Assets.Scripts.Graphics;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.ReplaceTools;

[Token(Token = "0x200059C")]
public class ReplaceFlowTexture : AbstractReplace
{
	[Token(Token = "0x2000B99")]
	public class ReplaceFlowTexturePart
	{
		[Token(Token = "0x4003AB8")]
		[FieldOffset(Offset = "0x10")]
		public Texture newTexture;

		[Token(Token = "0x4003AB9")]
		[FieldOffset(Offset = "0x18")]
		public bool replaceColor;

		[Token(Token = "0x4003ABA")]
		[FieldOffset(Offset = "0x1C")]
		public Color newColor;

		[Address(RVA = "0x658930", Offset = "0x657130", Length = "0xAB")]
		[Token(Token = "0x6005EDF")]
		public void Replace(FlowTexture flowTexture)
		{
		}

		[Address(RVA = "0x6589E0", Offset = "0x6571E0", Length = "0x2B")]
		[Token(Token = "0x6005EE0")]
		public ReplaceFlowTexturePart()
		{
		}
	}

	[Token(Token = "0x40020EB")]
	[FieldOffset(Offset = "0x10")]
	public FlowTexture flowTexture;

	[Token(Token = "0x40020EC")]
	[FieldOffset(Offset = "0x18")]
	public List<ReplaceFlowTexturePart> parts;

	[Token(Token = "0x60038DA")]
	[Address(RVA = "0x658A10", Offset = "0x657210", Length = "0x12A")]
	public override void Replace(int index)
	{
	}

	[Token(Token = "0x60038DB")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public ReplaceFlowTexture()
	{
	}
}
