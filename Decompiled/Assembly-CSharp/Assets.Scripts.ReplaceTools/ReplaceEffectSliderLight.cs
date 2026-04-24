using System.Collections.Generic;
using Assets.Scripts.UI.Controls;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.ReplaceTools;

[Token(Token = "0x200059B")]
public class ReplaceEffectSliderLight : AbstractReplace
{
	[Token(Token = "0x2000B98")]
	public class ReplaceEffectLightPart
	{
		[Token(Token = "0x4003AB5")]
		[FieldOffset(Offset = "0x10")]
		public bool replaceColor;

		[Token(Token = "0x4003AB6")]
		[FieldOffset(Offset = "0x14")]
		public Color newFromColor;

		[Token(Token = "0x4003AB7")]
		[FieldOffset(Offset = "0x24")]
		public Color newToColor;

		[Token(Token = "0x6005EDD")]
		[Address(RVA = "0x6587E0", Offset = "0x656FE0", Length = "0x3A")]
		public void Replace(EffectSliderLight effectSliderLight)
		{
		}

		[Token(Token = "0x6005EDE")]
		[Address(RVA = "0x658820", Offset = "0x657020", Length = "0x3E")]
		public ReplaceEffectLightPart()
		{
		}
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40020E9")]
	public EffectSliderLight effectSliderLight;

	[Token(Token = "0x40020EA")]
	[FieldOffset(Offset = "0x18")]
	public List<ReplaceEffectLightPart> parts;

	[Address(RVA = "0x658860", Offset = "0x657060", Length = "0xC3")]
	[Token(Token = "0x60038D8")]
	public override void Replace(int index)
	{
	}

	[Token(Token = "0x60038D9")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public ReplaceEffectSliderLight()
	{
	}
}
