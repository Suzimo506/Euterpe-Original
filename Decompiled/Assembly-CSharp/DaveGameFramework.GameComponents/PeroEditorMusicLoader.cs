using Cpp2ILInjected;
using UnityEngine;

namespace DaveGameFramework.GameComponents;

[Token(Token = "0x20004CD")]
public class PeroEditorMusicLoader
{
	[Token(Token = "0x4001A24")]
	private static PeroEditorMusicLoader s_Instance;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001A25")]
	private AudioClip m_BmsBattleAudioClip;

	[Token(Token = "0x60035C5")]
	[Address(RVA = "0x9A0AD0", Offset = "0x99F2D0", Length = "0x64")]
	public static AudioClip GetBgm()
	{
		return null;
	}

	[Address(RVA = "0x9A0B40", Offset = "0x99F340", Length = "0x8B")]
	[Token(Token = "0x60035C6")]
	public static void LoadAudioClip(string fullMusicPath)
	{
	}

	[Token(Token = "0x60035C7")]
	[Address(RVA = "0x9A0BD0", Offset = "0x99F3D0", Length = "0x1F9")]
	private AudioClip LoadFileAudioClip(string path)
	{
		return null;
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60035C8")]
	public PeroEditorMusicLoader()
	{
	}
}
