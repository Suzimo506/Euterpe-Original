using System.Collections.Generic;
using Cpp2ILInjected;
using GameLogic;

[Token(Token = "0x200000B")]
public abstract class BaseConfigReader
{
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x10")]
	protected List<MusicData> m_DataBuffer;

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6000021")]
	protected abstract void Init();

	[Address(RVA = "0x5F3A80", Offset = "0x5F2280", Length = "0x76")]
	[Token(Token = "0x6000022")]
	public List<MusicData> CreateMusicDatas()
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x5F3B00", Offset = "0x5F2300", Length = "0x430")]
	internal static void MusicTickDataSort(List<MusicData> musicTickData)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x5F3F40", Offset = "0x5F2740", Length = "0x69")]
	protected BaseConfigReader()
	{
	}
}
