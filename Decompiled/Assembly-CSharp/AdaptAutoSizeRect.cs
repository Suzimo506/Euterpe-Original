using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000141")]
public class AdaptAutoSizeRect : MonoBehaviour
{
	[Token(Token = "0x40007D0")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x246A0", Offset = "0x23AA0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x246A0", Offset = "0x23AA0")]
	[FieldOffset(Offset = "0x18")]
	public float left4x3;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40007D1")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x246A0", Offset = "0x23AA0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x246A0", Offset = "0x23AA0")]
	public float right4x3;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007D2")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x246A0", Offset = "0x23AA0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x246A0", Offset = "0x23AA0")]
	public float posHeight4x3;

	[Attribute(Name = "HeaderAttribute", RVA = "0x246A0", Offset = "0x23AA0")]
	[Token(Token = "0x40007D3")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x246A0", Offset = "0x23AA0")]
	public float posY4x3;

	[Attribute(Name = "HeaderAttribute", RVA = "0x24F00", Offset = "0x24300")]
	[Token(Token = "0x40007D4")]
	[FieldOffset(Offset = "0x28")]
	public float leftOther;

	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40007D5")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x24F00", Offset = "0x24300")]
	public float rightOther;

	[Token(Token = "0x40007D6")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x24F00", Offset = "0x24300")]
	[FieldOffset(Offset = "0x30")]
	public float posHeightOther;

	[Token(Token = "0x40007D7")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x24F00", Offset = "0x24300")]
	public float posYOther;

	[Token(Token = "0x40007D8")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform m_Rect;

	[Token(Token = "0x6000909")]
	[Address(RVA = "0x590550", Offset = "0x58ED50", Length = "0x189")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600090A")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public AdaptAutoSizeRect()
	{
	}
}
