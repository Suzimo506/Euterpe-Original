using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x2000619")]
public class FadeIn : Action
{
	[SerializeField]
	[Attribute(Name = "VariableAttribute", RVA = "0x120B0", Offset = "0x114B0")]
	[Token(Token = "0x4002267")]
	[FieldOffset(Offset = "0x10")]
	private IVariable m_GameObejct;

	[Attribute(Name = "VariableAttribute", RVA = "0x122A0", Offset = "0x116A0")]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002268")]
	[SerializeField]
	private IVariable m_From;

	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "VariableAttribute", RVA = "0x12630", Offset = "0x11A30")]
	[Token(Token = "0x4002269")]
	private IVariable m_Duration;

	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400226A")]
	private Ease m_Ease;

	[Token(Token = "0x400226B")]
	[FieldOffset(Offset = "0x30")]
	private Tweener m_Tweener;

	[Token(Token = "0x400226C")]
	[FieldOffset(Offset = "0x38")]
	private CanvasGroup m_CanvasGroup;

	[Token(Token = "0x17000583")]
	public override float duration
	{
		[Address(RVA = "0x73E520", Offset = "0x73CD20", Length = "0x5E")]
		[Token(Token = "0x6003B60")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6003B61")]
	[Address(RVA = "0x73E280", Offset = "0x73CA80", Length = "0x1C5")]
	public override void Execute()
	{
	}

	[Token(Token = "0x6003B62")]
	[Address(RVA = "0x73E450", Offset = "0x73CC50", Length = "0x53")]
	public override void Pause()
	{
	}

	[Token(Token = "0x6003B63")]
	[Address(RVA = "0x73E4B0", Offset = "0x73CCB0", Length = "0x53")]
	public override void Resume()
	{
	}

	[Token(Token = "0x6003B64")]
	[Address(RVA = "0x73E510", Offset = "0x73CD10", Length = "0xE")]
	public FadeIn()
	{
	}
}
