using System.Collections.Generic;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.GameCore.Managers;

[CreateAssetMenu]
[Token(Token = "0x200075C")]
public class VoiceSetting : SingletonScriptableObject<VoiceSetting>
{
	[Token(Token = "0x2000CF5")]
	public class Voice
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003E4E")]
		public int index;

		[Token(Token = "0x4003E4F")]
		[FieldOffset(Offset = "0x18")]
		public List<string> voiceNames;

		[Token(Token = "0x4003E50")]
		[FieldOffset(Offset = "0x20")]
		public List<string> catNames;

		[Token(Token = "0x600630A")]
		[Address(RVA = "0x7E09C0", Offset = "0x7DF1C0", Length = "0x9D")]
		public Voice()
		{
		}

		[Token(Token = "0x600630B")]
		[Address(RVA = "0x7E0900", Offset = "0x7DF100", Length = "0xB0")]
		public List<string> GetVoices(int skin)
		{
			return null;
		}

		[Address(RVA = "0x7E0A60", Offset = "0x7DF260", Length = "0x8D")]
		[Token(Token = "0x600630C")]
		public Voice(Voice copy)
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x40026F1")]
	[FieldOffset(Offset = "0x58")]
	private List<Voice> m_ApplyVoices;

	[SerializeField]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40026F2")]
	private List<Voice> m_StartVoices;

	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x40026F3")]
	private List<Voice> m_FailVoices;

	[SerializeField]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40026F4")]
	private List<Voice> m_VictoryVoices;

	[SerializeField]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40026F5")]
	private List<Voice> m_PeroLogoVoices;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40026F6")]
	[SerializeField]
	private List<Voice> m_HasuLogoVoices;

	[SerializeField]
	[Token(Token = "0x40026F7")]
	[FieldOffset(Offset = "0x88")]
	private List<Voice> m_HurtVoices;

	[Token(Token = "0x40026F8")]
	[SerializeField]
	[FieldOffset(Offset = "0x90")]
	private List<Voice> m_EmptyHits;

	[Token(Token = "0x600451F")]
	[Address(RVA = "0x7E01C0", Offset = "0x7DE9C0", Length = "0x2C0")]
	public Voice GetVoiceConfig(VoiceType type, int index = -1, bool copy = true)
	{
		return null;
	}

	[Token(Token = "0x6004520")]
	[Address(RVA = "0x7E04A0", Offset = "0x7DECA0", Length = "0x280")]
	public string GetVoice(VoiceType type, int index, int skin)
	{
		return null;
	}

	[Address(RVA = "0x7E0740", Offset = "0x7DEF40", Length = "0x1B2")]
	[Token(Token = "0x6004521")]
	public VoiceSetting()
	{
		((SingletonScriptableObject<>)(object)this)._002Ector();
	}
}
