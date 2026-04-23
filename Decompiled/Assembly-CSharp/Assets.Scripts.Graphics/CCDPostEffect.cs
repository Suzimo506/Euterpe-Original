using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

namespace Assets.Scripts.Graphics;

[Token(Token = "0x20006EB")]
public class CCDPostEffect : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002519")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x6E530", Offset = "0x6D930")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x6E530", Offset = "0x6D930")]
	private float blurRadius;

	[Attribute(Name = "RangeAttribute", RVA = "0x6E7F0", Offset = "0x6DBF0")]
	[Token(Token = "0x400251A")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private int iteration;

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400251B")]
	[Attribute(Name = "RangeAttribute", RVA = "0x6E7F0", Offset = "0x6DBF0")]
	private float rtDownScaling;

	[Attribute(Name = "RangeAttribute", RVA = "0x18E30", Offset = "0x18230")]
	[SerializeField]
	[Token(Token = "0x400251C")]
	[FieldOffset(Offset = "0x24")]
	private float blurAlpha;

	[Token(Token = "0x400251D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x18E30", Offset = "0x18230")]
	private float noiseValue;

	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x6EEF0", Offset = "0x6E2F0")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x6EEF0", Offset = "0x6E2F0")]
	[Token(Token = "0x400251E")]
	[FieldOffset(Offset = "0x2C")]
	private float contrast;

	[Token(Token = "0x400251F")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "RangeAttribute", RVA = "0x6F320", Offset = "0x6E720")]
	[SerializeField]
	private float brightnessValue;

	[SerializeField]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "RangeAttribute", RVA = "0x6F320", Offset = "0x6E720")]
	[Token(Token = "0x4002520")]
	private float saturationValue;

	[Attribute(Name = "RangeAttribute", RVA = "0x3C050", Offset = "0x3B450")]
	[SerializeField]
	[Token(Token = "0x4002521")]
	[FieldOffset(Offset = "0x38")]
	private float hueValue;

	[Token(Token = "0x4002522")]
	[FieldOffset(Offset = "0x40")]
	private Material m_BlurMaterial;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002523")]
	private CommandBuffer m_CmdBuffer;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002524")]
	private Camera targetCamera;

	[Token(Token = "0x4002525")]
	private static readonly int s_BlurRadius;

	[Token(Token = "0x4002526")]
	private static readonly int s_BlurAlpha;

	[Token(Token = "0x4002527")]
	private static readonly int s_Contrast;

	[Token(Token = "0x4002528")]
	private static readonly int s_BrightnessValue;

	[Token(Token = "0x4002529")]
	private static readonly int s_SaturationValue;

	[Token(Token = "0x400252A")]
	private static readonly int s_HueValue;

	[Token(Token = "0x400252B")]
	private static readonly int s_BlurTex;

	[Token(Token = "0x400252C")]
	private static readonly int s_NoiseValue;

	[Address(RVA = "0x7CD470", Offset = "0x7CBC70", Length = "0x9A")]
	[Token(Token = "0x6004160")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004161")]
	[Address(RVA = "0x7CD340", Offset = "0x7CBB40", Length = "0x128")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6004162")]
	[Address(RVA = "0x7CD1A0", Offset = "0x7CB9A0", Length = "0x19C")]
	private void InitResources()
	{
	}

	[Address(RVA = "0x7CD340", Offset = "0x7CBB40", Length = "0x128")]
	[Token(Token = "0x6004163")]
	private void ReleaseResources()
	{
	}

	[Token(Token = "0x6004164")]
	[Address(RVA = "0x7CD510", Offset = "0x7CBD10", Length = "0x6C0")]
	private void UpdateCommandBuffer()
	{
	}

	[Token(Token = "0x6004165")]
	[Address(RVA = "0x7CDBE0", Offset = "0x7CC3E0", Length = "0x54")]
	private void Update()
	{
	}

	[Token(Token = "0x6004166")]
	[Address(RVA = "0x7CDD60", Offset = "0x7CC560", Length = "0x1C")]
	public CCDPostEffect()
	{
	}
}
