using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Graphics;

[ExecuteInEditMode]
[Token(Token = "0x20006F1")]
[Attribute(Name = "AddComponentMenu", RVA = "0x724C0", Offset = "0x718C0")]
public class FlowTexture : MonoBehaviour
{
	[Token(Token = "0x4002543")]
	[FieldOffset(Offset = "0x18")]
	public Texture flowTexture;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002544")]
	public Vector2 scale;

	[Token(Token = "0x4002545")]
	[FieldOffset(Offset = "0x28")]
	public Color flowTextureColor;

	[Attribute(Name = "TooltipAttribute", RVA = "0x72790", Offset = "0x71B90")]
	[Attribute(Name = "RangeAttribute", RVA = "0x72790", Offset = "0x71B90")]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002546")]
	public float flowSpeedX;

	[Attribute(Name = "TooltipAttribute", RVA = "0x72790", Offset = "0x71B90")]
	[Attribute(Name = "RangeAttribute", RVA = "0x72790", Offset = "0x71B90")]
	[Token(Token = "0x4002547")]
	[FieldOffset(Offset = "0x3C")]
	public float flowSpeedY;

	[Token(Token = "0x4002548")]
	[Attribute(Name = "RangeAttribute", RVA = "0x25E40", Offset = "0x25240")]
	[FieldOffset(Offset = "0x40")]
	public float offsetX;

	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "RangeAttribute", RVA = "0x25E40", Offset = "0x25240")]
	[Token(Token = "0x4002549")]
	public float offsetY;

	[Token(Token = "0x400254A")]
	[FieldOffset(Offset = "0x48")]
	public Shader shader;

	[Token(Token = "0x400254B")]
	[FieldOffset(Offset = "0x50")]
	private Material m_Material;

	[Token(Token = "0x400254C")]
	[FieldOffset(Offset = "0x58")]
	private int m_FlowTexId;

	[Token(Token = "0x400254D")]
	[FieldOffset(Offset = "0x5C")]
	private int m_FlowColorId;

	[Token(Token = "0x400254E")]
	[FieldOffset(Offset = "0x60")]
	private int m_FlowScaleXId;

	[Token(Token = "0x400254F")]
	[FieldOffset(Offset = "0x64")]
	private int m_FlowScaleYId;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4002550")]
	private int m_SpeedXId;

	[Token(Token = "0x4002551")]
	[FieldOffset(Offset = "0x6C")]
	private int m_SpeedYId;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4002552")]
	private int m_OffsetXId;

	[Token(Token = "0x4002553")]
	[FieldOffset(Offset = "0x74")]
	private int m_OffsetYId;

	[Address(RVA = "0xC6F9A0", Offset = "0xC6E1A0", Length = "0x3F7")]
	[Token(Token = "0x6004176")]
	private void Start()
	{
	}

	[Token(Token = "0x6004177")]
	[Address(RVA = "0xC6F850", Offset = "0xC6E050", Length = "0x14B")]
	public void SetParas()
	{
	}

	[Token(Token = "0x6004178")]
	[Address(RVA = "0xC6FDA0", Offset = "0xC6E5A0", Length = "0x56")]
	public FlowTexture()
	{
	}
}
