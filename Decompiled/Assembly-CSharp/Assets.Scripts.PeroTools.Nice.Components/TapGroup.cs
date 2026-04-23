using Assets.Scripts.PeroTools.Nice.Actions;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Components;

[Token(Token = "0x200060B")]
public class TapGroup : Action
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400222E")]
	public Transform tapGroupRoot;

	[Token(Token = "0x400222F")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "VariableAttribute", RVA = "0xC400", Offset = "0xB800")]
	public IVariable activeIndex;

	[Token(Token = "0x4002230")]
	[FieldOffset(Offset = "0x20")]
	private Transform m_CurrentActive;

	[Address(RVA = "0x985310", Offset = "0x983B10", Length = "0x15A")]
	[Token(Token = "0x6003B28")]
	public override void Execute()
	{
	}

	[Address(RVA = "0x985280", Offset = "0x983A80", Length = "0x86")]
	[Token(Token = "0x6003B29")]
	public override void Enter()
	{
	}

	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	[Token(Token = "0x6003B2A")]
	public TapGroup()
	{
	}
}
