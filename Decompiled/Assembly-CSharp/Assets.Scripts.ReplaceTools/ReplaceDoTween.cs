using System.Collections.Generic;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts.ReplaceTools;

[Token(Token = "0x200059A")]
public class ReplaceDoTween : AbstractReplace
{
	[Token(Token = "0x2000B97")]
	public class ReplaceDoTweenPart
	{
		[Token(Token = "0x4003AB3")]
		[FieldOffset(Offset = "0x10")]
		public bool replaceColor;

		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4003AB4")]
		public Color newToColor;

		[Token(Token = "0x6005EDB")]
		[Address(RVA = "0x658680", Offset = "0x656E80", Length = "0x24")]
		public void Replace(DOTweenAnimation doTween)
		{
		}

		[Token(Token = "0x6005EDC")]
		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		public ReplaceDoTweenPart()
		{
		}
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40020E7")]
	public DOTweenAnimation doTweenAnimation;

	[Token(Token = "0x40020E8")]
	[FieldOffset(Offset = "0x18")]
	public List<ReplaceDoTweenPart> parts;

	[Token(Token = "0x60038D6")]
	[Address(RVA = "0x6586B0", Offset = "0x656EB0", Length = "0xB2")]
	public override void Replace(int index)
	{
	}

	[Token(Token = "0x60038D7")]
	[Address(RVA = "0x658770", Offset = "0x656F70", Length = "0x69")]
	public ReplaceDoTween()
	{
	}
}
