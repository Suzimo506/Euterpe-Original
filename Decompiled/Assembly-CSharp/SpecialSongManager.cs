using System;
using System.Collections.Generic;
using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000056")]
public class SpecialSongManager : Singleton<SpecialSongManager>
{
	[Token(Token = "0x20009B6")]
	private class HideBmsInfo
	{
		[Token(Token = "0x40034D2")]
		[FieldOffset(Offset = "0x10")]
		private string musicUid;

		[Token(Token = "0x40034D3")]
		[FieldOffset(Offset = "0x18")]
		private int triggerDiff;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40034D4")]
		private Func<bool> extraCondition;

		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40034D5")]
		private string resultMapName;

		[Token(Token = "0x40034D6")]
		[FieldOffset(Offset = "0x30")]
		private int m_HideDiff;

		[Token(Token = "0x1700092E")]
		public string uid
		{
			[Token(Token = "0x6005748")]
			[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005747")]
		[Address(RVA = "0x620A00", Offset = "0x61F200", Length = "0x73")]
		public HideBmsInfo(string musicUid, int triggerDiff, int hideDiff, string resultMap, Func<bool> extraCondition = null)
		{
		}

		[Address(RVA = "0x620A80", Offset = "0x61F280", Length = "0x78")]
		[Token(Token = "0x6005749")]
		public string isMatch(ref int diff)
		{
			return null;
		}
	}

	[Token(Token = "0x40001F6")]
	private const int width_size = 18;

	[Token(Token = "0x40001F7")]
	private const int height_size = 10;

	[Token(Token = "0x40001F8")]
	[FieldOffset(Offset = "0x10")]
	private Vector2[] m_PosPoints;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001F9")]
	private string[] m_OperationInfos;

	[Token(Token = "0x40001FA")]
	[FieldOffset(Offset = "0x20")]
	private string[] m_OperationInfosTouchTwo;

	[Token(Token = "0x40001FB")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<string, HideBmsInfo> m_HideBmsInfos;

	[Token(Token = "0x40001FC")]
	[FieldOffset(Offset = "0x30")]
	private DBConfigHideMusic m_ConfigHideMusic;

	[Token(Token = "0x40001FD")]
	private const int m_LongPressType = 1;

	[Token(Token = "0x40001FE")]
	private const int m_ToggleChangedType = 2;

	[Token(Token = "0x40001FF")]
	private const int m_ClickType = 3;

	[Token(Token = "0x4000200")]
	private const int m_OtherSpecialType = 4;

	[Token(Token = "0x4000201")]
	private const int m_SpecialHandleType = 0;

	[Token(Token = "0x4000202")]
	private const int m_LvAndDifChanged = 1;

	[Token(Token = "0x4000203")]
	private const int m_DifChanged = 2;

	[Token(Token = "0x4000204")]
	[FieldOffset(Offset = "0x38")]
	private string[] m_CircleData;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000205")]
	private string m_RecordChangedValue;

	[Token(Token = "0x4000206")]
	[FieldOffset(Offset = "0x48")]
	private readonly Dictionary<string, bool> m_IsInvokeHideDic;

	[Token(Token = "0x4000207")]
	[FieldOffset(Offset = "0x50")]
	private string m_PrevMusicUid;

	[Token(Token = "0x4000208")]
	public static Action onTriggerHideBmsEvent;

	[Token(Token = "0x4000209")]
	[FieldOffset(Offset = "0x58")]
	private bool m_IsInit;

	[Token(Token = "0x400020A")]
	[FieldOffset(Offset = "0x5C")]
	private int m_ClickTglIndex;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400020B")]
	private int m_DiffTglClickCount;

	[Token(Token = "0x400020C")]
	[FieldOffset(Offset = "0x68")]
	private DateTime m_GameInTime;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400020D")]
	private byte m_XInputBuffer;

	[Token(Token = "0x400020E")]
	[FieldOffset(Offset = "0x74")]
	private int m_PrevIndex;

	[Address(RVA = "0x633030", Offset = "0x631830", Length = "0xAE")]
	[Token(Token = "0x6000279")]
	private string SetFDOperationInfo(char str, string inputInfos)
	{
		return null;
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x631150", Offset = "0x62F950", Length = "0xD67")]
	public void InvokeHideBms(MusicInfo musicInfo, bool forceSet = false)
	{
	}

	[Address(RVA = "0x6308C0", Offset = "0x62F0C0", Length = "0x5B1")]
	[Token(Token = "0x600027B")]
	public void InitManager(bool forceInit = false)
	{
	}

	[Address(RVA = "0x632070", Offset = "0x630870", Length = "0x18D")]
	[Token(Token = "0x600027C")]
	public bool IsInvokeHideBms(string musicUid)
	{
		return default(bool);
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x6325D0", Offset = "0x630DD0", Length = "0x21B")]
	private void OnDifficultyChanged(object sender, object rev, params object[] args)
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x631020", Offset = "0x62F820", Length = "0x120")]
	public void InputListener()
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x632420", Offset = "0x630C20", Length = "0x1A9")]
	public void OnDiffToggleClicked(int tglIndex, bool isOn)
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x632360", Offset = "0x630B60", Length = "0xB2")]
	private void OnDiffClicked(MusicInfo musicInfo, int tglIndex, bool isOn)
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x631EC0", Offset = "0x6306C0", Length = "0xE5")]
	public bool IsBarrageBms(string uid)
	{
		return default(bool);
	}

	[Address(RVA = "0x632BE0", Offset = "0x6313E0", Length = "0x440")]
	[Token(Token = "0x6000282")]
	public void SetBarrageMode(bool isOn)
	{
	}

	[Address(RVA = "0x632AB0", Offset = "0x6312B0", Length = "0x4D")]
	[Token(Token = "0x6000283")]
	public void ResetHideBmsInputRecord()
	{
	}

	[Address(RVA = "0x6327F0", Offset = "0x630FF0", Length = "0xD0")]
	[Token(Token = "0x6000284")]
	public void OnGameEnd(string jsonName)
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x630110", Offset = "0x62E910", Length = "0x1C2")]
	public string HideBmsCheck(MusicInfo selectedMusic, ref int selectedDifficulty)
	{
		return null;
	}

	[Address(RVA = "0x630770", Offset = "0x62EF70", Length = "0x145")]
	[Token(Token = "0x6000286")]
	private void InitHideInvoke()
	{
	}

	[Address(RVA = "0x630720", Offset = "0x62EF20", Length = "0x4E")]
	[Token(Token = "0x6000287")]
	private void InitHideBmsInfoField()
	{
	}

	[Address(RVA = "0x632A50", Offset = "0x631250", Length = "0x53")]
	[Token(Token = "0x6000288")]
	public void RefreshHideDataTime()
	{
	}

	[Address(RVA = "0x6302E0", Offset = "0x62EAE0", Length = "0x437")]
	[Token(Token = "0x6000289")]
	private void InitHideBmsInfoDic()
	{
	}

	[Address(RVA = "0x632200", Offset = "0x630A00", Length = "0x159")]
	[Token(Token = "0x600028A")]
	public bool IsSpecialMusic()
	{
		return default(bool);
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x630E80", Offset = "0x62F680", Length = "0x197")]
	private void InitRhythmSpecialStage()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x633280", Offset = "0x631A80", Length = "0x3CE")]
	private void UpdateFDInput()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x6328D0", Offset = "0x6310D0", Length = "0x174")]
	private void RecordFDInput(Vector2 end, bool isTouchTwo = false)
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x630030", Offset = "0x62E830", Length = "0xD2")]
	private int GetScreenQuadrant(ref Vector2 pos)
	{
		return default(int);
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x632BD0", Offset = "0x6313D0", Length = "0xC")]
	private void ResetXInput()
	{
	}

	[Address(RVA = "0x633940", Offset = "0x632140", Length = "0x1AC")]
	[Token(Token = "0x6000290")]
	private void XInputCalc(Vector2 pos, bool isPress)
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x633650", Offset = "0x631E50", Length = "0x2E2")]
	private void UpdateXInput()
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x6330E0", Offset = "0x6318E0", Length = "0x11A")]
	private char SetPosTag(int index, Vector2 end)
	{
		return default(char);
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x631FB0", Offset = "0x6307B0", Length = "0xB0")]
	private bool IsCircleData()
	{
		return default(bool);
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x632B00", Offset = "0x631300", Length = "0xCA")]
	private void ResetUserInputInfo()
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x633AF0", Offset = "0x6322F0", Length = "0x3BF")]
	public SpecialSongManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
