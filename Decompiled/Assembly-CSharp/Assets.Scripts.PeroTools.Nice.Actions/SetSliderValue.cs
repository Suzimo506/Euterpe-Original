using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x2000634")]
public class SetSliderValue : Action
{
	[Attribute(Name = "VariableAttribute", RVA = "0x21150", Offset = "0x20550")]
	[Token(Token = "0x40022FD")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private IVariable m_Object;

	[SerializeField]
	[Attribute(Name = "VariableAttribute", RVA = "0x21300", Offset = "0x20700")]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40022FE")]
	private IVariable m_Percent;

	[SerializeField]
	[Attribute(Name = "VariableAttribute", RVA = "0x21480", Offset = "0x20880")]
	[Token(Token = "0x40022FF")]
	[FieldOffset(Offset = "0x20")]
	private IVariable m_Duration;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002300")]
	[Attribute(Name = "VariableAttribute", RVA = "0x21660", Offset = "0x20A60")]
	[SerializeField]
	private IVariable m_Curve;

	[Token(Token = "0x4002301")]
	[FieldOffset(Offset = "0x30")]
	private Tweener m_Tweener;

	[Token(Token = "0x4002302")]
	[FieldOffset(Offset = "0x38")]
	private DG.Tweening.Sequence m_Sequence;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002303")]
	private Slider m_Slider;

	[Token(Token = "0x4002304")]
	[FieldOffset(Offset = "0x48")]
	private Image m_Image;

	[Token(Token = "0x17000592")]
	public override float duration
	{
		[Token(Token = "0x6003BD6")]
		[Address(RVA = "0x74C9B0", Offset = "0x74B1B0", Length = "0x5E")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6003BD7")]
	[Address(RVA = "0x74BE20", Offset = "0x74A620", Length = "0x9E2")]
	public override void Execute()
	{
	}

	[Token(Token = "0x6003BD8")]
	[Address(RVA = "0x74C810", Offset = "0x74B010", Length = "0x3A")]
	public override void Exit()
	{
	}

	[Token(Token = "0x6003BD9")]
	[Address(RVA = "0x74C850", Offset = "0x74B050", Length = "0x77")]
	public override void Pause()
	{
	}

	[Token(Token = "0x6003BDA")]
	[Address(RVA = "0x74C8D0", Offset = "0x74B0D0", Length = "0x77")]
	public override void Resume()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003BDB")]
	public SetSliderValue()
	{
	}
}
