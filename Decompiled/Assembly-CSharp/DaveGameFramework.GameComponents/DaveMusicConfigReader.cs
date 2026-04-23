using System.Collections.Generic;
using Assets.Scripts.Database;
using Cpp2ILInjected;
using GameLogic;

namespace DaveGameFramework.GameComponents;

[Token(Token = "0x20004C8")]
public class DaveMusicConfigReader
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001A13")]
	private List<MusicData> m_MusicDataList;

	[Token(Token = "0x4001A14")]
	[FieldOffset(Offset = "0x18")]
	private DaveGameManager m_DaveGameManager;

	[Token(Token = "0x170004F7")]
	public List<MusicData> MusicDataList
	{
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		[Token(Token = "0x60035B0")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x99DBE0", Offset = "0x99C3E0", Length = "0x89")]
	[Token(Token = "0x60035B1")]
	public void CreateMusicData(MusicInfo musicInfo = null)
	{
	}

	[Address(RVA = "0x99D320", Offset = "0x99BB20", Length = "0x8BB")]
	[Token(Token = "0x60035B2")]
	private void CreateMusicDataInRuntime(MusicInfo musicInfo)
	{
	}

	[Token(Token = "0x60035B3")]
	[Address(RVA = "0x99DC70", Offset = "0x99C470", Length = "0xA1")]
	public DaveMusicConfigReader()
	{
	}
}
