using Assets.Scripts.PeroTools.Nice.Components;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.Effects;

[Token(Token = "0x200089F")]
public class BgEffectImageRotation : BgEffect
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002CDB")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView fancyScrollView;

	[Token(Token = "0x4002CDC")]
	[FieldOffset(Offset = "0x38")]
	public float staticRotateSpeed;

	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4002CDD")]
	public float speedFactor;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002CDE")]
	private float m_Direction;

	[Token(Token = "0x6004E21")]
	[Address(RVA = "0x5A7620", Offset = "0x5A5E20", Length = "0x176")]
	private void Update()
	{
	}

	[Token(Token = "0x6004E22")]
	[Address(RVA = "0x5A77A0", Offset = "0x5A5FA0", Length = "0x6E")]
	public BgEffectImageRotation()
	{
	}
}
