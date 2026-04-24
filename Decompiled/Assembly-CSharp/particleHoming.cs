using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000A7")]
[ExecuteInEditMode]
public class particleHoming : MonoBehaviour
{
	[Attribute(Name = "TooltipAttribute", RVA = "0x97860", Offset = "0x96C60")]
	[Token(Token = "0x400046E")]
	[FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x400046F")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x97990", Offset = "0x96D90")]
	public float speed;

	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000470")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x97B20", Offset = "0x96F20")]
	public float maxSpeed;

	[Attribute(Name = "TooltipAttribute", RVA = "0x97C60", Offset = "0x97060")]
	[Token(Token = "0x4000471")]
	[FieldOffset(Offset = "0x28")]
	public float homingDelay;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000472")]
	private ParticleSystem m_System;

	[Token(Token = "0x4000473")]
	[FieldOffset(Offset = "0x38")]
	private ParticleSystem.Particle[] m_Particles;

	[Token(Token = "0x6000511")]
	[Address(RVA = "0xD34A50", Offset = "0xD33250", Length = "0xEC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000512")]
	[Address(RVA = "0xD34400", Offset = "0xD32C00", Length = "0x649")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000513")]
	[Address(RVA = "0xD342A0", Offset = "0xD32AA0", Length = "0x159")]
	private void InitializeIfNeeded()
	{
	}

	[Token(Token = "0x6000514")]
	[Address(RVA = "0xD34B40", Offset = "0xD33340", Length = "0x1C")]
	public particleHoming()
	{
	}
}
