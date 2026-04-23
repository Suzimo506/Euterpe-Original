using System;
using Cpp2ILInjected;

namespace Assets.Scripts.Graphics;

[Serializable]
[Token(Token = "0x20006ED")]
internal class ColorRange
{
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6F920", Offset = "0x6ED20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6F920", Offset = "0x6ED20")]
	[Token(Token = "0x400252F")]
	public float redMin;

	[Token(Token = "0x4002530")]
	[FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x25E40", Offset = "0x25240")]
	public float redMax;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002531")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x710B0", Offset = "0x704B0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x710B0", Offset = "0x704B0")]
	public float greenMin;

	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x25E40", Offset = "0x25240")]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4002532")]
	public float greenMax;

	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x71340", Offset = "0x70740")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x71340", Offset = "0x70740")]
	[Token(Token = "0x4002533")]
	public float blueMin;

	[Token(Token = "0x4002534")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x25E40", Offset = "0x25240")]
	[FieldOffset(Offset = "0x24")]
	public float blueMax;

	[Address(RVA = "0xC6F040", Offset = "0xC6D840", Length = "0x1C")]
	[Token(Token = "0x600416C")]
	public ColorRange()
	{
	}
}
