using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x200075E")]
public class WeekFreeManager : Singleton<WeekFreeManager>
{
	[Token(Token = "0x40026FD")]
	[FieldOffset(Offset = "0x10")]
	private WeekFreeExInfo m_WeekFreeExInfo;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002700")]
	private bool m_OldVersion;

	[Token(Token = "0x1700067C")]
	public Dictionary<string, string> discounts
	{
		[Address(RVA = "0x45EEE0", Offset = "0x45D6E0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6004528")]
		get
		{
			return null;
		}
		[Address(RVA = "0x45EF10", Offset = "0x45D710", Length = "0xC")]
		[Token(Token = "0x6004527")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700067D")]
	public string[] freeMusicUids
	{
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		[Token(Token = "0x6004529")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700067E")]
	public int[] freeAlbumIndexs
	{
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		[Token(Token = "0x600452A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000088")]
	public static event Action refreshEndHandler
	{
		[Address(RVA = "0x7E1DE0", Offset = "0x7E05E0", Length = "0xA4")]
		[CompilerGenerated]
		[Token(Token = "0x6004525")]
		add
		{
		}
		[Address(RVA = "0x7E1E90", Offset = "0x7E0690", Length = "0xA4")]
		[Token(Token = "0x6004526")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Address(RVA = "0x7E1130", Offset = "0x7DF930", Length = "0x5A")]
	[Token(Token = "0x6004523")]
	public bool IsFreeSongUid(string musicUid)
	{
		return default(bool);
	}

	[Token(Token = "0x6004524")]
	[Address(RVA = "0x7E10D0", Offset = "0x7DF8D0", Length = "0x5A")]
	public bool IsFreeAlbumUid(string albumUid)
	{
		return default(bool);
	}

	[Address(RVA = "0x7E1030", Offset = "0x7DF830", Length = "0x95")]
	[Token(Token = "0x600452B")]
	private void Init()
	{
	}

	[Token(Token = "0x600452C")]
	[Address(RVA = "0x7E1190", Offset = "0x7DF990", Length = "0x70")]
	private void OnSceneLoad(Scene scene, LoadSceneMode mode)
	{
	}

	[Address(RVA = "0x7E1210", Offset = "0x7DFA10", Length = "0x60")]
	[Token(Token = "0x600452D")]
	private void OnSceneRefresh(string sceneName)
	{
	}

	[Address(RVA = "0x7E1280", Offset = "0x7DFA80", Length = "0x1B2")]
	[Token(Token = "0x600452E")]
	private void RefreshEnd()
	{
	}

	[Token(Token = "0x600452F")]
	[Address(RVA = "0x7E15A0", Offset = "0x7DFDA0", Length = "0x7F7")]
	private void Refresh()
	{
	}

	[Token(Token = "0x6004530")]
	[Address(RVA = "0x7E1440", Offset = "0x7DFC40", Length = "0x153")]
	private void RefreshWeekPopup()
	{
	}

	[Token(Token = "0x6004531")]
	[Address(RVA = "0x7E0EB0", Offset = "0x7DF6B0", Length = "0x17D")]
	private bool CheckWeekFreeToDlcInfos()
	{
		return default(bool);
	}

	[Address(RVA = "0x7E1DA0", Offset = "0x7E05A0", Length = "0x38")]
	[Token(Token = "0x6004532")]
	public WeekFreeManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
