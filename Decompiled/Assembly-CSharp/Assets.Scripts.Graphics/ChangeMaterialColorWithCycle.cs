using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Graphics;

[Token(Token = "0x20006EE")]
public class ChangeMaterialColorWithCycle : MonoBehaviour
{
	[Attribute(Name = "HeaderAttribute", RVA = "0x715F0", Offset = "0x709F0")]
	[SerializeField]
	[Token(Token = "0x4002535")]
	[FieldOffset(Offset = "0x18")]
	private float cycleSpeed;

	[Token(Token = "0x4002536")]
	[SerializeField]
	[FieldOffset(Offset = "0x1C")]
	private bool useSmoothTransition;

	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002537")]
	private ColorRange[] m_ColorRanges;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002538")]
	private Material[] m_TargetMaterials;

	[Address(RVA = "0xC6EAB0", Offset = "0xC6D2B0", Length = "0x5B")]
	[Token(Token = "0x600416D")]
	private void Start()
	{
	}

	[Address(RVA = "0xC6EB10", Offset = "0xC6D310", Length = "0x420")]
	[Token(Token = "0x600416E")]
	private void Update()
	{
	}

	[Token(Token = "0x600416F")]
	[Address(RVA = "0xC6EA10", Offset = "0xC6D210", Length = "0x95")]
	private float CalculateChannelValue(float time, float min, float max)
	{
		return default(float);
	}

	[Address(RVA = "0xC6EF40", Offset = "0xC6D740", Length = "0x12")]
	[Token(Token = "0x6004170")]
	public ChangeMaterialColorWithCycle()
	{
	}
}
