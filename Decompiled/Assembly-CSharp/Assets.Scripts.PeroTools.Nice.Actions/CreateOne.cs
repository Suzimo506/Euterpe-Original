using System;
using System.Collections.Generic;
using Assets.Scripts.PeroTools.Managers;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x2000617")]
[Obsolete]
public class CreateOne : Action
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002257")]
	[SerializeField]
	private bool m_IsPro;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002258")]
	[SerializeField]
	private UnityEngine.Object m_List;

	[Token(Token = "0x4002259")]
	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	private string m_JsonKey;

	[SerializeField]
	[HideInInspector]
	[Token(Token = "0x400225A")]
	[FieldOffset(Offset = "0x28")]
	private List<string> m_ObjectNames;

	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[HideInInspector]
	[Token(Token = "0x400225B")]
	private GameObject m_GameObject;

	[SerializeField]
	[HideInInspector]
	[Token(Token = "0x400225C")]
	[FieldOffset(Offset = "0x38")]
	private string m_Path;

	[SerializeField]
	[AttributeAttribute(Name = "VariableAttribute", RVA = "0xFD90", Offset = "0xF190")]
	[Token(Token = "0x400225D")]
	[FieldOffset(Offset = "0x40")]
	private IVariable m_Index;

	[SerializeField]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400225E")]
	private int m_Preload;

	[Token(Token = "0x400225F")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private int m_Capacity;

	[Token(Token = "0x4002260")]
	[SerializeField]
	[AttributeAttribute(Name = "VariableAttribute", RVA = "0x115D0", Offset = "0x109D0")]
	[FieldOffset(Offset = "0x50")]
	private IVariable m_Position;

	[SerializeField]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "VariableAttribute", RVA = "0x118A0", Offset = "0x10CA0")]
	[Token(Token = "0x4002261")]
	private IVariable m_Rotation;

	[HideInInspector]
	[Token(Token = "0x4002262")]
	[FieldOffset(Offset = "0x60")]
	public GameObject rootGameObject;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4002263")]
	private GameObject m_CreatedGameObject;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4002264")]
	private Effect m_Effect;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4002265")]
	private List<string> m_JsonKeys;

	[Token(Token = "0x17000582")]
	public int count
	{
		[Token(Token = "0x6003B55")]
		[Address(RVA = "0x73E0F0", Offset = "0x73C8F0", Length = "0x3C")]
		get
		{
			return default(int);
		}
	}

	[Address(RVA = "0x73E050", Offset = "0x73C850", Length = "0x73")]
	[Token(Token = "0x6003B54")]
	public void SetIndex(int index)
	{
	}

	[Address(RVA = "0x73D3F0", Offset = "0x73BBF0", Length = "0xD5")]
	[Token(Token = "0x6003B56")]
	public override void Enter()
	{
	}

	[Address(RVA = "0x73D4D0", Offset = "0x73BCD0", Length = "0x55A")]
	[Token(Token = "0x6003B57")]
	public override void Execute()
	{
	}

	[Token(Token = "0x6003B58")]
	[Address(RVA = "0x73E010", Offset = "0x73C810", Length = "0x11")]
	public override void Pause()
	{
	}

	[Token(Token = "0x6003B59")]
	[Address(RVA = "0x73E030", Offset = "0x73C830", Length = "0x11")]
	public override void Resume()
	{
	}

	[Token(Token = "0x6003B5A")]
	[Address(RVA = "0x73DA30", Offset = "0x73C230", Length = "0x5B")]
	public override void Exit()
	{
	}

	[Token(Token = "0x6003B5B")]
	[Address(RVA = "0x73DD10", Offset = "0x73C510", Length = "0x2FC")]
	public void OnListChanged()
	{
	}

	[Token(Token = "0x6003B5C")]
	[Address(RVA = "0x73DA90", Offset = "0x73C290", Length = "0x276")]
	private void OnJsonKeyChanged(string value)
	{
	}

	[Token(Token = "0x6003B5D")]
	[Address(RVA = "0x73E0D0", Offset = "0x73C8D0", Length = "0x15")]
	public CreateOne()
	{
	}
}
