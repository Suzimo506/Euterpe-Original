using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Effects;

[Token(Token = "0x20008A1")]
public class ExpParticles : MonoBehaviour
{
	[Token(Token = "0x4002CE2")]
	[FieldOffset(Offset = "0x18")]
	public float expRate;

	[Token(Token = "0x4002CE3")]
	[FieldOffset(Offset = "0x20")]
	public Transform target;

	[Token(Token = "0x4002CE4")]
	[FieldOffset(Offset = "0x28")]
	private ParticleSystem m_System;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002CE5")]
	private ParticleSystem.Particle[] m_Particles;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002CE6")]
	private IVariable m_ExpVariable;

	[Token(Token = "0x4002CE7")]
	[FieldOffset(Offset = "0x40")]
	private IVariable m_ExpCount;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002CE8")]
	private IVariable m_Level;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002CE9")]
	private IVariable m_ExpPercent;

	[Token(Token = "0x4002CEA")]
	[FieldOffset(Offset = "0x58")]
	private List<IData> m_Messages;

	[Token(Token = "0x4002CEB")]
	[FieldOffset(Offset = "0x60")]
	private IData m_Message;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4002CEC")]
	private int m_Num;

	[Token(Token = "0x4002CED")]
	[FieldOffset(Offset = "0x6C")]
	private float m_Sum;

	[Token(Token = "0x4002CEE")]
	[FieldOffset(Offset = "0x70")]
	private RectTransform m_TargeTransform;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4002CEF")]
	private float m_X;

	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4002CF0")]
	private bool m_IsLevelUp;

	[Token(Token = "0x6004E27")]
	[Address(RVA = "0x5ADCE0", Offset = "0x5AC4E0", Length = "0x233")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004E28")]
	[Address(RVA = "0x5AEA10", Offset = "0x5AD210", Length = "0xBD")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6004E29")]
	[Address(RVA = "0x5AEAD0", Offset = "0x5AD2D0", Length = "0x46A")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004E2A")]
	[Address(RVA = "0x5AE030", Offset = "0x5AC830", Length = "0x9D3")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6004E2B")]
	[Address(RVA = "0x5ADF20", Offset = "0x5AC720", Length = "0x10C")]
	private void InitializeIfNeeded()
	{
	}

	[Address(RVA = "0x4E21B0", Offset = "0x4E09B0", Length = "0xE")]
	[Token(Token = "0x6004E2C")]
	public ExpParticles()
	{
	}
}
