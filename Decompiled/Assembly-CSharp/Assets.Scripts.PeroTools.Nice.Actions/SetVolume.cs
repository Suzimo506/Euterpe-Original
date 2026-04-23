using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x200063A")]
public class SetVolume : Action
{
	[Token(Token = "0x2000BE6")]
	public enum AudioType
	{
		[Token(Token = "0x4003BAA")]
		BGM,
		[Token(Token = "0x4003BAB")]
		Others
	}

	[SerializeField]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400231D")]
	private AudioType m_AudioType;

	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x400231E")]
	private AudioSource m_AudioSource;

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400231F")]
	[Attribute(Name = "VariableAttribute", RVA = "0x252B0", Offset = "0x246B0")]
	private IVariable m_Volume;

	[Token(Token = "0x4002320")]
	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	private float m_Duration;

	[SerializeField]
	[Token(Token = "0x4002321")]
	[FieldOffset(Offset = "0x2C")]
	private Ease m_Ease;

	[Address(RVA = "0x74E8C0", Offset = "0x74D0C0", Length = "0x74")]
	[Token(Token = "0x6003BF1")]
	public override void Execute()
	{
	}

	[Address(RVA = "0x74E940", Offset = "0x74D140", Length = "0x171")]
	[Token(Token = "0x6003BF2")]
	private void SetAudioSourceVolume(AudioSource audioSource)
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003BF3")]
	public SetVolume()
	{
	}
}
