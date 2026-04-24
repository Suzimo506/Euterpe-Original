using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x200061A")]
public class FadeOut : Action
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400226D")]
	[Attribute(Name = "VariableAttribute", RVA = "0x129A0", Offset = "0x11DA0")]
	[SerializeField]
	private IVariable m_GameObejct;

	[SerializeField]
	[Attribute(Name = "VariableAttribute", RVA = "0x12B10", Offset = "0x11F10")]
	[Token(Token = "0x400226E")]
	[FieldOffset(Offset = "0x18")]
	private IVariable m_To;

	[SerializeField]
	[Token(Token = "0x400226F")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "VariableAttribute", RVA = "0x14220", Offset = "0x13620")]
	private IVariable m_Duration;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002270")]
	[SerializeField]
	private Ease m_Ease;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002271")]
	private Tweener m_Tweener;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002272")]
	private CanvasGroup m_CanvasGroup;

	[Token(Token = "0x17000584")]
	public override float duration
	{
		[Token(Token = "0x6003B65")]
		[Address(RVA = "0x73E800", Offset = "0x73D000", Length = "0x5E")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6003B66")]
	[Address(RVA = "0x73E580", Offset = "0x73CD80", Length = "0x1B6")]
	public override void Execute()
	{
	}

	[Token(Token = "0x6003B67")]
	[Address(RVA = "0x73E740", Offset = "0x73CF40", Length = "0x53")]
	public override void Pause()
	{
	}

	[Address(RVA = "0x73E7A0", Offset = "0x73CFA0", Length = "0x53")]
	[Token(Token = "0x6003B68")]
	public override void Resume()
	{
	}

	[Token(Token = "0x6003B69")]
	[Address(RVA = "0x73E510", Offset = "0x73CD10", Length = "0xE")]
	public FadeOut()
	{
	}
}
