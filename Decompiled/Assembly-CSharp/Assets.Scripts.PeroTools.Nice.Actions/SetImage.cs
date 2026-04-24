using System;
using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Obsolete]
[Token(Token = "0x2000632")]
public class SetImage : Action
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40022F4")]
	[AttributeAttribute(Name = "VariableAttribute", RVA = "0x20020", Offset = "0x1F420")]
	[SerializeField]
	private IVariable m_Object;

	[Token(Token = "0x40022F5")]
	[AttributeAttribute(Name = "OnConstanceChangedAttribute", RVA = "0x20340", Offset = "0x1F740")]
	[AttributeAttribute(Name = "VariableAttribute", RVA = "0x20340", Offset = "0x1F740")]
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	private IVariable m_ImageSource;

	[Token(Token = "0x40022F6")]
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[SerializeField]
	private string m_Path;

	[SerializeField]
	[HideInInspector]
	[Token(Token = "0x40022F7")]
	[FieldOffset(Offset = "0x28")]
	private List<string> m_TextureNames;

	[Token(Token = "0x6003BCF")]
	[Address(RVA = "0x74B9B0", Offset = "0x74A1B0", Length = "0x87")]
	public override void Enter()
	{
	}

	[Address(RVA = "0x74BA40", Offset = "0x74A240", Length = "0x18B")]
	[Token(Token = "0x6003BD0")]
	public override void Execute()
	{
	}

	[Token(Token = "0x6003BD1")]
	[Address(RVA = "0x74B9B0", Offset = "0x74A1B0", Length = "0x87")]
	private void OnImageSourceChanged()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003BD2")]
	public SetImage()
	{
	}
}
