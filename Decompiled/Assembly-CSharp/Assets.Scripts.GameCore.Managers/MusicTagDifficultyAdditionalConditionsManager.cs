using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Database;
using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000746")]
public class MusicTagDifficultyAdditionalConditionsManager
{
	[Token(Token = "0x4002681")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, List<string>> m_CompleteAchiDic;

	[Token(Token = "0x4002682")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, List<SavedSongResult>> m_CompleteSongInfos;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002683")]
	private HashSet<string> m_ClearSongMap;

	[Token(Token = "0x4002684")]
	[FieldOffset(Offset = "0x30")]
	private AdditionalConditionSettings m_ConditionSavedSettings;

	[Token(Token = "0x4002685")]
	[FieldOffset(Offset = "0x38")]
	private DBConfigStageAchievement m_CfgStageAchievement;

	[Token(Token = "0x17000666")]
	public DifficultyFilterDefines ConditionFilter
	{
		[CompilerGenerated]
		[Token(Token = "0x600441D")]
		[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
		get
		{
			return default(DifficultyFilterDefines);
		}
		[Token(Token = "0x600441E")]
		[CompilerGenerated]
		[Address(RVA = "0x42CB50", Offset = "0x42B350", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000667")]
	public AdditionalConditionSettings ConditionSavedSettings
	{
		[Token(Token = "0x600441F")]
		[Address(RVA = "0x45EEE0", Offset = "0x45D6E0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004420")]
	[Address(RVA = "0x6DAC30", Offset = "0x6D9430", Length = "0x17F")]
	public void Init()
	{
	}

	[Token(Token = "0x6004421")]
	[Address(RVA = "0x6DADB0", Offset = "0x6D95B0", Length = "0x6D")]
	public void Release()
	{
	}

	[Address(RVA = "0x6DAE90", Offset = "0x6D9690", Length = "0x30C")]
	[Token(Token = "0x6004422")]
	public void ScanSongBufferWithConditions(List<MusicInfo> buffer, int difficultyIndex)
	{
	}

	[Address(RVA = "0x6DA100", Offset = "0x6D8900", Length = "0x10")]
	[Token(Token = "0x6004423")]
	public void AddCondition(DifficultyFilterDefines condition)
	{
	}

	[Address(RVA = "0x6DA110", Offset = "0x6D8910", Length = "0x1C4")]
	[Token(Token = "0x6004424")]
	public void AutoMusicSelectAccordingToAdditionalCondition(DBMusicTag dbMusicTag)
	{
	}

	[Token(Token = "0x6004425")]
	[Address(RVA = "0x6DB850", Offset = "0x6DA050", Length = "0x48D")]
	public void UpdateSongSavedResult(SavedSongResult songRes)
	{
	}

	[Address(RVA = "0x6DA670", Offset = "0x6D8E70", Length = "0x5B0")]
	[Token(Token = "0x6004426")]
	private void InitSongSavedResultList()
	{
	}

	[Address(RVA = "0x6DB840", Offset = "0x6DA040", Length = "0x7")]
	[Token(Token = "0x6004427")]
	public void UpdateSongAchievementData()
	{
	}

	[Address(RVA = "0x6DA400", Offset = "0x6D8C00", Length = "0x264")]
	[Token(Token = "0x6004428")]
	private void InitSongArchiIndex()
	{
	}

	[Address(RVA = "0x6DAE20", Offset = "0x6D9620", Length = "0x66")]
	[Token(Token = "0x6004429")]
	public void SaveAdditionalSettings()
	{
	}

	[Address(RVA = "0x6DA2E0", Offset = "0x6D8AE0", Length = "0x112")]
	[Token(Token = "0x600442A")]
	private void InitConditionSavedSetting()
	{
	}

	[Token(Token = "0x600442B")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public MusicTagDifficultyAdditionalConditionsManager()
	{
	}
}
