using Cpp2ILInjected;
using PeroPeroGames.GlobalDefines;
using UnityEngine;

namespace Assets.Scripts.UI.Components.NiceReplacement;

[Token(Token = "0x20008BF")]
public class ReplacedPlaySound : MonoBehaviour, IPlayable
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4002D9B")]
	private AudioClip m_Clip;

	[SerializeField]
	[Token(Token = "0x4002D9C")]
	[FieldOffset(Offset = "0x20")]
	private bool m_UseSettingVolume;

	[SerializeField]
	[Token(Token = "0x4002D9D")]
	[FieldOffset(Offset = "0x24")]
	private PeroAudioType m_VolumeType;

	[SerializeField]
	[Token(Token = "0x4002D9E")]
	[FieldOffset(Offset = "0x28")]
	private float m_Volume;

	[Address(RVA = "0x5B2FA0", Offset = "0x5B17A0", Length = "0x100")]
	[Token(Token = "0x6004EE3")]
	public void Execute()
	{
	}

	[Address(RVA = "0x5B30A0", Offset = "0x5B18A0", Length = "0x19")]
	[Token(Token = "0x6004EE4")]
	public ReplacedPlaySound()
	{
	}
}
