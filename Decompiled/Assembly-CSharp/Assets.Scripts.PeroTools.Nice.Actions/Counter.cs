using System;
using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x2000613")]
public class Counter : Action
{
	[SerializeField]
	[AttributeAttribute(Name = "VariableAttribute", RVA = "0xD7E0", Offset = "0xCBE0")]
	[Token(Token = "0x4002242")]
	[FieldOffset(Offset = "0x10")]
	private IVariable m_Value;

	[SerializeField]
	[Token(Token = "0x4002243")]
	[FieldOffset(Offset = "0x18")]
	private List<State> m_States;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002244")]
	private List<Action<int>> m_Callbacks;

	[Address(RVA = "0x73BE00", Offset = "0x73A600", Length = "0x78D")]
	[Token(Token = "0x6003B47")]
	public override void Enter()
	{
	}

	[Address(RVA = "0x73C590", Offset = "0x73AD90", Length = "0xC2")]
	[Token(Token = "0x6003B48")]
	public override void Execute()
	{
	}

	[Address(RVA = "0x73C660", Offset = "0x73AE60", Length = "0x155")]
	[Token(Token = "0x6003B49")]
	public override void Pause()
	{
	}

	[Token(Token = "0x6003B4A")]
	[Address(RVA = "0x73C7C0", Offset = "0x73AFC0", Length = "0x155")]
	public override void Resume()
	{
	}

	[Token(Token = "0x6003B4B")]
	[Address(RVA = "0x73C920", Offset = "0x73B120", Length = "0x69")]
	public Counter()
	{
	}
}
