using System.Collections.Generic;
using System.Threading;
using Assets.Scripts.Database;
using Cpp2ILInjected;
using PeroTools2.PeroString;

namespace Assets.Scripts.Structs.Modules;

[Token(Token = "0x2000598")]
public class SearchResults
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40020DD")]
	private MusicInfoResult m_MusicResult;

	[Token(Token = "0x40020DE")]
	[FieldOffset(Offset = "0x18")]
	private MusicInfoResult m_AuthorResult;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40020DF")]
	private MusicInfoResult m_LevelDesignerResult;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40020E0")]
	private Dictionary<int, MusicInfoResult> m_MusicAlbumResults;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40020E1")]
	private MusicInfoResult[] m_MusicResults;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40020E2")]
	private MusicInfoResult[] m_AuthorResults;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40020E3")]
	private MusicInfoResult[] m_LevelDesignerResults;

	[Token(Token = "0x40020E4")]
	[FieldOffset(Offset = "0x48")]
	private PeroString[] m_PeroStrings;

	[Token(Token = "0x40020E5")]
	[FieldOffset(Offset = "0x50")]
	private ManualResetEvent[] m_ManualResetEvent;

	[Token(Token = "0x40020E6")]
	[FieldOffset(Offset = "0x58")]
	private List<List<MusicInfo>> m_Buffers;

	[Token(Token = "0x17000531")]
	private int m_AlbumResultResultCount
	{
		[Address(RVA = "0x65DAB0", Offset = "0x65C2B0", Length = "0x155")]
		[Token(Token = "0x60038BE")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000532")]
	public MusicInfoResult musicResult
	{
		[Token(Token = "0x60038BF")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000533")]
	public MusicInfoResult authorResult
	{
		[Token(Token = "0x60038C0")]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000534")]
	public MusicInfoResult levelDesignerResult
	{
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		[Token(Token = "0x60038C1")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000535")]
	public Dictionary<int, MusicInfoResult> musicAlbumResults
	{
		[Token(Token = "0x60038C2")]
		[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000536")]
	public int count
	{
		[Token(Token = "0x60038C3")]
		[Address(RVA = "0x65D9A0", Offset = "0x65C1A0", Length = "0x10F")]
		get
		{
			return default(int);
		}
	}

	[Address(RVA = "0x65D760", Offset = "0x65BF60", Length = "0x23B")]
	[Token(Token = "0x60038C4")]
	public SearchResults()
	{
	}

	[Token(Token = "0x60038C5")]
	[Address(RVA = "0x65D340", Offset = "0x65BB40", Length = "0x41A")]
	public void ToList(List<string> buffer)
	{
	}

	[Token(Token = "0x60038C6")]
	[Address(RVA = "0x65BF00", Offset = "0x65A700", Length = "0x161")]
	private MusicInfoResult[] InitList(int core)
	{
		return null;
	}

	[Token(Token = "0x60038C7")]
	[Address(RVA = "0x65AE90", Offset = "0x659690", Length = "0x46D")]
	private void ClearAll()
	{
	}

	[Token(Token = "0x60038C8")]
	[Address(RVA = "0x65C1D0", Offset = "0x65A9D0", Length = "0x5BA")]
	private void Merge()
	{
	}

	[Token(Token = "0x60038C9")]
	[Address(RVA = "0x65ADD0", Offset = "0x6595D0", Length = "0xB5")]
	private void AppendMusic(MusicInfo info, int index, bool isUnlock)
	{
	}

	[Address(RVA = "0x65AC50", Offset = "0x659450", Length = "0xB5")]
	[Token(Token = "0x60038CA")]
	private void AppendAuthor(MusicInfo info, int index, bool isUnlock)
	{
	}

	[Address(RVA = "0x65AD10", Offset = "0x659510", Length = "0xB5")]
	[Token(Token = "0x60038CB")]
	private void AppendLevelDesigner(MusicInfo info, int index, bool isUnlock)
	{
	}

	[Address(RVA = "0x65BD70", Offset = "0x65A570", Length = "0x187")]
	[Token(Token = "0x60038CC")]
	private void InitLanguageResources()
	{
	}

	[Address(RVA = "0x65B890", Offset = "0x65A090", Length = "0x4DF")]
	[Token(Token = "0x60038CD")]
	private void FindMusicJobs(int threadIndex, List<MusicInfo> buffer, string findText, PeroString strBuffer, object state)
	{
	}

	[Address(RVA = "0x65B300", Offset = "0x659B00", Length = "0x58D")]
	[Token(Token = "0x60038CE")]
	private void FindAlbumJob(int threadIndex, string findText, PeroString strBuffer, int nowLanguage, object state)
	{
	}

	[Address(RVA = "0x65C790", Offset = "0x65AF90", Length = "0x7F")]
	[Token(Token = "0x60038CF")]
	private bool PeroContains(PeroString peroString, string oriText, string containsText)
	{
		return default(bool);
	}

	[Token(Token = "0x60038D0")]
	[Address(RVA = "0x65C810", Offset = "0x65B010", Length = "0x14E")]
	private bool PeroLevelDesigner(PeroString peroString, MusicInfo musicInfo, string containsText)
	{
		return default(bool);
	}

	[Token(Token = "0x60038D1")]
	[Address(RVA = "0x65C070", Offset = "0x65A870", Length = "0x15F")]
	private void InitManualResetEvent(int coreCount)
	{
	}

	[Address(RVA = "0x65D210", Offset = "0x65BA10", Length = "0x122")]
	[Token(Token = "0x60038D2")]
	private void ReleaseJobs()
	{
	}

	[Address(RVA = "0x65C960", Offset = "0x65B160", Length = "0x8A7")]
	[Token(Token = "0x60038D3")]
	public void RefreshData(string keyword)
	{
	}
}
