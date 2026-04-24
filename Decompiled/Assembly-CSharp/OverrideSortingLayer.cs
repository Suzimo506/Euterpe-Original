using Assets.Scripts.PeroTools.Nice.Actions;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200006B")]
public class OverrideSortingLayer : Action
{
	[Token(Token = "0x40002F3")]
	[FieldOffset(Offset = "0x10")]
	public Transform target;

	[Token(Token = "0x40002F4")]
	[FieldOffset(Offset = "0x18")]
	public string layerName;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002F5")]
	public int sortingOrder;

	[Address(RVA = "0x8726C0", Offset = "0x870EC0", Length = "0xBF")]
	[Token(Token = "0x6000322")]
	public override void Execute()
	{
	}

	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	[Token(Token = "0x6000323")]
	public OverrideSortingLayer()
	{
	}
}
