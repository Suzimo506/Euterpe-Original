using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using GameLogic;
using UnityEngine;

namespace FormulaBase;

[Token(Token = "0x2000460")]
public class StageBattleComponent : Singleton<StageBattleComponent>
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40017C9")]
	private Dictionary<string, GameObject> m_PrefabCatchObj;

	[Token(Token = "0x40017CA")]
	[FieldOffset(Offset = "0x18")]
	private List<MusicData> m_MusicTickData;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40017CB")]
	private List<MusicData> m_SortedMusicTickData;

	[Token(Token = "0x40017CD")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<int, List<TimeNodeOrder>> m_TimeNodeOrders;

	[Token(Token = "0x40017CE")]
	[FieldOffset(Offset = "0x38")]
	public int musicStartTime;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40017D1")]
	public bool isInGame;

	[FieldOffset(Offset = "0x51")]
	[Token(Token = "0x40017D2")]
	public bool isDead;

	[Token(Token = "0x40017D3")]
	[FieldOffset(Offset = "0x58")]
	public string evaluate;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40017D4")]
	public int evaluateNum;

	[Token(Token = "0x40017D5")]
	[FieldOffset(Offset = "0x64")]
	public float leastHpRate;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40017D6")]
	public float failTime;

	[Token(Token = "0x40017D7")]
	[FieldOffset(Offset = "0x6C")]
	public bool unlockNextLevel;

	[Token(Token = "0x40017D8")]
	[FieldOffset(Offset = "0x6D")]
	public bool isSucceed;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40017D9")]
	public int rank;

	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40017DA")]
	public int resizeAdd;

	[Token(Token = "0x40017DB")]
	[FieldOffset(Offset = "0x78")]
	public bool isSceneChangeType;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40017DC")]
	private Coroutine m_MusicOffsetCoroutine;

	[Token(Token = "0x40017DD")]
	[FieldOffset(Offset = "0x88")]
	public readonly Dictionary<string, int> sceneInfo;

	[Token(Token = "0x40017DE")]
	[FieldOffset(Offset = "0x90")]
	public List<string> curSceneChangeType;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40017DF")]
	private int m_Combo;

	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x40017E0")]
	public bool isNew;

	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40017E1")]
	private Coroutine m_DelayStartCoroutine;

	[Token(Token = "0x40017E3")]
	[AttributeAttribute(Name = "DecimalConstantAttribute", RVA = "0x37C90", Offset = "0x37090")]
	private static readonly decimal add_end_time;

	[Token(Token = "0x40017E4")]
	[FieldOffset(Offset = "0xB0")]
	private readonly TimeNodeOrder[] m_TmpTnos;

	[Token(Token = "0x17000480")]
	public bool isPause
	{
		[CompilerGenerated]
		[Token(Token = "0x600329A")]
		[Address(RVA = "0x45A8E0", Offset = "0x4590E0", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x45AB40", Offset = "0x459340", Length = "0x4")]
		[Token(Token = "0x6003299")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000481")]
	public int lastTnoIndex
	{
		[Token(Token = "0x600329B")]
		[CompilerGenerated]
		[Address(RVA = "0x45A8F0", Offset = "0x4590F0", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x45AB50", Offset = "0x459350", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600329C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000482")]
	public decimal lastTnoTime
	{
		[Address(RVA = "0x45A900", Offset = "0x459100", Length = "0xB")]
		[Token(Token = "0x600329D")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Token(Token = "0x600329E")]
		[CompilerGenerated]
		[Address(RVA = "0x45AB60", Offset = "0x459360", Length = "0x8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000483")]
	public float timeFromMusicStart
	{
		[Address(RVA = "0x45AAC0", Offset = "0x4592C0", Length = "0x7B")]
		[Token(Token = "0x600329F")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000484")]
	public decimal timeFromMusicStartDecimal
	{
		[Token(Token = "0x60032A0")]
		[Address(RVA = "0x45A990", Offset = "0x459190", Length = "0x129")]
		get
		{
			return default(decimal);
		}
	}

	[Token(Token = "0x17000485")]
	public long realTimeTick
	{
		[Address(RVA = "0x45A920", Offset = "0x459120", Length = "0x6A")]
		[Token(Token = "0x60032A1")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17000486")]
	public TimeNodeOrder curTimeNodeOrder
	{
		[Token(Token = "0x60032A2")]
		[Address(RVA = "0x45A5C0", Offset = "0x458DC0", Length = "0x164")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000487")]
	public TimeNodeOrder curAirTimeNodeOrder
	{
		[Address(RVA = "0x45A450", Offset = "0x458C50", Length = "0x164")]
		[Token(Token = "0x60032A3")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000488")]
	private int getMusicOffset
	{
		[Token(Token = "0x60032B3")]
		[Address(RVA = "0x45A730", Offset = "0x458F30", Length = "0x1AC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000489")]
	public float offset
	{
		[Address(RVA = "0x45A910", Offset = "0x459110", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x60032BE")]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		[Address(RVA = "0x45AB70", Offset = "0x459370", Length = "0x9")]
		[Token(Token = "0x60032BD")]
		private set
		{
		}
	}

	[Token(Token = "0x60032A4")]
	[Address(RVA = "0x458C60", Offset = "0x457460", Length = "0xB0")]
	public static void ReleaseReferences()
	{
	}

	[Token(Token = "0x60032A5")]
	[Address(RVA = "0x455000", Offset = "0x453800", Length = "0x126")]
	public string GetSceneName()
	{
		return null;
	}

	[Token(Token = "0x60032A6")]
	[Address(RVA = "0x455130", Offset = "0x453930", Length = "0x1A9")]
	public string GetSceneStringIndex()
	{
		return null;
	}

	[Token(Token = "0x60032A7")]
	[Address(RVA = "0x4543A0", Offset = "0x452BA0", Length = "0x7")]
	public int GetCombo()
	{
		return default(int);
	}

	[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
	[Token(Token = "0x60032A8")]
	public List<MusicData> GetMusicData()
	{
		return null;
	}

	[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
	[Token(Token = "0x60032A9")]
	public List<MusicData> GetSortedMusicData()
	{
		return null;
	}

	[Address(RVA = "0x454910", Offset = "0x453110", Length = "0x189")]
	[Token(Token = "0x60032AA")]
	public MusicData GetMusicDataByIdx(int idx)
	{
		return default(MusicData);
	}

	[Address(RVA = "0x459750", Offset = "0x457F50", Length = "0x193")]
	[Token(Token = "0x60032AB")]
	public void SetMusicData(MusicData md)
	{
	}

	[Address(RVA = "0x4595E0", Offset = "0x457DE0", Length = "0x168")]
	[Token(Token = "0x60032AC")]
	public void SetCombo(int combo, bool addCount = true)
	{
	}

	[Token(Token = "0x60032AD")]
	[Address(RVA = "0x455480", Offset = "0x453C80", Length = "0x130")]
	public float GetTimeProgress()
	{
		return default(float);
	}

	[Address(RVA = "0x4581E0", Offset = "0x4569E0", Length = "0x137")]
	[Token(Token = "0x60032AE")]
	private void OnLoadComplete()
	{
	}

	[Token(Token = "0x60032AF")]
	[Address(RVA = "0x4585C0", Offset = "0x456DC0", Length = "0x1E0")]
	private void PlayMusic(string musicPath, MusicInfo musicInfo = null)
	{
	}

	[Token(Token = "0x60032B0")]
	[Address(RVA = "0x452ED0", Offset = "0x4516D0", Length = "0x1BD")]
	public void EnterGameBattle()
	{
	}

	[Token(Token = "0x60032B1")]
	[Address(RVA = "0x458320", Offset = "0x456B20", Length = "0x294")]
	public void Pause(bool pauseCorountine = true)
	{
	}

	[Token(Token = "0x60032B2")]
	[Address(RVA = "0x4592E0", Offset = "0x457AE0", Length = "0x2FF")]
	public void Resume(bool isExit = false)
	{
	}

	[Token(Token = "0x60032B4")]
	[Address(RVA = "0x4534D0", Offset = "0x451CD0", Length = "0x281")]
	public void FixedOffset()
	{
	}

	[Token(Token = "0x60032B5")]
	[Address(RVA = "0x453460", Offset = "0x451C60", Length = "0x6A")]
	private void FixedMusicOffset(AudioSource bgm)
	{
	}

	[Token(Token = "0x60032B6")]
	[Address(RVA = "0x452340", Offset = "0x450B40", Length = "0x17E")]
	public GameObject CreatePrefabAndCache(string filename)
	{
		return null;
	}

	[Address(RVA = "0x452700", Offset = "0x450F00", Length = "0x7C6")]
	[Token(Token = "0x60032B7")]
	public void End()
	{
	}

	[Token(Token = "0x60032B8")]
	[Address(RVA = "0x452080", Offset = "0x450880", Length = "0x2B0")]
	private void ActivityReward(string musicUid, bool isHalloweenMap)
	{
	}

	[Token(Token = "0x60032B9")]
	[Address(RVA = "0x4555C0", Offset = "0x453DC0", Length = "0x1BC")]
	private bool Halloween(bool isRun, int getCount, int targetCount)
	{
		return default(bool);
	}

	[Address(RVA = "0x459F10", Offset = "0x458710", Length = "0x2DD")]
	[Token(Token = "0x60032BA")]
	private void WeekFreeToDlcHandle()
	{
	}

	[Token(Token = "0x60032BB")]
	[Address(RVA = "0x457C20", Offset = "0x456420", Length = "0xAB")]
	private bool NeedShowWeekFree(MusicInfo musicInfo)
	{
		return default(bool);
	}

	[Address(RVA = "0x4524C0", Offset = "0x450CC0", Length = "0x236")]
	[Token(Token = "0x60032BC")]
	public void Dead()
	{
	}

	[Token(Token = "0x60032BF")]
	[Address(RVA = "0x453E70", Offset = "0x452670", Length = "0x354")]
	public void GameStart()
	{
	}

	[Address(RVA = "0x459BD0", Offset = "0x4583D0", Length = "0x7A")]
	[Token(Token = "0x60032C0")]
	private void StopResumeCoroutine()
	{
	}

	[Address(RVA = "0x455780", Offset = "0x453F80", Length = "0x15D")]
	[Token(Token = "0x60032C1")]
	public void InitData()
	{
	}

	[Address(RVA = "0x459190", Offset = "0x457990", Length = "0x149")]
	[Token(Token = "0x60032C2")]
	private void ResetAll()
	{
	}

	[Token(Token = "0x60032C3")]
	[Address(RVA = "0x458C40", Offset = "0x457440", Length = "0x1F")]
	private void Private_InitData()
	{
	}

	[Token(Token = "0x60032C4")]
	[Address(RVA = "0x453DF0", Offset = "0x4525F0", Length = "0x75")]
	public void GameRestart()
	{
	}

	[Token(Token = "0x60032C5")]
	[Address(RVA = "0x453090", Offset = "0x451890", Length = "0x3C8")]
	public void Exit(string sceneName = "UISystem", Action callback = null, bool backToPnlStage = true)
	{
	}

	[Token(Token = "0x60032C6")]
	[Address(RVA = "0x458D20", Offset = "0x457520", Length = "0x46C")]
	private void Release()
	{
	}

	[Token(Token = "0x60032C7")]
	[Address(RVA = "0x459E50", Offset = "0x458650", Length = "0xB2")]
	private void UnregBattleEvent()
	{
	}

	[Token(Token = "0x60032C8")]
	[Address(RVA = "0x4558E0", Offset = "0x4540E0", Length = "0x389")]
	public void InitGame()
	{
	}

	[Token(Token = "0x60032C9")]
	[Address(RVA = "0x4598F0", Offset = "0x4580F0", Length = "0x2D3")]
	private void SetSpecialSwitch()
	{
	}

	[Token(Token = "0x60032CA")]
	[Address(RVA = "0x4577F0", Offset = "0x455FF0", Length = "0x423")]
	private void Load()
	{
	}

	[Address(RVA = "0x455C70", Offset = "0x454470", Length = "0x13B")]
	[Token(Token = "0x60032CB")]
	private void InitTimeNodeOrder()
	{
	}

	[Address(RVA = "0x4587B0", Offset = "0x456FB0", Length = "0x480")]
	[Token(Token = "0x60032CC")]
	private void PreloadAudioSfx()
	{
	}

	[Address(RVA = "0x454AA0", Offset = "0x4532A0", Length = "0x452")]
	[Token(Token = "0x60032CD")]
	private List<MusicData> GetMusicDataFromStageInfo(MusicInfo info)
	{
		return null;
	}

	[Token(Token = "0x60032CE")]
	[Address(RVA = "0x453760", Offset = "0x451F60", Length = "0x68F")]
	private void FoolHandler(List<MusicData> musicDatas)
	{
	}

	[Address(RVA = "0x454F00", Offset = "0x453700", Length = "0xF4")]
	[Token(Token = "0x60032CF")]
	private string GetNoteInfoName(int switchSceneId, string noteInfo)
	{
		return null;
	}

	[Token(Token = "0x60032D0")]
	[Address(RVA = "0x455DB0", Offset = "0x4545B0", Length = "0xED")]
	private bool IsIgnoreCurrentNoteChecking(string prefabName)
	{
		return default(bool);
	}

	[Address(RVA = "0x455EA0", Offset = "0x4546A0", Length = "0x1941")]
	[Token(Token = "0x60032D1")]
	private void LoadMusicData()
	{
	}

	[Token(Token = "0x60032D2")]
	[Address(RVA = "0x4552E0", Offset = "0x453AE0", Length = "0x94")]
	public List<TimeNodeOrder> GetTimeNodeByTick(float tick)
	{
		return null;
	}

	[Token(Token = "0x60032D3")]
	[Address(RVA = "0x455380", Offset = "0x453B80", Length = "0xF7")]
	public List<TimeNodeOrder> GetTimeNodeByTick(decimal tick)
	{
		return null;
	}

	[Address(RVA = "0x4541D0", Offset = "0x4529D0", Length = "0x1CA")]
	[Token(Token = "0x60032D4")]
	public TimeNodeOrder[] GetAllTimeNodeByTick(decimal tick, out int count)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref count) = null;
		return null;
	}

	[Token(Token = "0x60032D5")]
	[Address(RVA = "0x4543B0", Offset = "0x452BB0", Length = "0x557")]
	public MusicData GetCurMusicData(bool isAir = false)
	{
		return default(MusicData);
	}

	[Token(Token = "0x60032D6")]
	[Address(RVA = "0x4581D0", Offset = "0x4569D0", Length = "0xC")]
	public void OnFocusChangePauseGame(bool focus)
	{
	}

	[Address(RVA = "0x457CD0", Offset = "0x4564D0", Length = "0x4FB")]
	[Token(Token = "0x60032D7")]
	public void OnFocusChangePauseGame()
	{
	}

	[Address(RVA = "0x45A260", Offset = "0x458A60", Length = "0x1EB")]
	[Token(Token = "0x60032D8")]
	public StageBattleComponent()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
