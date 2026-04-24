using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Graphics;

[Attribute(Name = "RequireComponent", RVA = "0x71F60", Offset = "0x71360")]
[Token(Token = "0x20006F0")]
public class DynamicGradient : MonoBehaviour
{
	[Token(Token = "0x400253D")]
	[FieldOffset(Offset = "0x18")]
	public Gradient[] keyGradient;

	[Attribute(Name = "TooltipAttribute", RVA = "0x721D0", Offset = "0x715D0")]
	[Token(Token = "0x400253E")]
	[FieldOffset(Offset = "0x20")]
	public float timeStep;

	[Attribute(Name = "TooltipAttribute", RVA = "0x72340", Offset = "0x71740")]
	[Token(Token = "0x400253F")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve timeStepCurve;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002540")]
	private Gradient m_Origin;

	[Token(Token = "0x4002541")]
	[FieldOffset(Offset = "0x38")]
	private float m_PassTime;

	[Token(Token = "0x4002542")]
	[FieldOffset(Offset = "0x40")]
	private GradientFog m_target;

	[Address(RVA = "0xC6F1B0", Offset = "0xC6D9B0", Length = "0x17F")]
	[Token(Token = "0x6004173")]
	private void Start()
	{
	}

	[Address(RVA = "0xC6F330", Offset = "0xC6DB30", Length = "0x50B")]
	[Token(Token = "0x6004174")]
	private void Update()
	{
	}

	[Address(RVA = "0xC6F840", Offset = "0xC6E040", Length = "0xE")]
	[Token(Token = "0x6004175")]
	public DynamicGradient()
	{
	}
}
