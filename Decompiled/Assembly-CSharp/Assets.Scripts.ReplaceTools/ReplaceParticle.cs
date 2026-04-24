using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.ReplaceTools;

[Token(Token = "0x200059F")]
public class ReplaceParticle : AbstractReplace
{
	[Token(Token = "0x2000B9C")]
	public class ReplaceParticlePart
	{
		[Token(Token = "0x4003AC1")]
		[FieldOffset(Offset = "0x10")]
		public ParticleSystemGradientMode mode;

		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4003AC2")]
		public bool replaceColor;

		[Token(Token = "0x4003AC3")]
		[FieldOffset(Offset = "0x15")]
		public bool replaceColorLife;

		[Token(Token = "0x4003AC4")]
		[FieldOffset(Offset = "0x18")]
		public Gradient newGradient;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003AC5")]
		public Color newColor;

		[Token(Token = "0x6005EE5")]
		[Address(RVA = "0x658E10", Offset = "0x657610", Length = "0x147")]
		public void Replace(ParticleSystem particleSystem)
		{
		}

		[Token(Token = "0x6005EE6")]
		[Address(RVA = "0x658F60", Offset = "0x657760", Length = "0x77")]
		public ReplaceParticlePart()
		{
		}
	}

	[Token(Token = "0x40020F1")]
	[FieldOffset(Offset = "0x10")]
	public ParticleSystem particleSystem;

	[Token(Token = "0x40020F2")]
	[FieldOffset(Offset = "0x18")]
	public List<ReplaceParticlePart> parts;

	[Token(Token = "0x60038E0")]
	[Address(RVA = "0x658FE0", Offset = "0x6577E0", Length = "0x1C6")]
	public override void Replace(int index)
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60038E1")]
	public ReplaceParticle()
	{
	}
}
