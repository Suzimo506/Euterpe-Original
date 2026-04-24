using System;
using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Obsolete]
[Token(Token = "0x2000616")]
public class CreateList : Action
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400224E")]
	[SerializeField]
	private UnityEngine.Object m_List;

	[Token(Token = "0x400224F")]
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	private string m_Path;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002250")]
	[AttributeAttribute(Name = "VariableAttribute", RVA = "0xE5B0", Offset = "0xD9B0")]
	[SerializeField]
	private IVariable m_Count;

	[SerializeField]
	[Token(Token = "0x4002251")]
	[FieldOffset(Offset = "0x28")]
	private bool m_AutoCount;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002252")]
	[SerializeField]
	private string m_JsonKey;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002253")]
	[HideInInspector]
	[SerializeField]
	private List<GameObject> m_GameObjects;

	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4002254")]
	private GameObject m_Parent;

	[SerializeField]
	[HideInInspector]
	[Token(Token = "0x4002255")]
	[FieldOffset(Offset = "0x48")]
	private int m_MaxCount;

	[Token(Token = "0x4002256")]
	[FieldOffset(Offset = "0x50")]
	private List<string> m_JsonKeys;

	[Address(RVA = "0x73D390", Offset = "0x73BB90", Length = "0x5C")]
	[Token(Token = "0x6003B4E")]
	public void SetCount(int count)
	{
	}

	[Token(Token = "0x6003B4F")]
	[Address(RVA = "0x73C990", Offset = "0x73B190", Length = "0x7")]
	public override void Enter()
	{
	}

	[Address(RVA = "0x73C9A0", Offset = "0x73B1A0", Length = "0x1BA")]
	[Token(Token = "0x6003B50")]
	public override void Execute()
	{
	}

	[Address(RVA = "0x73CB60", Offset = "0x73B360", Length = "0x3A5")]
	[Token(Token = "0x6003B51")]
	private void OnJsonKeyChanged(string value)
	{
	}

	[Address(RVA = "0x73CF10", Offset = "0x73B710", Length = "0x47A")]
	[Token(Token = "0x6003B52")]
	private void OnListChanged()
	{
	}

	[Token(Token = "0x6003B53")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public CreateList()
	{
	}
}
