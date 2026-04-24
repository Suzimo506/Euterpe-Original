using System.Collections.Generic;
using Cpp2ILInjected;
using PeroPeroGames.GlobalDefines;

namespace DaveGameFramework.GameComponents;

[Token(Token = "0x20004C0")]
public class DaveGameAudioController
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40019E5")]
	private Dictionary<PeroAudioType, float> m_AudioVolumesSettings;

	[Token(Token = "0x6003573")]
	[Address(RVA = "0x997250", Offset = "0x995A50", Length = "0x10B")]
	public void Init()
	{
	}

	[Address(RVA = "0x997360", Offset = "0x995B60", Length = "0x108")]
	[Token(Token = "0x6003574")]
	public void PlayAudio(string audioName, PeroAudioType audioType)
	{
	}

	[Address(RVA = "0x9974F0", Offset = "0x995CF0", Length = "0x79")]
	[Token(Token = "0x6003575")]
	public void Reset()
	{
	}

	[Token(Token = "0x6003576")]
	[Address(RVA = "0x997470", Offset = "0x995C70", Length = "0x79")]
	public void Release()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003577")]
	public DaveGameAudioController()
	{
	}
}
