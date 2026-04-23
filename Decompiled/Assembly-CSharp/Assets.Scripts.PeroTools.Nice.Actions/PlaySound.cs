using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x2000626")]
public class PlaySound : Action
{
	[Attribute(Name = "OnConstanceChangedAttribute", RVA = "0x164B0", Offset = "0x158B0")]
	[Attribute(Name = "VariableAttribute", RVA = "0x164B0", Offset = "0x158B0")]
	[SerializeField]
	[Token(Token = "0x400228F")]
	[FieldOffset(Offset = "0x10")]
	private IVariable m_AudioClipSource;

	[SerializeField]
	[Attribute(Name = "VariableAttribute", RVA = "0x16630", Offset = "0x15A30")]
	[Token(Token = "0x4002290")]
	[FieldOffset(Offset = "0x18")]
	private IVariable m_Volume;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002291")]
	private AudioClip m_AudioClip;

	[Token(Token = "0x4002292")]
	[HideInInspector]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<string> m_AudioClipNames;

	[Token(Token = "0x1700058B")]
	public override float duration
	{
		[Address(RVA = "0x746C70", Offset = "0x745470", Length = "0x85")]
		[Token(Token = "0x6003B85")]
		get
		{
			return default(float);
		}
	}

	[Address(RVA = "0x7469E0", Offset = "0x7451E0", Length = "0xFE")]
	[Token(Token = "0x6003B86")]
	public override void Enter()
	{
	}

	[Address(RVA = "0x746AE0", Offset = "0x7452E0", Length = "0x183")]
	[Token(Token = "0x6003B87")]
	public override void Execute()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003B88")]
	public PlaySound()
	{
	}
}
