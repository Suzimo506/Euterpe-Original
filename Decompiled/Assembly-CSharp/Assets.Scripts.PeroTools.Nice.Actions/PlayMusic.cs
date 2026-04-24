using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x2000625")]
public class PlayMusic : Action
{
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "VariableAttribute", RVA = "0x15FE0", Offset = "0x153E0")]
	[SerializeField]
	[Token(Token = "0x400228A")]
	[Attribute(Name = "OnConstanceChangedAttribute", RVA = "0x15FE0", Offset = "0x153E0")]
	private IVariable m_AudioClipSource;

	[SerializeField]
	[Attribute(Name = "VariableAttribute", RVA = "0x16190", Offset = "0x15590")]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400228B")]
	private IVariable m_FadeInTime;

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400228C")]
	private Ease m_Ease;

	[Token(Token = "0x400228D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[HideInInspector]
	private List<string> m_AudioClipNames;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400228E")]
	private AudioClip m_AudioClip;

	[Token(Token = "0x1700058A")]
	public override float duration
	{
		[Token(Token = "0x6003B82")]
		[Address(RVA = "0x746840", Offset = "0x745040", Length = "0x85")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6003B83")]
	[Address(RVA = "0x7466A0", Offset = "0x744EA0", Length = "0x181")]
	public override void Execute()
	{
	}

	[Address(RVA = "0x746830", Offset = "0x745030", Length = "0xE")]
	[Token(Token = "0x6003B84")]
	public PlayMusic()
	{
	}
}
