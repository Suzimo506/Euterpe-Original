using System;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Effects;

[Token(Token = "0x20008A0")]
public class ColorGradient
{
	[Serializable]
	[Token(Token = "0x2000D43")]
	private struct GraphicGradient
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4003F2B")]
		public Color form;

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003F2C")]
		public Color to;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003F2D")]
		public Graphic graphic;
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002CDF")]
	[SerializeField]
	private GraphicGradient[] m_Gradients;

	[Token(Token = "0x4002CE0")]
	[FieldOffset(Offset = "0x18")]
	private Tweener[] m_Tweener;

	[Token(Token = "0x4002CE1")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float m_ChangeTime;

	[Token(Token = "0x6004E23")]
	[Address(RVA = "0x5ABE20", Offset = "0x5AA620", Length = "0xC4")]
	private void KillAllTweener()
	{
	}

	[Token(Token = "0x6004E24")]
	[Address(RVA = "0x5ABEF0", Offset = "0x5AA6F0", Length = "0x7")]
	public void StopChangeColor()
	{
	}

	[Token(Token = "0x6004E25")]
	[Address(RVA = "0x5ABC20", Offset = "0x5AA420", Length = "0x1FE")]
	public void ChangeColor(bool isShowTo)
	{
	}

	[Token(Token = "0x6004E26")]
	[Address(RVA = "0x5ABF00", Offset = "0x5AA700", Length = "0xE")]
	public ColorGradient()
	{
	}
}
