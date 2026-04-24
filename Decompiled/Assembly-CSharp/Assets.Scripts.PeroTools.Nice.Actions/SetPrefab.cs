using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x2000633")]
public class SetPrefab : Action
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40022F8")]
	[SerializeField]
	private bool m_IsPro;

	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40022F9")]
	private IVariable m_Prefab;

	[SerializeField]
	[Token(Token = "0x40022FA")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "VariableAttribute", RVA = "0x20CA0", Offset = "0x200A0")]
	private IVariable m_Count;

	[SerializeField]
	[Token(Token = "0x40022FB")]
	[FieldOffset(Offset = "0x28")]
	private Transform m_Transform;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40022FC")]
	private List<GameObject> m_GameObjects;

	[Address(RVA = "0x74BBD0", Offset = "0x74A3D0", Length = "0xD7")]
	[Token(Token = "0x6003BD3")]
	public override void Execute()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003BD4")]
	public SetPrefab()
	{
	}
}
