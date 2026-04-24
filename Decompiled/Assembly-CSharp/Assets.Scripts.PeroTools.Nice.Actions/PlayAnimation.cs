using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x2000622")]
public class PlayAnimation : Action
{
	[SerializeField]
	[Attribute(Name = "VariableAttribute", RVA = "0x14B30", Offset = "0x13F30")]
	[Token(Token = "0x4002279")]
	[FieldOffset(Offset = "0x10")]
	private IVariable m_Object;

	[Token(Token = "0x400227A")]
	[Attribute(Name = "VariableAttribute", RVA = "0x14E20", Offset = "0x14220")]
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	private IVariable m_Loop;

	[Attribute(Name = "VariableAttribute", RVA = "0x14FE0", Offset = "0x143E0")]
	[Token(Token = "0x400227B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private IVariable m_Speed;

	[SerializeField]
	[Token(Token = "0x400227C")]
	[FieldOffset(Offset = "0x28")]
	private int m_Layer;

	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400227D")]
	[SerializeField]
	private AnimationType m_AnimationType;

	[Token(Token = "0x400227E")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ActionType m_ActionType;

	[Attribute(Name = "VariableAttribute", RVA = "0x15600", Offset = "0x14A00")]
	[Token(Token = "0x400227F")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<IVariable> m_AnimNames;

	[Token(Token = "0x4002280")]
	[SerializeField]
	[FieldOffset(Offset = "0x40")]
	private Object m_AnimObject;

	[Token(Token = "0x4002281")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float m_Duration;

	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4002282")]
	private bool m_IsPlaying;

	[Token(Token = "0x17000588")]
	public override float duration
	{
		[Token(Token = "0x6003B7E")]
		[Address(RVA = "0x746380", Offset = "0x744B80", Length = "0x6")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000589")]
	public bool isComplete
	{
		[Token(Token = "0x6003B80")]
		[Address(RVA = "0x746390", Offset = "0x744B90", Length = "0x306")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6003B7F")]
	[Address(RVA = "0x7459A0", Offset = "0x7441A0", Length = "0x926")]
	public override void Execute()
	{
	}

	[Token(Token = "0x6003B81")]
	[Address(RVA = "0x7462D0", Offset = "0x744AD0", Length = "0xA8")]
	public PlayAnimation()
	{
	}
}
