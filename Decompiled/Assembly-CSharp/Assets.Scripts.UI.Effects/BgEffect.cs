using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Effects;

[Token(Token = "0x200089E")]
[Attribute(Name = "RequireComponent", RVA = "0x3E340", Offset = "0x3D740")]
public class BgEffect : MonoBehaviour
{
	[Token(Token = "0x4002CD8")]
	[FieldOffset(Offset = "0x18")]
	public string fadeInAnimName;

	[Token(Token = "0x4002CD9")]
	[FieldOffset(Offset = "0x20")]
	public string fadeOutAnimName;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002CDA")]
	private Animator m_Animator;

	[Address(RVA = "0x5A7810", Offset = "0x5A6010", Length = "0x47")]
	[Token(Token = "0x6004E1D")]
	private void Awake()
	{
	}

	[Address(RVA = "0x5A7860", Offset = "0x5A6060", Length = "0x8F")]
	[Token(Token = "0x6004E1E")]
	public void FadeIn()
	{
	}

	[Token(Token = "0x6004E1F")]
	[Address(RVA = "0x5A78F0", Offset = "0x5A60F0", Length = "0x8F")]
	public void FadeOut()
	{
	}

	[Token(Token = "0x6004E20")]
	[Address(RVA = "0x5A7980", Offset = "0x5A6180", Length = "0x59")]
	public BgEffect()
	{
	}
}
